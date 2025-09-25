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
            textBoxTitre = new TextBox();
            textBoxDescription = new TextBox();
            flowLayoutPanelButtons = new FlowLayoutPanel();
            buttonAdd = new Button();
            buttonModify = new Button();
            buttonRemove = new Button();
            dataGridViewEtapes = new DataGridView();
            bindingSourceEtapes = new BindingSource(components);
            tableLayoutPanelFormManageEtapes.SuspendLayout();
            tableLayoutPanelManageEtapes.SuspendLayout();
            tableLayoutPanelManageEtapesInputs.SuspendLayout();
            tableLayoutPanelInputs.SuspendLayout();
            flowLayoutPanelButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEtapes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceEtapes).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanelFormManageEtapes
            // 
            tableLayoutPanelFormManageEtapes.ColumnCount = 1;
            tableLayoutPanelFormManageEtapes.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelFormManageEtapes.Controls.Add(tableLayoutPanelManageEtapes, 0, 0);
            tableLayoutPanelFormManageEtapes.Dock = DockStyle.Fill;
            tableLayoutPanelFormManageEtapes.Location = new Point(0, 0);
            tableLayoutPanelFormManageEtapes.Name = "tableLayoutPanelFormManageEtapes";
            tableLayoutPanelFormManageEtapes.RowCount = 1;
            tableLayoutPanelFormManageEtapes.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelFormManageEtapes.Size = new Size(800, 450);
            tableLayoutPanelFormManageEtapes.TabIndex = 0;
            // 
            // tableLayoutPanelManageEtapes
            // 
            tableLayoutPanelManageEtapes.ColumnCount = 1;
            tableLayoutPanelManageEtapes.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelManageEtapes.Controls.Add(tableLayoutPanelManageEtapesInputs, 0, 1);
            tableLayoutPanelManageEtapes.Controls.Add(dataGridViewEtapes, 0, 0);
            tableLayoutPanelManageEtapes.Dock = DockStyle.Fill;
            tableLayoutPanelManageEtapes.Location = new Point(3, 3);
            tableLayoutPanelManageEtapes.Name = "tableLayoutPanelManageEtapes";
            tableLayoutPanelManageEtapes.RowCount = 2;
            tableLayoutPanelManageEtapes.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelManageEtapes.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelManageEtapes.Size = new Size(794, 444);
            tableLayoutPanelManageEtapes.TabIndex = 0;
            // 
            // tableLayoutPanelManageEtapesInputs
            // 
            tableLayoutPanelManageEtapesInputs.ColumnCount = 1;
            tableLayoutPanelManageEtapesInputs.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelManageEtapesInputs.Controls.Add(tableLayoutPanelInputs, 0, 0);
            tableLayoutPanelManageEtapesInputs.Controls.Add(flowLayoutPanelButtons, 0, 1);
            tableLayoutPanelManageEtapesInputs.Dock = DockStyle.Fill;
            tableLayoutPanelManageEtapesInputs.Location = new Point(3, 225);
            tableLayoutPanelManageEtapesInputs.Name = "tableLayoutPanelManageEtapesInputs";
            tableLayoutPanelManageEtapesInputs.RowCount = 2;
            tableLayoutPanelManageEtapesInputs.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelManageEtapesInputs.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelManageEtapesInputs.Size = new Size(788, 216);
            tableLayoutPanelManageEtapesInputs.TabIndex = 0;
            // 
            // tableLayoutPanelInputs
            // 
            tableLayoutPanelInputs.ColumnCount = 2;
            tableLayoutPanelInputs.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelInputs.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelInputs.Controls.Add(labelTitre, 0, 0);
            tableLayoutPanelInputs.Controls.Add(labelDescription, 0, 1);
            tableLayoutPanelInputs.Controls.Add(textBoxTitre, 1, 0);
            tableLayoutPanelInputs.Controls.Add(textBoxDescription, 1, 1);
            tableLayoutPanelInputs.Dock = DockStyle.Fill;
            tableLayoutPanelInputs.Location = new Point(3, 3);
            tableLayoutPanelInputs.Name = "tableLayoutPanelInputs";
            tableLayoutPanelInputs.RowCount = 2;
            tableLayoutPanelInputs.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelInputs.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelInputs.Size = new Size(782, 102);
            tableLayoutPanelInputs.TabIndex = 0;
            // 
            // labelTitre
            // 
            labelTitre.AutoSize = true;
            labelTitre.Dock = DockStyle.Fill;
            labelTitre.Location = new Point(3, 0);
            labelTitre.Name = "labelTitre";
            labelTitre.Size = new Size(385, 51);
            labelTitre.TabIndex = 0;
            labelTitre.Text = "label1";
            // 
            // labelDescription
            // 
            labelDescription.AutoSize = true;
            labelDescription.Dock = DockStyle.Fill;
            labelDescription.Location = new Point(3, 51);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(385, 51);
            labelDescription.TabIndex = 1;
            labelDescription.Text = "label2";
            // 
            // textBoxTitre
            // 
            textBoxTitre.Dock = DockStyle.Fill;
            textBoxTitre.Location = new Point(394, 3);
            textBoxTitre.Name = "textBoxTitre";
            textBoxTitre.Size = new Size(385, 23);
            textBoxTitre.TabIndex = 2;
            // 
            // textBoxDescription
            // 
            textBoxDescription.Dock = DockStyle.Fill;
            textBoxDescription.Location = new Point(394, 54);
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(385, 23);
            textBoxDescription.TabIndex = 3;
            // 
            // flowLayoutPanelButtons
            // 
            flowLayoutPanelButtons.Controls.Add(buttonAdd);
            flowLayoutPanelButtons.Controls.Add(buttonModify);
            flowLayoutPanelButtons.Controls.Add(buttonRemove);
            flowLayoutPanelButtons.Dock = DockStyle.Fill;
            flowLayoutPanelButtons.Location = new Point(3, 111);
            flowLayoutPanelButtons.Name = "flowLayoutPanelButtons";
            flowLayoutPanelButtons.Size = new Size(782, 102);
            flowLayoutPanelButtons.TabIndex = 1;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(3, 3);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(75, 23);
            buttonAdd.TabIndex = 0;
            buttonAdd.Text = "button1";
            buttonAdd.UseVisualStyleBackColor = true;
            // 
            // buttonModify
            // 
            buttonModify.Location = new Point(84, 3);
            buttonModify.Name = "buttonModify";
            buttonModify.Size = new Size(75, 23);
            buttonModify.TabIndex = 1;
            buttonModify.Text = "button2";
            buttonModify.UseVisualStyleBackColor = true;
            // 
            // buttonRemove
            // 
            buttonRemove.Location = new Point(165, 3);
            buttonRemove.Name = "buttonRemove";
            buttonRemove.Size = new Size(74, 23);
            buttonRemove.TabIndex = 2;
            buttonRemove.Text = "button3";
            buttonRemove.UseVisualStyleBackColor = true;
            // 
            // dataGridViewEtapes
            // 
            dataGridViewEtapes.AllowUserToAddRows = false;
            dataGridViewEtapes.AllowUserToDeleteRows = false;
            dataGridViewEtapes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEtapes.Dock = DockStyle.Fill;
            dataGridViewEtapes.Location = new Point(3, 3);
            dataGridViewEtapes.Name = "dataGridViewEtapes";
            dataGridViewEtapes.ReadOnly = true;
            dataGridViewEtapes.Size = new Size(788, 216);
            dataGridViewEtapes.TabIndex = 1;
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
            tableLayoutPanelManageEtapesInputs.ResumeLayout(false);
            tableLayoutPanelInputs.ResumeLayout(false);
            tableLayoutPanelInputs.PerformLayout();
            flowLayoutPanelButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewEtapes).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceEtapes).EndInit();
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
        private TextBox textBoxTitre;
        private TextBox textBoxDescription;
        private FlowLayoutPanel flowLayoutPanelButtons;
        private Button buttonAdd;
        private Button buttonModify;
        private Button buttonRemove;
    }
}