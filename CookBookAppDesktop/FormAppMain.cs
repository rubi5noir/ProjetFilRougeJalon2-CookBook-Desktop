using CookBookAppDesktop.Models.DTO;
using CookBookAppDesktop.Properties;
using System.ComponentModel;
using System.IdentityModel.Tokens.Jwt;

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

        const string URL_GET_INGREDIENTS = "api/Ingredients";

        readonly RestClient _rest = new();
        BindingList<RecetteDTO> _recettes;
        BindingList<EtapeDTO> _etapes;
        BindingList<CategorieDTO> _categories;
        BindingList<IngredientDTO> _ingredients;


#pragma warning disable CS8618 // Un champ non-nullable doit contenir une valeur autre que Null lors de la fermeture du constructeur. Envisagez d’ajouter le modificateur « required » ou de déclarer le champ comme pouvant accepter la valeur Null.
#pragma warning disable S1104 // Fields should not have public accessibility
#pragma warning disable S2223 // Non-constant static fields should not be visible
        public static string Token;
#pragma warning restore S2223 // Non-constant static fields should not be visible
#pragma warning restore S1104 // Fields should not have public accessibility
#pragma warning restore CS8618 // Un champ non-nullable doit contenir une valeur autre que Null lors de la fermeture du constructeur. Envisagez d’ajouter le modificateur « required » ou de déclarer le champ comme pouvant accepter la valeur Null.

#pragma warning disable S4487 // Unread "private" fields should be removed
        IEnumerable<string> _roles = [];
#pragma warning restore S4487 // Unread "private" fields should be removed



#pragma warning disable CS8618 // Un champ non-nullable doit contenir une valeur autre que Null lors de la fermeture du constructeur. Envisagez d’ajouter le modificateur « required » ou de déclarer le champ comme pouvant accepter la valeur Null.
        public FormAppMain()
