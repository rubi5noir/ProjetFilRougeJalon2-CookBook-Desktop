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
    public partial class FormRecetteDetails : Form
    {
        const string URL_GET_RECETTES = "api/Recettes";

        const string URL_GET_COMPTES = "api/Comptes";

        readonly RestClient _rest = new();

        private int idRecette;

        public FormRecetteDetails(int id)
        {
            idRecette = id;
            InitializeComponent();

        }

        #region Methods

        private async Task RefreshRecetteDetails()
        {
            RecetteDetailsDTO recette = await _rest.GetAsync<RecetteDetailsDTO>($"{URL_GET_RECETTES}/{idRecette}");

            double noteMoyenne = 0;

            if (recette.avis.Count > 0)
            {
                noteMoyenne = recette.avis.Average(a => a.note);
            }

            labelNomRecette.Text = recette.nom;
            textBoxDecriptionRecette.Text = recette.description;
            await RefreshTableLayoutPanelEtapes(recette.etapes);
            labelNoteMoyenne.Text = $"Note Moyenne : {noteMoyenne}";
            await RefreshTableLayoutPanelAvis(recette.avis);
            // IMG si le temps et les competences
            labelTempsPrepa.Text = recette.temps_preparation.ToString();
            labelTempsCui.Text = recette.temps_cuisson.ToString();
            labelTempsTotal.Text = recette.temps_total.ToString();
            await RefreshTableLayoutPanelIngredients(recette.ingredients);
            await RefreshTableLayoutPanelCategories(recette.categories);
            labelCreateur.Text = $"Créateur : {recette.identifiantCreateur}";
        }

        #endregion

        #region RightPartDetails

#pragma warning disable CS1998 // Cette méthode async n'a pas d'opérateur 'await' et elle s'exécutera de façon synchrone
        private async Task RefreshTableLayoutPanelIngredients(List<IngredientDTO> ingredients)
#pragma warning restore CS1998 // Cette méthode async n'a pas d'opérateur 'await' et elle s'exécutera de façon synchrone
        {
            tableLayoutPanelIngredients.Controls.Clear(); // call redraw sur le control
            tableLayoutPanelIngredients.RowStyles.Clear(); //call redraw sur la table
            tableLayoutPanelIngredients.ColumnStyles[0].Width = 65; // call redraw
            tableLayoutPanelIngredients.ColumnStyles[1].Width = 25;
            tableLayoutPanelIngredients.RowCount = ingredients.Count;
            
            
          

            int rowIndex = 0;
            foreach (IngredientDTO ingredient in ingredients)
            {
                tableLayoutPanelIngredients.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                labelIngredient = new Label();
                labelIngredient.Name = $"labelIngredient{ingredient.id}";
                labelIngredient.AutoSize = true;
                labelIngredient.Text = ingredient.nom;
                labelIngredient.Dock = DockStyle.Top;
                labelIngredient.BackColor = Color.FromArgb(147, 129, 255);


                labelQuantite = new Label();
                labelQuantite.Name = $"labelQuantite{ingredient.id}";
                labelQuantite.AutoSize = true;
                labelQuantite.Text = ingredient.quantite;
                labelQuantite.Dock = DockStyle.Top;
                labelQuantite.BackColor = Color.FromArgb(147, 129, 255);

                tableLayoutPanelIngredients.Controls.Add(labelIngredient, 0, rowIndex);
                tableLayoutPanelIngredients.Controls.Add(labelQuantite, 1, rowIndex);

            
                rowIndex++;
            }
        }

#pragma warning disable CS1998 // Cette méthode async n'a pas d'opérateur 'await' et elle s'exécutera de façon synchrone
        private async Task RefreshTableLayoutPanelCategories(List<CategorieDTO> categories)
#pragma warning restore CS1998 // Cette méthode async n'a pas d'opérateur 'await' et elle s'exécutera de façon synchrone
        {
            tableLayoutPanelCategories.Controls.Clear();
            tableLayoutPanelCategories.RowCount = categories.Count;

            int rowIndex = 0;

            foreach (CategorieDTO categorie in categories)
            {
                labelCategorie = new Label();
                labelCategorie.Name = $"labelCategorie{categorie.id}";
                labelCategorie.AutoSize = true;
                labelCategorie.Text = categorie.nom;
                labelCategorie.BackColor = Color.FromArgb(147, 129, 255);

                tableLayoutPanelCategories.Controls.Add(labelCategorie, 0, rowIndex);

                rowIndex++;
            }
        }

        #endregion

        #region LeftPartDetails

#pragma warning disable CS1998 // Cette méthode async n'a pas d'opérateur 'await' et elle s'exécutera de façon synchrone
        private async Task RefreshTableLayoutPanelEtapes(List<EtapeDTO> etapes)
#pragma warning restore CS1998 // Cette méthode async n'a pas d'opérateur 'await' et elle s'exécutera de façon synchrone
        {
            tableLayoutPanelEtapes.Controls.Clear(); // call redraw sur le control
            tableLayoutPanelEtapes.RowStyles.Clear(); //call redraw sur la table
            // besoin mettre un style permettant de voir le multiligne et pas plus que ce que le texte prends
            tableLayoutPanelEtapes.RowCount = etapes.Count;

            int rowIndex = 0;

            foreach (EtapeDTO etape in etapes)
            {
                labelEtape = new Label();
                labelEtape.Name = $"labelEtape{etape.numero}";
                labelEtape.AutoSize = true;
                labelEtape.Text = etape.numero.ToString();
                labelEtape.BackColor = Color.FromArgb(147, 129, 255);

                textBoxEtape = new TextBox();
                textBoxEtape.Name = $"textBoxEtape{etape.numero}";
                textBoxEtape.ReadOnly = true;
                textBoxEtape.Multiline = true;
                textBoxEtape.Dock = DockStyle.Fill;
                textBoxEtape.Text = etape.texte;
                
                tableLayoutPanelEtapes.Controls.Add(labelEtape, 0, rowIndex);
                tableLayoutPanelEtapes.Controls.Add(textBoxEtape, 1, rowIndex);

                rowIndex++;
            }
        }

        private async Task RefreshTableLayoutPanelAvis(List<AvisDTO> avis)
        {
            tableLayoutPanelAvis.Controls.Clear();
            tableLayoutPanelAvis.RowCount = avis.Count;

            List<UtilisateurDTO> utilisateurs = await _rest.GetAsync<List<UtilisateurDTO>>(URL_GET_COMPTES); 

            int rowIndex = 0;

            foreach (AvisDTO avi in avis)
            {
                var utilisateur = utilisateurs.FirstOrDefault(u => u.id == avi.id_utilisateur);

                labelUtilisateur = new Label();
#pragma warning disable CS8602 // Déréférencement d'une éventuelle référence null.
                labelUtilisateur.Text = utilisateur.identifiant;
#pragma warning restore CS8602 // Déréférencement d'une éventuelle référence null.
                labelUtilisateur.BackColor = Color.FromArgb(147, 129, 255);

                textBoxAvis = new TextBox();
                textBoxAvis.Name = $"textBoxAvis{avi.id_utilisateur}";
                textBoxAvis.ReadOnly = true;
                textBoxAvis.Multiline = true;
                textBoxAvis.Dock = DockStyle.Fill;
                textBoxAvis.Text = avi.commentaire;

                labelNote = new Label();
                labelNote.Name = $"labelNote{avi.id_utilisateur}";
                labelNote.Text = avi.note.ToString();
                labelNote.BackColor = Color.FromArgb(147, 129, 255);

                tableLayoutPanelAvis.Controls.Add(labelUtilisateur, 0, rowIndex);
                tableLayoutPanelAvis.Controls.Add(textBoxAvis, 1, rowIndex);
                tableLayoutPanelAvis.Controls.Add(labelNote, 2, rowIndex);

                rowIndex++;
            }
        }

        #endregion

        #region Events

        private async void FormRecetteDetails_FormLoad(object sender, EventArgs e)
        {
            _rest.BaseUrl = Settings.Default.BaseUrl;
            _rest.JwtToken = FormAppMain.Token;

            await RefreshRecetteDetails();
        }

        protected override void OnResizeEnd(EventArgs e)
        {
            base.OnResizeEnd(e);
            Task.Delay(1);
            tableLayoutPanelIngredients.Refresh();
        }

        #endregion
    }
}
