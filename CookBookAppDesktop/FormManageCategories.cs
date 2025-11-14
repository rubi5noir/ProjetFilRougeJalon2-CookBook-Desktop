using CookBookAppDesktop.Models.DTO;
using CookBookAppDesktop.Properties;
using System.ComponentModel;
using System.Data;

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
        BindingList<RecetteDTO> _recettes;
        BindingList<RecetteDTO> _recettesWithoutTheCategorie;
        BindingList<CategorieDTO> _categories;
        BindingList<CategorieDTO> _categoriesInRecettes;

        #region Methods

#pragma warning disable CS8618 // Un champ non-nullable doit contenir une valeur autre que Null lors de la fermeture du constructeur. Envisagez d’ajouter le modificateur « required » ou de déclarer le champ comme pouvant accepter la valeur Null.
        public FormManageCategories()
#pragma warning restore CS8618 // Un champ non-nullable doit contenir une valeur autre que Null lors de la fermeture du constructeur. Envisagez d’ajouter le modificateur « required » ou de déclarer le champ comme pouvant accepter la valeur Null.
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

            dataGridViewCategories.Columns["id"].Visible = false;

            // recettes
            _recettes = new();
            bindingSourceRecettes.DataSource = _recettes;
            dataGridViewRecettes.DataSource = bindingSourceRecettes;

            dataGridViewRecettes.Columns["id"].Visible = false;
            dataGridViewRecettes.Columns["temps_preparation"].Visible = false;
            dataGridViewRecettes.Columns["temps_cuisson"].Visible = false;
            dataGridViewRecettes.Columns["temps_total"].Visible = false;
            dataGridViewRecettes.Columns["difficulte"].Visible = false;
            dataGridViewRecettes.Columns["img"].Visible = false;

            // recettes without the categorie
            _recettesWithoutTheCategorie = new();
            bindingSourceRecettesWithoutTheCategorie.DataSource = _recettesWithoutTheCategorie;
            dataGridViewRecettesWithoutTheCategorie.DataSource = bindingSourceRecettesWithoutTheCategorie;

            dataGridViewRecettesWithoutTheCategorie.Columns["id"].Visible = false;
            dataGridViewRecettesWithoutTheCategorie.Columns["temps_preparation"].Visible = false;
            dataGridViewRecettesWithoutTheCategorie.Columns["temps_cuisson"].Visible = false;
            dataGridViewRecettesWithoutTheCategorie.Columns["temps_total"].Visible = false;
            dataGridViewRecettesWithoutTheCategorie.Columns["difficulte"].Visible = false;
            dataGridViewRecettesWithoutTheCategorie.Columns["img"].Visible = false;

            // categories in recettes
            _categoriesInRecettes = new();
            bindingSourceCategoriesOfRecette.DataSource = _categoriesInRecettes;
            dataGridViewCategoriesOfRecette.DataSource = bindingSourceCategoriesOfRecette;

            dataGridViewCategoriesOfRecette.Columns["id"].Visible = false;
        }

        private async Task RefreshCategories()
        {
#pragma warning disable IDE0019 // Utiliser les critères spéciaux
#pragma warning disable CS8600 // Conversion de littéral ayant une valeur null ou d'une éventuelle valeur null en type non-nullable.
            CategorieDTO current = bindingSourceCategories.Current as CategorieDTO;
#pragma warning restore CS8600 // Conversion de littéral ayant une valeur null ou d'une éventuelle valeur null en type non-nullable.
#pragma warning restore IDE0019 // Utiliser les critères spéciaux
            // Remplissage de la liste
            var res = await _rest.GetAsync<IEnumerable<CategorieDTO>>(URL_GET_CATEGORIES);
            _categories.Clear();
            foreach (var item in res)
            {
                _categories.Add(item);
            }
            if (current != null)
#pragma warning disable CS8604 // Existence possible d'un argument de référence null.
                bindingSourceCategories.Position = _categories.IndexOf(_categories.FirstOrDefault(c => c.id == current.id));
#pragma warning restore CS8604 // Existence possible d'un argument de référence null.
        }

        #endregion

        #region Events

        private async void FormManageCategories_Load(object sender, EventArgs e)
        {
            _rest.BaseUrl = Settings.Default.BaseUrl;
            _rest.JwtToken = FormAppMain.Token;

            await RefreshCategories();
        }

        private async void dataGridViewCategories_CurrentCellChanged(object sender, EventArgs e)
        {
#pragma warning disable IDE0019 // Utiliser les critères spéciaux
#pragma warning disable CS8600 // Conversion de littéral ayant une valeur null ou d'une éventuelle valeur null en type non-nullable.
            CategorieDTO current = bindingSourceCategories.Current as CategorieDTO;
#pragma warning restore CS8600 // Conversion de littéral ayant une valeur null ou d'une éventuelle valeur null en type non-nullable.
#pragma warning restore IDE0019 // Utiliser les critères spéciaux

            if (current != null)
            {
                // Récupération des recettes de la catégorie
                var allRecettes = await _rest.GetAsync<IEnumerable<RecetteDTO>>(URL_GET_RECETTES);

                try
                {
                    IEnumerable<int> recetteIDs = await _rest.GetAsync<IEnumerable<int>>($"{URL_GET_CATEGORIES}/RecettesIDs/{current.id}");

                    var recettesOfCategory = allRecettes.Where(r => recetteIDs.Contains(r.id)).ToList();
                    var recettesWithoutTheCategory = allRecettes.Where(r => !recetteIDs.Contains(r.id)).ToList();

                    _recettes.Clear();
                    foreach (var item in recettesOfCategory)
                    {
                        _recettes.Add(item);
                    }

                    _recettesWithoutTheCategorie.Clear();
                    foreach (var item in recettesWithoutTheCategory)
                    {
                        _recettesWithoutTheCategorie.Add(item);
                    }
                }
                catch (Exception ex)
                {
                    _recettes.Clear();
                    _categoriesInRecettes.Clear();

                    MessageBox.Show($"{ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async void dataGridViewRecettes_CurrentCellChanged(object sender, EventArgs e)
        {
#pragma warning disable IDE0019 // Utiliser les critères spéciaux
#pragma warning disable CS8600 // Conversion de littéral ayant une valeur null ou d'une éventuelle valeur null en type non-nullable.
            RecetteDTO current = bindingSourceRecettes.Current as RecetteDTO;
#pragma warning restore CS8600 // Conversion de littéral ayant une valeur null ou d'une éventuelle valeur null en type non-nullable.
#pragma warning restore IDE0019 // Utiliser les critères spéciaux
            if (current != null)
            {
                var categories = await _rest.GetAsync<IEnumerable<CategorieDTO>>($"{URL_GET_CATEGORIES}/{current.id}");

                _categoriesInRecettes.Clear();
                foreach (var item in categories)
                {
                    _categoriesInRecettes.Add(item);
                }
            }
        }

        private async void buttonRefreshCategories_Click(object sender, EventArgs e)
        {
            await RefreshCategories();
        }

        private async void buttonAddCategorie_Click(object sender, EventArgs e)
        {
#pragma warning disable IDE0019 // Utiliser les critères spéciaux
#pragma warning disable CS8600 // Conversion de littéral ayant une valeur null ou d'une éventuelle valeur null en type non-nullable.
            CategorieDTO current = bindingSourceCategories.Current as CategorieDTO;
#pragma warning restore CS8600 // Conversion de littéral ayant une valeur null ou d'une éventuelle valeur null en type non-nullable.
#pragma warning restore IDE0019 // Utiliser les critères spéciaux
            if (current != null)
            {
                var categorieDTO = new CategorieDTO
                {
                    id = 0, // Database will Create it by itself
                    nom = textBoxCategorieNom.Text
                };

                var result = MessageBox.Show($"Êtes-vous sûr de vouloir Ajouter la catégorie '{categorieDTO}' ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    await _rest.PostAsync($"{URL_CREATE_CATEGORIES}", categorieDTO);
                    await RefreshCategories();
                }
            }
        }

        private async void buttonModifyCategorie_Click(object sender, EventArgs e)
        {
#pragma warning disable IDE0019 // Utiliser les critères spéciaux
#pragma warning disable CS8600 // Conversion de littéral ayant une valeur null ou d'une éventuelle valeur null en type non-nullable.
            CategorieDTO current = bindingSourceCategories.Current as CategorieDTO;
#pragma warning restore CS8600 // Conversion de littéral ayant une valeur null ou d'une éventuelle valeur null en type non-nullable.
#pragma warning restore IDE0019 // Utiliser les critères spéciaux
            if (current != null)
            {
                var categorieDTO = new CategorieDTO
                {
                    id = current.id,
                    nom = textBoxCategorieNom.Text
                };

                var result = MessageBox.Show($"Êtes-vous sûr de vouloir Modifier le nom de la catégorie '{current.nom}' en '{categorieDTO.nom}' ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    await _rest.PutAsync($"{URL_UPDATE_CATEGORIES}/{current.id}", categorieDTO);
                    await RefreshCategories();
                }
            }
        }

        private async void buttonDeleteCategorie_Click(object sender, EventArgs e)
        {
#pragma warning disable IDE0019 // Utiliser les critères spéciaux
#pragma warning disable CS8600 // Conversion de littéral ayant une valeur null ou d'une éventuelle valeur null en type non-nullable.
            CategorieDTO current = bindingSourceCategories.Current as CategorieDTO;
#pragma warning restore CS8600 // Conversion de littéral ayant une valeur null ou d'une éventuelle valeur null en type non-nullable.
#pragma warning restore IDE0019 // Utiliser les critères spéciaux
            if (current != null)
            {
                var result = MessageBox.Show($"Êtes-vous sûr de vouloir supprimer la catégorie '{current.nom}' ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    await _rest.DeleteAsync($"{URL_DELETE_CATEGORIES}/{current.id}");
                    await RefreshCategories();
                }
            }
        }

        private async void buttonAddCategorieToRecette_Click(object sender, EventArgs e)
        {
#pragma warning disable IDE0019 // Utiliser les critères spéciaux
#pragma warning disable CS8600 // Conversion de littéral ayant une valeur null ou d'une éventuelle valeur null en type non-nullable.
            CategorieDTO currentCategorie = bindingSourceCategories.Current as CategorieDTO;
#pragma warning restore CS8600 // Conversion de littéral ayant une valeur null ou d'une éventuelle valeur null en type non-nullable.
#pragma warning restore IDE0019 // Utiliser les critères spéciaux
#pragma warning disable IDE0019 // Utiliser les critères spéciaux
#pragma warning disable CS8600 // Conversion de littéral ayant une valeur null ou d'une éventuelle valeur null en type non-nullable.
            RecetteDTO currentRecette = bindingSourceRecettesWithoutTheCategorie.Current as RecetteDTO;
#pragma warning restore CS8600 // Conversion de littéral ayant une valeur null ou d'une éventuelle valeur null en type non-nullable.
#pragma warning restore IDE0019 // Utiliser les critères spéciaux

            if (currentCategorie != null)
            {
                if (currentRecette != null)
                {
                    var result = MessageBox.Show($"Êtes-vous sûr de vouloir ajouter la catégorie '{currentCategorie.nom}' à la recette '{currentRecette.nom}' ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == DialogResult.Yes)
                    {
                        await _rest.PostAsync($"{URL_GET_CATEGORIES}/AddToRecette/{currentRecette.id}", currentCategorie);

                        var categories = await _rest.GetAsync<IEnumerable<CategorieDTO>>($"{URL_GET_CATEGORIES}/{currentRecette.id}");

                        _categoriesInRecettes.Clear();
                        foreach (var item in categories)
                        {
                            _categoriesInRecettes.Add(item);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Veuillez sélectionner une recette.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                await RefreshCategories();
            }
        }

        private async void buttonRemoveCategorieFromRecette_Click(object sender, EventArgs e)
        {
#pragma warning disable IDE0019 // Utiliser les critères spéciaux
#pragma warning disable CS8600 // Conversion de littéral ayant une valeur null ou d'une éventuelle valeur null en type non-nullable.
            CategorieDTO currentCategorie = bindingSourceCategoriesOfRecette.Current as CategorieDTO;
#pragma warning restore CS8600 // Conversion de littéral ayant une valeur null ou d'une éventuelle valeur null en type non-nullable.
#pragma warning restore IDE0019 // Utiliser les critères spéciaux

#pragma warning disable IDE0019 // Utiliser les critères spéciaux
#pragma warning disable CS8600 // Conversion de littéral ayant une valeur null ou d'une éventuelle valeur null en type non-nullable.
            RecetteDTO currentRecette = bindingSourceRecettes.Current as RecetteDTO;
#pragma warning restore CS8600 // Conversion de littéral ayant une valeur null ou d'une éventuelle valeur null en type non-nullable.
#pragma warning restore IDE0019 // Utiliser les critères spéciaux

            if (currentCategorie != null)
            {
                if (currentRecette != null)
                {
                    var result = MessageBox.Show($"Êtes-vous sûr de vouloir retirer la catégorie '{currentCategorie.nom}' de la recette '{currentRecette.nom}' ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == DialogResult.Yes)
                    {
                        await _rest.DeleteAsync($"{URL_GET_CATEGORIES}/RemoveFromRecette/{currentRecette.id}", currentCategorie);

                        var categories = await _rest.GetAsync<IEnumerable<CategorieDTO>>($"{URL_GET_CATEGORIES}/{currentRecette.id}");
                        _categoriesInRecettes.Clear();
                        foreach (var item in categories)
                        {
                            _categoriesInRecettes.Add(item);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Veuillez sélectionner une recette.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                await RefreshCategories();
            }
        }

        #endregion
    }
}