#pragma warning restore CS8618 // Un champ non-nullable doit contenir une valeur autre que Null lors de la fermeture du constructeur. Envisagez d’ajouter le modificateur « required » ou de déclarer le champ comme pouvant accepter la valeur Null.
        {

            DoubleBuffered = true;
            InitializeComponent(); //designer

            InitializeBinding();
            InitializeInputsLimits();

            //Initialize the MouseWheel events as you can't do it with the properties on the conceptor side
            //Using of Different Methods for each "part" in case they need some exclusive code in the future
            numericUpDownDifficulteRecette.MouseWheel += NumericUpDownDifficulteRecette_MouseWheel;

            //Same for both as i think that if there is some events logic to do with one the other need it
#pragma warning disable CS8622 // La nullabilité des types référence dans le type du paramètre ne correspond pas au délégué cible (probablement en raison des attributs de nullabilité).
            numericUpDownTemps_PréparationHeures.MouseWheel += NumericUpDownTempsPreparation_MouseWheel;
            numericUpDownTemps_PréparationMinutes.MouseWheel += NumericUpDownTempsPreparation_MouseWheel;

            numericUpDownTemps_CuissonHeures.MouseWheel += NumericUpDownTempsPreparation_MouseWheel;
            numericUpDownTemps_CuissonMinutes.MouseWheel += NumericUpDownTempsPreparation_MouseWheel;
#pragma warning restore CS8622 // La nullabilité des types référence dans le type du paramètre ne correspond pas au délégué cible (probablement en raison des attributs de nullabilité).

        }

        #region Methods

        private void InitializeBinding()
        {
            // Recettes
            _recettes = new();
            bindingSourceRecettes.DataSource = _recettes;
            dataGridViewRecettes.DataSource = bindingSourceRecettes;
            dataGridViewEtapesRecette.DataSource = bindingSourceRecettes;

            dataGridViewRecettes.Columns["id"].Visible = false;
            dataGridViewRecettes.Columns["img"].Visible = false;


            dataGridViewEtapesRecette.Columns["id"].DisplayIndex = 2; //Deplacement d'index pour pouvoir le rendre invisible 
            // raison = Pas trouvé d'autres soluce pour :/
            dataGridViewEtapesRecette.Columns["id"].Visible = false;
            dataGridViewEtapesRecette.Columns["temps_preparation"].Visible = false;
            dataGridViewEtapesRecette.Columns["temps_cuisson"].Visible = false;
            dataGridViewEtapesRecette.Columns["temps_total"].Visible = false;
            dataGridViewEtapesRecette.Columns["difficulte"].Visible = false;
            dataGridViewEtapesRecette.Columns["img"].Visible = false;

            textBoxNomRecette.DataBindings.Add("text", bindingSourceRecettes, "nom", false, DataSourceUpdateMode.Never);
            textBoxDescriptionRecette.DataBindings.Add("text", bindingSourceRecettes, "description", false, DataSourceUpdateMode.Never);
            numericUpDownDifficulteRecette.DataBindings.Add("value", bindingSourceRecettes, "difficulte", true, DataSourceUpdateMode.Never);
            textBoxImageRecette.DataBindings.Add("text", bindingSourceRecettes, "img", false, DataSourceUpdateMode.Never);

            numericUpDownTemps_PréparationHeures.DataBindings.Add("value", bindingSourceRecettes, "temps_preparation", true, DataSourceUpdateMode.Never);
            numericUpDownTemps_PréparationHeures.DataBindings["value"].Format += (obj, evt) => Utility.ConvertTimeSpanBinding(evt, true);

            numericUpDownTemps_PréparationMinutes.DataBindings.Add("value", bindingSourceRecettes, "temps_preparation", true, DataSourceUpdateMode.Never);
            numericUpDownTemps_PréparationMinutes.DataBindings["value"].Format += (obj, evt) => Utility.ConvertTimeSpanBinding(evt);


            numericUpDownTemps_CuissonHeures.DataBindings.Add("value", bindingSourceRecettes, "temps_cuisson", true, DataSourceUpdateMode.Never);
            numericUpDownTemps_CuissonHeures.DataBindings["value"].Format += (obj, evt) => Utility.ConvertTimeSpanBinding(evt, true);

            numericUpDownTemps_CuissonMinutes.DataBindings.Add("value", bindingSourceRecettes, "temps_cuisson", true, DataSourceUpdateMode.Never);
            numericUpDownTemps_CuissonMinutes.DataBindings["value"].Format += (obj, evt) => Utility.ConvertTimeSpanBinding(evt);


            // Etapes
            _etapes = new();

            bindingSourceEtapes.DataSource = _etapes;
            dataGridViewEtapes.DataSource = bindingSourceEtapes;


            dataGridViewEtapes.Columns["id"].DisplayIndex = 2; //Deplacement d'index pour pouvoir le rendre invisible 
            // raison = Pas trouvé d'autres soluce pour :/
            dataGridViewEtapes.Columns["id"].Visible = false;


            // Categories
            _categories = new();
            bindingSourceCategories.DataSource = _categories;
            dataGridViewCategories.DataSource = bindingSourceCategories;

            dataGridViewCategories.Columns["id"].Visible = false;

            // Ingredients
            _ingredients = new();
            bindingSourceIngredients.DataSource = _ingredients;
            dataGridViewIngredients.DataSource = bindingSourceIngredients;

            dataGridViewIngredients.Columns["id"].Visible = false;
            dataGridViewIngredients.Columns["quantite"].Visible = false;


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
#pragma warning disable CS8600 // Conversion de littéral ayant une valeur null ou d'une éventuelle valeur null en type non-nullable.
            RecetteDTO current = bindingSourceRecettes.Current as RecetteDTO;
#pragma warning restore CS8600 // Conversion de littéral ayant une valeur null ou d'une éventuelle valeur null en type non-nullable.
            // Remplissage de la liste
            var res = await _rest.GetAsync<IEnumerable<RecetteDTO>>($"{URL_GET_RECETTES}/Details");

            _recettes.Clear();
            foreach (RecetteDTO r in res)
                _recettes.Add(r);

            // On se repositionne sur le current
            if (current is not null)
#pragma warning disable CS8604 // Existence possible d'un argument de référence null.
                bindingSourceRecettes.Position = _recettes.IndexOf(_recettes.FirstOrDefault(r => r.id == current.id));
#pragma warning restore CS8604 // Existence possible d'un argument de référence null.
        }

        private async Task RefreshEtapes()
        {
#pragma warning disable CS8600 // Conversion de littéral ayant une valeur null ou d'une éventuelle valeur null en type non-nullable.
            RecetteDTO recette = bindingSourceRecettes.Current as RecetteDTO;
#pragma warning restore CS8600 // Conversion de littéral ayant une valeur null ou d'une éventuelle valeur null en type non-nullable.

#pragma warning disable CS8602 // Déréférencement d'une éventuelle référence null.
            var res = await _rest.GetAsync<IEnumerable<EtapeDTO>>($"{URL_GET_ETAPES}/{recette.id}");
#pragma warning restore CS8602 // Déréférencement d'une éventuelle référence null.

            _etapes.Clear();
            foreach (EtapeDTO e in res)
                _etapes.Add(e);
        }

        private async Task RefreshCategories()
        {
#pragma warning disable CS8600 // Conversion de littéral ayant une valeur null ou d'une éventuelle valeur null en type non-nullable.
            CategorieDTO current = bindingSourceRecettes.Current as CategorieDTO;
#pragma warning restore CS8600 // Conversion de littéral ayant une valeur null ou d'une éventuelle valeur null en type non-nullable.

            var res = await _rest.GetAsync<IEnumerable<CategorieDTO>>($"{URL_GET_CATEGORIES}");

            _categories.Clear();
            foreach (CategorieDTO c in res)
                _categories.Add(c);

            if (current is not null)
            {
#pragma warning disable CS8604 // Existence possible d'un argument de référence null.
                bindingSourceCategories.Position = _categories.IndexOf(_categories.FirstOrDefault(c => c.id == current.id));
#pragma warning restore CS8604 // Existence possible d'un argument de référence null.
            }
        }

        private async Task RefreshIngredients()
        {
#pragma warning disable CS8600 // Conversion de littéral ayant une valeur null ou d'une éventuelle valeur null en type non-nullable.
            IngredientDTO current = bindingSourceIngredients.Current as IngredientDTO;
#pragma warning restore CS8600 // Conversion de littéral ayant une valeur null ou d'une éventuelle valeur null en type non-nullable.

            var res = await _rest.GetAsync<IEnumerable<IngredientDTO>>($"{URL_GET_INGREDIENTS}");

            _ingredients.Clear();
            foreach (IngredientDTO i in res)
                _ingredients.Add(i);

            if (current is not null)
            {
#pragma warning disable CS8604 // Existence possible d'un argument de référence null.
                bindingSourceIngredients.Position = _ingredients.IndexOf(_ingredients.FirstOrDefault(i => i.id == current.id));
#pragma warning restore CS8604 // Existence possible d'un argument de référence null.
            }
        }

        /// <summary>
        /// Write user info in the compte tab / such as username and roles based on JWT token
        /// </summary>
        /// <returns></returns>
