namespace CookBookAppDesktop
{
    partial class FormManageCategories
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            tableLayoutPanelManageCategories = new TableLayoutPanel();
            tableLayoutPanelManageCategoriesRecettes = new TableLayoutPanel();
            tableLayoutPanelRecipesAndCategoriesInThem = new TableLayoutPanel();
            dataGridViewCategoriesOfRecette = new DataGridView();
            dataGridViewRecettes = new DataGridView();
            buttonRemoveCategorieFromRecette = new Button();
            buttonAddCategorieToRecette = new Button();
            dataGridViewRecettesWithoutTheCategorie = new DataGridView();
            tableLayoutPanelCategories = new TableLayoutPanel();
            dataGridViewCategories = new DataGridView();
            tableLayoutPanelCategoriesInputs = new TableLayoutPanel();
            labelCategorieNom = new Label();
            textBoxCategorieNom = new TextBox();
            flowLayoutPanelCategoriesButtons = new FlowLayoutPanel();
            buttonActualiserCategorie = new Button();
            buttonAddCategorie = new Button();
            buttonModifyCategorie = new Button();
            buttonRemoveCategorie = new Button();
            bindingSourceCategories = new BindingSource(components);
            bindingSourceRecettes = new BindingSource(components);
            bindingSourceCategoriesOfRecette = new BindingSource(components);
            bindingSourceRecettesWithoutTheCategorie = new BindingSource(components);
            tableLayoutPanelManageCategories.SuspendLayout();
            tableLayoutPanelManageCategoriesRecettes.SuspendLayout();
            tableLayoutPanelRecipesAndCategoriesInThem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCategoriesOfRecette).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRecettes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRecettesWithoutTheCategorie).BeginInit();
            tableLayoutPanelCategories.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCategories).BeginInit();
            tableLayoutPanelCategoriesInputs.SuspendLayout();
            flowLayoutPanelCategoriesButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSourceCategories).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceRecettes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceCategoriesOfRecette).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceRecettesWithoutTheCategorie).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanelManageCategories
            // 
            tableLayoutPanelManageCategories.ColumnCount = 2;
            tableLayoutPanelManageCategories.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F));
            tableLayoutPanelManageCategories.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanelManageCategories.Controls.Add(tableLayoutPanelManageCategoriesRecettes, 0, 0);
            tableLayoutPanelManageCategories.Controls.Add(tableLayoutPanelCategories, 1, 0);
            tableLayoutPanelManageCategories.Dock = DockStyle.Fill;
            tableLayoutPanelManageCategories.Location = new Point(0, 0);
            tableLayoutPanelManageCategories.Name = "tableLayoutPanelManageCategories";
            tableLayoutPanelManageCategories.RowCount = 1;
            tableLayoutPanelManageCategories.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelManageCategories.Size = new Size(800, 450);
            tableLayoutPanelManageCategories.TabIndex = 0;
            // 
            // tableLayoutPanelManageCategoriesRecettes
            // 
            tableLayoutPanelManageCategoriesRecettes.ColumnCount = 2;
            tableLayoutPanelManageCategoriesRecettes.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelManageCategoriesRecettes.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelManageCategoriesRecettes.Controls.Add(tableLayoutPanelRecipesAndCategoriesInThem, 1, 0);
            tableLayoutPanelManageCategoriesRecettes.Controls.Add(buttonRemoveCategorieFromRecette, 1, 1);
            tableLayoutPanelManageCategoriesRecettes.Controls.Add(buttonAddCategorieToRecette, 0, 1);
            tableLayoutPanelManageCategoriesRecettes.Controls.Add(dataGridViewRecettesWithoutTheCategorie, 0, 0);
            tableLayoutPanelManageCategoriesRecettes.Dock = DockStyle.Fill;
            tableLayoutPanelManageCategoriesRecettes.Location = new Point(3, 3);
            tableLayoutPanelManageCategoriesRecettes.Name = "tableLayoutPanelManageCategoriesRecettes";
            tableLayoutPanelManageCategoriesRecettes.RowCount = 2;
            tableLayoutPanelManageCategoriesRecettes.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableLayoutPanelManageCategoriesRecettes.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanelManageCategoriesRecettes.Size = new Size(594, 444);
            tableLayoutPanelManageCategoriesRecettes.TabIndex = 0;
            // 
            // tableLayoutPanelRecipesAndCategoriesInThem
            // 
            tableLayoutPanelRecipesAndCategoriesInThem.ColumnCount = 1;
            tableLayoutPanelRecipesAndCategoriesInThem.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelRecipesAndCategoriesInThem.Controls.Add(dataGridViewCategoriesOfRecette, 0, 1);
            tableLayoutPanelRecipesAndCategoriesInThem.Controls.Add(dataGridViewRecettes, 0, 0);
            tableLayoutPanelRecipesAndCategoriesInThem.Dock = DockStyle.Fill;
            tableLayoutPanelRecipesAndCategoriesInThem.Location = new Point(300, 3);
            tableLayoutPanelRecipesAndCategoriesInThem.Name = "tableLayoutPanelRecipesAndCategoriesInThem";
            tableLayoutPanelRecipesAndCategoriesInThem.RowCount = 2;
            tableLayoutPanelRecipesAndCategoriesInThem.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelRecipesAndCategoriesInThem.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelRecipesAndCategoriesInThem.Size = new Size(291, 349);
            tableLayoutPanelRecipesAndCategoriesInThem.TabIndex = 4;
            // 
            // dataGridViewCategoriesOfRecette
            // 
            dataGridViewCategoriesOfRecette.AllowUserToAddRows = false;
            dataGridViewCategoriesOfRecette.AllowUserToDeleteRows = false;
            dataGridViewCategoriesOfRecette.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCategoriesOfRecette.Location = new Point(3, 177);
            dataGridViewCategoriesOfRecette.Name = "dataGridViewCategoriesOfRecette";
            dataGridViewCategoriesOfRecette.ReadOnly = true;
            dataGridViewCategoriesOfRecette.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewCategoriesOfRecette.Size = new Size(285, 169);
            dataGridViewCategoriesOfRecette.TabIndex = 0;
            // 
            // dataGridViewRecettes
            // 
            dataGridViewRecettes.AllowUserToAddRows = false;
            dataGridViewRecettes.AllowUserToDeleteRows = false;
            dataGridViewRecettes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRecettes.Location = new Point(3, 3);
            dataGridViewRecettes.Name = "dataGridViewRecettes";
            dataGridViewRecettes.ReadOnly = true;
            dataGridViewRecettes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewRecettes.Size = new Size(285, 168);
            dataGridViewRecettes.TabIndex = 1;
            dataGridViewRecettes.CurrentCellChanged += dataGridViewRecettes_CurrentCellChanged;
            // 
            // buttonRemoveCategorieFromRecette
            // 
            buttonRemoveCategorieFromRecette.Location = new Point(300, 358);
            buttonRemoveCategorieFromRecette.Name = "buttonRemoveCategorieFromRecette";
            buttonRemoveCategorieFromRecette.Size = new Size(291, 83);
            buttonRemoveCategorieFromRecette.TabIndex = 2;
            buttonRemoveCategorieFromRecette.Text = "Supprimer Categorie de la recette";
            buttonRemoveCategorieFromRecette.UseVisualStyleBackColor = true;
            buttonRemoveCategorieFromRecette.Click += buttonRemoveCategorieFromRecette_Click;
            // 
            // buttonAddCategorieToRecette
            // 
            buttonAddCategorieToRecette.Location = new Point(3, 358);
            buttonAddCategorieToRecette.Name = "buttonAddCategorieToRecette";
            buttonAddCategorieToRecette.Size = new Size(291, 83);
            buttonAddCategorieToRecette.TabIndex = 3;
            buttonAddCategorieToRecette.Text = "Ajouter Categorie a la recette";
            buttonAddCategorieToRecette.UseVisualStyleBackColor = true;
            buttonAddCategorieToRecette.Click += buttonAddCategorieToRecette_Click;
            // 
            // dataGridViewRecettesWithoutTheCategorie
            // 
            dataGridViewRecettesWithoutTheCategorie.AllowUserToAddRows = false;
            dataGridViewRecettesWithoutTheCategorie.AllowUserToDeleteRows = false;
            dataGridViewRecettesWithoutTheCategorie.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRecettesWithoutTheCategorie.Dock = DockStyle.Fill;
            dataGridViewRecettesWithoutTheCategorie.Location = new Point(3, 3);
            dataGridViewRecettesWithoutTheCategorie.Name = "dataGridViewRecettesWithoutTheCategorie";
            dataGridViewRecettesWithoutTheCategorie.ReadOnly = true;
            dataGridViewRecettesWithoutTheCategorie.Size = new Size(291, 349);
            dataGridViewRecettesWithoutTheCategorie.TabIndex = 5;
            // 
            // tableLayoutPanelCategories
            // 
            tableLayoutPanelCategories.ColumnCount = 1;
            tableLayoutPanelCategories.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelCategories.Controls.Add(dataGridViewCategories, 0, 0);
            tableLayoutPanelCategories.Controls.Add(tableLayoutPanelCategoriesInputs, 0, 1);
            tableLayoutPanelCategories.Controls.Add(flowLayoutPanelCategoriesButtons, 0, 2);
            tableLayoutPanelCategories.Dock = DockStyle.Fill;
            tableLayoutPanelCategories.Location = new Point(603, 3);
            tableLayoutPanelCategories.Name = "tableLayoutPanelCategories";
            tableLayoutPanelCategories.RowCount = 3;
            tableLayoutPanelCategories.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            tableLayoutPanelCategories.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanelCategories.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanelCategories.Size = new Size(194, 444);
            tableLayoutPanelCategories.TabIndex = 1;
            // 
            // dataGridViewCategories
            // 
            dataGridViewCategories.AllowUserToAddRows = false;
            dataGridViewCategories.AllowUserToDeleteRows = false;
            dataGridViewCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCategories.Dock = DockStyle.Fill;
            dataGridViewCategories.Location = new Point(3, 3);
            dataGridViewCategories.Name = "dataGridViewCategories";
            dataGridViewCategories.ReadOnly = true;
            dataGridViewCategories.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewCategories.Size = new Size(188, 304);
            dataGridViewCategories.TabIndex = 0;
            dataGridViewCategories.CurrentCellChanged += dataGridViewCategories_CurrentCellChanged;
            // 
            // tableLayoutPanelCategoriesInputs
            // 
            tableLayoutPanelCategoriesInputs.ColumnCount = 2;
            tableLayoutPanelCategoriesInputs.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanelCategoriesInputs.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F));
            tableLayoutPanelCategoriesInputs.Controls.Add(labelCategorieNom, 0, 0);
            tableLayoutPanelCategoriesInputs.Controls.Add(textBoxCategorieNom, 1, 0);
            tableLayoutPanelCategoriesInputs.Dock = DockStyle.Fill;
            tableLayoutPanelCategoriesInputs.Location = new Point(3, 313);
            tableLayoutPanelCategoriesInputs.Name = "tableLayoutPanelCategoriesInputs";
            tableLayoutPanelCategoriesInputs.RowCount = 1;
            tableLayoutPanelCategoriesInputs.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelCategoriesInputs.Size = new Size(188, 38);
            tableLayoutPanelCategoriesInputs.TabIndex = 1;
            // 
            // labelCategorieNom
            // 
            labelCategorieNom.AutoSize = true;
            labelCategorieNom.Dock = DockStyle.Fill;
            labelCategorieNom.Location = new Point(3, 0);
            labelCategorieNom.Name = "labelCategorieNom";
            labelCategorieNom.Size = new Size(41, 38);
            labelCategorieNom.TabIndex = 0;
            labelCategorieNom.Text = "Nom :";
            // 
            // textBoxCategorieNom
            // 
            textBoxCategorieNom.Dock = DockStyle.Fill;
            textBoxCategorieNom.Location = new Point(50, 3);
            textBoxCategorieNom.Name = "textBoxCategorieNom";
            textBoxCategorieNom.Size = new Size(135, 23);
            textBoxCategorieNom.TabIndex = 1;
            // 
            // flowLayoutPanelCategoriesButtons
            // 
            flowLayoutPanelCategoriesButtons.Controls.Add(buttonActualiserCategorie);
            flowLayoutPanelCategoriesButtons.Controls.Add(buttonAddCategorie);
            flowLayoutPanelCategoriesButtons.Controls.Add(buttonModifyCategorie);
            flowLayoutPanelCategoriesButtons.Controls.Add(buttonRemoveCategorie);
            flowLayoutPanelCategoriesButtons.Location = new Point(3, 357);
            flowLayoutPanelCategoriesButtons.Name = "flowLayoutPanelCategoriesButtons";
            flowLayoutPanelCategoriesButtons.Size = new Size(188, 84);
            flowLayoutPanelCategoriesButtons.TabIndex = 2;
            // 
            // buttonActualiserCategorie
            // 
            buttonActualiserCategorie.Location = new Point(3, 3);
            buttonActualiserCategorie.Name = "buttonActualiserCategorie";
            buttonActualiserCategorie.Size = new Size(75, 23);
            buttonActualiserCategorie.TabIndex = 3;
            buttonActualiserCategorie.Text = "Actualiser";
            buttonActualiserCategorie.UseVisualStyleBackColor = true;
            buttonActualiserCategorie.Click += buttonRefreshCategories_Click;
            // 
            // buttonAddCategorie
            // 
            buttonAddCategorie.Location = new Point(84, 3);
            buttonAddCategorie.Name = "buttonAddCategorie";
            buttonAddCategorie.Size = new Size(75, 23);
            buttonAddCategorie.TabIndex = 0;
            buttonAddCategorie.Text = "Ajouter";
            buttonAddCategorie.UseVisualStyleBackColor = true;
            buttonAddCategorie.Click += buttonAddCategorie_Click;
            // 
            // buttonModifyCategorie
            // 
            buttonModifyCategorie.Location = new Point(3, 32);
            buttonModifyCategorie.Name = "buttonModifyCategorie";
            buttonModifyCategorie.Size = new Size(75, 23);
            buttonModifyCategorie.TabIndex = 1;
            buttonModifyCategorie.Text = "Modifier";
            buttonModifyCategorie.UseVisualStyleBackColor = true;
            buttonModifyCategorie.Click += buttonModifyCategorie_Click;
            // 
            // buttonRemoveCategorie
            // 
            buttonRemoveCategorie.Location = new Point(84, 32);
            buttonRemoveCategorie.Name = "buttonRemoveCategorie";
            buttonRemoveCategorie.Size = new Size(75, 23);
            buttonRemoveCategorie.TabIndex = 2;
            buttonRemoveCategorie.Text = "Supprimer";
            buttonRemoveCategorie.UseVisualStyleBackColor = true;
            buttonRemoveCategorie.Click += buttonDeleteCategorie_Click;
            // 
            // FormManageCategories
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanelManageCategories);
            Name = "FormManageCategories";
            Text = "FormManageCategories";
            Load += FormManageCategories_Load;
            tableLayoutPanelManageCategories.ResumeLayout(false);
            tableLayoutPanelManageCategoriesRecettes.ResumeLayout(false);
            tableLayoutPanelRecipesAndCategoriesInThem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewCategoriesOfRecette).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRecettes).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRecettesWithoutTheCategorie).EndInit();
            tableLayoutPanelCategories.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewCategories).EndInit();
            tableLayoutPanelCategoriesInputs.ResumeLayout(false);
            tableLayoutPanelCategoriesInputs.PerformLayout();
            flowLayoutPanelCategoriesButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)bindingSourceCategories).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceRecettes).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceCategoriesOfRecette).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceRecettesWithoutTheCategorie).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanelManageCategories;
        private TableLayoutPanel tableLayoutPanelManageCategoriesRecettes;
        private DataGridView dataGridViewCategoriesOfRecette;
        private DataGridView dataGridViewRecettes;
        private Button buttonRemoveCategorieFromRecette;
        private Button buttonAddCategorieToRecette;
        private TableLayoutPanel tableLayoutPanelCategories;
        private DataGridView dataGridViewCategories;
        private TableLayoutPanel tableLayoutPanelCategoriesInputs;
        private FlowLayoutPanel flowLayoutPanelCategoriesButtons;
        private Button buttonAddCategorie;
        private Button buttonModifyCategorie;
        private Button buttonRemoveCategorie;
        private Label labelCategorieNom;
        private TextBox textBoxCategorieNom;
        private BindingSource bindingSourceCategories;
        private BindingSource bindingSourceRecettes;
        private BindingSource bindingSourceCategoriesOfRecette;
        private TableLayoutPanel tableLayoutPanelRecipesAndCategoriesInThem;
        private DataGridView dataGridViewRecettesWithoutTheCategorie;
        private BindingSource bindingSourceRecettesWithoutTheCategorie;
        private Button buttonActualiserCategorie;
    }
}