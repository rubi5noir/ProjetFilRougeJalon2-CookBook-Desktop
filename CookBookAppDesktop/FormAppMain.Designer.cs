using System.Windows.Forms;

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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAppMain));
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
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
            tableLayoutPanelDifficulteRecette = new TableLayoutPanel();
            numericUpDownDifficulteRecette = new NumericUpDown();
            tableLayoutPanelDescriptionRecette = new TableLayoutPanel();
            textBoxDescriptionRecette = new TextBox();
            flowLayoutPanelGestionRecettesButtons = new FlowLayoutPanel();
            buttonRefreshRecettes = new Button();
            buttonAddRecettes = new Button();
            buttonModifyRecettes = new Button();
            buttonRemoveRecettes = new Button();
            buttonOpenRecetteDetailsForm = new Button();
            labelRecettes = new Label();
            tabPageEtapes = new TabPage();
            tableLayoutPanelEtapesRecette = new TableLayoutPanel();
            tableLayoutPanelEtapesButtons = new TableLayoutPanel();
            buttonOpenFormSelectionEtapes = new Button();
            buttonRefreshEtapes = new Button();
            tableLayoutPanelDataGridViewsEtapes = new TableLayoutPanel();
            dataGridViewEtapes = new DataGridView();
            dataGridViewEtapesRecette = new DataGridView();
            labelEtapes = new Label();
            labelEtapesRecette = new Label();
            tabPageCategories = new TabPage();
            tableLayoutPanelCategoriesRecette = new TableLayoutPanel();
            tableLayoutPanelCategories = new TableLayoutPanel();
            buttonOpenFormSelectionCategories = new Button();
            buttonRefreshCategories = new Button();
            dataGridViewCategories = new DataGridView();
            labelCategories = new Label();
            tabPageIngredients = new TabPage();
            tableLayoutPanelIngredientsRecette = new TableLayoutPanel();
            tableLayoutPanelIngredientsButtons = new TableLayoutPanel();
            buttonOpenFormSelectionIngredients = new Button();
            buttonRefreshIngredients = new Button();
            dataGridViewIngredients = new DataGridView();
            labelIngredients = new Label();
            tabPageAvis = new TabPage();
            tabPageCompte = new TabPage();
            bindingSourceRecettes = new BindingSource(components);
            bindingSourceEtapes = new BindingSource(components);
            bindingSourceCategories = new BindingSource(components);
            bindingSourceIngredients = new BindingSource(components);
            bindingSourceAvis = new BindingSource(components);
            bindingSourceRecettesInEtapes = new BindingSource(components);
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
            tableLayoutPanelDifficulteRecette.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDifficulteRecette).BeginInit();
            tableLayoutPanelDescriptionRecette.SuspendLayout();
            flowLayoutPanelGestionRecettesButtons.SuspendLayout();
            tabPageEtapes.SuspendLayout();
            tableLayoutPanelEtapesRecette.SuspendLayout();
            tableLayoutPanelEtapesButtons.SuspendLayout();
            tableLayoutPanelDataGridViewsEtapes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEtapes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEtapesRecette).BeginInit();
            tabPageCategories.SuspendLayout();
            tableLayoutPanelCategoriesRecette.SuspendLayout();
            tableLayoutPanelCategories.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCategories).BeginInit();
            tabPageIngredients.SuspendLayout();
            tableLayoutPanelIngredientsRecette.SuspendLayout();
            tableLayoutPanelIngredientsButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewIngredients).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceRecettes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceEtapes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceCategories).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceIngredients).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceAvis).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceRecettesInEtapes).BeginInit();
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
            tableLayoutPanelApp.Enabled = false;
            tableLayoutPanelApp.Location = new Point(0, 0);
            tableLayoutPanelApp.Name = "tableLayoutPanelApp";
            tableLayoutPanelApp.RowCount = 1;
            tableLayoutPanelApp.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelApp.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanelApp.Size = new Size(692, 563);
            tableLayoutPanelApp.TabIndex = 0;
            // 
            // tabControlApp
            // 
            tabControlApp.Controls.Add(tabPageRecettes);
            tabControlApp.Controls.Add(tabPageEtapes);
            tabControlApp.Controls.Add(tabPageCategories);
            tabControlApp.Controls.Add(tabPageIngredients);
            tabControlApp.Controls.Add(tabPageAvis);
            tabControlApp.Controls.Add(tabPageCompte);
            tabControlApp.Dock = DockStyle.Fill;
            tabControlApp.Location = new Point(3, 3);
            tabControlApp.Name = "tabControlApp";
            tabControlApp.SelectedIndex = 0;
            tabControlApp.Size = new Size(686, 557);
            tabControlApp.TabIndex = 0;
            tabControlApp.Selecting += tabControl_Selecting;
            // 
            // tabPageRecettes
            // 
            tabPageRecettes.Controls.Add(tableLayoutPanelGestionRecettes);
            tabPageRecettes.Location = new Point(4, 24);
            tabPageRecettes.Name = "tabPageRecettes";
            tabPageRecettes.Padding = new Padding(3);
            tabPageRecettes.Size = new Size(678, 529);
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
            tableLayoutPanelGestionRecettes.Controls.Add(dataGridViewRecettes, 0, 1);
            tableLayoutPanelGestionRecettes.Controls.Add(panelRecettesInputs, 0, 2);
            tableLayoutPanelGestionRecettes.Controls.Add(flowLayoutPanelGestionRecettesButtons, 0, 3);
            tableLayoutPanelGestionRecettes.Controls.Add(labelRecettes, 0, 0);
            tableLayoutPanelGestionRecettes.Dock = DockStyle.Fill;
            tableLayoutPanelGestionRecettes.Location = new Point(3, 3);
            tableLayoutPanelGestionRecettes.Name = "tableLayoutPanelGestionRecettes";
            tableLayoutPanelGestionRecettes.RowCount = 4;
            tableLayoutPanelGestionRecettes.RowStyles.Add(new RowStyle());
            tableLayoutPanelGestionRecettes.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelGestionRecettes.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelGestionRecettes.RowStyles.Add(new RowStyle());
            tableLayoutPanelGestionRecettes.Size = new Size(672, 523);
            tableLayoutPanelGestionRecettes.TabIndex = 0;
            // 
            // dataGridViewRecettes
            // 
            dataGridViewRecettes.AllowUserToAddRows = false;
            dataGridViewRecettes.AllowUserToDeleteRows = false;
            dataGridViewRecettes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Maroon;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.DarkRed;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewRecettes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.LightCoral;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.Red;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewRecettes.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewRecettes.Dock = DockStyle.Fill;
            dataGridViewRecettes.EnableHeadersVisualStyles = false;
            dataGridViewRecettes.Location = new Point(3, 18);
            dataGridViewRecettes.Name = "dataGridViewRecettes";
            dataGridViewRecettes.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.OrangeRed;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewRecettes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewRecettes.RowHeadersVisible = false;
            dataGridViewRecettes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewRecettes.Size = new Size(666, 214);
            dataGridViewRecettes.TabIndex = 2;
            // 
            // panelRecettesInputs
            // 
            panelRecettesInputs.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelRecettesInputs.Controls.Add(tableLayoutPanelGestionRecettesInputs);
            panelRecettesInputs.Dock = DockStyle.Fill;
            panelRecettesInputs.Location = new Point(3, 238);
            panelRecettesInputs.Name = "panelRecettesInputs";
            panelRecettesInputs.Size = new Size(666, 214);
            panelRecettesInputs.TabIndex = 3;
            // 
            // tableLayoutPanelGestionRecettesInputs
            // 
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
            tableLayoutPanelGestionRecettesInputs.Controls.Add(tableLayoutPanelDifficulteRecette, 1, 4);
            tableLayoutPanelGestionRecettesInputs.Controls.Add(tableLayoutPanelDescriptionRecette, 1, 1);
            tableLayoutPanelGestionRecettesInputs.Dock = DockStyle.Fill;
            tableLayoutPanelGestionRecettesInputs.Location = new Point(0, 0);
            tableLayoutPanelGestionRecettesInputs.Name = "tableLayoutPanelGestionRecettesInputs";
            tableLayoutPanelGestionRecettesInputs.RowCount = 6;
            tableLayoutPanelGestionRecettesInputs.RowStyles.Add(new RowStyle());
            tableLayoutPanelGestionRecettesInputs.RowStyles.Add(new RowStyle());
            tableLayoutPanelGestionRecettesInputs.RowStyles.Add(new RowStyle());
            tableLayoutPanelGestionRecettesInputs.RowStyles.Add(new RowStyle());
            tableLayoutPanelGestionRecettesInputs.RowStyles.Add(new RowStyle());
            tableLayoutPanelGestionRecettesInputs.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelGestionRecettesInputs.Size = new Size(666, 214);
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
            tableLayoutPanelNomRecette.Size = new Size(527, 29);
            tableLayoutPanelNomRecette.TabIndex = 21;
            // 
            // textBoxNomRecette
            // 
            textBoxNomRecette.Dock = DockStyle.Fill;
            textBoxNomRecette.Location = new Point(3, 3);
            textBoxNomRecette.Name = "textBoxNomRecette";
            textBoxNomRecette.Size = new Size(521, 23);
            textBoxNomRecette.TabIndex = 9;
            // 
            // tableLayoutPanelImageRecette
            // 
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
            tableLayoutPanelImageRecette.Size = new Size(527, 33);
            tableLayoutPanelImageRecette.TabIndex = 22;
            // 
            // textBoxImageRecette
            // 
            textBoxImageRecette.Dock = DockStyle.Fill;
            textBoxImageRecette.Location = new Point(134, 3);
            textBoxImageRecette.Name = "textBoxImageRecette";
            textBoxImageRecette.ReadOnly = true;
            textBoxImageRecette.Size = new Size(390, 23);
            textBoxImageRecette.TabIndex = 0;
            // 
            // buttonSelectionnerImageRecette
            // 
            buttonSelectionnerImageRecette.Dock = DockStyle.Fill;
            buttonSelectionnerImageRecette.Location = new Point(3, 3);
            buttonSelectionnerImageRecette.Name = "buttonSelectionnerImageRecette";
            buttonSelectionnerImageRecette.Size = new Size(125, 27);
            buttonSelectionnerImageRecette.TabIndex = 1;
            buttonSelectionnerImageRecette.Text = "Ajouter une image";
            buttonSelectionnerImageRecette.UseVisualStyleBackColor = true;
            buttonSelectionnerImageRecette.Click += buttonSelectionnerImageRecette_Click;
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
            tableLayoutPanelTemps_PréparationRecette.Size = new Size(527, 29);
            tableLayoutPanelTemps_PréparationRecette.TabIndex = 13;
            // 
            // numericUpDownTemps_PréparationHeures
            // 
            numericUpDownTemps_PréparationHeures.Dock = DockStyle.Fill;
            numericUpDownTemps_PréparationHeures.Location = new Point(3, 3);
            numericUpDownTemps_PréparationHeures.Name = "numericUpDownTemps_PréparationHeures";
            numericUpDownTemps_PréparationHeures.Size = new Size(257, 23);
            numericUpDownTemps_PréparationHeures.TabIndex = 0;
            // 
            // numericUpDownTemps_PréparationMinutes
            // 
            numericUpDownTemps_PréparationMinutes.Dock = DockStyle.Fill;
            numericUpDownTemps_PréparationMinutes.Location = new Point(266, 3);
            numericUpDownTemps_PréparationMinutes.Name = "numericUpDownTemps_PréparationMinutes";
            numericUpDownTemps_PréparationMinutes.Size = new Size(258, 23);
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
            tableLayoutPanelTemps_CuissonRecette.Size = new Size(527, 29);
            tableLayoutPanelTemps_CuissonRecette.TabIndex = 14;
            // 
            // numericUpDownTemps_CuissonHeures
            // 
            numericUpDownTemps_CuissonHeures.Dock = DockStyle.Fill;
            numericUpDownTemps_CuissonHeures.Location = new Point(3, 3);
            numericUpDownTemps_CuissonHeures.Name = "numericUpDownTemps_CuissonHeures";
            numericUpDownTemps_CuissonHeures.Size = new Size(257, 23);
            numericUpDownTemps_CuissonHeures.TabIndex = 0;
            // 
            // numericUpDownTemps_CuissonMinutes
            // 
            numericUpDownTemps_CuissonMinutes.Dock = DockStyle.Fill;
            numericUpDownTemps_CuissonMinutes.Location = new Point(266, 3);
            numericUpDownTemps_CuissonMinutes.Name = "numericUpDownTemps_CuissonMinutes";
            numericUpDownTemps_CuissonMinutes.Size = new Size(258, 23);
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
            labelIMGRecette.Size = new Size(127, 39);
            labelIMGRecette.TabIndex = 5;
            labelIMGRecette.Text = "Image :";
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
            tableLayoutPanelDifficulteRecette.Size = new Size(527, 29);
            tableLayoutPanelDifficulteRecette.TabIndex = 19;
            // 
            // numericUpDownDifficulteRecette
            // 
            numericUpDownDifficulteRecette.Dock = DockStyle.Fill;
            numericUpDownDifficulteRecette.Location = new Point(3, 3);
            numericUpDownDifficulteRecette.Name = "numericUpDownDifficulteRecette";
            numericUpDownDifficulteRecette.Size = new Size(521, 23);
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
            tableLayoutPanelDescriptionRecette.Size = new Size(527, 29);
            tableLayoutPanelDescriptionRecette.TabIndex = 20;
            // 
            // textBoxDescriptionRecette
            // 
            textBoxDescriptionRecette.Dock = DockStyle.Fill;
            textBoxDescriptionRecette.Location = new Point(3, 3);
            textBoxDescriptionRecette.Name = "textBoxDescriptionRecette";
            textBoxDescriptionRecette.Size = new Size(521, 23);
            textBoxDescriptionRecette.TabIndex = 10;
            // 
            // flowLayoutPanelGestionRecettesButtons
            // 
            flowLayoutPanelGestionRecettesButtons.AutoSize = true;
            flowLayoutPanelGestionRecettesButtons.Controls.Add(buttonRefreshRecettes);
            flowLayoutPanelGestionRecettesButtons.Controls.Add(buttonAddRecettes);
            flowLayoutPanelGestionRecettesButtons.Controls.Add(buttonModifyRecettes);
            flowLayoutPanelGestionRecettesButtons.Controls.Add(buttonRemoveRecettes);
            flowLayoutPanelGestionRecettesButtons.Controls.Add(buttonOpenRecetteDetailsForm);
            flowLayoutPanelGestionRecettesButtons.Dock = DockStyle.Fill;
            flowLayoutPanelGestionRecettesButtons.Location = new Point(3, 458);
            flowLayoutPanelGestionRecettesButtons.Name = "flowLayoutPanelGestionRecettesButtons";
            flowLayoutPanelGestionRecettesButtons.Size = new Size(666, 62);
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
            buttonRefreshRecettes.Click += buttonRefreshRecettes_Click;
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
            buttonAddRecettes.Click += buttonAddRecette_Click;
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
            buttonModifyRecettes.Click += buttonUpdateRecette_Click;
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
            buttonRemoveRecettes.Click += buttonDeleteRecette_Click;
            // 
            // buttonOpenRecetteDetailsForm
            // 
            buttonOpenRecetteDetailsForm.Location = new Point(447, 3);
            buttonOpenRecetteDetailsForm.Name = "buttonOpenRecetteDetailsForm";
            buttonOpenRecetteDetailsForm.Size = new Size(216, 55);
            buttonOpenRecetteDetailsForm.TabIndex = 4;
            buttonOpenRecetteDetailsForm.Text = "Détails";
            buttonOpenRecetteDetailsForm.UseVisualStyleBackColor = true;
            buttonOpenRecetteDetailsForm.Click += buttonOpenRecetteDetailsForm_Click;
            // 
            // labelRecettes
            // 
            labelRecettes.AutoSize = true;
            labelRecettes.Dock = DockStyle.Fill;
            labelRecettes.Location = new Point(3, 0);
            labelRecettes.Name = "labelRecettes";
            labelRecettes.Size = new Size(666, 15);
            labelRecettes.TabIndex = 4;
            labelRecettes.Text = "Recettes";
            // 
            // tabPageEtapes
            // 
            tabPageEtapes.Controls.Add(tableLayoutPanelEtapesRecette);
            tabPageEtapes.Location = new Point(4, 24);
            tabPageEtapes.Name = "tabPageEtapes";
            tabPageEtapes.Padding = new Padding(3);
            tabPageEtapes.Size = new Size(678, 529);
            tabPageEtapes.TabIndex = 1;
            tabPageEtapes.Text = "Etapes";
            tabPageEtapes.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanelEtapesRecette
            // 
            tableLayoutPanelEtapesRecette.ColumnCount = 1;
            tableLayoutPanelEtapesRecette.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 66.6666641F));
            tableLayoutPanelEtapesRecette.Controls.Add(tableLayoutPanelEtapesButtons, 0, 1);
            tableLayoutPanelEtapesRecette.Controls.Add(tableLayoutPanelDataGridViewsEtapes, 0, 0);
            tableLayoutPanelEtapesRecette.Dock = DockStyle.Fill;
            tableLayoutPanelEtapesRecette.Location = new Point(3, 3);
            tableLayoutPanelEtapesRecette.Name = "tableLayoutPanelEtapesRecette";
            tableLayoutPanelEtapesRecette.RowCount = 2;
            tableLayoutPanelEtapesRecette.RowStyles.Add(new RowStyle(SizeType.Percent, 75F));
            tableLayoutPanelEtapesRecette.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanelEtapesRecette.Size = new Size(672, 523);
            tableLayoutPanelEtapesRecette.TabIndex = 15;
            // 
            // tableLayoutPanelEtapesButtons
            // 
            tableLayoutPanelEtapesButtons.ColumnCount = 2;
            tableLayoutPanelEtapesButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanelEtapesButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanelEtapesButtons.Controls.Add(buttonOpenFormSelectionEtapes, 1, 0);
            tableLayoutPanelEtapesButtons.Controls.Add(buttonRefreshEtapes, 0, 0);
            tableLayoutPanelEtapesButtons.Dock = DockStyle.Fill;
            tableLayoutPanelEtapesButtons.Location = new Point(3, 395);
            tableLayoutPanelEtapesButtons.Name = "tableLayoutPanelEtapesButtons";
            tableLayoutPanelEtapesButtons.RowCount = 1;
            tableLayoutPanelEtapesButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelEtapesButtons.Size = new Size(666, 125);
            tableLayoutPanelEtapesButtons.TabIndex = 2;
            // 
            // buttonOpenFormSelectionEtapes
            // 
            buttonOpenFormSelectionEtapes.Dock = DockStyle.Fill;
            buttonOpenFormSelectionEtapes.Location = new Point(202, 3);
            buttonOpenFormSelectionEtapes.Name = "buttonOpenFormSelectionEtapes";
            buttonOpenFormSelectionEtapes.Size = new Size(461, 119);
            buttonOpenFormSelectionEtapes.TabIndex = 0;
            buttonOpenFormSelectionEtapes.Text = "Gérer les étapes";
            buttonOpenFormSelectionEtapes.UseVisualStyleBackColor = true;
            buttonOpenFormSelectionEtapes.Click += buttonOpenFormSelectionEtapes_Click;
            // 
            // buttonRefreshEtapes
            // 
            buttonRefreshEtapes.Dock = DockStyle.Fill;
            buttonRefreshEtapes.Location = new Point(3, 3);
            buttonRefreshEtapes.Name = "buttonRefreshEtapes";
            buttonRefreshEtapes.Size = new Size(193, 119);
            buttonRefreshEtapes.TabIndex = 1;
            buttonRefreshEtapes.Text = "Actualiser";
            buttonRefreshEtapes.UseVisualStyleBackColor = true;
            buttonRefreshEtapes.Click += buttonRefreshRecettes_Click;
            // 
            // tableLayoutPanelDataGridViewsEtapes
            // 
            tableLayoutPanelDataGridViewsEtapes.ColumnCount = 2;
            tableLayoutPanelDataGridViewsEtapes.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 43.00912F));
            tableLayoutPanelDataGridViewsEtapes.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 56.9908829F));
            tableLayoutPanelDataGridViewsEtapes.Controls.Add(dataGridViewEtapes, 0, 1);
            tableLayoutPanelDataGridViewsEtapes.Controls.Add(dataGridViewEtapesRecette, 1, 1);
            tableLayoutPanelDataGridViewsEtapes.Controls.Add(labelEtapes, 0, 0);
            tableLayoutPanelDataGridViewsEtapes.Controls.Add(labelEtapesRecette, 1, 0);
            tableLayoutPanelDataGridViewsEtapes.Dock = DockStyle.Fill;
            tableLayoutPanelDataGridViewsEtapes.Location = new Point(3, 3);
            tableLayoutPanelDataGridViewsEtapes.Name = "tableLayoutPanelDataGridViewsEtapes";
            tableLayoutPanelDataGridViewsEtapes.RowCount = 2;
            tableLayoutPanelDataGridViewsEtapes.RowStyles.Add(new RowStyle());
            tableLayoutPanelDataGridViewsEtapes.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelDataGridViewsEtapes.Size = new Size(666, 386);
            tableLayoutPanelDataGridViewsEtapes.TabIndex = 4;
            // 
            // dataGridViewEtapes
            // 
            dataGridViewEtapes.AllowUserToAddRows = false;
            dataGridViewEtapes.AllowUserToDeleteRows = false;
            dataGridViewEtapes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.Maroon;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = Color.DarkRed;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridViewEtapes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewEtapes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.LightCoral;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = Color.Red;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dataGridViewEtapes.DefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewEtapes.Dock = DockStyle.Fill;
            dataGridViewEtapes.EnableHeadersVisualStyles = false;
            dataGridViewEtapes.Location = new Point(3, 18);
            dataGridViewEtapes.Name = "dataGridViewEtapes";
            dataGridViewEtapes.ReadOnly = true;
            dataGridViewEtapes.RowHeadersVisible = false;
            dataGridViewEtapes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewEtapes.Size = new Size(280, 365);
            dataGridViewEtapes.TabIndex = 1;
            // 
            // dataGridViewEtapesRecette
            // 
            dataGridViewEtapesRecette.AllowUserToAddRows = false;
            dataGridViewEtapesRecette.AllowUserToDeleteRows = false;
            dataGridViewEtapesRecette.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewEtapesRecette.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewEtapesRecette.DefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewEtapesRecette.Dock = DockStyle.Fill;
            dataGridViewEtapesRecette.EnableHeadersVisualStyles = false;
            dataGridViewEtapesRecette.Location = new Point(289, 18);
            dataGridViewEtapesRecette.Name = "dataGridViewEtapesRecette";
            dataGridViewEtapesRecette.ReadOnly = true;
            dataGridViewEtapesRecette.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewEtapesRecette.RowHeadersVisible = false;
            dataGridViewEtapesRecette.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewEtapesRecette.Size = new Size(374, 365);
            dataGridViewEtapesRecette.TabIndex = 3;
            dataGridViewEtapesRecette.CurrentCellChanged += dataGridViewEtapesRecettes_SelectionChanged;
            // 
            // labelEtapes
            // 
            labelEtapes.AutoSize = true;
            labelEtapes.Dock = DockStyle.Fill;
            labelEtapes.Location = new Point(3, 0);
            labelEtapes.Name = "labelEtapes";
            labelEtapes.Size = new Size(280, 15);
            labelEtapes.TabIndex = 4;
            labelEtapes.Text = "Etapes de la recette";
            // 
            // labelEtapesRecette
            // 
            labelEtapesRecette.AutoSize = true;
            labelEtapesRecette.Dock = DockStyle.Fill;
            labelEtapesRecette.Location = new Point(289, 0);
            labelEtapesRecette.Name = "labelEtapesRecette";
            labelEtapesRecette.Size = new Size(374, 15);
            labelEtapesRecette.TabIndex = 5;
            labelEtapesRecette.Text = "Recettes";
            // 
            // tabPageCategories
            // 
            tabPageCategories.Controls.Add(tableLayoutPanelCategoriesRecette);
            tabPageCategories.Location = new Point(4, 24);
            tabPageCategories.Name = "tabPageCategories";
            tabPageCategories.Padding = new Padding(3);
            tabPageCategories.Size = new Size(678, 529);
            tabPageCategories.TabIndex = 2;
            tabPageCategories.Text = "Categories";
            tabPageCategories.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanelCategoriesRecette
            // 
            tableLayoutPanelCategoriesRecette.ColumnCount = 1;
            tableLayoutPanelCategoriesRecette.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelCategoriesRecette.Controls.Add(tableLayoutPanelCategories, 0, 2);
            tableLayoutPanelCategoriesRecette.Controls.Add(dataGridViewCategories, 0, 1);
            tableLayoutPanelCategoriesRecette.Controls.Add(labelCategories, 0, 0);
            tableLayoutPanelCategoriesRecette.Dock = DockStyle.Fill;
            tableLayoutPanelCategoriesRecette.Location = new Point(3, 3);
            tableLayoutPanelCategoriesRecette.Name = "tableLayoutPanelCategoriesRecette";
            tableLayoutPanelCategoriesRecette.RowCount = 3;
            tableLayoutPanelCategoriesRecette.RowStyles.Add(new RowStyle());
            tableLayoutPanelCategoriesRecette.RowStyles.Add(new RowStyle(SizeType.Percent, 75F));
            tableLayoutPanelCategoriesRecette.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanelCategoriesRecette.Size = new Size(672, 523);
            tableLayoutPanelCategoriesRecette.TabIndex = 17;
            // 
            // tableLayoutPanelCategories
            // 
            tableLayoutPanelCategories.ColumnCount = 2;
            tableLayoutPanelCategories.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanelCategories.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F));
            tableLayoutPanelCategories.Controls.Add(buttonOpenFormSelectionCategories, 1, 0);
            tableLayoutPanelCategories.Controls.Add(buttonRefreshCategories, 0, 0);
            tableLayoutPanelCategories.Dock = DockStyle.Fill;
            tableLayoutPanelCategories.Location = new Point(3, 399);
            tableLayoutPanelCategories.Name = "tableLayoutPanelCategories";
            tableLayoutPanelCategories.RowCount = 1;
            tableLayoutPanelCategories.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelCategories.Size = new Size(666, 121);
            tableLayoutPanelCategories.TabIndex = 18;
            // 
            // buttonOpenFormSelectionCategories
            // 
            buttonOpenFormSelectionCategories.Location = new Point(169, 3);
            buttonOpenFormSelectionCategories.Name = "buttonOpenFormSelectionCategories";
            buttonOpenFormSelectionCategories.Size = new Size(488, 115);
            buttonOpenFormSelectionCategories.TabIndex = 0;
            buttonOpenFormSelectionCategories.Text = "Gérer la liste des catégories";
            buttonOpenFormSelectionCategories.UseVisualStyleBackColor = true;
            buttonOpenFormSelectionCategories.Click += buttonOpenFormSelectionCategories_Click;
            // 
            // buttonRefreshCategories
            // 
            buttonRefreshCategories.Dock = DockStyle.Fill;
            buttonRefreshCategories.Location = new Point(3, 3);
            buttonRefreshCategories.Name = "buttonRefreshCategories";
            buttonRefreshCategories.Size = new Size(160, 115);
            buttonRefreshCategories.TabIndex = 1;
            buttonRefreshCategories.Text = "Actualiser";
            buttonRefreshCategories.UseVisualStyleBackColor = true;
            buttonRefreshCategories.Click += buttonRefreshCategories_Click;
            // 
            // dataGridViewCategories
            // 
            dataGridViewCategories.AllowUserToAddRows = false;
            dataGridViewCategories.AllowUserToDeleteRows = false;
            dataGridViewCategories.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCategories.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCategories.DefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCategories.Dock = DockStyle.Fill;
            dataGridViewCategories.EnableHeadersVisualStyles = false;
            dataGridViewCategories.Location = new Point(3, 18);
            dataGridViewCategories.Name = "dataGridViewCategories";
            dataGridViewCategories.ReadOnly = true;
            dataGridViewCategories.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCategories.RowHeadersVisible = false;
            dataGridViewCategories.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewCategories.Size = new Size(666, 375);
            dataGridViewCategories.TabIndex = 19;
            // 
            // labelCategories
            // 
            labelCategories.AutoSize = true;
            labelCategories.Dock = DockStyle.Fill;
            labelCategories.Location = new Point(3, 0);
            labelCategories.Name = "labelCategories";
            labelCategories.Size = new Size(666, 15);
            labelCategories.TabIndex = 20;
            labelCategories.Text = "Catégories";
            // 
            // tabPageIngredients
            // 
            tabPageIngredients.Controls.Add(tableLayoutPanelIngredientsRecette);
            tabPageIngredients.Location = new Point(4, 24);
            tabPageIngredients.Name = "tabPageIngredients";
            tabPageIngredients.Padding = new Padding(3);
            tabPageIngredients.Size = new Size(678, 529);
            tabPageIngredients.TabIndex = 3;
            tabPageIngredients.Text = "Ingredients";
            tabPageIngredients.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanelIngredientsRecette
            // 
            tableLayoutPanelIngredientsRecette.ColumnCount = 1;
            tableLayoutPanelIngredientsRecette.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelIngredientsRecette.Controls.Add(tableLayoutPanelIngredientsButtons, 0, 2);
            tableLayoutPanelIngredientsRecette.Controls.Add(dataGridViewIngredients, 0, 1);
            tableLayoutPanelIngredientsRecette.Controls.Add(labelIngredients, 0, 0);
            tableLayoutPanelIngredientsRecette.Dock = DockStyle.Fill;
            tableLayoutPanelIngredientsRecette.Location = new Point(3, 3);
            tableLayoutPanelIngredientsRecette.Name = "tableLayoutPanelIngredientsRecette";
            tableLayoutPanelIngredientsRecette.RowCount = 3;
            tableLayoutPanelIngredientsRecette.RowStyles.Add(new RowStyle());
            tableLayoutPanelIngredientsRecette.RowStyles.Add(new RowStyle(SizeType.Percent, 74.66411F));
            tableLayoutPanelIngredientsRecette.RowStyles.Add(new RowStyle(SizeType.Percent, 25.3358917F));
            tableLayoutPanelIngredientsRecette.Size = new Size(672, 523);
            tableLayoutPanelIngredientsRecette.TabIndex = 16;
            // 
            // tableLayoutPanelIngredientsButtons
            // 
            tableLayoutPanelIngredientsButtons.ColumnCount = 2;
            tableLayoutPanelIngredientsButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 31.4589672F));
            tableLayoutPanelIngredientsButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 68.54103F));
            tableLayoutPanelIngredientsButtons.Controls.Add(buttonOpenFormSelectionIngredients, 1, 0);
            tableLayoutPanelIngredientsButtons.Controls.Add(buttonRefreshIngredients, 0, 0);
            tableLayoutPanelIngredientsButtons.Dock = DockStyle.Fill;
            tableLayoutPanelIngredientsButtons.Location = new Point(3, 397);
            tableLayoutPanelIngredientsButtons.Name = "tableLayoutPanelIngredientsButtons";
            tableLayoutPanelIngredientsButtons.RowCount = 1;
            tableLayoutPanelIngredientsButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelIngredientsButtons.Size = new Size(666, 123);
            tableLayoutPanelIngredientsButtons.TabIndex = 1;
            // 
            // buttonOpenFormSelectionIngredients
            // 
            buttonOpenFormSelectionIngredients.Dock = DockStyle.Fill;
            buttonOpenFormSelectionIngredients.Location = new Point(212, 3);
            buttonOpenFormSelectionIngredients.Name = "buttonOpenFormSelectionIngredients";
            buttonOpenFormSelectionIngredients.Size = new Size(451, 117);
            buttonOpenFormSelectionIngredients.TabIndex = 0;
            buttonOpenFormSelectionIngredients.Text = "Gérér la liste des ingrédients";
            buttonOpenFormSelectionIngredients.UseVisualStyleBackColor = true;
            buttonOpenFormSelectionIngredients.Click += buttonOpenFormManageIngredients_Click;
            // 
            // buttonRefreshIngredients
            // 
            buttonRefreshIngredients.Dock = DockStyle.Fill;
            buttonRefreshIngredients.Location = new Point(3, 3);
            buttonRefreshIngredients.Name = "buttonRefreshIngredients";
            buttonRefreshIngredients.Size = new Size(203, 117);
            buttonRefreshIngredients.TabIndex = 1;
            buttonRefreshIngredients.Text = "Actualiser";
            buttonRefreshIngredients.UseVisualStyleBackColor = true;
            buttonRefreshIngredients.Click += buttonRefreshIngredients_Click;
            // 
            // dataGridViewIngredients
            // 
            dataGridViewIngredients.AllowUserToAddRows = false;
            dataGridViewIngredients.AllowUserToDeleteRows = false;
            dataGridViewIngredients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewIngredients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewIngredients.DefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewIngredients.Dock = DockStyle.Fill;
            dataGridViewIngredients.EnableHeadersVisualStyles = false;
            dataGridViewIngredients.Location = new Point(3, 18);
            dataGridViewIngredients.Name = "dataGridViewIngredients";
            dataGridViewIngredients.ReadOnly = true;
            dataGridViewIngredients.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewIngredients.RowHeadersVisible = false;
            dataGridViewIngredients.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewIngredients.Size = new Size(666, 373);
            dataGridViewIngredients.TabIndex = 2;
            // 
            // labelIngredients
            // 
            labelIngredients.AutoSize = true;
            labelIngredients.Dock = DockStyle.Fill;
            labelIngredients.Location = new Point(3, 0);
            labelIngredients.Name = "labelIngredients";
            labelIngredients.Size = new Size(666, 15);
            labelIngredients.TabIndex = 3;
            labelIngredients.Text = "Ingrédients";
            // 
            // tabPageAvis
            // 
            tabPageAvis.Location = new Point(4, 24);
            tabPageAvis.Name = "tabPageAvis";
            tabPageAvis.Padding = new Padding(3);
            tabPageAvis.Size = new Size(678, 529);
            tabPageAvis.TabIndex = 4;
            tabPageAvis.Text = "Avis";
            tabPageAvis.UseVisualStyleBackColor = true;
            // 
            // tabPageCompte
            // 
            tabPageCompte.Location = new Point(4, 24);
            tabPageCompte.Name = "tabPageCompte";
            tabPageCompte.Padding = new Padding(3);
            tabPageCompte.Size = new Size(678, 529);
            tabPageCompte.TabIndex = 5;
            tabPageCompte.Text = "Compte";
            tabPageCompte.UseVisualStyleBackColor = true;
            // 
            // FormAppMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(692, 563);
            Controls.Add(tableLayoutPanelApp);
            MaximizeBox = false;
            MaximumSize = new Size(708, 602);
            MinimumSize = new Size(700, 600);
            Name = "FormAppMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CookBook App";
            Load += FormAppMain_Load;
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
            tableLayoutPanelDifficulteRecette.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDownDifficulteRecette).EndInit();
            tableLayoutPanelDescriptionRecette.ResumeLayout(false);
            tableLayoutPanelDescriptionRecette.PerformLayout();
            flowLayoutPanelGestionRecettesButtons.ResumeLayout(false);
            tabPageEtapes.ResumeLayout(false);
            tableLayoutPanelEtapesRecette.ResumeLayout(false);
            tableLayoutPanelEtapesButtons.ResumeLayout(false);
            tableLayoutPanelDataGridViewsEtapes.ResumeLayout(false);
            tableLayoutPanelDataGridViewsEtapes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEtapes).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEtapesRecette).EndInit();
            tabPageCategories.ResumeLayout(false);
            tableLayoutPanelCategoriesRecette.ResumeLayout(false);
            tableLayoutPanelCategoriesRecette.PerformLayout();
            tableLayoutPanelCategories.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewCategories).EndInit();
            tabPageIngredients.ResumeLayout(false);
            tableLayoutPanelIngredientsRecette.ResumeLayout(false);
            tableLayoutPanelIngredientsRecette.PerformLayout();
            tableLayoutPanelIngredientsButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewIngredients).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceRecettes).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceEtapes).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceCategories).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceIngredients).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceAvis).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceRecettesInEtapes).EndInit();
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
        private NumericUpDown numericUpDownDifficulteRecette;
        private Panel panelRecettesInputs;
        private TableLayoutPanel tableLayoutPanelDifficulteRecette;
        private TableLayoutPanel tableLayoutPanelDescriptionRecette;
        private TableLayoutPanel tableLayoutPanelNomRecette;
        private TableLayoutPanel tableLayoutPanelImageRecette;
        private TextBox textBoxImageRecette;
        private Button buttonSelectionnerImageRecette;
        private NumericUpDown numericUpDown6;
        private TabPage tabPageCategories;
        private TabPage tabPageIngredients;
        private TabPage tabPageAvis;
        private TabPage tabPageCompte;
        private DataGridView dataGridViewEtapes;
        private BindingSource bindingSourceEtapes;
        private BindingSource bindingSourceCategories;
        private BindingSource bindingSourceIngredients;
        private BindingSource bindingSourceAvis;
        private TableLayoutPanel tableLayoutPanelEtapesButtons;
        private Button buttonRefreshEtapes;
        private TableLayoutPanel tableLayoutPanelCategories;
        private Button buttonRefreshCategories;
        private DataGridView dataGridViewCategories;
        private DataGridView dataGridViewEtapesRecette;
        private TableLayoutPanel tableLayoutPanelDataGridViewsEtapes;
        private TableLayoutPanel tableLayoutPanelIngredientsButtons;
        private Button buttonRefreshIngredients;
        private DataGridView dataGridViewIngredients;
        private BindingSource bindingSourceRecettesInEtapes;
        private Button buttonOpenRecetteDetailsForm;
        private Label labelRecettes;
        private Label labelEtapes;
        private Label labelEtapesRecette;
        private Label labelCategories;
        private Label labelIngredients;
    }
}