#pragma warning disable CS1998 // Cette méthode async n'a pas d'opérateur 'await' et elle s'exécutera de façon synchrone
        private async Task WriteUserInfo()
#pragma warning restore CS1998 // Cette méthode async n'a pas d'opérateur 'await' et elle s'exécutera de façon synchrone
        {
            var handler = new JwtSecurityTokenHandler();
            var jwt = handler.ReadJwtToken(_rest.JwtToken);

            labelPseudonymeUtilisateur.Text = jwt.Claims.First(c => c.Type == "sub").Value; ;
            labelRoleUtilisateur.Text = _roles != null && _roles.Any() ? string.Join(", ", _roles) : "Aucun rôle";
        }

        private async Task ToggleAllowedButtons()
        {
            if (_roles.Contains("Admin"))
            {
                // Recettes Tab
                buttonAddRecettes.Enabled = true;
                buttonModifyRecettes.Enabled = true;
                buttonRemoveRecettes.Enabled = true;

                // Etapes Tab
                buttonOpenFormSelectionEtapes.Enabled = true;

                // Categories Tab
                buttonOpenFormSelectionCategories.Enabled = true;

                // Ingredients Tab
                buttonOpenFormSelectionIngredients.Enabled = true;
            }
            else if (_roles.Contains("User"))
            {
                // Recettes Tab
                buttonAddRecettes.Enabled = false;
                buttonModifyRecettes.Enabled = false;
                buttonRemoveRecettes.Enabled = false;

                // Etapes Tab
                buttonOpenFormSelectionEtapes.Enabled = false;

                // Categories Tab
                buttonOpenFormSelectionCategories.Enabled = false;

                // Ingredients Tab
                buttonOpenFormSelectionIngredients.Enabled = false;
            }
        }

        #endregion

        #region Events

        private async void FormAppMain_Load(object sender, EventArgs e)
        {

            _rest.BaseUrl = Settings.Default.BaseUrl;

            // Hide the tab that is not implemented yet
            tabControlApp.TabPages.Remove(tabPageAvis);

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
#pragma warning disable S2696 // Instance members should not write to "static" fields
                    Token = _rest.JwtToken;
#pragma warning restore S2696 // Instance members should not write to "static" fields

                    tableLayoutPanelApp.Enabled = true;

                    await ToggleAllowedButtons();

                    await RefreshRecettes();
                    await WriteUserInfo();
                }
            }
            dataGridViewEtapes.Columns["id"].Visible = false;
        }

        private void FormAppMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Close();
        }

        private async void tabControl_Selecting(object sender, TabControlCancelEventArgs e)
        {
            await ToggleAllowedButtons();

            if (e.TabPage == tabPageRecettes)
                await RefreshRecettes();
            else if (e.TabPage == tabPageEtapes)
                await RefreshEtapes();
            else if (e.TabPage == tabPageCategories)
                await RefreshCategories();
            else if (e.TabPage == tabPageIngredients)
                await RefreshIngredients();
            else if (e.TabPage == tabPageCompte)
                await WriteUserInfo();
        }

        #region TabPageRecettes

        private void NumericUpDownTempsPreparation_MouseWheel(object sender, MouseEventArgs e)
        {
            Utility.HandleMouseWheelEventForNumericUpDown(sender, e);
        }

        private void NumericUpDownTempsCuisson_MouseWheel(object sender, MouseEventArgs e)
        {
            Utility.HandleMouseWheelEventForNumericUpDown(sender, e);
        }

        private void NumericUpDownDifficulteRecette_MouseWheel(object? sender, MouseEventArgs e)
        {
#pragma warning disable CS8604 // Existence possible d'un argument de référence null.
            Utility.HandleMouseWheelEventForNumericUpDown(sender, e);
#pragma warning restore CS8604 // Existence possible d'un argument de référence null.
        }

        private async void buttonRefreshRecettes_Click(object sender, EventArgs e)
        {
            await RefreshRecettes();
        }

        private async void buttonAddRecette_Click(object sender, EventArgs e)
        {
            RecetteDTO newRecette = new()
            {
                nom = textBoxNomRecette.Text,
                description = textBoxDescriptionRecette.Text,
                temps_preparation = new TimeSpan((int)numericUpDownTemps_PréparationHeures.Value, (int)numericUpDownTemps_PréparationMinutes.Value, 0),
                temps_cuisson = new TimeSpan((int)numericUpDownTemps_CuissonHeures.Value, (int)numericUpDownTemps_CuissonMinutes.Value, 0),
                difficulte = (int)numericUpDownDifficulteRecette.Value,
                img = textBoxImageRecette.Text
            };

            await _rest.PostAsync<RecetteDTO, RecetteDTO>(URL_CREATE_RECETTES, newRecette);
        }

        private async void buttonUpdateRecette_Click(object sender, EventArgs e)
        {
            if (bindingSourceRecettes.Current is not RecetteDTO selectedRecette)
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
            await _rest.PutAsync($"{URL_UPDATE_RECETTES}/{selectedRecette.id}", selectedRecette);
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

        private void buttonSelectionnerImageRecette_Click(object sender, EventArgs e)
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

        private void buttonOpenRecetteDetailsForm_Click(object sender, EventArgs e)
        {
#pragma warning disable CS8600 // Conversion de littéral ayant une valeur null ou d'une éventuelle valeur null en type non-nullable.
            RecetteDTO current = bindingSourceRecettes.Current as RecetteDTO;
#pragma warning restore CS8600 // Conversion de littéral ayant une valeur null ou d'une éventuelle valeur null en type non-nullable.

#pragma warning disable CS8602 // Déréférencement d'une éventuelle référence null.
            FormRecetteDetails formRecetteDetails = new FormRecetteDetails(current.id);
#pragma warning restore CS8602 // Déréférencement d'une éventuelle référence null.
            formRecetteDetails.ShowDialog();
        }

        #endregion

        #region TabPageEtapes

        private async void dataGridViewEtapesRecettes_SelectionChanged(object sender, EventArgs e)
        {
#pragma warning disable IDE0019 // Utiliser les critères spéciaux
#pragma warning disable CS8600 // Conversion de littéral ayant une valeur null ou d'une éventuelle valeur null en type non-nullable.
            RecetteDTO current = bindingSourceRecettes.Current as RecetteDTO;
#pragma warning restore CS8600 // Conversion de littéral ayant une valeur null ou d'une éventuelle valeur null en type non-nullable.
#pragma warning restore IDE0019 // Utiliser les critères spéciaux

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

        #region TabPageIngredients

        private async void buttonRefreshIngredients_Click(object sender, EventArgs e)
        {
            await RefreshIngredients();
        }

        private async void buttonOpenFormManageIngredients_Click(object sender, EventArgs e)
        {
            FormManageIngredients formManageIngredients = new FormManageIngredients();
            if (formManageIngredients.ShowDialog() == DialogResult.OK)
            {
                await RefreshIngredients();
            }
        }

        #endregion

        #region TabPageUtilisateurs

        private async void buttonLogOut_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show($"Êtes-vous sûr de vouloir vous déconnecter ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                _rest.JwtToken = null;
                _roles = [];

                this.FormAppMain_Load(this, EventArgs.Empty);
            }
        }

        #endregion

        #endregion

    }
}
