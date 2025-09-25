using CookBookAppDesktop.Models.DTO;
using System.ComponentModel;
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

        readonly RestClient _rest = new();
        BindingList<RecetteDetailsDTO> _recettes;

        IEnumerable<string> _roles = [];



        public FormAppMain()
        {
            InitializeComponent();
            InitializeInputsLimits();
        }

        #region Methods

        private void InitializeBinding()
        {
            // Recettes
            _recettes = new();
            bindingSourceRecettes.DataSource = _recettes;
            dataGridViewRecettes.DataSource = bindingSourceRecettes;
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

        private async void FormAppMain_Load(object sender, EventArgs e)
        {
            InitializeBinding();

            _rest.BaseUrl = "http://localhost:5555";

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

                    tableLayoutPanelApp.Enabled = true;

                    await RefreshRecettes();
                }
            }
        }



        private async void tabControl_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPage == tabPageRecettes)
                await RefreshRecettes();
        }


        #region TabPageRecettes

        private async void buttonRefreshRecettes_Click(object sender, EventArgs e)
        {
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

        private async void buttonOpenFormSelectionEtapes_Click(object sender, EventArgs e)
        {
            FormManageEtapes formManageEtapes = new FormManageEtapes();
            if (formManageEtapes.ShowDialog() != DialogResult.OK)
            {
                // Annulation
            }
            else
            {
                // Recuperation des etapes selectionnées
            }
        }

        #endregion

        #region TabPageUtilisateurs



        #endregion

        #endregion


    }
}
