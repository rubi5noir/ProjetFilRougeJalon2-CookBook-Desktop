using CookBookAppDesktop.Models.DTO;
using CookBookAppDesktop.Properties;
using System.ComponentModel;
using System.Configuration;
using System.IdentityModel.Tokens.Jwt;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CookBookAppDesktop
{
    public partial class FormAppMain : Form
    {

        const string URL_GET_RECETTES = "api/Recettes";
        const string URL_CREATE_RECETTES = "api/Recettes";
        const string URL_UPDATE_RECETTES = "api/Recettes";
        const string URL_DELETE_RECETTES = "api/Recettes";

        const string URL_GET_ETAPES = "api/Etapes";

        const string URL_GET_CATEGORIES = "api/Categories";


        readonly RestClient _rest = new();
        BindingList<RecetteDTO> _recettes;
        BindingList<EtapeDTO> _etapes;
        BindingList<CategorieDTO> _categories;
        BindingList<IngredientDTO> _ingredients;
        BindingList<AvisDTO> _avis;


        public static string Token;

        IEnumerable<string> _roles = [];



        public FormAppMain()
        {
            InitializeComponent();
            InitializeBinding();
            InitializeInputsLimits();
        }

        #region Methods

        private void InitializeBinding()
        {
            // Recettes
            _recettes = new();
            bindingSourceRecettes.DataSource = _recettes;
            dataGridViewRecettes.DataSource = bindingSourceRecettes;
            dataGridViewEtapesRecette.DataSource = bindingSourceRecettes;

            // Etapes
            _etapes = new();
            bindingSourceEtapes.DataSource = _etapes;
            dataGridViewEtapes.DataSource = bindingSourceEtapes;

            // Categories
            _categories = new();
            bindingSourceCategories.DataSource = _categories;
            dataGridViewCategories.DataSource = bindingSourceCategories;
        }

        private void InitializeInputsLimits()
        {
            textBoxNomRecette.MaxLength = 100;

            textBoxDescriptionRecette.MaxLength = 5000;

            numericUpDownTemps_PréparationHeures.Minimum = 0;
            numericUpDownTemps_PréparationHeures.Maximum = 128;
            numericUpDownTemps_PréparationMinutes.Minimum = 0;
            numericUpDownTemps_PréparationMinutes.Maximum = 59;

            numericUpDownTemps_CuissonHeures.Minimum = 0;
            numericUpDownTemps_CuissonHeures.Maximum = 128;
            numericUpDownTemps_CuissonMinutes.Minimum = 0;
            numericUpDownTemps_CuissonMinutes.Maximum = 59;

            numericUpDownDifficulteRecette.Minimum = 1;
            numericUpDownDifficulteRecette.Maximum = 4;
        }

        private async Task RefreshRecettes()
        {
            RecetteDTO current = bindingSourceRecettes.Current as RecetteDTO;

            // Remplissage de la liste
            var res = await _rest.GetAsync<IEnumerable<RecetteDTO>>($"{URL_GET_RECETTES}/Details");

            _recettes.Clear();
            foreach (RecetteDTO r in res)
                _recettes.Add(r);

            // On se repositionne sur le current
            if (current is not null)
                bindingSourceRecettes.Position = _recettes.IndexOf(_recettes.Where(r => r.id == current.id).FirstOrDefault());
        }

        private async Task RefreshEtapes()
        {
            RecetteDTO recette = bindingSourceRecettes.Current as RecetteDTO;
            EtapeDTO current = bindingSourceEtapes.Current as EtapeDTO;

            var res = await _rest.GetAsync<IEnumerable<EtapeDTO>>($"{URL_GET_ETAPES}/{recette.id}");

            _etapes.Clear();
            foreach (EtapeDTO e in res)
                _etapes.Add(e);

            if (current is not null)
            {
                bindingSourceEtapes.Position = _etapes.IndexOf(_etapes.Where(e => e.id == current.id && e.numero == current.numero).FirstOrDefault());
            }
        }

        private async Task RefreshCategories()
        {
            CategorieDTO current = bindingSourceRecettes.Current as CategorieDTO;

            var res = await _rest.GetAsync<IEnumerable<CategorieDTO>>($"{URL_GET_CATEGORIES}");

            _categories.Clear();
            foreach (CategorieDTO c in res)
                _categories.Add(c);

            if (current is not null)
            {
                bindingSourceCategories.Position = _categories.IndexOf(_categories.Where(c => c.id == current.id).FirstOrDefault());
            }
        }

        #endregion

        #region Events

        private async void FormAppMain_Load(object sender, EventArgs e)
        {
            _rest.BaseUrl = Settings.Default.BaseUrl;

            if (string.IsNullOrEmpty(_rest.JwtToken))
            {
                FormLogin formLogin = new();
                if (formLogin.ShowDialog() != DialogResult.OK)
                {
                    Close();
                    return;
                }
                else
                {
                    _rest.JwtToken = formLogin.JwtToken;
                    _roles = formLogin._roles;
                    Token = _rest.JwtToken;

                    tableLayoutPanelApp.Enabled = true;

                    await RefreshRecettes();
                }
            }
        }

        private void FormAppMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Close();
        }

        private async void tabControl_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPage == tabPageRecettes)
                await RefreshRecettes();
            else if (e.TabPage == tabPageEtapes)
                await RefreshRecettes();
            else if (e.TabPage == tabPageCategories)
                await RefreshCategories();
        }


        #region TabPageRecettes

        private async void buttonRefreshRecettes_Click(object sender, EventArgs e)
        {
            await RefreshRecettes();
        }

        private async void buttonAddRecette_Click(object sender, EventArgs e)
        {
            RecetteDetailsDTO newRecette = new()
            {
                nom = textBoxNomRecette.Text,
                description = textBoxDescriptionRecette.Text,
                temps_preparation = new TimeSpan((int)numericUpDownTemps_PréparationHeures.Value, (int)numericUpDownTemps_PréparationMinutes.Value, 0),
                temps_cuisson = new TimeSpan((int)numericUpDownTemps_CuissonHeures.Value, (int)numericUpDownTemps_CuissonMinutes.Value, 0),
                difficulte = (int)numericUpDownDifficulteRecette.Value,
                img = textBoxImageRecette.Text
            };

            var createdRecette = await _rest.PostAsync<RecetteDetailsDTO, RecetteDetailsDTO>(URL_CREATE_RECETTES, newRecette);
        }

        private async void buttonUpdateRecette_Click(object sender, EventArgs e)
        {
            if (bindingSourceRecettes.Current is not RecetteDetailsDTO selectedRecette)
            {
                MessageBox.Show("Veuillez Séléctionné une recette a modifié.");
                return;
            }
            selectedRecette.nom = textBoxNomRecette.Text;
            selectedRecette.description = textBoxDescriptionRecette.Text;
            selectedRecette.temps_preparation = new TimeSpan((int)numericUpDownTemps_PréparationHeures.Value, (int)numericUpDownTemps_PréparationMinutes.Value, 0);
            selectedRecette.temps_cuisson = new TimeSpan((int)numericUpDownTemps_CuissonHeures.Value, (int)numericUpDownTemps_CuissonMinutes.Value, 0);
            selectedRecette.difficulte = (int)numericUpDownDifficulteRecette.Value;
            selectedRecette.img = textBoxImageRecette.Text;
            await _rest.PutAsync<RecetteDetailsDTO>($"{URL_UPDATE_RECETTES}/{selectedRecette.id}", selectedRecette);
        }

        private async void buttonDeleteRecette_Click(object sender, EventArgs e)
        {
            if (bindingSourceRecettes.Current is not RecetteDTO selectedRecette)
            {
                MessageBox.Show("Veuillez Séléctionné une recette a supprimé.");
                return;
            }
            var confirmResult = MessageBox.Show("Etes vous sure de vouloir supprimé cette recette?", "Confirmation Suppression", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                await _rest.DeleteAsync($"{URL_DELETE_RECETTES}/{selectedRecette.id}");
                _recettes.Remove(selectedRecette);
            }

            await RefreshRecettes();
        }

        private async void buttonSelectionnerImageRecette_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Image Files|*.jpg;*.jpeg;*.png",
                Title = "Select an Image",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)
            };

            DialogResult result = openFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                textBoxImageRecette.Text = openFileDialog.FileName;
            }
        }

        #endregion

        #region TabPageEtapes

        private async void dataGridViewRecettes_SelectionChanged(object sender, EventArgs e)
        {
            RecetteDTO current = bindingSourceRecettes.Current as RecetteDTO;

            if (current != null)
            {
                await RefreshEtapes();
            }
        }

        private async void buttonOpenFormSelectionEtapes_Click(object sender, EventArgs e)
        {
            FormManageEtapes formManageEtapes = new FormManageEtapes();
            if (formManageEtapes.ShowDialog() == DialogResult.OK)
            {
                await RefreshEtapes();
            }
        }

        #endregion

        #region TabPageCategories

        private async void buttonRefreshCategories_Click(object sender, EventArgs e)
        {
            await RefreshCategories();
        }

        private async void buttonOpenFormSelectionCategories_Click(object sender, EventArgs e)
        {
            FormManageCategories formManageCategories = new FormManageCategories();
            if (formManageCategories.ShowDialog() == DialogResult.OK)
            {
                await RefreshCategories();
            }
        }

        #endregion

        #region TabPageUtilisateurs



        #endregion

        #endregion
    }
}
