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

        readonly RestClient _rest = new();
        BindingList<EtapeDTO> _etapes;

        public FormManageEtapes()
        {
            InitializeComponent();
            InitializeBinding();
        }

        #region Methods

        private void InitializeBinding()
        {
            _etapes = new();
            bindingSourceEtapes.DataSource = _etapes;
            dataGridViewEtapes.DataSource = bindingSourceEtapes;
        }

        private async Task RefreshEtapes()
        {
            EtapeDTO current = bindingSourceEtapes.Current as EtapeDTO;

            if (current == null)
            {
                current = new EtapeDTO();
                current.id = 1;
            }

            // Remplissage de la liste
            var res = await _rest.GetAsync<IEnumerable<EtapeDTO>>($"{URL_GET_ETAPES}/{current.id}");

            res = res.Select(r =>
            {
                r.id = current.id;
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

        #endregion

        #region Events

        private async void FormManageEtapes_Load(object sender, EventArgs e)
        {
            _rest.BaseUrl = Settings.Default.BaseUrl;
            _rest.JwtToken = FormAppMain.Token;

            await RefreshEtapes();
        }

        private async void buttonAdd_Click(object sender, EventArgs e)
        {
            EtapeDTO current = bindingSourceEtapes.Current as EtapeDTO;

            var etape = new EtapeDTO
            {
                numero = int.Parse(numericUpDownTitre.Value.ToString()),
                texte = textBoxDescription.Text
            };

            var res = await _rest.PostAsync<EtapeDTO, EtapeDTO>($"{URL_CREATE_ETAPES}/{current.id}", etape);
            await RefreshEtapes();
        }

        private async void buttonModify_Click(object sender, EventArgs e)
        {
            if (bindingSourceEtapes.Current is not EtapeDTO current)
                return;

            var etape = new EtapeDTO();
            etape.id = current.id;
            etape.numero = int.Parse(numericUpDownTitre.Value.ToString());
            etape.texte = textBoxDescription.Text;

            var res = await _rest.PutAsync<EtapeDTO, EtapeDTO>($"{URL_UPDATE_ETAPES}/{current.id}/{current.numero}", etape);
            await RefreshEtapes();
        }

        private async void buttonDelete_Click(object sender, EventArgs e)
        {
            if (bindingSourceEtapes.Current is not EtapeDTO current)
                return;
            await _rest.DeleteAsync($"{URL_DELETE_ETAPES}/{current.id}/{current.numero}");
            await RefreshEtapes();
        }

        #endregion


    }
}
