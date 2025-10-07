namespace CookBookAppDesktop
{
    partial class FormManageIngredients
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
            panelFormManageIngredients = new Panel();
            tableLayoutPanelFormManageIngredients = new TableLayoutPanel();
            tableLayoutPanelManageIngredients = new TableLayoutPanel();
            tableLayoutPanelRecipesAndIngredientsInThem = new TableLayoutPanel();
            dataGridViewRecipes = new DataGridView();
            dataGridViewIngredientsOfRecette = new DataGridView();
            buttonAddIngredientToRecette = new Button();
            buttonRemoveIngredientFromRecette = new Button();
            tableLayoutPanelIngredientsManagement = new TableLayoutPanel();
            dataGridViewRecipesWithoutTheIngredient = new DataGridView();
            tableLayoutPanelQuantityInputs = new TableLayoutPanel();
            labelModifyQuantity = new Label();
            textBoxModifyQuantity = new TextBox();
            flowLayoutPanelButtonModify = new FlowLayoutPanel();
            buttonModifyQuantityIngredient = new Button();
            tableLayoutPanelIngredients = new TableLayoutPanel();
            dataGridViewIngredients = new DataGridView();
            tableLayoutPanelIngredientsInputs = new TableLayoutPanel();
            labelNomIngredient = new Label();
            textBoxNomIngredient = new TextBox();
            flowLayoutPanelIngredientsButtons = new FlowLayoutPanel();
            buttonRefreshIngredient = new Button();
            buttonAddIngredient = new Button();
            buttonModifyIngredient = new Button();
            buttonRemoveIngredient = new Button();
            bindingSourceIngredients = new BindingSource(components);
            panelFormManageIngredients.SuspendLayout();
            tableLayoutPanelFormManageIngredients.SuspendLayout();
            tableLayoutPanelManageIngredients.SuspendLayout();
            tableLayoutPanelRecipesAndIngredientsInThem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRecipes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewIngredientsOfRecette).BeginInit();
            tableLayoutPanelIngredientsManagement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRecipesWithoutTheIngredient).BeginInit();
            tableLayoutPanelQuantityInputs.SuspendLayout();
            flowLayoutPanelButtonModify.SuspendLayout();
            tableLayoutPanelIngredients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewIngredients).BeginInit();
            tableLayoutPanelIngredientsInputs.SuspendLayout();
            flowLayoutPanelIngredientsButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSourceIngredients).BeginInit();
            SuspendLayout();
            // 
            // panelFormManageIngredients
            // 
            panelFormManageIngredients.Controls.Add(tableLayoutPanelFormManageIngredients);
            panelFormManageIngredients.Dock = DockStyle.Fill;
            panelFormManageIngredients.Location = new Point(0, 0);
            panelFormManageIngredients.Name = "panelFormManageIngredients";
            panelFormManageIngredients.Size = new Size(800, 450);
            panelFormManageIngredients.TabIndex = 0;
            // 
            // tableLayoutPanelFormManageIngredients
            // 
            tableLayoutPanelFormManageIngredients.ColumnCount = 2;
            tableLayoutPanelFormManageIngredients.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 68.875F));
            tableLayoutPanelFormManageIngredients.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 31.125F));
            tableLayoutPanelFormManageIngredients.Controls.Add(tableLayoutPanelManageIngredients, 0, 0);
            tableLayoutPanelFormManageIngredients.Controls.Add(tableLayoutPanelIngredients, 1, 0);
            tableLayoutPanelFormManageIngredients.Dock = DockStyle.Fill;
            tableLayoutPanelFormManageIngredients.Location = new Point(0, 0);
            tableLayoutPanelFormManageIngredients.Name = "tableLayoutPanelFormManageIngredients";
            tableLayoutPanelFormManageIngredients.RowCount = 1;
            tableLayoutPanelFormManageIngredients.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelFormManageIngredients.Size = new Size(800, 450);
            tableLayoutPanelFormManageIngredients.TabIndex = 0;
            // 
            // tableLayoutPanelManageIngredients
            // 
            tableLayoutPanelManageIngredients.ColumnCount = 2;
            tableLayoutPanelManageIngredients.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelManageIngredients.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelManageIngredients.Controls.Add(tableLayoutPanelRecipesAndIngredientsInThem, 1, 0);
            tableLayoutPanelManageIngredients.Controls.Add(buttonAddIngredientToRecette, 0, 1);
            tableLayoutPanelManageIngredients.Controls.Add(buttonRemoveIngredientFromRecette, 1, 1);
            tableLayoutPanelManageIngredients.Controls.Add(tableLayoutPanelIngredientsManagement, 0, 0);
            tableLayoutPanelManageIngredients.Dock = DockStyle.Fill;
            tableLayoutPanelManageIngredients.Location = new Point(3, 3);
            tableLayoutPanelManageIngredients.Name = "tableLayoutPanelManageIngredients";
            tableLayoutPanelManageIngredients.RowCount = 2;
            tableLayoutPanelManageIngredients.RowStyles.Add(new RowStyle(SizeType.Percent, 81.3063049F));
            tableLayoutPanelManageIngredients.RowStyles.Add(new RowStyle(SizeType.Percent, 18.6936932F));
            tableLayoutPanelManageIngredients.Size = new Size(545, 444);
            tableLayoutPanelManageIngredients.TabIndex = 0;
            // 
            // tableLayoutPanelRecipesAndIngredientsInThem
            // 
            tableLayoutPanelRecipesAndIngredientsInThem.ColumnCount = 1;
            tableLayoutPanelRecipesAndIngredientsInThem.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelRecipesAndIngredientsInThem.Controls.Add(dataGridViewRecipes, 0, 0);
            tableLayoutPanelRecipesAndIngredientsInThem.Controls.Add(dataGridViewIngredientsOfRecette, 0, 1);
            tableLayoutPanelRecipesAndIngredientsInThem.Dock = DockStyle.Fill;
            tableLayoutPanelRecipesAndIngredientsInThem.Location = new Point(275, 3);
            tableLayoutPanelRecipesAndIngredientsInThem.Name = "tableLayoutPanelRecipesAndIngredientsInThem";
            tableLayoutPanelRecipesAndIngredientsInThem.RowCount = 2;
            tableLayoutPanelRecipesAndIngredientsInThem.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelRecipesAndIngredientsInThem.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelRecipesAndIngredientsInThem.Size = new Size(267, 355);
            tableLayoutPanelRecipesAndIngredientsInThem.TabIndex = 0;
            // 
            // dataGridViewRecipes
            // 
            dataGridViewRecipes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRecipes.Dock = DockStyle.Fill;
            dataGridViewRecipes.Location = new Point(3, 3);
            dataGridViewRecipes.Name = "dataGridViewRecipes";
            dataGridViewRecipes.Size = new Size(261, 171);
            dataGridViewRecipes.TabIndex = 0;
            // 
            // dataGridViewIngredientsOfRecette
            // 
            dataGridViewIngredientsOfRecette.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewIngredientsOfRecette.Dock = DockStyle.Fill;
            dataGridViewIngredientsOfRecette.Location = new Point(3, 180);
            dataGridViewIngredientsOfRecette.Name = "dataGridViewIngredientsOfRecette";
            dataGridViewIngredientsOfRecette.Size = new Size(261, 172);
            dataGridViewIngredientsOfRecette.TabIndex = 1;
            // 
            // buttonAddIngredientToRecette
            // 
            buttonAddIngredientToRecette.Dock = DockStyle.Fill;
            buttonAddIngredientToRecette.Location = new Point(3, 364);
            buttonAddIngredientToRecette.Name = "buttonAddIngredientToRecette";
            buttonAddIngredientToRecette.Size = new Size(266, 77);
            buttonAddIngredientToRecette.TabIndex = 2;
            buttonAddIngredientToRecette.Text = "Ajouter Ingredient a la recette";
            buttonAddIngredientToRecette.UseVisualStyleBackColor = true;
            // 
            // buttonRemoveIngredientFromRecette
            // 
            buttonRemoveIngredientFromRecette.Dock = DockStyle.Fill;
            buttonRemoveIngredientFromRecette.Location = new Point(275, 364);
            buttonRemoveIngredientFromRecette.Name = "buttonRemoveIngredientFromRecette";
            buttonRemoveIngredientFromRecette.Size = new Size(267, 77);
            buttonRemoveIngredientFromRecette.TabIndex = 3;
            buttonRemoveIngredientFromRecette.Text = "Supprimer Ingredient de la recette";
            buttonRemoveIngredientFromRecette.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanelIngredientsManagement
            // 
            tableLayoutPanelIngredientsManagement.ColumnCount = 1;
            tableLayoutPanelIngredientsManagement.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelIngredientsManagement.Controls.Add(dataGridViewRecipesWithoutTheIngredient, 0, 0);
            tableLayoutPanelIngredientsManagement.Controls.Add(tableLayoutPanelQuantityInputs, 0, 1);
            tableLayoutPanelIngredientsManagement.Controls.Add(flowLayoutPanelButtonModify, 0, 2);
            tableLayoutPanelIngredientsManagement.Dock = DockStyle.Fill;
            tableLayoutPanelIngredientsManagement.Location = new Point(3, 3);
            tableLayoutPanelIngredientsManagement.Name = "tableLayoutPanelIngredientsManagement";
            tableLayoutPanelIngredientsManagement.RowCount = 3;
            tableLayoutPanelIngredientsManagement.RowStyles.Add(new RowStyle(SizeType.Percent, 74.3661957F));
            tableLayoutPanelIngredientsManagement.RowStyles.Add(new RowStyle(SizeType.Percent, 10.1408453F));
            tableLayoutPanelIngredientsManagement.RowStyles.Add(new RowStyle(SizeType.Percent, 15.2112675F));
            tableLayoutPanelIngredientsManagement.Size = new Size(266, 355);
            tableLayoutPanelIngredientsManagement.TabIndex = 4;
            // 
            // dataGridViewRecipesWithoutTheIngredient
            // 
            dataGridViewRecipesWithoutTheIngredient.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRecipesWithoutTheIngredient.Dock = DockStyle.Fill;
            dataGridViewRecipesWithoutTheIngredient.Location = new Point(3, 3);
            dataGridViewRecipesWithoutTheIngredient.Name = "dataGridViewRecipesWithoutTheIngredient";
            dataGridViewRecipesWithoutTheIngredient.Size = new Size(260, 258);
            dataGridViewRecipesWithoutTheIngredient.TabIndex = 1;
            // 
            // tableLayoutPanelQuantityInputs
            // 
            tableLayoutPanelQuantityInputs.ColumnCount = 2;
            tableLayoutPanelQuantityInputs.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.6923084F));
            tableLayoutPanelQuantityInputs.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 72.30769F));
            tableLayoutPanelQuantityInputs.Controls.Add(labelModifyQuantity, 0, 0);
            tableLayoutPanelQuantityInputs.Controls.Add(textBoxModifyQuantity, 1, 0);
            tableLayoutPanelQuantityInputs.Dock = DockStyle.Fill;
            tableLayoutPanelQuantityInputs.Location = new Point(3, 267);
            tableLayoutPanelQuantityInputs.Name = "tableLayoutPanelQuantityInputs";
            tableLayoutPanelQuantityInputs.RowCount = 1;
            tableLayoutPanelQuantityInputs.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelQuantityInputs.Size = new Size(260, 30);
            tableLayoutPanelQuantityInputs.TabIndex = 2;
            // 
            // labelModifyQuantity
            // 
            labelModifyQuantity.AutoSize = true;
            labelModifyQuantity.Dock = DockStyle.Fill;
            labelModifyQuantity.Location = new Point(3, 0);
            labelModifyQuantity.Name = "labelModifyQuantity";
            labelModifyQuantity.Size = new Size(66, 30);
            labelModifyQuantity.TabIndex = 0;
            labelModifyQuantity.Text = "Quantité :";
            // 
            // textBoxModifyQuantity
            // 
            textBoxModifyQuantity.Dock = DockStyle.Fill;
            textBoxModifyQuantity.Location = new Point(75, 3);
            textBoxModifyQuantity.Name = "textBoxModifyQuantity";
            textBoxModifyQuantity.Size = new Size(182, 23);
            textBoxModifyQuantity.TabIndex = 1;
            // 
            // flowLayoutPanelButtonModify
            // 
            flowLayoutPanelButtonModify.Controls.Add(buttonModifyQuantityIngredient);
            flowLayoutPanelButtonModify.Dock = DockStyle.Fill;
            flowLayoutPanelButtonModify.Location = new Point(3, 303);
            flowLayoutPanelButtonModify.Name = "flowLayoutPanelButtonModify";
            flowLayoutPanelButtonModify.Size = new Size(260, 49);
            flowLayoutPanelButtonModify.TabIndex = 3;
            // 
            // buttonModifyQuantityIngredient
            // 
            buttonModifyQuantityIngredient.Location = new Point(3, 3);
            buttonModifyQuantityIngredient.Name = "buttonModifyQuantityIngredient";
            buttonModifyQuantityIngredient.Size = new Size(257, 44);
            buttonModifyQuantityIngredient.TabIndex = 0;
            buttonModifyQuantityIngredient.Text = "Modifier Quantité";
            buttonModifyQuantityIngredient.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanelIngredients
            // 
            tableLayoutPanelIngredients.ColumnCount = 1;
            tableLayoutPanelIngredients.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelIngredients.Controls.Add(dataGridViewIngredients, 0, 0);
            tableLayoutPanelIngredients.Controls.Add(tableLayoutPanelIngredientsInputs, 0, 1);
            tableLayoutPanelIngredients.Controls.Add(flowLayoutPanelIngredientsButtons, 0, 2);
            tableLayoutPanelIngredients.Dock = DockStyle.Fill;
            tableLayoutPanelIngredients.Location = new Point(554, 3);
            tableLayoutPanelIngredients.Name = "tableLayoutPanelIngredients";
            tableLayoutPanelIngredients.RowCount = 3;
            tableLayoutPanelIngredients.RowStyles.Add(new RowStyle(SizeType.Percent, 88.91967F));
            tableLayoutPanelIngredients.RowStyles.Add(new RowStyle(SizeType.Percent, 11.0803328F));
            tableLayoutPanelIngredients.RowStyles.Add(new RowStyle(SizeType.Absolute, 82F));
            tableLayoutPanelIngredients.Size = new Size(243, 444);
            tableLayoutPanelIngredients.TabIndex = 1;
            // 
            // dataGridViewIngredients
            // 
            dataGridViewIngredients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewIngredients.Dock = DockStyle.Fill;
            dataGridViewIngredients.Location = new Point(3, 3);
            dataGridViewIngredients.Name = "dataGridViewIngredients";
            dataGridViewIngredients.Size = new Size(237, 315);
            dataGridViewIngredients.TabIndex = 0;
            // 
            // tableLayoutPanelIngredientsInputs
            // 
            tableLayoutPanelIngredientsInputs.ColumnCount = 2;
            tableLayoutPanelIngredientsInputs.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23.6286926F));
            tableLayoutPanelIngredientsInputs.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 76.37131F));
            tableLayoutPanelIngredientsInputs.Controls.Add(labelNomIngredient, 0, 0);
            tableLayoutPanelIngredientsInputs.Controls.Add(textBoxNomIngredient, 1, 0);
            tableLayoutPanelIngredientsInputs.Dock = DockStyle.Fill;
            tableLayoutPanelIngredientsInputs.Location = new Point(3, 324);
            tableLayoutPanelIngredientsInputs.Name = "tableLayoutPanelIngredientsInputs";
            tableLayoutPanelIngredientsInputs.RowCount = 1;
            tableLayoutPanelIngredientsInputs.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelIngredientsInputs.Size = new Size(237, 34);
            tableLayoutPanelIngredientsInputs.TabIndex = 1;
            // 
            // labelNomIngredient
            // 
            labelNomIngredient.AutoSize = true;
            labelNomIngredient.Dock = DockStyle.Fill;
            labelNomIngredient.Location = new Point(3, 0);
            labelNomIngredient.Name = "labelNomIngredient";
            labelNomIngredient.Size = new Size(50, 34);
            labelNomIngredient.TabIndex = 0;
            labelNomIngredient.Text = "Nom :";
            // 
            // textBoxNomIngredient
            // 
            textBoxNomIngredient.Dock = DockStyle.Fill;
            textBoxNomIngredient.Location = new Point(59, 3);
            textBoxNomIngredient.Name = "textBoxNomIngredient";
            textBoxNomIngredient.Size = new Size(175, 23);
            textBoxNomIngredient.TabIndex = 1;
            // 
            // flowLayoutPanelIngredientsButtons
            // 
            flowLayoutPanelIngredientsButtons.Controls.Add(buttonRefreshIngredient);
            flowLayoutPanelIngredientsButtons.Controls.Add(buttonAddIngredient);
            flowLayoutPanelIngredientsButtons.Controls.Add(buttonModifyIngredient);
            flowLayoutPanelIngredientsButtons.Controls.Add(buttonRemoveIngredient);
            flowLayoutPanelIngredientsButtons.Dock = DockStyle.Fill;
            flowLayoutPanelIngredientsButtons.Location = new Point(3, 364);
            flowLayoutPanelIngredientsButtons.Name = "flowLayoutPanelIngredientsButtons";
            flowLayoutPanelIngredientsButtons.Size = new Size(237, 77);
            flowLayoutPanelIngredientsButtons.TabIndex = 2;
            // 
            // buttonRefreshIngredient
            // 
            buttonRefreshIngredient.Location = new Point(3, 3);
            buttonRefreshIngredient.Name = "buttonRefreshIngredient";
            buttonRefreshIngredient.Size = new Size(75, 23);
            buttonRefreshIngredient.TabIndex = 0;
            buttonRefreshIngredient.Text = "Actualiser";
            buttonRefreshIngredient.UseVisualStyleBackColor = true;
            // 
            // buttonAddIngredient
            // 
            buttonAddIngredient.Location = new Point(84, 3);
            buttonAddIngredient.Name = "buttonAddIngredient";
            buttonAddIngredient.Size = new Size(75, 23);
            buttonAddIngredient.TabIndex = 1;
            buttonAddIngredient.Text = "Ajouter";
            buttonAddIngredient.UseVisualStyleBackColor = true;
            // 
            // buttonModifyIngredient
            // 
            buttonModifyIngredient.Location = new Point(3, 32);
            buttonModifyIngredient.Name = "buttonModifyIngredient";
            buttonModifyIngredient.Size = new Size(75, 23);
            buttonModifyIngredient.TabIndex = 2;
            buttonModifyIngredient.Text = "Modifier";
            buttonModifyIngredient.UseVisualStyleBackColor = true;
            // 
            // buttonRemoveIngredient
            // 
            buttonRemoveIngredient.Location = new Point(84, 32);
            buttonRemoveIngredient.Name = "buttonRemoveIngredient";
            buttonRemoveIngredient.Size = new Size(75, 23);
            buttonRemoveIngredient.TabIndex = 3;
            buttonRemoveIngredient.Text = "Supprimer";
            buttonRemoveIngredient.UseVisualStyleBackColor = true;
            // 
            // FormManageIngredients
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelFormManageIngredients);
            Name = "FormManageIngredients";
            Text = "FormManageIngredients";
            panelFormManageIngredients.ResumeLayout(false);
            tableLayoutPanelFormManageIngredients.ResumeLayout(false);
            tableLayoutPanelManageIngredients.ResumeLayout(false);
            tableLayoutPanelRecipesAndIngredientsInThem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewRecipes).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewIngredientsOfRecette).EndInit();
            tableLayoutPanelIngredientsManagement.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewRecipesWithoutTheIngredient).EndInit();
            tableLayoutPanelQuantityInputs.ResumeLayout(false);
            tableLayoutPanelQuantityInputs.PerformLayout();
            flowLayoutPanelButtonModify.ResumeLayout(false);
            tableLayoutPanelIngredients.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewIngredients).EndInit();
            tableLayoutPanelIngredientsInputs.ResumeLayout(false);
            tableLayoutPanelIngredientsInputs.PerformLayout();
            flowLayoutPanelIngredientsButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)bindingSourceIngredients).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelFormManageIngredients;
        private TableLayoutPanel tableLayoutPanelFormManageIngredients;
        private TableLayoutPanel tableLayoutPanelManageIngredients;
        private TableLayoutPanel tableLayoutPanelIngredients;
        private TableLayoutPanel tableLayoutPanelRecipesAndIngredientsInThem;
        private DataGridView dataGridViewRecipes;
        private DataGridView dataGridViewIngredientsOfRecette;
        private BindingSource bindingSourceIngredients;
        private DataGridView dataGridViewRecipesWithoutTheIngredient;
        private Button buttonAddIngredientToRecette;
        private Button buttonRemoveIngredientFromRecette;
        private DataGridView dataGridViewIngredients;
        private TableLayoutPanel tableLayoutPanelIngredientsInputs;
        private FlowLayoutPanel flowLayoutPanelIngredientsButtons;
        private TableLayoutPanel tableLayoutPanelIngredientsManagement;
        private TableLayoutPanel tableLayoutPanelQuantityInputs;
        private FlowLayoutPanel flowLayoutPanelButtonModify;
        private Button buttonModifyQuantityIngredient;
        private Label labelNomIngredient;
        private TextBox textBoxNomIngredient;
        private Label labelModifyQuantity;
        private TextBox textBoxModifyQuantity;
        private Button buttonRefreshIngredient;
        private Button buttonAddIngredient;
        private Button buttonModifyIngredient;
        private Button buttonRemoveIngredient;
    }
}