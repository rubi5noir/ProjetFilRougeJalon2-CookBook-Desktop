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
    public partial class FormManageIngredients : Form
    {
        const string URL_GET_INGREDIENTS = "api/Ingredients";
        const string URL_CREATE_INGREDIENTS = "api/Ingredients";
        const string URL_MODIFY_INGREDIENTS = "api/Ingredients";
        const string URL_DELETE_INGREDIENTS = "api/Ingredients";

        const string URL_GET_RECETTES = "api/Recettes";

        readonly RestClient _rest = new();
        BindingList<IngredientDTO> _ingredients;
        BindingList<IngredientDTO> _ingredientsInRecette;
        BindingList<RecetteDTO> _recettesWithTheIngredient;
        BindingList<RecetteDTO> _recettesWithoutTheIngredient;

        public FormManageIngredients()
        {
            InitializeComponent();
            InitializeBinding();
        }

        private void InitializeBinding()
        {
            //Ingredients
            _ingredients = new();
            bindingSourceIngredients.DataSource = _ingredients;
            dataGridViewIngredients.DataSource = bindingSourceIngredients;

            dataGridViewIngredients.Columns["id"].Visible = false;
            dataGridViewIngredients.Columns["quantite"].Visible = false;

            //Ingredients in recette
            _ingredientsInRecette = new();
            bindingSourceIngredientsInRecette.DataSource = _ingredientsInRecette;
            dataGridViewIngredientsOfRecette.DataSource = bindingSourceIngredientsInRecette;

            dataGridViewIngredientsOfRecette.Columns["id"].Visible = false;

            //Recettes
            _recettesWithTheIngredient = new();
            bindingSourceRecetteWithTheIngredient.DataSource = _recettesWithTheIngredient;
            dataGridViewRecipes.DataSource = bindingSourceRecetteWithTheIngredient;

            dataGridViewRecipes.Columns["id"].Visible = false;
            dataGridViewRecipes.Columns["temps_preparation"].Visible = false;
            dataGridViewRecipes.Columns["temps_cuisson"].Visible = false;
            dataGridViewRecipes.Columns["temps_total"].Visible = false;
            dataGridViewRecipes.Columns["difficulte"].Visible = false;
            dataGridViewRecipes.Columns["img"].Visible = false;

            //Recettes without ingredients
            _recettesWithoutTheIngredient = new();
            bindingSourceRecetteWithoutTheIngredients.DataSource = _recettesWithoutTheIngredient;
            dataGridViewRecipesWithoutTheIngredient.DataSource = bindingSourceRecetteWithoutTheIngredients;

            dataGridViewRecipesWithoutTheIngredient.Columns["id"].Visible = false;
            dataGridViewRecipesWithoutTheIngredient.Columns["temps_preparation"].Visible = false;
            dataGridViewRecipesWithoutTheIngredient.Columns["temps_cuisson"].Visible = false;
            dataGridViewRecipesWithoutTheIngredient.Columns["temps_total"].Visible = false;
            dataGridViewRecipesWithoutTheIngredient.Columns["difficulte"].Visible = false;
            dataGridViewRecipesWithoutTheIngredient.Columns["img"].Visible = false;
        }

        #region Methods

        private async Task RefreshIngredients()
        {
            IngredientDTO current = bindingSourceIngredients.Current as IngredientDTO;

            var res = await _rest.GetAsync<IEnumerable<IngredientDTO>>(URL_GET_INGREDIENTS);

            _ingredients.Clear();
            foreach (IngredientDTO r in res)
                _ingredients.Add(r);

            // On se repositionne sur le current
            if (current is not null)
                bindingSourceIngredients.Position = _ingredients.IndexOf(_ingredients.Where(r => r.id == current.id).FirstOrDefault());
        }

        #endregion

        #region Events

        private async void FormManageIngredients_Load(object sender, EventArgs e)
        {
            _rest.BaseUrl = Settings.Default.BaseUrl;
            _rest.JwtToken = FormAppMain.Token;

            await RefreshIngredients();
        }

        private async void dataGridViewIngredients_CurrentChanged(object sender, EventArgs e)
        {
            IngredientDTO current = bindingSourceIngredients.Current as IngredientDTO;

            _ingredientsInRecette.Clear();

            if (current != null)
            {
                try
                {
                    var recetteIDs = await _rest.GetAsync<IEnumerable<int>>($"{URL_GET_INGREDIENTS}/{current.id}");
                    var recettes = await _rest.GetAsync<IEnumerable<RecetteDTO>>($"{URL_GET_RECETTES}");

                    var recetteWithIngredients = recettes.Where(r => recetteIDs.Contains(r.id)).ToList();
                    var recetteWithoutIngredients = recettes.Where(r => !recetteIDs.Contains(r.id)).ToList();

                    _recettesWithTheIngredient.Clear();
                    foreach (RecetteDTO rec in recetteWithIngredients)
                    {
                        _recettesWithTheIngredient.Add(rec);
                    }

                    _recettesWithoutTheIngredient.Clear();
                    foreach (RecetteDTO rec in recetteWithoutIngredients)
                    {
                        _recettesWithoutTheIngredient.Add(rec);
                    }
                }
                catch (Exception ex)
                {
                    _recettesWithTheIngredient.Clear();
                    _recettesWithoutTheIngredient.Clear();

                    var result = MessageBox.Show($"{ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async void dataGridViewRecipes_CurrentChanged(object sender, EventArgs e)
        {
            RecetteDTO current = bindingSourceRecetteWithTheIngredient.Current as RecetteDTO;

            _ingredientsInRecette.Clear();

            if (current != null)
            {
                try
                {
                    var res = await _rest.GetAsync<IEnumerable<IngredientDTO>>($"{URL_GET_INGREDIENTS}/recette/{current.id}");

                    _ingredientsInRecette.Clear();
                    foreach (var rec in res)
                    {
                        _ingredientsInRecette.Add(rec);
                    }
                }
                catch (Exception ex)
                {
                    _ingredientsInRecette.Clear();
                    var result = MessageBox.Show($"{ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async void buttonAddIngredient_Click(object sender, EventArgs e)
        {
            var nom = textBoxNomIngredient.Text;

            var confirm = MessageBox.Show(
                $"Créer l'ingrédient : {nom} ?",
                "Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );
            if (confirm == DialogResult.Yes)
            {
                await _rest.PostAsync($"{URL_CREATE_INGREDIENTS}", nom);
                await RefreshIngredients();
            }
        }

        private async void buttonModifyIngredient_Click(object sender, EventArgs e)
        {
            IngredientDTO current = bindingSourceIngredients.Current as IngredientDTO;
            var nom = textBoxNomIngredient.Text;

            var confirm = MessageBox.Show(
                $"Modifier l'ingrédient : {current.nom} en '{nom}' ?",
                "Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );
            if (confirm == DialogResult.Yes)
            {
                await _rest.PutAsync($"{URL_MODIFY_INGREDIENTS}/{current.id}", nom);
                await RefreshIngredients();
            }
        }

        private async void buttonRemoveIngredient_Click(object sender, EventArgs e)
        {
            IngredientDTO current = bindingSourceIngredients.Current as IngredientDTO;

            var confirm = MessageBox.Show(
                $"Supprimer l'ingrédient : {current.nom} ?",
                "Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );
            if (confirm == DialogResult.Yes)
            {
                await _rest.DeleteAsync($"{URL_CREATE_INGREDIENTS}/{current.id}");
                await RefreshIngredients();
            }
        }

        private async void buttonAddIngredientToRecette_Click(object sender, EventArgs e)
        {
            IngredientDTO current = bindingSourceIngredients.Current as IngredientDTO;
            RecetteDTO recette = bindingSourceRecetteWithoutTheIngredients.Current as RecetteDTO;

            if (recette is null || current is null)
            {
                MessageBox.Show("Aucune recette sélectionnée ou donnée introuvable.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var confirm = MessageBox.Show(
                $"Ajouter l'ingrédient : {current.nom} pour la recette '{recette.nom}' ?",
                "Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );
            if (confirm == DialogResult.Yes)
            {

                await _rest.PostAsync($"{URL_CREATE_INGREDIENTS}/AddToRecette/{recette.id}", current);
                await RefreshIngredients();
            }
        }

        private async void buttonModifyIngredientQuantity_Click(object sender, EventArgs e)
        {
            IngredientDTO current = bindingSourceIngredientsInRecette.Current as IngredientDTO;
            RecetteDTO recette = bindingSourceRecetteWithTheIngredient.Current as RecetteDTO;

            if (recette is null || current is null)
            {
                MessageBox.Show("Aucune recette ou ingrédient sélectionné.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var quantity = textBoxModifyQuantity.Text;

            var confirm = MessageBox.Show(
                $"Modifier la quantité de {current.nom}. de {current.quantite} en {quantity} pour la recette '{recette.nom}' ?",
                "Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );
            if (confirm == DialogResult.Yes)
            {

                current.quantite = quantity;

                try
                {
                    await _rest.PutAsync($"{URL_CREATE_INGREDIENTS}/UpdateQuantityInRecette/{recette.id}", current);
                    await RefreshIngredients();

                    MessageBox.Show($"Quantité de {current.nom} mise à jour avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erreur lors de la modification : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async void buttonRemoveIngredientFromRecette_Click(object sender, EventArgs e)
        {
            IngredientDTO current = bindingSourceIngredientsInRecette.Current as IngredientDTO;
            RecetteDTO recette = bindingSourceRecetteWithTheIngredient.Current as RecetteDTO;

            if (recette is null || current is null)
            {
                MessageBox.Show("Aucune recette ou ingrédient sélectionné.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var confirm = MessageBox.Show(
                $"Supprimer {current.nom} de la recette '{recette.nom}' ?",
                "Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );
            if (confirm == DialogResult.Yes)
            {
                await _rest.DeleteAsync($"{URL_CREATE_INGREDIENTS}/RemoveFromRecette/{recette.id}/{current.id}");
                await RefreshIngredients();
            }
        }

        #endregion
    }
}
