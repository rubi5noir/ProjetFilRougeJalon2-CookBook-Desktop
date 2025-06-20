namespace ProjetFilRougeJalon2
{
    partial class formMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMain));
            tableLayoutPanelMain = new TableLayoutPanel();
            tableLayoutPanelHeader = new TableLayoutPanel();
            tableLayoutPanelMyRecipes = new TableLayoutPanel();
            tableLayoutPanelCategories = new TableLayoutPanel();
            tableLayoutPanelRecipes = new TableLayoutPanel();
            tableLayoutPanelBody = new TableLayoutPanel();
            tableLayoutPanelFooter = new TableLayoutPanel();
            tableLayoutPanelResearch = new TableLayoutPanel();
            textBoxResearch = new TextBox();
            buttonResearch = new Button();
            buttonAccount = new Button();
            labelMyRecipes = new Label();
            labelCategories = new Label();
            labelRecipes = new Label();
            tableLayoutPanelMain.SuspendLayout();
            tableLayoutPanelHeader.SuspendLayout();
            tableLayoutPanelMyRecipes.SuspendLayout();
            tableLayoutPanelCategories.SuspendLayout();
            tableLayoutPanelRecipes.SuspendLayout();
            tableLayoutPanelBody.SuspendLayout();
            tableLayoutPanelResearch.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanelMain
            // 
            tableLayoutPanelMain.ColumnCount = 1;
            tableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelMain.Controls.Add(tableLayoutPanelHeader, 0, 0);
            tableLayoutPanelMain.Controls.Add(tableLayoutPanelBody, 0, 1);
            tableLayoutPanelMain.Controls.Add(tableLayoutPanelFooter, 0, 2);
            tableLayoutPanelMain.Dock = DockStyle.Fill;
            tableLayoutPanelMain.Location = new Point(0, 0);
            tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            tableLayoutPanelMain.RowCount = 3;
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 75F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanelMain.Size = new Size(874, 511);
            tableLayoutPanelMain.TabIndex = 0;
            // 
            // tableLayoutPanelHeader
            // 
            tableLayoutPanelHeader.ColumnCount = 3;
            tableLayoutPanelHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanelHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F));
            tableLayoutPanelHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanelHeader.Controls.Add(tableLayoutPanelResearch, 1, 0);
            tableLayoutPanelHeader.Controls.Add(buttonAccount, 2, 0);
            tableLayoutPanelHeader.Dock = DockStyle.Fill;
            tableLayoutPanelHeader.Location = new Point(3, 3);
            tableLayoutPanelHeader.Name = "tableLayoutPanelHeader";
            tableLayoutPanelHeader.RowCount = 1;
            tableLayoutPanelHeader.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelHeader.Size = new Size(868, 70);
            tableLayoutPanelHeader.TabIndex = 1;
            // 
            // tableLayoutPanelMyRecipes
            // 
            tableLayoutPanelMyRecipes.ColumnCount = 1;
            tableLayoutPanelMyRecipes.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelMyRecipes.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanelMyRecipes.Controls.Add(labelMyRecipes, 0, 0);
            tableLayoutPanelMyRecipes.Dock = DockStyle.Fill;
            tableLayoutPanelMyRecipes.Location = new Point(3, 3);
            tableLayoutPanelMyRecipes.Name = "tableLayoutPanelMyRecipes";
            tableLayoutPanelMyRecipes.RowCount = 2;
            tableLayoutPanelMyRecipes.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelMyRecipes.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelMyRecipes.Size = new Size(862, 119);
            tableLayoutPanelMyRecipes.TabIndex = 2;
            // 
            // tableLayoutPanelCategories
            // 
            tableLayoutPanelCategories.ColumnCount = 1;
            tableLayoutPanelCategories.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelCategories.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanelCategories.Controls.Add(labelCategories, 0, 0);
            tableLayoutPanelCategories.Dock = DockStyle.Fill;
            tableLayoutPanelCategories.Location = new Point(3, 128);
            tableLayoutPanelCategories.Name = "tableLayoutPanelCategories";
            tableLayoutPanelCategories.RowCount = 2;
            tableLayoutPanelCategories.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelCategories.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelCategories.Size = new Size(862, 119);
            tableLayoutPanelCategories.TabIndex = 3;
            // 
            // tableLayoutPanelRecipes
            // 
            tableLayoutPanelRecipes.ColumnCount = 1;
            tableLayoutPanelRecipes.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelRecipes.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanelRecipes.Controls.Add(labelRecipes, 0, 0);
            tableLayoutPanelRecipes.Dock = DockStyle.Fill;
            tableLayoutPanelRecipes.Location = new Point(3, 253);
            tableLayoutPanelRecipes.Name = "tableLayoutPanelRecipes";
            tableLayoutPanelRecipes.RowCount = 2;
            tableLayoutPanelRecipes.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelRecipes.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelRecipes.Size = new Size(862, 121);
            tableLayoutPanelRecipes.TabIndex = 4;
            // 
            // tableLayoutPanelBody
            // 
            tableLayoutPanelBody.ColumnCount = 1;
            tableLayoutPanelBody.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelBody.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanelBody.Controls.Add(tableLayoutPanelMyRecipes, 0, 0);
            tableLayoutPanelBody.Controls.Add(tableLayoutPanelCategories, 0, 1);
            tableLayoutPanelBody.Controls.Add(tableLayoutPanelRecipes, 0, 2);
            tableLayoutPanelBody.Dock = DockStyle.Fill;
            tableLayoutPanelBody.Location = new Point(3, 79);
            tableLayoutPanelBody.Name = "tableLayoutPanelBody";
            tableLayoutPanelBody.RowCount = 3;
            tableLayoutPanelBody.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanelBody.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanelBody.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanelBody.Size = new Size(868, 377);
            tableLayoutPanelBody.TabIndex = 5;
            // 
            // tableLayoutPanelFooter
            // 
            tableLayoutPanelFooter.ColumnCount = 2;
            tableLayoutPanelFooter.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelFooter.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelFooter.Dock = DockStyle.Fill;
            tableLayoutPanelFooter.Location = new Point(3, 462);
            tableLayoutPanelFooter.Name = "tableLayoutPanelFooter";
            tableLayoutPanelFooter.RowCount = 2;
            tableLayoutPanelFooter.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelFooter.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelFooter.Size = new Size(868, 46);
            tableLayoutPanelFooter.TabIndex = 6;
            // 
            // tableLayoutPanelResearch
            // 
            tableLayoutPanelResearch.ColumnCount = 2;
            tableLayoutPanelResearch.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F));
            tableLayoutPanelResearch.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanelResearch.Controls.Add(textBoxResearch, 0, 0);
            tableLayoutPanelResearch.Controls.Add(buttonResearch, 1, 0);
            tableLayoutPanelResearch.Dock = DockStyle.Fill;
            tableLayoutPanelResearch.Location = new Point(133, 3);
            tableLayoutPanelResearch.Name = "tableLayoutPanelResearch";
            tableLayoutPanelResearch.RowCount = 1;
            tableLayoutPanelResearch.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelResearch.Size = new Size(645, 64);
            tableLayoutPanelResearch.TabIndex = 0;
            // 
            // textBoxResearch
            // 
            textBoxResearch.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxResearch.Location = new Point(5, 20);
            textBoxResearch.Margin = new Padding(5, 20, 5, 20);
            textBoxResearch.Name = "textBoxResearch";
            textBoxResearch.PlaceholderText = "Rechercher une recette...";
            textBoxResearch.Size = new Size(473, 23);
            textBoxResearch.TabIndex = 0;
            // 
            // buttonResearch
            // 
            buttonResearch.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonResearch.AutoSize = true;
            buttonResearch.Location = new Point(503, 20);
            buttonResearch.Margin = new Padding(20);
            buttonResearch.Name = "buttonResearch";
            buttonResearch.Size = new Size(122, 24);
            buttonResearch.TabIndex = 1;
            buttonResearch.Text = "Rechercher";
            buttonResearch.UseVisualStyleBackColor = true;
            // 
            // buttonAccount
            // 
            buttonAccount.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonAccount.AutoSize = true;
            buttonAccount.BackColor = Color.Transparent;
            buttonAccount.Cursor = Cursors.Hand;
            buttonAccount.Image = (Image)resources.GetObject("buttonAccount.Image");
            buttonAccount.Location = new Point(801, 15);
            buttonAccount.Margin = new Padding(20, 15, 20, 15);
            buttonAccount.Name = "buttonAccount";
            buttonAccount.Size = new Size(47, 40);
            buttonAccount.TabIndex = 1;
            buttonAccount.UseVisualStyleBackColor = false;
            // 
            // labelMyRecipes
            // 
            labelMyRecipes.AutoSize = true;
            labelMyRecipes.BackColor = Color.DarkGray;
            labelMyRecipes.BorderStyle = BorderStyle.FixedSingle;
            labelMyRecipes.Dock = DockStyle.Fill;
            labelMyRecipes.Font = new Font("Calibri", 35F, FontStyle.Bold);
            labelMyRecipes.Location = new Point(3, 0);
            labelMyRecipes.Name = "labelMyRecipes";
            labelMyRecipes.Size = new Size(856, 59);
            labelMyRecipes.TabIndex = 0;
            labelMyRecipes.Text = "Mes Recettes";
            // 
            // labelCategories
            // 
            labelCategories.AutoSize = true;
            labelCategories.BackColor = Color.DarkGray;
            labelCategories.BorderStyle = BorderStyle.FixedSingle;
            labelCategories.Dock = DockStyle.Fill;
            labelCategories.Font = new Font("Calibri", 35.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCategories.Location = new Point(3, 0);
            labelCategories.Name = "labelCategories";
            labelCategories.Size = new Size(856, 59);
            labelCategories.TabIndex = 0;
            labelCategories.Text = "Categories";
            // 
            // labelRecipes
            // 
            labelRecipes.AutoSize = true;
            labelRecipes.BackColor = Color.DarkGray;
            labelRecipes.BorderStyle = BorderStyle.FixedSingle;
            labelRecipes.Dock = DockStyle.Fill;
            labelRecipes.Font = new Font("Calibri", 35.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelRecipes.Location = new Point(3, 0);
            labelRecipes.Name = "labelRecipes";
            labelRecipes.Size = new Size(856, 60);
            labelRecipes.TabIndex = 0;
            labelRecipes.Text = "Recettes";
            // 
            // formMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(874, 511);
            Controls.Add(tableLayoutPanelMain);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "formMain";
            Text = "CookBook";
            tableLayoutPanelMain.ResumeLayout(false);
            tableLayoutPanelHeader.ResumeLayout(false);
            tableLayoutPanelHeader.PerformLayout();
            tableLayoutPanelMyRecipes.ResumeLayout(false);
            tableLayoutPanelMyRecipes.PerformLayout();
            tableLayoutPanelCategories.ResumeLayout(false);
            tableLayoutPanelCategories.PerformLayout();
            tableLayoutPanelRecipes.ResumeLayout(false);
            tableLayoutPanelRecipes.PerformLayout();
            tableLayoutPanelBody.ResumeLayout(false);
            tableLayoutPanelResearch.ResumeLayout(false);
            tableLayoutPanelResearch.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanelMain;
        private TableLayoutPanel tableLayoutPanelHeader;
        private TableLayoutPanel tableLayoutPanelFooter;
        private TableLayoutPanel tableLayoutPanelMyRecipes;
        private TableLayoutPanel tableLayoutPanelCategories;
        private TableLayoutPanel tableLayoutPanelRecipes;
        private TableLayoutPanel tableLayoutPanelBody;
        private TableLayoutPanel tableLayoutPanelResearch;
        private TextBox textBoxResearch;
        private Button buttonResearch;
        private Button buttonAccount;
        private Label labelMyRecipes;
        private Label labelCategories;
        private Label labelRecipes;
    }
}
