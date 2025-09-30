using CookBookAppDesktop.Models.DTO;
using CookBookAppDesktop.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CookBookAppDesktop
{
    public partial class FormManageCategories : Form
    {
        const string URL_GET_CATEGORIES = "api/Categories";
        const string URL_CREATE_CATEGORIES = "api/Categories";
        const string URL_UPDATE_CATEGORIES = "api/Categories";
        const string URL_DELETE_CATEGORIES = "api/Categories";

        const string URL_GET_RECETTES = "api/Recettes";

        readonly RestClient _rest = new();
        BindingList<RecetteDetailsDTO> _recettes;
        BindingList<CategorieDTO> _categories;

        #region Methods

        public FormManageCategories()
        {
            InitializeComponent();
            InitializeBinding();
        }

        private void InitializeBinding()
        {
            // categories
            _categories = new();
            bindingSourceCategories.DataSource = _categories;
            dataGridViewCategories.DataSource = bindingSourceCategories;

            // recettes
            _recettes = new();
            bindingSourceRecettes.DataSource = _recettes;
            dataGridViewRecettes.DataSource = bindingSourceRecettes;

            // categories of recette
            //_categoriesOfRecette = new();
            //bindingSourceCategoriesOfRecette.DataSource = _categoriesOfRecette;
            //dataGridViewCategoriesOfRecette.DataSource = bindingSourceCategoriesOfRecette;
        }

        private async Task RefreshCategories()
        {
            CategorieDTO current = bindingSourceCategories.Current as CategorieDTO;
            // Remplissage de la liste
            var res = await _rest.GetAsync<IEnumerable<CategorieDTO>>(URL_GET_CATEGORIES);
            _categories.Clear();
            foreach (var item in res)
            {
                _categories.Add(item);
            }
            if (current != null)
                bindingSourceCategories.Position = bindingSourceCategories.IndexOf(current);
        }

        private async Task RefreshRecettes()
        {
            RecetteDetailsDTO current = bindingSourceRecettes.Current as RecetteDetailsDTO;
            // Remplissage de la liste
            var res = await _rest.GetAsync<IEnumerable<RecetteDetailsDTO>>($"{URL_GET_RECETTES}/{current.id}");
            _recettes.Clear();
            foreach (var item in res)
            {
                _recettes.Add(item);
            }
            if (current != null)
                bindingSourceRecettes.Position = bindingSourceRecettes.IndexOf(current);
        }

        #endregion

        #region Events

        private async void FormManageCategories_Load(object sender, EventArgs e)
        {
            _rest.BaseUrl = Settings.Default.BaseUrl;
            _rest.JwtToken = FormAppMain.Token;

            await RefreshCategories();
            await RefreshRecettes();
        }

        private async void dataGridViewCategories_CurrentCellChanged(object sender, EventArgs e)
        {
            await RefreshRecettes();
        }

        private async void buttonRefreshCategories_Click(object sender, EventArgs e)
        {
            await RefreshCategories();
        }

        #endregion
    }
}
