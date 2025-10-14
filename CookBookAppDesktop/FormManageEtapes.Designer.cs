namespace CookBookAppDesktop
{
    partial class FormManageEtapes
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
            tableLayoutPanelFormManageEtapes = new TableLayoutPanel();
            tableLayoutPanelManageEtapes = new TableLayoutPanel();
            tableLayoutPanelManageEtapesInputs = new TableLayoutPanel();
            tableLayoutPanelInputs = new TableLayoutPanel();
            labelTitre = new Label();
            labelDescription = new Label();
            textBoxDescription = new TextBox();
            numericUpDownTitre = new NumericUpDown();
            flowLayoutPanelButtons = new FlowLayoutPanel();
            buttonAdd = new Button();
            buttonModify = new Button();
            buttonRemove = new Button();
            dataGridViewEtapes = new DataGridView();
            tableLayoutPanelManageEtapesRecettes = new TableLayoutPanel();
            dataGridViewRecettesForEtapes = new DataGridView();
            buttonRefresh = new Button();
            bindingSourceEtapes = new BindingSource(components);
            bindingSourceRecettes = new BindingSource(components);
            labelRecettes = new Label();
            labelEtapes = new Label();
            tableLayoutPanelFormManageEtapes.SuspendLayout();
            tableLayoutPanelManageEtapes.SuspendLayout();
            tableLayoutPanelManageEtapesInputs.SuspendLayout();
            tableLayoutPanelInputs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownTitre).BeginInit();
            flowLayoutPanelButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEtapes).BeginInit();
            tableLayoutPanelManageEtapesRecettes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRecettesForEtapes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceEtapes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceRecettes).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanelFormManageEtapes
            // 
            tableLayoutPanelFormManageEtapes.ColumnCount = 2;
            tableLayoutPanelFormManageEtapes.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelFormManageEtapes.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelFormManageEtapes.Controls.Add(tableLayoutPanelManageEtapes, 0, 0);
            tableLayoutPanelFormManageEtapes.Controls.Add(tableLayoutPanelManageEtapesRecettes, 1, 0);
            tableLayoutPanelFormManageEtapes.Dock = DockStyle.Fill;
            tableLayoutPanelFormManageEtapes.Location = new Point(0, 0);
            tableLayoutPanelFormManageEtapes.Name = "tableLayoutPanelFormManageEtapes";
            tableLayoutPanelFormManageEtapes.RowCount = 1;
            tableLayoutPanelFormManageEtapes.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelFormManageEtapes.Size = new Size(800, 450);
            tableLayoutPanelFormManageEtapes.TabIndex = 0;
            // 
            // tableLayoutPanelManageEtapes
            // 
            tableLayoutPanelManageEtapes.ColumnCount = 1;
            tableLayoutPanelManageEtapes.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelManageEtapes.Controls.Add(tableLayoutPanelManageEtapesInputs, 0, 2);
            tableLayoutPanelManageEtapes.Controls.Add(dataGridViewEtapes, 0, 1);
            tableLayoutPanelManageEtapes.Controls.Add(labelEtapes, 0, 0);
            tableLayoutPanelManageEtapes.Dock = DockStyle.Fill;
            tableLayoutPanelManageEtapes.Location = new Point(3, 3);
            tableLayoutPanelManageEtapes.Name = "tableLayoutPanelManageEtapes";
            tableLayoutPanelManageEtapes.RowCount = 3;
            tableLayoutPanelManageEtapes.RowStyles.Add(new RowStyle());
            tableLayoutPanelManageEtapes.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelManageEtapes.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelManageEtapes.Size = new Size(394, 444);
            tableLayoutPanelManageEtapes.TabIndex = 0;
            // 
            // tableLayoutPanelManageEtapesInputs
            // 
            tableLayoutPanelManageEtapesInputs.ColumnCount = 1;
            tableLayoutPanelManageEtapesInputs.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelManageEtapesInputs.Controls.Add(tableLayoutPanelInputs, 0, 0);
            tableLayoutPanelManageEtapesInputs.Controls.Add(flowLayoutPanelButtons, 0, 1);
            tableLayoutPanelManageEtapesInputs.Dock = DockStyle.Fill;
            tableLayoutPanelManageEtapesInputs.Location = new Point(3, 232);
            tableLayoutPanelManageEtapesInputs.Name = "tableLayoutPanelManageEtapesInputs";
            tableLayoutPanelManageEtapesInputs.RowCount = 2;
            tableLayoutPanelManageEtapesInputs.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelManageEtapesInputs.RowStyles.Add(new RowStyle());
            tableLayoutPanelManageEtapesInputs.Size = new Size(388, 209);
            tableLayoutPanelManageEtapesInputs.TabIndex = 0;
            // 
            // tableLayoutPanelInputs
            // 
            tableLayoutPanelInputs.ColumnCount = 2;
            tableLayoutPanelInputs.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanelInputs.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelInputs.Controls.Add(labelTitre, 0, 0);
            tableLayoutPanelInputs.Controls.Add(labelDescription, 0, 1);
            tableLayoutPanelInputs.Controls.Add(textBoxDescription, 1, 1);
            tableLayoutPanelInputs.Controls.Add(numericUpDownTitre, 1, 0);
            tableLayoutPanelInputs.Dock = DockStyle.Fill;
            tableLayoutPanelInputs.Location = new Point(3, 3);
            tableLayoutPanelInputs.Name = "tableLayoutPanelInputs";
            tableLayoutPanelInputs.RowCount = 2;
            tableLayoutPanelInputs.RowStyles.Add(new RowStyle());
            tableLayoutPanelInputs.RowStyles.Add(new RowStyle());
            tableLayoutPanelInputs.Size = new Size(382, 95);
            tableLayoutPanelInputs.TabIndex = 0;
            // 
            // labelTitre
            // 
            labelTitre.AutoSize = true;
            labelTitre.Dock = DockStyle.Fill;
            labelTitre.Location = new Point(3, 0);
            labelTitre.Name = "labelTitre";
            labelTitre.Size = new Size(57, 29);
            labelTitre.TabIndex = 0;
            labelTitre.Text = "Numéro :";
            // 
            // labelDescription
            // 
            labelDescription.AutoSize = true;
            labelDescription.Dock = DockStyle.Fill;
            labelDescription.Location = new Point(3, 29);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(57, 73);
            labelDescription.TabIndex = 1;
            labelDescription.Text = "Texte :";
            // 
            // textBoxDescription
            // 
            textBoxDescription.Dock = DockStyle.Fill;
            textBoxDescription.Location = new Point(66, 32);
            textBoxDescription.Multiline = true;
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(313, 67);
            textBoxDescription.TabIndex = 3;
            // 
            // numericUpDownTitre
            // 
            numericUpDownTitre.Dock = DockStyle.Fill;
            numericUpDownTitre.Location = new Point(66, 3);
            numericUpDownTitre.Name = "numericUpDownTitre";
            numericUpDownTitre.Size = new Size(313, 23);
            numericUpDownTitre.TabIndex = 4;
            // 
            // flowLayoutPanelButtons
            // 
            flowLayoutPanelButtons.Controls.Add(buttonAdd);
            flowLayoutPanelButtons.Controls.Add(buttonModify);
            flowLayoutPanelButtons.Controls.Add(buttonRemove);
            flowLayoutPanelButtons.Dock = DockStyle.Fill;
            flowLayoutPanelButtons.Location = new Point(3, 104);
            flowLayoutPanelButtons.Name = "flowLayoutPanelButtons";
            flowLayoutPanelButtons.Size = new Size(382, 102);
            flowLayoutPanelButtons.TabIndex = 1;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(3, 3);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(75, 23);
            buttonAdd.TabIndex = 0;
            buttonAdd.Text = "Ajouter";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonModify
            // 
            buttonModify.Location = new Point(84, 3);
            buttonModify.Name = "buttonModify";
            buttonModify.Size = new Size(75, 23);
            buttonModify.TabIndex = 1;
            buttonModify.Text = "Modifier";
            buttonModify.UseVisualStyleBackColor = true;
            buttonModify.Click += buttonModify_Click;
            // 
            // buttonRemove
            // 
            buttonRemove.Location = new Point(165, 3);
            buttonRemove.Name = "buttonRemove";
            buttonRemove.Size = new Size(74, 23);
            buttonRemove.TabIndex = 2;
            buttonRemove.Text = "Supprimer";
            buttonRemove.UseVisualStyleBackColor = true;
            buttonRemove.Click += buttonDelete_Click;
            // 
            // dataGridViewEtapes
            // 
            dataGridViewEtapes.AllowUserToAddRows = false;
            dataGridViewEtapes.AllowUserToDeleteRows = false;
            dataGridViewEtapes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEtapes.Dock = DockStyle.Fill;
            dataGridViewEtapes.Location = new Point(3, 18);
            dataGridViewEtapes.Name = "dataGridViewEtapes";
            dataGridViewEtapes.ReadOnly = true;
            dataGridViewEtapes.Size = new Size(388, 208);
            dataGridViewEtapes.TabIndex = 1;
            // 
            // tableLayoutPanelManageEtapesRecettes
            // 
            tableLayoutPanelManageEtapesRecettes.ColumnCount = 1;
            tableLayoutPanelManageEtapesRecettes.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelManageEtapesRecettes.Controls.Add(dataGridViewRecettesForEtapes, 0, 1);
            tableLayoutPanelManageEtapesRecettes.Controls.Add(buttonRefresh, 0, 2);
            tableLayoutPanelManageEtapesRecettes.Controls.Add(labelRecettes, 0, 0);
            tableLayoutPanelManageEtapesRecettes.Dock = DockStyle.Fill;
            tableLayoutPanelManageEtapesRecettes.Location = new Point(403, 3);
            tableLayoutPanelManageEtapesRecettes.Name = "tableLayoutPanelManageEtapesRecettes";
            tableLayoutPanelManageEtapesRecettes.RowCount = 3;
            tableLayoutPanelManageEtapesRecettes.RowStyles.Add(new RowStyle());
            tableLayoutPanelManageEtapesRecettes.RowStyles.Add(new RowStyle(SizeType.Percent, 85F));
            tableLayoutPanelManageEtapesRecettes.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanelManageEtapesRecettes.Size = new Size(394, 444);
            tableLayoutPanelManageEtapesRecettes.TabIndex = 1;
            // 
            // dataGridViewRecettesForEtapes
            // 
            dataGridViewRecettesForEtapes.AllowUserToAddRows = false;
            dataGridViewRecettesForEtapes.AllowUserToDeleteRows = false;
            dataGridViewRecettesForEtapes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRecettesForEtapes.Dock = DockStyle.Fill;
            dataGridViewRecettesForEtapes.Location = new Point(3, 18);
            dataGridViewRecettesForEtapes.Name = "dataGridViewRecettesForEtapes";
            dataGridViewRecettesForEtapes.ReadOnly = true;
            dataGridViewRecettesForEtapes.Size = new Size(388, 358);
            dataGridViewRecettesForEtapes.TabIndex = 0;
            dataGridViewRecettesForEtapes.CurrentCellChanged += dataGridViewRecettesForEtapes_SelectionChanged;
            // 
            // buttonRefresh
            // 
            buttonRefresh.Dock = DockStyle.Fill;
            buttonRefresh.Location = new Point(3, 382);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new Size(388, 59);
            buttonRefresh.TabIndex = 1;
            buttonRefresh.Text = "Actualiser";
            buttonRefresh.UseVisualStyleBackColor = true;
            buttonRefresh.Click += buttonRefresh_Click;
            // 
            // labelRecettes
            // 
            labelRecettes.AutoSize = true;
            labelRecettes.Dock = DockStyle.Fill;
            labelRecettes.Location = new Point(3, 0);
            labelRecettes.Name = "labelRecettes";
            labelRecettes.Size = new Size(388, 15);
            labelRecettes.TabIndex = 2;
            labelRecettes.Text = "Recettes";
            // 
            // labelEtapes
            // 
            labelEtapes.AutoSize = true;
            labelEtapes.Dock = DockStyle.Fill;
            labelEtapes.Location = new Point(3, 0);
            labelEtapes.Name = "labelEtapes";
            labelEtapes.Size = new Size(388, 15);
            labelEtapes.TabIndex = 2;
            labelEtapes.Text = "Etapes";
            // 
            // FormManageEtapes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanelFormManageEtapes);
            Name = "FormManageEtapes";
            Text = "FormManageEtapes";
            Load += FormManageEtapes_Load;
            tableLayoutPanelFormManageEtapes.ResumeLayout(false);
            tableLayoutPanelManageEtapes.ResumeLayout(false);
            tableLayoutPanelManageEtapes.PerformLayout();
            tableLayoutPanelManageEtapesInputs.ResumeLayout(false);
            tableLayoutPanelInputs.ResumeLayout(false);
            tableLayoutPanelInputs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownTitre).EndInit();
            flowLayoutPanelButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewEtapes).EndInit();
            tableLayoutPanelManageEtapesRecettes.ResumeLayout(false);
            tableLayoutPanelManageEtapesRecettes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRecettesForEtapes).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceEtapes).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceRecettes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanelFormManageEtapes;
        private TableLayoutPanel tableLayoutPanelManageEtapes;
        private TableLayoutPanel tableLayoutPanelManageEtapesInputs;
        private DataGridView dataGridViewEtapes;
        private BindingSource bindingSourceEtapes;
        private TableLayoutPanel tableLayoutPanelInputs;
        private Label labelTitre;
        private Label labelDescription;
        private TextBox textBoxDescription;
        private FlowLayoutPanel flowLayoutPanelButtons;
        private Button buttonAdd;
        private Button buttonModify;
        private Button buttonRemove;
        private NumericUpDown numericUpDownTitre;
        private TableLayoutPanel tableLayoutPanelManageEtapesRecettes;
        private DataGridView dataGridViewRecettesForEtapes;
        private Button buttonRefresh;
        private BindingSource bindingSourceRecettes;
        private Label labelRecettes;
        private Label labelEtapes;
    }
}