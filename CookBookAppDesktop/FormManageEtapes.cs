using CookBookAppDesktop.Models.DTO;
using CookBookAppDesktop.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CookBookAppDesktop
{
    public partial class FormManageEtapes : Form
    {
        const string URL_GET_ETAPES = "api/Etapes";
        const string URL_CREATE_ETAPES = "api/Etapes";
        const string URL_UPDATE_ETAPES = "api/Etapes";
        const string URL_DELETE_ETAPES = "api/Etapes";

        const string URL_GET_RECETTES = "api/Recettes";

        readonly RestClient _rest = new();
        BindingList<EtapeDTO> _etapes;
        BindingList<RecetteDetailsDTO> _recettes;

        public FormManageEtapes()
        {
            InitializeComponent();
            InitializeBinding();
        }

        #region Methods

        private void InitializeBinding()
        {
            // etapes
            _etapes = new();
            bindingSourceEtapes.DataSource = _etapes;
            dataGridViewEtapes.DataSource = bindingSourceEtapes;

            dataGridViewEtapes.Columns["id"].Visible = false;
            dataGridViewEtapes.Columns["texte"].HeaderText = "Description";

            numericUpDownTitre.DataBindings.Add("Value", bindingSourceEtapes, "numero", false, DataSourceUpdateMode.Never);
            textBoxDescription.DataBindings.Add("Text", bindingSourceEtapes, "texte", false, DataSourceUpdateMode.Never);

            // recettes
            _recettes = new();
            bindingSourceRecettes.DataSource = _recettes;
            dataGridViewRecettesForEtapes.DataSource = bindingSourceRecettes;

            dataGridViewRecettesForEtapes.Columns["id"].Visible = false;
            dataGridViewRecettesForEtapes.Columns["identifiantCreateur"].Visible = false;
            dataGridViewRecettesForEtapes.Columns["temps_preparation"].Visible = false;
            dataGridViewRecettesForEtapes.Columns["temps_cuisson"].Visible = false;
            dataGridViewRecettesForEtapes.Columns["temps_total"].Visible = false;
            dataGridViewRecettesForEtapes.Columns["difficulte"].Visible = false;
            dataGridViewRecettesForEtapes.Columns["img"].Visible = false;
        }

        private async Task RefreshEtapes(int id)
        {
            EtapeDTO current = bindingSourceEtapes.Current as EtapeDTO;

            // Remplissage de la liste
            var res = await _rest.GetAsync<IEnumerable<EtapeDTO>>($"{URL_GET_ETAPES}/{id}");

            res = res.Select(r =>
            {
                r.id = id;
                return r;
            });

            _etapes.Clear();
            foreach (EtapeDTO e in res)
            {
                _etapes.Add(e);
            }

            // On se repositionne sur le current
            if (current is not null)
                bindingSourceEtapes.Position = _etapes.IndexOf(_etapes.Where(e => e.numero == current.numero).FirstOrDefault());
        }

        private async Task RefreshRecettes()
        {
            RecetteDetailsDTO current = bindingSourceRecettes.Current as RecetteDetailsDTO;

            // Remplissage de la liste
            var res = await _rest.GetAsync<IEnumerable<RecetteDetailsDTO>>(URL_GET_RECETTES);

            _recettes.Clear();
            foreach (RecetteDetailsDTO r in res)
                _recettes.Add(r);

            // On se repositionne sur le current
            if (current is not null)
                bindingSourceRecettes.Position = _recettes.IndexOf(_recettes.Where(r => r.id == current.id).FirstOrDefault());
        }

        #endregion

        #region Events

        private async void FormManageEtapes_Load(object sender, EventArgs e)
        {
            _rest.BaseUrl = Settings.Default.BaseUrl;
            _rest.JwtToken = FormAppMain.Token;

            await RefreshRecettes();
        }

        private async void dataGridViewRecettesForEtapes_SelectionChanged(object sender, EventArgs e)
        {
            RecetteDetailsDTO current = bindingSourceRecettes.Current as RecetteDetailsDTO;

            if (current is not null)
                await RefreshEtapes(current.id);
        }

        private async void buttonAdd_Click(object sender, EventArgs e)
        {
            EtapeDTO current = bindingSourceEtapes.Current as EtapeDTO;

            var etape = new EtapeDTO
            {
                numero = int.Parse(numericUpDownTitre.Value.ToString()),
                texte = textBoxDescription.Text
            };

            var result = MessageBox.Show($"Êtes-vous sûr de vouloir créer l'étape suivante : \n- numero : {etape.numero}\n- Description : {etape.texte} ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                var res = await _rest.PostAsync<EtapeDTO, EtapeDTO>($"{URL_CREATE_ETAPES}/{current.id}", etape);
                await RefreshEtapes(current.id);
            }

        }

        private async void buttonModify_Click(object sender, EventArgs e)
        {
            if (bindingSourceEtapes.Current is not EtapeDTO current)
                return;

            var etape = new EtapeDTO();
            etape.id = current.id;
            etape.numero = int.Parse(numericUpDownTitre.Value.ToString());
            etape.texte = textBoxDescription.Text;

            var result = MessageBox.Show($"Êtes-vous sûr de vouloir modifier l'étape actuel : \n- numero : {current.numero}\n- Description : {current.texte}\nen l'étape suivante : \n- numero : {etape.numero}\n- Description : {etape.texte} ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                var res = await _rest.PutAsync<EtapeDTO, EtapeDTO>($"{URL_UPDATE_ETAPES}/{current.id}/{current.numero}", etape);
                await RefreshEtapes(current.id);
            }
        }

        private async void buttonDelete_Click(object sender, EventArgs e)
        {
            if (bindingSourceEtapes.Current is not EtapeDTO current)
                return;

            var result = MessageBox.Show($"Êtes-vous sûr de vouloir supprimer l'étape suivante : \n- numero : {current.numero}\n- Description : {current.texte} ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                await _rest.DeleteAsync($"{URL_DELETE_ETAPES}/{current.id}/{current.numero}");
                await RefreshEtapes(current.id);
            }
        }

        private async void buttonRefresh_Click(object sender, EventArgs e)
        {
            await RefreshRecettes();
        }

        #endregion


    }
}
