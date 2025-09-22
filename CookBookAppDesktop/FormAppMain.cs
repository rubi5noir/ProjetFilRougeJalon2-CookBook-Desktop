using CookBookAppDesktop.Models.DTO;
using System.ComponentModel;
using System.Threading.Tasks;

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



        public FormAppMain()
        {
            InitializeComponent();
        }

        #region Methods

        private void InitializeBinding()
        {
            // Books
            _recettes = new();
            bindingSourceRecettes.DataSource = _recettes;
            dataGridViewRecettes.DataSource = bindingSourceRecettes;

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
            await RefreshRecettes();
        }

       

        private async void tabControl_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPage == tabPageRecettes)
                await RefreshRecettes();
        }
          

        #region TabPageRecettes



        #endregion

        #endregion
    }
}
