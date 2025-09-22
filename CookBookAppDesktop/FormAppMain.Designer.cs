namespace CookBookAppDesktop
{
    partial class FormAppMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAppMain));
            tableLayoutPanelApp = new TableLayoutPanel();
            tabControlApp = new TabControl();
            tabPageRecettes = new TabPage();
            tableLayoutPanelGestionRecettes = new TableLayoutPanel();
            dataGridViewRecettes = new DataGridView();
            panelRecettesInputs = new Panel();
            tableLayoutPanelGestionRecettesInputs = new TableLayoutPanel();
            labelDescriptionRecette = new Label();
            labelNomRecette = new Label();
            tableLayoutPanelNomRecette = new TableLayoutPanel();
            textBoxNomRecette = new TextBox();
            tableLayoutPanelImageRecette = new TableLayoutPanel();
            textBoxImageRecette = new TextBox();
            buttonSelectionnerImageRecette = new Button();
            labelTemps_PréparationRecette = new Label();
            tableLayoutPanelTemps_PréparationRecette = new TableLayoutPanel();
            numericUpDownTemps_PréparationHeures = new NumericUpDown();
            numericUpDownTemps_PréparationMinutes = new NumericUpDown();
            labelTemps_CuissonRecette = new Label();
            tableLayoutPanelTemps_CuissonRecette = new TableLayoutPanel();
            numericUpDownTemps_CuissonHeures = new NumericUpDown();
            numericUpDownTemps_CuissonMinutes = new NumericUpDown();
            labelDifficulteRecette = new Label();
            labelIMGRecette = new Label();
            labelListEtapesRecette = new Label();
            tableLayoutPanelEtapesRecette = new TableLayoutPanel();
            buttonOpenFormSelectionEtapes = new Button();
            listViewListEtapesRecette = new ListView();
            labelListCategoriesRecette = new Label();
            tableLayoutPanelCategoriesRecette = new TableLayoutPanel();
            buttonOpenFormSelectionCategories = new Button();
            listViewListCategoriesRecette = new ListView();
            labelListIngredientsRecette = new Label();
            tableLayoutPanelIngredientsRecette = new TableLayoutPanel();
            buttonOpenFormSelectionIngredients = new Button();
            listViewListIngredientsRecette = new ListView();
            tableLayoutPanelDifficulteRecette = new TableLayoutPanel();
            numericUpDownDifficulteRecette = new NumericUpDown();
            tableLayoutPanelDescriptionRecette = new TableLayoutPanel();
            textBoxDescriptionRecette = new TextBox();
            flowLayoutPanelGestionRecettesButtons = new FlowLayoutPanel();
            buttonRefreshRecettes = new Button();
            buttonAddRecettes = new Button();
            buttonModifyRecettes = new Button();
            buttonRemoveRecettes = new Button();
            tabPageEtapes = new TabPage();
            bindingSourceRecettes = new BindingSource(components);
            tableLayoutPanelApp.SuspendLayout();
            tabControlApp.SuspendLayout();
            tabPageRecettes.SuspendLayout();
            tableLayoutPanelGestionRecettes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRecettes).BeginInit();
            panelRecettesInputs.SuspendLayout();
            tableLayoutPanelGestionRecettesInputs.SuspendLayout();
            tableLayoutPanelNomRecette.SuspendLayout();
            tableLayoutPanelImageRecette.SuspendLayout();
            tableLayoutPanelTemps_PréparationRecette.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownTemps_PréparationHeures).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownTemps_PréparationMinutes).BeginInit();
            tableLayoutPanelTemps_CuissonRecette.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownTemps_CuissonHeures).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownTemps_CuissonMinutes).BeginInit();
            tableLayoutPanelEtapesRecette.SuspendLayout();
            tableLayoutPanelCategoriesRecette.SuspendLayout();
            tableLayoutPanelIngredientsRecette.SuspendLayout();
            tableLayoutPanelDifficulteRecette.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDifficulteRecette).BeginInit();
            tableLayoutPanelDescriptionRecette.SuspendLayout();
            flowLayoutPanelGestionRecettesButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSourceRecettes).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanelApp
            // 
            tableLayoutPanelApp.AutoSize = true;
            tableLayoutPanelApp.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanelApp.ColumnCount = 1;
            tableLayoutPanelApp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelApp.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanelApp.Controls.Add(tabControlApp, 0, 0);
            tableLayoutPanelApp.Dock = DockStyle.Fill;
            tableLayoutPanelApp.Location = new Point(0, 0);
            tableLayoutPanelApp.Name = "tableLayoutPanelApp";
            tableLayoutPanelApp.RowCount = 1;
            tableLayoutPanelApp.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelApp.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanelApp.Size = new Size(684, 561);
            tableLayoutPanelApp.TabIndex = 0;
            // 
            // tabControlApp
            // 
            tabControlApp.Controls.Add(tabPageRecettes);
            tabControlApp.Controls.Add(tabPageEtapes);
            tabControlApp.Dock = DockStyle.Fill;
            tabControlApp.Location = new Point(3, 3);
            tabControlApp.Name = "tabControlApp";
            tabControlApp.SelectedIndex = 0;
            tabControlApp.Size = new Size(678, 555);
            tabControlApp.TabIndex = 0;
            // 
            // tabPageRecettes
            // 
            tabPageRecettes.Controls.Add(tableLayoutPanelGestionRecettes);
            tabPageRecettes.Location = new Point(4, 24);
            tabPageRecettes.Name = "tabPageRecettes";
            tabPageRecettes.Padding = new Padding(3);
            tabPageRecettes.Size = new Size(670, 527);
            tabPageRecettes.TabIndex = 0;
            tabPageRecettes.Text = "Recettes";
            tabPageRecettes.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanelGestionRecettes
            // 
            tableLayoutPanelGestionRecettes.AutoSize = true;
            tableLayoutPanelGestionRecettes.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanelGestionRecettes.ColumnCount = 1;
            tableLayoutPanelGestionRecettes.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelGestionRecettes.Controls.Add(dataGridViewRecettes, 0, 0);
            tableLayoutPanelGestionRecettes.Controls.Add(panelRecettesInputs, 0, 1);
            tableLayoutPanelGestionRecettes.Controls.Add(flowLayoutPanelGestionRecettesButtons, 0, 2);
            tableLayoutPanelGestionRecettes.Dock = DockStyle.Fill;
            tableLayoutPanelGestionRecettes.Location = new Point(3, 3);
            tableLayoutPanelGestionRecettes.Name = "tableLayoutPanelGestionRecettes";
            tableLayoutPanelGestionRecettes.RowCount = 3;
            tableLayoutPanelGestionRecettes.RowStyles.Add(new RowStyle(SizeType.Percent, 41.0256462F));
            tableLayoutPanelGestionRecettes.RowStyles.Add(new RowStyle(SizeType.Percent, 58.9743538F));
            tableLayoutPanelGestionRecettes.RowStyles.Add(new RowStyle());
            tableLayoutPanelGestionRecettes.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanelGestionRecettes.Size = new Size(664, 521);
            tableLayoutPanelGestionRecettes.TabIndex = 0;
            // 
            // dataGridViewRecettes
            // 
            dataGridViewRecettes.AllowUserToAddRows = false;
            dataGridViewRecettes.AllowUserToDeleteRows = false;
            dataGridViewRecettes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRecettes.Dock = DockStyle.Fill;
            dataGridViewRecettes.Location = new Point(3, 3);
            dataGridViewRecettes.Name = "dataGridViewRecettes";
            dataGridViewRecettes.ReadOnly = true;
            dataGridViewRecettes.Size = new Size(658, 180);
            dataGridViewRecettes.TabIndex = 2;
            // 
            // panelRecettesInputs
            // 
            panelRecettesInputs.AutoScroll = true;
            panelRecettesInputs.AutoSize = true;
            panelRecettesInputs.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelRecettesInputs.Controls.Add(tableLayoutPanelGestionRecettesInputs);
            panelRecettesInputs.Dock = DockStyle.Fill;
            panelRecettesInputs.Location = new Point(3, 189);
            panelRecettesInputs.Name = "panelRecettesInputs";
            panelRecettesInputs.Size = new Size(658, 261);
            panelRecettesInputs.TabIndex = 3;
            // 
            // tableLayoutPanelGestionRecettesInputs
            // 
            tableLayoutPanelGestionRecettesInputs.AutoScroll = true;
            tableLayoutPanelGestionRecettesInputs.ColumnCount = 2;
            tableLayoutPanelGestionRecettesInputs.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanelGestionRecettesInputs.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelGestionRecettesInputs.Controls.Add(labelDescriptionRecette, 0, 1);
            tableLayoutPanelGestionRecettesInputs.Controls.Add(labelNomRecette, 0, 0);
            tableLayoutPanelGestionRecettesInputs.Controls.Add(tableLayoutPanelNomRecette, 1, 0);
            tableLayoutPanelGestionRecettesInputs.Controls.Add(tableLayoutPanelImageRecette, 1, 5);
            tableLayoutPanelGestionRecettesInputs.Controls.Add(labelTemps_PréparationRecette, 0, 2);
            tableLayoutPanelGestionRecettesInputs.Controls.Add(tableLayoutPanelTemps_PréparationRecette, 1, 2);
            tableLayoutPanelGestionRecettesInputs.Controls.Add(labelTemps_CuissonRecette, 0, 3);
            tableLayoutPanelGestionRecettesInputs.Controls.Add(tableLayoutPanelTemps_CuissonRecette, 1, 3);
            tableLayoutPanelGestionRecettesInputs.Controls.Add(labelDifficulteRecette, 0, 4);
            tableLayoutPanelGestionRecettesInputs.Controls.Add(labelIMGRecette, 0, 5);
            tableLayoutPanelGestionRecettesInputs.Controls.Add(labelListEtapesRecette, 0, 6);
            tableLayoutPanelGestionRecettesInputs.Controls.Add(tableLayoutPanelEtapesRecette, 1, 6);
            tableLayoutPanelGestionRecettesInputs.Controls.Add(labelListCategoriesRecette, 0, 7);
            tableLayoutPanelGestionRecettesInputs.Controls.Add(tableLayoutPanelCategoriesRecette, 1, 7);
            tableLayoutPanelGestionRecettesInputs.Controls.Add(labelListIngredientsRecette, 0, 8);
            tableLayoutPanelGestionRecettesInputs.Controls.Add(tableLayoutPanelIngredientsRecette, 1, 8);
            tableLayoutPanelGestionRecettesInputs.Controls.Add(tableLayoutPanelDifficulteRecette, 1, 4);
            tableLayoutPanelGestionRecettesInputs.Controls.Add(tableLayoutPanelDescriptionRecette, 1, 1);
            tableLayoutPanelGestionRecettesInputs.Dock = DockStyle.Top;
            tableLayoutPanelGestionRecettesInputs.Location = new Point(0, 0);
            tableLayoutPanelGestionRecettesInputs.Name = "tableLayoutPanelGestionRecettesInputs";
            tableLayoutPanelGestionRecettesInputs.RowCount = 9;
            tableLayoutPanelGestionRecettesInputs.RowStyles.Add(new RowStyle());
            tableLayoutPanelGestionRecettesInputs.RowStyles.Add(new RowStyle());
            tableLayoutPanelGestionRecettesInputs.RowStyles.Add(new RowStyle());
            tableLayoutPanelGestionRecettesInputs.RowStyles.Add(new RowStyle());
            tableLayoutPanelGestionRecettesInputs.RowStyles.Add(new RowStyle());
            tableLayoutPanelGestionRecettesInputs.RowStyles.Add(new RowStyle());
            tableLayoutPanelGestionRecettesInputs.RowStyles.Add(new RowStyle());
            tableLayoutPanelGestionRecettesInputs.RowStyles.Add(new RowStyle());
            tableLayoutPanelGestionRecettesInputs.RowStyles.Add(new RowStyle());
            tableLayoutPanelGestionRecettesInputs.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanelGestionRecettesInputs.Size = new Size(641, 679);
            tableLayoutPanelGestionRecettesInputs.TabIndex = 0;
            // 
            // labelDescriptionRecette
            // 
            labelDescriptionRecette.AutoSize = true;
            labelDescriptionRecette.Dock = DockStyle.Fill;
            labelDescriptionRecette.Location = new Point(3, 35);
            labelDescriptionRecette.Name = "labelDescriptionRecette";
            labelDescriptionRecette.Size = new Size(127, 35);
            labelDescriptionRecette.TabIndex = 1;
            labelDescriptionRecette.Text = "Description :";
            // 
            // labelNomRecette
            // 
            labelNomRecette.AutoSize = true;
            labelNomRecette.Dock = DockStyle.Fill;
            labelNomRecette.Location = new Point(3, 0);
            labelNomRecette.Name = "labelNomRecette";
            labelNomRecette.Size = new Size(127, 35);
            labelNomRecette.TabIndex = 0;
            labelNomRecette.Text = "Nom :";
            // 
            // tableLayoutPanelNomRecette
            // 
            tableLayoutPanelNomRecette.AutoSize = true;
            tableLayoutPanelNomRecette.ColumnCount = 1;
            tableLayoutPanelNomRecette.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelNomRecette.Controls.Add(textBoxNomRecette, 0, 0);
            tableLayoutPanelNomRecette.Dock = DockStyle.Fill;
            tableLayoutPanelNomRecette.Location = new Point(136, 3);
            tableLayoutPanelNomRecette.Name = "tableLayoutPanelNomRecette";
            tableLayoutPanelNomRecette.RowCount = 1;
            tableLayoutPanelNomRecette.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelNomRecette.Size = new Size(502, 29);
            tableLayoutPanelNomRecette.TabIndex = 21;
            // 
            // textBoxNomRecette
            // 
            textBoxNomRecette.Dock = DockStyle.Fill;
            textBoxNomRecette.Location = new Point(3, 3);
            textBoxNomRecette.Name = "textBoxNomRecette";
            textBoxNomRecette.Size = new Size(496, 23);
            textBoxNomRecette.TabIndex = 9;
            // 
            // tableLayoutPanelImageRecette
            // 
            tableLayoutPanelImageRecette.AutoSize = true;
            tableLayoutPanelImageRecette.ColumnCount = 2;
            tableLayoutPanelImageRecette.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanelImageRecette.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F));
            tableLayoutPanelImageRecette.Controls.Add(textBoxImageRecette, 1, 0);
            tableLayoutPanelImageRecette.Controls.Add(buttonSelectionnerImageRecette, 0, 0);
            tableLayoutPanelImageRecette.Dock = DockStyle.Fill;
            tableLayoutPanelImageRecette.Location = new Point(136, 178);
            tableLayoutPanelImageRecette.Name = "tableLayoutPanelImageRecette";
            tableLayoutPanelImageRecette.RowCount = 1;
            tableLayoutPanelImageRecette.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelImageRecette.Size = new Size(502, 29);
            tableLayoutPanelImageRecette.TabIndex = 22;
            // 
            // textBoxImageRecette
            // 
            textBoxImageRecette.Dock = DockStyle.Fill;
            textBoxImageRecette.Enabled = false;
            textBoxImageRecette.Location = new Point(128, 3);
            textBoxImageRecette.Name = "textBoxImageRecette";
            textBoxImageRecette.Size = new Size(371, 23);
            textBoxImageRecette.TabIndex = 0;
            // 
            // buttonSelectionnerImageRecette
            // 
            buttonSelectionnerImageRecette.Dock = DockStyle.Fill;
            buttonSelectionnerImageRecette.Location = new Point(3, 3);
            buttonSelectionnerImageRecette.Name = "buttonSelectionnerImageRecette";
            buttonSelectionnerImageRecette.Size = new Size(119, 23);
            buttonSelectionnerImageRecette.TabIndex = 1;
            buttonSelectionnerImageRecette.Text = "Ajouter une image";
            buttonSelectionnerImageRecette.UseVisualStyleBackColor = true;
            // 
            // labelTemps_PréparationRecette
            // 
            labelTemps_PréparationRecette.AutoSize = true;
            labelTemps_PréparationRecette.Dock = DockStyle.Fill;
            labelTemps_PréparationRecette.Location = new Point(3, 70);
            labelTemps_PréparationRecette.Name = "labelTemps_PréparationRecette";
            labelTemps_PréparationRecette.Size = new Size(127, 35);
            labelTemps_PréparationRecette.TabIndex = 2;
            labelTemps_PréparationRecette.Text = "Temps de préparation :";
            // 
            // tableLayoutPanelTemps_PréparationRecette
            // 
            tableLayoutPanelTemps_PréparationRecette.AutoSize = true;
            tableLayoutPanelTemps_PréparationRecette.ColumnCount = 2;
            tableLayoutPanelTemps_PréparationRecette.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelTemps_PréparationRecette.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelTemps_PréparationRecette.Controls.Add(numericUpDownTemps_PréparationHeures, 0, 0);
            tableLayoutPanelTemps_PréparationRecette.Controls.Add(numericUpDownTemps_PréparationMinutes, 1, 0);
            tableLayoutPanelTemps_PréparationRecette.Dock = DockStyle.Fill;
            tableLayoutPanelTemps_PréparationRecette.Location = new Point(136, 73);
            tableLayoutPanelTemps_PréparationRecette.Name = "tableLayoutPanelTemps_PréparationRecette";
            tableLayoutPanelTemps_PréparationRecette.RowCount = 1;
            tableLayoutPanelTemps_PréparationRecette.RowStyles.Add(new RowStyle());
            tableLayoutPanelTemps_PréparationRecette.Size = new Size(502, 29);
            tableLayoutPanelTemps_PréparationRecette.TabIndex = 13;
            // 
            // numericUpDownTemps_PréparationHeures
            // 
            numericUpDownTemps_PréparationHeures.Dock = DockStyle.Fill;
            numericUpDownTemps_PréparationHeures.Location = new Point(3, 3);
            numericUpDownTemps_PréparationHeures.Name = "numericUpDownTemps_PréparationHeures";
            numericUpDownTemps_PréparationHeures.Size = new Size(245, 23);
            numericUpDownTemps_PréparationHeures.TabIndex = 0;
            // 
            // numericUpDownTemps_PréparationMinutes
            // 
            numericUpDownTemps_PréparationMinutes.Dock = DockStyle.Fill;
            numericUpDownTemps_PréparationMinutes.Location = new Point(254, 3);
            numericUpDownTemps_PréparationMinutes.Name = "numericUpDownTemps_PréparationMinutes";
            numericUpDownTemps_PréparationMinutes.Size = new Size(245, 23);
            numericUpDownTemps_PréparationMinutes.TabIndex = 1;
            // 
            // labelTemps_CuissonRecette
            // 
            labelTemps_CuissonRecette.AutoSize = true;
            labelTemps_CuissonRecette.Dock = DockStyle.Fill;
            labelTemps_CuissonRecette.Location = new Point(3, 105);
            labelTemps_CuissonRecette.Name = "labelTemps_CuissonRecette";
            labelTemps_CuissonRecette.Size = new Size(127, 35);
            labelTemps_CuissonRecette.TabIndex = 3;
            labelTemps_CuissonRecette.Text = "Temps de cuisson :";
            // 
            // tableLayoutPanelTemps_CuissonRecette
            // 
            tableLayoutPanelTemps_CuissonRecette.AutoSize = true;
            tableLayoutPanelTemps_CuissonRecette.ColumnCount = 2;
            tableLayoutPanelTemps_CuissonRecette.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelTemps_CuissonRecette.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelTemps_CuissonRecette.Controls.Add(numericUpDownTemps_CuissonHeures, 0, 0);
            tableLayoutPanelTemps_CuissonRecette.Controls.Add(numericUpDownTemps_CuissonMinutes, 1, 0);
            tableLayoutPanelTemps_CuissonRecette.Dock = DockStyle.Fill;
            tableLayoutPanelTemps_CuissonRecette.Location = new Point(136, 108);
            tableLayoutPanelTemps_CuissonRecette.Name = "tableLayoutPanelTemps_CuissonRecette";
            tableLayoutPanelTemps_CuissonRecette.RowCount = 1;
            tableLayoutPanelTemps_CuissonRecette.RowStyles.Add(new RowStyle());
            tableLayoutPanelTemps_CuissonRecette.Size = new Size(502, 29);
            tableLayoutPanelTemps_CuissonRecette.TabIndex = 14;
            // 
            // numericUpDownTemps_CuissonHeures
            // 
            numericUpDownTemps_CuissonHeures.Dock = DockStyle.Fill;
            numericUpDownTemps_CuissonHeures.Location = new Point(3, 3);
            numericUpDownTemps_CuissonHeures.Name = "numericUpDownTemps_CuissonHeures";
            numericUpDownTemps_CuissonHeures.Size = new Size(245, 23);
            numericUpDownTemps_CuissonHeures.TabIndex = 0;
            // 
            // numericUpDownTemps_CuissonMinutes
            // 
            numericUpDownTemps_CuissonMinutes.Dock = DockStyle.Fill;
            numericUpDownTemps_CuissonMinutes.Location = new Point(254, 3);
            numericUpDownTemps_CuissonMinutes.Name = "numericUpDownTemps_CuissonMinutes";
            numericUpDownTemps_CuissonMinutes.Size = new Size(245, 23);
            numericUpDownTemps_CuissonMinutes.TabIndex = 1;
            // 
            // labelDifficulteRecette
            // 
            labelDifficulteRecette.AutoSize = true;
            labelDifficulteRecette.Dock = DockStyle.Fill;
            labelDifficulteRecette.Location = new Point(3, 140);
            labelDifficulteRecette.Name = "labelDifficulteRecette";
            labelDifficulteRecette.Size = new Size(127, 35);
            labelDifficulteRecette.TabIndex = 4;
            labelDifficulteRecette.Text = "Difficulté :";
            // 
            // labelIMGRecette
            // 
            labelIMGRecette.AutoSize = true;
            labelIMGRecette.Dock = DockStyle.Fill;
            labelIMGRecette.Location = new Point(3, 175);
            labelIMGRecette.Name = "labelIMGRecette";
            labelIMGRecette.Size = new Size(127, 35);
            labelIMGRecette.TabIndex = 5;
            labelIMGRecette.Text = "Image :";
            // 
            // labelListEtapesRecette
            // 
            labelListEtapesRecette.AutoSize = true;
            labelListEtapesRecette.Dock = DockStyle.Fill;
            labelListEtapesRecette.Location = new Point(3, 210);
            labelListEtapesRecette.Name = "labelListEtapesRecette";
            labelListEtapesRecette.Size = new Size(127, 106);
            labelListEtapesRecette.TabIndex = 6;
            labelListEtapesRecette.Text = "Étapes :";
            // 
            // tableLayoutPanelEtapesRecette
            // 
            tableLayoutPanelEtapesRecette.ColumnCount = 2;
            tableLayoutPanelEtapesRecette.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelEtapesRecette.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelEtapesRecette.Controls.Add(buttonOpenFormSelectionEtapes, 0, 0);
            tableLayoutPanelEtapesRecette.Controls.Add(listViewListEtapesRecette, 1, 0);
            tableLayoutPanelEtapesRecette.Dock = DockStyle.Fill;
            tableLayoutPanelEtapesRecette.Location = new Point(136, 213);
            tableLayoutPanelEtapesRecette.Name = "tableLayoutPanelEtapesRecette";
            tableLayoutPanelEtapesRecette.RowCount = 1;
            tableLayoutPanelEtapesRecette.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelEtapesRecette.Size = new Size(502, 100);
            tableLayoutPanelEtapesRecette.TabIndex = 15;
            // 
            // buttonOpenFormSelectionEtapes
            // 
            buttonOpenFormSelectionEtapes.Dock = DockStyle.Fill;
            buttonOpenFormSelectionEtapes.Location = new Point(3, 3);
            buttonOpenFormSelectionEtapes.Name = "buttonOpenFormSelectionEtapes";
            buttonOpenFormSelectionEtapes.Size = new Size(245, 94);
            buttonOpenFormSelectionEtapes.TabIndex = 0;
            buttonOpenFormSelectionEtapes.Text = "Gérer la liste des étapes";
            buttonOpenFormSelectionEtapes.UseVisualStyleBackColor = true;
            // 
            // listViewListEtapesRecette
            // 
            listViewListEtapesRecette.Dock = DockStyle.Fill;
            listViewListEtapesRecette.Location = new Point(254, 3);
            listViewListEtapesRecette.Name = "listViewListEtapesRecette";
            listViewListEtapesRecette.Size = new Size(245, 94);
            listViewListEtapesRecette.TabIndex = 1;
            listViewListEtapesRecette.UseCompatibleStateImageBehavior = false;
            // 
            // labelListCategoriesRecette
            // 
            labelListCategoriesRecette.AutoSize = true;
            labelListCategoriesRecette.Dock = DockStyle.Fill;
            labelListCategoriesRecette.Location = new Point(3, 316);
            labelListCategoriesRecette.Name = "labelListCategoriesRecette";
            labelListCategoriesRecette.Size = new Size(127, 106);
            labelListCategoriesRecette.TabIndex = 7;
            labelListCategoriesRecette.Text = "Catégories :";
            // 
            // tableLayoutPanelCategoriesRecette
            // 
            tableLayoutPanelCategoriesRecette.ColumnCount = 2;
            tableLayoutPanelCategoriesRecette.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelCategoriesRecette.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelCategoriesRecette.Controls.Add(buttonOpenFormSelectionCategories, 0, 0);
            tableLayoutPanelCategoriesRecette.Controls.Add(listViewListCategoriesRecette, 1, 0);
            tableLayoutPanelCategoriesRecette.Dock = DockStyle.Fill;
            tableLayoutPanelCategoriesRecette.Location = new Point(136, 319);
            tableLayoutPanelCategoriesRecette.Name = "tableLayoutPanelCategoriesRecette";
            tableLayoutPanelCategoriesRecette.RowCount = 1;
            tableLayoutPanelCategoriesRecette.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelCategoriesRecette.Size = new Size(502, 100);
            tableLayoutPanelCategoriesRecette.TabIndex = 17;
            // 
            // buttonOpenFormSelectionCategories
            // 
            buttonOpenFormSelectionCategories.Dock = DockStyle.Fill;
            buttonOpenFormSelectionCategories.Location = new Point(3, 3);
            buttonOpenFormSelectionCategories.Name = "buttonOpenFormSelectionCategories";
            buttonOpenFormSelectionCategories.Size = new Size(245, 94);
            buttonOpenFormSelectionCategories.TabIndex = 0;
            buttonOpenFormSelectionCategories.Text = "Gérer la liste des catégories";
            buttonOpenFormSelectionCategories.UseVisualStyleBackColor = true;
            // 
            // listViewListCategoriesRecette
            // 
            listViewListCategoriesRecette.Dock = DockStyle.Fill;
            listViewListCategoriesRecette.Location = new Point(254, 3);
            listViewListCategoriesRecette.Name = "listViewListCategoriesRecette";
            listViewListCategoriesRecette.Size = new Size(245, 94);
            listViewListCategoriesRecette.TabIndex = 1;
            listViewListCategoriesRecette.UseCompatibleStateImageBehavior = false;
            // 
            // labelListIngredientsRecette
            // 
            labelListIngredientsRecette.AutoSize = true;
            labelListIngredientsRecette.Dock = DockStyle.Fill;
            labelListIngredientsRecette.Location = new Point(3, 422);
            labelListIngredientsRecette.Name = "labelListIngredientsRecette";
            labelListIngredientsRecette.Size = new Size(127, 257);
            labelListIngredientsRecette.TabIndex = 8;
            labelListIngredientsRecette.Text = "Ingrédients :";
            // 
            // tableLayoutPanelIngredientsRecette
            // 
            tableLayoutPanelIngredientsRecette.ColumnCount = 2;
            tableLayoutPanelIngredientsRecette.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelIngredientsRecette.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelIngredientsRecette.Controls.Add(buttonOpenFormSelectionIngredients, 0, 0);
            tableLayoutPanelIngredientsRecette.Controls.Add(listViewListIngredientsRecette, 1, 0);
            tableLayoutPanelIngredientsRecette.Dock = DockStyle.Fill;
            tableLayoutPanelIngredientsRecette.Location = new Point(136, 425);
            tableLayoutPanelIngredientsRecette.Name = "tableLayoutPanelIngredientsRecette";
            tableLayoutPanelIngredientsRecette.RowCount = 1;
            tableLayoutPanelIngredientsRecette.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelIngredientsRecette.Size = new Size(502, 251);
            tableLayoutPanelIngredientsRecette.TabIndex = 16;
            // 
            // buttonOpenFormSelectionIngredients
            // 
            buttonOpenFormSelectionIngredients.Dock = DockStyle.Fill;
            buttonOpenFormSelectionIngredients.Location = new Point(3, 3);
            buttonOpenFormSelectionIngredients.Name = "buttonOpenFormSelectionIngredients";
            buttonOpenFormSelectionIngredients.Size = new Size(245, 245);
            buttonOpenFormSelectionIngredients.TabIndex = 0;
            buttonOpenFormSelectionIngredients.Text = "Gérér la liste des ingrédients";
            buttonOpenFormSelectionIngredients.UseVisualStyleBackColor = true;
            // 
            // listViewListIngredientsRecette
            // 
            listViewListIngredientsRecette.Dock = DockStyle.Fill;
            listViewListIngredientsRecette.Location = new Point(254, 3);
            listViewListIngredientsRecette.Name = "listViewListIngredientsRecette";
            listViewListIngredientsRecette.Size = new Size(245, 245);
            listViewListIngredientsRecette.TabIndex = 1;
            listViewListIngredientsRecette.UseCompatibleStateImageBehavior = false;
            // 
            // tableLayoutPanelDifficulteRecette
            // 
            tableLayoutPanelDifficulteRecette.AutoSize = true;
            tableLayoutPanelDifficulteRecette.ColumnCount = 1;
            tableLayoutPanelDifficulteRecette.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelDifficulteRecette.Controls.Add(numericUpDownDifficulteRecette, 0, 0);
            tableLayoutPanelDifficulteRecette.Dock = DockStyle.Fill;
            tableLayoutPanelDifficulteRecette.Location = new Point(136, 143);
            tableLayoutPanelDifficulteRecette.Name = "tableLayoutPanelDifficulteRecette";
            tableLayoutPanelDifficulteRecette.RowCount = 1;
            tableLayoutPanelDifficulteRecette.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelDifficulteRecette.Size = new Size(502, 29);
            tableLayoutPanelDifficulteRecette.TabIndex = 19;
            // 
            // numericUpDownDifficulteRecette
            // 
            numericUpDownDifficulteRecette.Dock = DockStyle.Fill;
            numericUpDownDifficulteRecette.Location = new Point(3, 3);
            numericUpDownDifficulteRecette.Name = "numericUpDownDifficulteRecette";
            numericUpDownDifficulteRecette.Size = new Size(496, 23);
            numericUpDownDifficulteRecette.TabIndex = 18;
            // 
            // tableLayoutPanelDescriptionRecette
            // 
            tableLayoutPanelDescriptionRecette.AutoSize = true;
            tableLayoutPanelDescriptionRecette.ColumnCount = 1;
            tableLayoutPanelDescriptionRecette.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelDescriptionRecette.Controls.Add(textBoxDescriptionRecette, 0, 0);
            tableLayoutPanelDescriptionRecette.Dock = DockStyle.Fill;
            tableLayoutPanelDescriptionRecette.Location = new Point(136, 38);
            tableLayoutPanelDescriptionRecette.Name = "tableLayoutPanelDescriptionRecette";
            tableLayoutPanelDescriptionRecette.RowCount = 1;
            tableLayoutPanelDescriptionRecette.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelDescriptionRecette.Size = new Size(502, 29);
            tableLayoutPanelDescriptionRecette.TabIndex = 20;
            // 
            // textBoxDescriptionRecette
            // 
            textBoxDescriptionRecette.Dock = DockStyle.Fill;
            textBoxDescriptionRecette.Location = new Point(3, 3);
            textBoxDescriptionRecette.Name = "textBoxDescriptionRecette";
            textBoxDescriptionRecette.Size = new Size(496, 23);
            textBoxDescriptionRecette.TabIndex = 10;
            // 
            // flowLayoutPanelGestionRecettesButtons
            // 
            flowLayoutPanelGestionRecettesButtons.AutoSize = true;
            flowLayoutPanelGestionRecettesButtons.Controls.Add(buttonRefreshRecettes);
            flowLayoutPanelGestionRecettesButtons.Controls.Add(buttonAddRecettes);
            flowLayoutPanelGestionRecettesButtons.Controls.Add(buttonModifyRecettes);
            flowLayoutPanelGestionRecettesButtons.Controls.Add(buttonRemoveRecettes);
            flowLayoutPanelGestionRecettesButtons.Dock = DockStyle.Fill;
            flowLayoutPanelGestionRecettesButtons.Location = new Point(3, 456);
            flowLayoutPanelGestionRecettesButtons.Name = "flowLayoutPanelGestionRecettesButtons";
            flowLayoutPanelGestionRecettesButtons.Size = new Size(658, 62);
            flowLayoutPanelGestionRecettesButtons.TabIndex = 1;
            // 
            // buttonRefreshRecettes
            // 
            buttonRefreshRecettes.Image = (Image)resources.GetObject("buttonRefreshRecettes.Image");
            buttonRefreshRecettes.Location = new Point(3, 3);
            buttonRefreshRecettes.Name = "buttonRefreshRecettes";
            buttonRefreshRecettes.Size = new Size(105, 55);
            buttonRefreshRecettes.TabIndex = 0;
            buttonRefreshRecettes.Text = "Actualiser";
            buttonRefreshRecettes.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonRefreshRecettes.UseVisualStyleBackColor = true;
            // 
            // buttonAddRecettes
            // 
            buttonAddRecettes.Image = (Image)resources.GetObject("buttonAddRecettes.Image");
            buttonAddRecettes.Location = new Point(114, 3);
            buttonAddRecettes.Name = "buttonAddRecettes";
            buttonAddRecettes.Size = new Size(105, 55);
            buttonAddRecettes.TabIndex = 1;
            buttonAddRecettes.Text = "Ajouter";
            buttonAddRecettes.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonAddRecettes.UseVisualStyleBackColor = true;
            // 
            // buttonModifyRecettes
            // 
            buttonModifyRecettes.Image = (Image)resources.GetObject("buttonModifyRecettes.Image");
            buttonModifyRecettes.Location = new Point(225, 3);
            buttonModifyRecettes.Name = "buttonModifyRecettes";
            buttonModifyRecettes.Size = new Size(105, 55);
            buttonModifyRecettes.TabIndex = 2;
            buttonModifyRecettes.Text = "Modifier";
            buttonModifyRecettes.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonModifyRecettes.UseVisualStyleBackColor = true;
            // 
            // buttonRemoveRecettes
            // 
            buttonRemoveRecettes.Image = (Image)resources.GetObject("buttonRemoveRecettes.Image");
            buttonRemoveRecettes.Location = new Point(336, 3);
            buttonRemoveRecettes.Name = "buttonRemoveRecettes";
            buttonRemoveRecettes.Size = new Size(105, 55);
            buttonRemoveRecettes.TabIndex = 3;
            buttonRemoveRecettes.Text = "Supprimer";
            buttonRemoveRecettes.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonRemoveRecettes.UseVisualStyleBackColor = true;
            // 
            // tabPageEtapes
            // 
            tabPageEtapes.Location = new Point(4, 24);
            tabPageEtapes.Name = "tabPageEtapes";
            tabPageEtapes.Padding = new Padding(3);
            tabPageEtapes.Size = new Size(670, 527);
            tabPageEtapes.TabIndex = 1;
            tabPageEtapes.Text = "tabPage2";
            tabPageEtapes.UseVisualStyleBackColor = true;
            // 
            // FormAppMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(684, 561);
            Controls.Add(tableLayoutPanelApp);
            MaximumSize = new Size(1280, 1038);
            MinimumSize = new Size(700, 600);
            Name = "FormAppMain";
            Text = "Form1";
            tableLayoutPanelApp.ResumeLayout(false);
            tabControlApp.ResumeLayout(false);
            tabPageRecettes.ResumeLayout(false);
            tabPageRecettes.PerformLayout();
            tableLayoutPanelGestionRecettes.ResumeLayout(false);
            tableLayoutPanelGestionRecettes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRecettes).EndInit();
            panelRecettesInputs.ResumeLayout(false);
            tableLayoutPanelGestionRecettesInputs.ResumeLayout(false);
            tableLayoutPanelGestionRecettesInputs.PerformLayout();
            tableLayoutPanelNomRecette.ResumeLayout(false);
            tableLayoutPanelNomRecette.PerformLayout();
            tableLayoutPanelImageRecette.ResumeLayout(false);
            tableLayoutPanelImageRecette.PerformLayout();
            tableLayoutPanelTemps_PréparationRecette.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDownTemps_PréparationHeures).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownTemps_PréparationMinutes).EndInit();
            tableLayoutPanelTemps_CuissonRecette.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDownTemps_CuissonHeures).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownTemps_CuissonMinutes).EndInit();
            tableLayoutPanelEtapesRecette.ResumeLayout(false);
            tableLayoutPanelCategoriesRecette.ResumeLayout(false);
            tableLayoutPanelIngredientsRecette.ResumeLayout(false);
            tableLayoutPanelDifficulteRecette.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDownDifficulteRecette).EndInit();
            tableLayoutPanelDescriptionRecette.ResumeLayout(false);
            tableLayoutPanelDescriptionRecette.PerformLayout();
            flowLayoutPanelGestionRecettesButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)bindingSourceRecettes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanelApp;
        private TabControl tabControlApp;
        private TabPage tabPageRecettes;
        private TabPage tabPageEtapes;
        private TableLayoutPanel tableLayoutPanelGestionRecettes;
        private TableLayoutPanel tableLayoutPanelGestionRecettesInputs;
        private FlowLayoutPanel flowLayoutPanelGestionRecettesButtons;
        private Button buttonRefreshRecettes;
        private Button buttonAddRecettes;
        private Button buttonModifyRecettes;
        private Button buttonRemoveRecettes;
        private Label labelNomRecette;
        private Label labelDescriptionRecette;
        private Label labelTemps_PréparationRecette;
        private Label labelTemps_CuissonRecette;
        private Label labelDifficulteRecette;
        private Label labelIMGRecette;
        private Label labelListEtapesRecette;
        private Label labelListCategoriesRecette;
        private Label labelListIngredientsRecette;
        private DataGridView dataGridViewRecettes;
        private BindingSource bindingSourceRecettes;
        private TextBox textBoxNomRecette;
        private TextBox textBoxDescriptionRecette;
        private TableLayoutPanel tableLayoutPanelTemps_PréparationRecette;
        private NumericUpDown numericUpDownTemps_PréparationHeures;
        private NumericUpDown numericUpDownTemps_PréparationMinutes;
        private NumericUpDown numericUpDownTemps_PréparationSecondes;
        private TableLayoutPanel tableLayoutPanelTemps_CuissonRecette;
        private NumericUpDown numericUpDownTemps_CuissonHeures;
        private NumericUpDown numericUpDownTemps_CuissonMinutes;
        private TableLayoutPanel tableLayoutPanelEtapesRecette;
        private TableLayoutPanel tableLayoutPanelIngredientsRecette;
        private TableLayoutPanel tableLayoutPanelCategoriesRecette;
        private Button buttonOpenFormSelectionEtapes;
        private Button buttonOpenFormSelectionCategories;
        private Button buttonOpenFormSelectionIngredients;
        private ListView listViewListEtapesRecette;
        private ListView listViewListCategoriesRecette;
        private ListView listViewListIngredientsRecette;
        private NumericUpDown numericUpDownDifficulteRecette;
        private Panel panelRecettesInputs;
        private TableLayoutPanel tableLayoutPanelDifficulteRecette;
        private TableLayoutPanel tableLayoutPanelDescriptionRecette;
        private TableLayoutPanel tableLayoutPanelNomRecette;
        private TableLayoutPanel tableLayoutPanelImageRecette;
        private TextBox textBoxImageRecette;
        private Button buttonSelectionnerImageRecette;
        private NumericUpDown numericUpDown6;
    }
}
