namespace CookBookAppDesktop
{
    partial class FormRecetteDetails
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
            panelFormRecetteDetails = new Panel();
            tableLayoutPanelFormRecetteDetails = new TableLayoutPanel();
            tableLayoutPanelRecetteSummary = new TableLayoutPanel();
            labelNomRecette = new Label();
            textBoxDecriptionRecette = new TextBox();
            pictureBoxImgRecette = new PictureBox();
            tableLayoutPanelRightPartDetails = new TableLayoutPanel();
            labelCreateur = new Label();
            tableLayoutPanelTempsIngredients = new TableLayoutPanel();
            tableLayoutPanelTemps = new TableLayoutPanel();
            labelTitreTempsPrepa = new Label();
            labelTempsPrepa = new Label();
            labelTitreTempsCui = new Label();
            labelTempsCui = new Label();
            labelTitreTempsTotal = new Label();
            labelTempsTotal = new Label();
            ScrollPanel = new Panel();
            tableLayoutPanelIngredients = new TableLayoutPanel();
            labelIngredient = new Label();
            labelQuantite = new Label();
            tableLayoutPanelCategories = new TableLayoutPanel();
            labelCategorie = new Label();
            tableLayoutPanelLeftPartDetails = new TableLayoutPanel();
            tableLayoutPanelEtapes = new TableLayoutPanel();
            labelEtape = new Label();
            textBoxEtape = new TextBox();
            labelNoteMoyenne = new Label();
            tableLayoutPanelAvis = new TableLayoutPanel();
            labelUtilisateur = new Label();
            labelNote = new Label();
            textBoxAvis = new TextBox();
            panelFormRecetteDetails.SuspendLayout();
            tableLayoutPanelFormRecetteDetails.SuspendLayout();
            tableLayoutPanelRecetteSummary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImgRecette).BeginInit();
            tableLayoutPanelRightPartDetails.SuspendLayout();
            tableLayoutPanelTempsIngredients.SuspendLayout();
            tableLayoutPanelTemps.SuspendLayout();
            ScrollPanel.SuspendLayout();
            tableLayoutPanelIngredients.SuspendLayout();
            tableLayoutPanelCategories.SuspendLayout();
            tableLayoutPanelLeftPartDetails.SuspendLayout();
            tableLayoutPanelEtapes.SuspendLayout();
            tableLayoutPanelAvis.SuspendLayout();
            SuspendLayout();
            // 
            // panelFormRecetteDetails
            // 
            panelFormRecetteDetails.AutoScroll = true;
            panelFormRecetteDetails.AutoSize = true;
            panelFormRecetteDetails.Controls.Add(tableLayoutPanelFormRecetteDetails);
            panelFormRecetteDetails.Dock = DockStyle.Fill;
            panelFormRecetteDetails.Location = new Point(0, 0);
            panelFormRecetteDetails.Name = "panelFormRecetteDetails";
            panelFormRecetteDetails.Size = new Size(1039, 655);
            panelFormRecetteDetails.TabIndex = 0;
            // 
            // tableLayoutPanelFormRecetteDetails
            // 
            tableLayoutPanelFormRecetteDetails.ColumnCount = 2;
            tableLayoutPanelFormRecetteDetails.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 59.1233444F));
            tableLayoutPanelFormRecetteDetails.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40.8766556F));
            tableLayoutPanelFormRecetteDetails.Controls.Add(tableLayoutPanelRecetteSummary, 0, 0);
            tableLayoutPanelFormRecetteDetails.Controls.Add(pictureBoxImgRecette, 1, 0);
            tableLayoutPanelFormRecetteDetails.Controls.Add(tableLayoutPanelRightPartDetails, 1, 1);
            tableLayoutPanelFormRecetteDetails.Controls.Add(tableLayoutPanelLeftPartDetails, 0, 1);
            tableLayoutPanelFormRecetteDetails.Dock = DockStyle.Fill;
            tableLayoutPanelFormRecetteDetails.Location = new Point(0, 0);
            tableLayoutPanelFormRecetteDetails.Name = "tableLayoutPanelFormRecetteDetails";
            tableLayoutPanelFormRecetteDetails.RowCount = 2;
            tableLayoutPanelFormRecetteDetails.RowStyles.Add(new RowStyle(SizeType.Percent, 42.0289841F));
            tableLayoutPanelFormRecetteDetails.RowStyles.Add(new RowStyle(SizeType.Percent, 57.9710159F));
            tableLayoutPanelFormRecetteDetails.Size = new Size(1039, 655);
            tableLayoutPanelFormRecetteDetails.TabIndex = 0;
            // 
            // tableLayoutPanelRecetteSummary
            // 
            tableLayoutPanelRecetteSummary.ColumnCount = 1;
            tableLayoutPanelRecetteSummary.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelRecetteSummary.Controls.Add(labelNomRecette, 0, 0);
            tableLayoutPanelRecetteSummary.Controls.Add(textBoxDecriptionRecette, 0, 1);
            tableLayoutPanelRecetteSummary.Dock = DockStyle.Fill;
            tableLayoutPanelRecetteSummary.Location = new Point(3, 3);
            tableLayoutPanelRecetteSummary.Name = "tableLayoutPanelRecetteSummary";
            tableLayoutPanelRecetteSummary.RowCount = 2;
            tableLayoutPanelRecetteSummary.RowStyles.Add(new RowStyle(SizeType.Percent, 26.4840183F));
            tableLayoutPanelRecetteSummary.RowStyles.Add(new RowStyle(SizeType.Percent, 73.51598F));
            tableLayoutPanelRecetteSummary.Size = new Size(608, 269);
            tableLayoutPanelRecetteSummary.TabIndex = 0;
            // 
            // labelNomRecette
            // 
            labelNomRecette.AutoSize = true;
            labelNomRecette.Dock = DockStyle.Fill;
            labelNomRecette.Location = new Point(3, 0);
            labelNomRecette.Name = "labelNomRecette";
            labelNomRecette.Size = new Size(602, 71);
            labelNomRecette.TabIndex = 0;
            labelNomRecette.Text = "nom";
            // 
            // textBoxDecriptionRecette
            // 
            textBoxDecriptionRecette.Dock = DockStyle.Fill;
            textBoxDecriptionRecette.Location = new Point(3, 74);
            textBoxDecriptionRecette.Multiline = true;
            textBoxDecriptionRecette.Name = "textBoxDecriptionRecette";
            textBoxDecriptionRecette.PlaceholderText = "Description recette";
            textBoxDecriptionRecette.Size = new Size(602, 192);
            textBoxDecriptionRecette.TabIndex = 1;
            // 
            // pictureBoxImgRecette
            // 
            pictureBoxImgRecette.Dock = DockStyle.Fill;
            pictureBoxImgRecette.Location = new Point(617, 3);
            pictureBoxImgRecette.Name = "pictureBoxImgRecette";
            pictureBoxImgRecette.Size = new Size(419, 269);
            pictureBoxImgRecette.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxImgRecette.TabIndex = 1;
            pictureBoxImgRecette.TabStop = false;
            // 
            // tableLayoutPanelRightPartDetails
            // 
            tableLayoutPanelRightPartDetails.ColumnCount = 1;
            tableLayoutPanelRightPartDetails.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelRightPartDetails.Controls.Add(labelCreateur, 0, 2);
            tableLayoutPanelRightPartDetails.Controls.Add(tableLayoutPanelTempsIngredients, 0, 0);
            tableLayoutPanelRightPartDetails.Controls.Add(tableLayoutPanelCategories, 0, 1);
            tableLayoutPanelRightPartDetails.Dock = DockStyle.Fill;
            tableLayoutPanelRightPartDetails.Location = new Point(617, 278);
            tableLayoutPanelRightPartDetails.Name = "tableLayoutPanelRightPartDetails";
            tableLayoutPanelRightPartDetails.RowCount = 3;
            tableLayoutPanelRightPartDetails.RowStyles.Add(new RowStyle(SizeType.Percent, 50.44248F));
            tableLayoutPanelRightPartDetails.RowStyles.Add(new RowStyle(SizeType.Percent, 13.8053093F));
            tableLayoutPanelRightPartDetails.RowStyles.Add(new RowStyle(SizeType.Percent, 35.7142868F));
            tableLayoutPanelRightPartDetails.Size = new Size(419, 374);
            tableLayoutPanelRightPartDetails.TabIndex = 2;
            // 
            // labelCreateur
            // 
            labelCreateur.AutoSize = true;
            labelCreateur.Dock = DockStyle.Fill;
            labelCreateur.Location = new Point(3, 239);
            labelCreateur.Name = "labelCreateur";
            labelCreateur.Size = new Size(413, 135);
            labelCreateur.TabIndex = 0;
            labelCreateur.Text = "Créateur :";
            // 
            // tableLayoutPanelTempsIngredients
            // 
            tableLayoutPanelTempsIngredients.ColumnCount = 1;
            tableLayoutPanelTempsIngredients.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelTempsIngredients.Controls.Add(tableLayoutPanelTemps, 0, 0);
            tableLayoutPanelTempsIngredients.Controls.Add(ScrollPanel, 0, 1);
            tableLayoutPanelTempsIngredients.Dock = DockStyle.Fill;
            tableLayoutPanelTempsIngredients.Location = new Point(3, 3);
            tableLayoutPanelTempsIngredients.Name = "tableLayoutPanelTempsIngredients";
            tableLayoutPanelTempsIngredients.RowCount = 2;
            tableLayoutPanelTempsIngredients.RowStyles.Add(new RowStyle(SizeType.Percent, 31.899641F));
            tableLayoutPanelTempsIngredients.RowStyles.Add(new RowStyle(SizeType.Percent, 68.10036F));
            tableLayoutPanelTempsIngredients.Size = new Size(413, 182);
            tableLayoutPanelTempsIngredients.TabIndex = 1;
            // 
            // tableLayoutPanelTemps
            // 
            tableLayoutPanelTemps.ColumnCount = 2;
            tableLayoutPanelTemps.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.4203644F));
            tableLayoutPanelTemps.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 66.5796356F));
            tableLayoutPanelTemps.Controls.Add(labelTitreTempsPrepa, 0, 0);
            tableLayoutPanelTemps.Controls.Add(labelTempsPrepa, 1, 0);
            tableLayoutPanelTemps.Controls.Add(labelTitreTempsCui, 0, 1);
            tableLayoutPanelTemps.Controls.Add(labelTempsCui, 1, 1);
            tableLayoutPanelTemps.Controls.Add(labelTitreTempsTotal, 0, 2);
            tableLayoutPanelTemps.Controls.Add(labelTempsTotal, 1, 2);
            tableLayoutPanelTemps.Dock = DockStyle.Fill;
            tableLayoutPanelTemps.Location = new Point(3, 3);
            tableLayoutPanelTemps.Name = "tableLayoutPanelTemps";
            tableLayoutPanelTemps.RowCount = 3;
            tableLayoutPanelTemps.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanelTemps.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanelTemps.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanelTemps.Size = new Size(407, 52);
            tableLayoutPanelTemps.TabIndex = 0;
            // 
            // labelTitreTempsPrepa
            // 
            labelTitreTempsPrepa.AutoSize = true;
            labelTitreTempsPrepa.Dock = DockStyle.Fill;
            labelTitreTempsPrepa.Location = new Point(3, 0);
            labelTitreTempsPrepa.Name = "labelTitreTempsPrepa";
            labelTitreTempsPrepa.Size = new Size(130, 17);
            labelTitreTempsPrepa.TabIndex = 0;
            labelTitreTempsPrepa.Text = "Temps Préparation :";
            // 
            // labelTempsPrepa
            // 
            labelTempsPrepa.AutoSize = true;
            labelTempsPrepa.Dock = DockStyle.Fill;
            labelTempsPrepa.Location = new Point(139, 0);
            labelTempsPrepa.Name = "labelTempsPrepa";
            labelTempsPrepa.Size = new Size(265, 17);
            labelTempsPrepa.TabIndex = 1;
            labelTempsPrepa.Text = "0:00:0";
            // 
            // labelTitreTempsCui
            // 
            labelTitreTempsCui.AutoSize = true;
            labelTitreTempsCui.Dock = DockStyle.Fill;
            labelTitreTempsCui.Location = new Point(3, 17);
            labelTitreTempsCui.Name = "labelTitreTempsCui";
            labelTitreTempsCui.Size = new Size(130, 17);
            labelTitreTempsCui.TabIndex = 2;
            labelTitreTempsCui.Text = "Temps Cuisson :";
            // 
            // labelTempsCui
            // 
            labelTempsCui.AutoSize = true;
            labelTempsCui.Dock = DockStyle.Fill;
            labelTempsCui.Location = new Point(139, 17);
            labelTempsCui.Name = "labelTempsCui";
            labelTempsCui.Size = new Size(265, 17);
            labelTempsCui.TabIndex = 3;
            labelTempsCui.Text = "0:00:0";
            // 
            // labelTitreTempsTotal
            // 
            labelTitreTempsTotal.AutoSize = true;
            labelTitreTempsTotal.Dock = DockStyle.Fill;
            labelTitreTempsTotal.Location = new Point(3, 34);
            labelTitreTempsTotal.Name = "labelTitreTempsTotal";
            labelTitreTempsTotal.Size = new Size(130, 18);
            labelTitreTempsTotal.TabIndex = 4;
            labelTitreTempsTotal.Text = "Temps Total :";
            // 
            // labelTempsTotal
            // 
            labelTempsTotal.AutoSize = true;
            labelTempsTotal.Dock = DockStyle.Fill;
            labelTempsTotal.Location = new Point(139, 34);
            labelTempsTotal.Name = "labelTempsTotal";
            labelTempsTotal.Size = new Size(265, 18);
            labelTempsTotal.TabIndex = 5;
            labelTempsTotal.Text = "0:00:0";
            // 
            // ScrollPanel
            // 
            ScrollPanel.AutoScroll = true;
            ScrollPanel.AutoSize = true;
            ScrollPanel.Controls.Add(tableLayoutPanelIngredients);
            ScrollPanel.Dock = DockStyle.Fill;
            ScrollPanel.Location = new Point(3, 61);
            ScrollPanel.Name = "ScrollPanel";
            ScrollPanel.Size = new Size(407, 118);
            ScrollPanel.TabIndex = 1;
            // 
            // tableLayoutPanelIngredients
            // 
            tableLayoutPanelIngredients.AutoSize = true;
            tableLayoutPanelIngredients.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanelIngredients.ColumnCount = 2;
            tableLayoutPanelIngredients.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 68.6684F));
            tableLayoutPanelIngredients.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 31.3315926F));
            tableLayoutPanelIngredients.Controls.Add(labelIngredient, 0, 0);
            tableLayoutPanelIngredients.Controls.Add(labelQuantite, 1, 0);
            tableLayoutPanelIngredients.Dock = DockStyle.Top;
            tableLayoutPanelIngredients.Location = new Point(0, 0);
            tableLayoutPanelIngredients.Name = "tableLayoutPanelIngredients";
            tableLayoutPanelIngredients.RowCount = 1;
            tableLayoutPanelIngredients.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelIngredients.Size = new Size(407, 18);
            tableLayoutPanelIngredients.TabIndex = 2;
            // 
            // labelIngredient
            // 
            labelIngredient.AutoSize = true;
            labelIngredient.Dock = DockStyle.Top;
            labelIngredient.Location = new Point(3, 0);
            labelIngredient.Name = "labelIngredient";
            labelIngredient.Size = new Size(273, 15);
            labelIngredient.TabIndex = 0;
            labelIngredient.Text = "ingredient";
            // 
            // labelQuantite
            // 
            labelQuantite.AutoSize = true;
            labelQuantite.BackColor = SystemColors.Control;
            labelQuantite.Dock = DockStyle.Top;
            labelQuantite.Location = new Point(282, 3);
            labelQuantite.Margin = new Padding(3, 3, 30, 0);
            labelQuantite.Name = "labelQuantite";
            labelQuantite.Size = new Size(95, 15);
            labelQuantite.TabIndex = 1;
            labelQuantite.Text = "quantite";
            // 
            // tableLayoutPanelCategories
            // 
            tableLayoutPanelCategories.ColumnCount = 1;
            tableLayoutPanelCategories.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelCategories.Controls.Add(labelCategorie, 0, 0);
            tableLayoutPanelCategories.Dock = DockStyle.Fill;
            tableLayoutPanelCategories.Location = new Point(3, 191);
            tableLayoutPanelCategories.Name = "tableLayoutPanelCategories";
            tableLayoutPanelCategories.RowCount = 1;
            tableLayoutPanelCategories.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelCategories.Size = new Size(413, 45);
            tableLayoutPanelCategories.TabIndex = 2;
            // 
            // labelCategorie
            // 
            labelCategorie.AutoSize = true;
            labelCategorie.Dock = DockStyle.Fill;
            labelCategorie.Location = new Point(3, 0);
            labelCategorie.Name = "labelCategorie";
            labelCategorie.Size = new Size(407, 45);
            labelCategorie.TabIndex = 0;
            labelCategorie.Text = "categorie";
            // 
            // tableLayoutPanelLeftPartDetails
            // 
            tableLayoutPanelLeftPartDetails.ColumnCount = 1;
            tableLayoutPanelLeftPartDetails.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelLeftPartDetails.Controls.Add(tableLayoutPanelEtapes, 0, 0);
            tableLayoutPanelLeftPartDetails.Controls.Add(labelNoteMoyenne, 0, 1);
            tableLayoutPanelLeftPartDetails.Controls.Add(tableLayoutPanelAvis, 0, 2);
            tableLayoutPanelLeftPartDetails.Dock = DockStyle.Fill;
            tableLayoutPanelLeftPartDetails.Location = new Point(3, 278);
            tableLayoutPanelLeftPartDetails.Name = "tableLayoutPanelLeftPartDetails";
            tableLayoutPanelLeftPartDetails.RowCount = 3;
            tableLayoutPanelLeftPartDetails.RowStyles.Add(new RowStyle(SizeType.Percent, 59.3220329F));
            tableLayoutPanelLeftPartDetails.RowStyles.Add(new RowStyle(SizeType.Percent, 7.06214666F));
            tableLayoutPanelLeftPartDetails.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanelLeftPartDetails.Size = new Size(608, 374);
            tableLayoutPanelLeftPartDetails.TabIndex = 3;
            // 
            // tableLayoutPanelEtapes
            // 
            tableLayoutPanelEtapes.AutoScroll = true;
            tableLayoutPanelEtapes.AutoSize = true;
            tableLayoutPanelEtapes.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanelEtapes.ColumnCount = 2;
            tableLayoutPanelEtapes.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 13.80597F));
            tableLayoutPanelEtapes.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 86.19403F));
            tableLayoutPanelEtapes.Controls.Add(labelEtape, 0, 0);
            tableLayoutPanelEtapes.Controls.Add(textBoxEtape, 1, 0);
            tableLayoutPanelEtapes.Dock = DockStyle.Fill;
            tableLayoutPanelEtapes.Location = new Point(3, 3);
            tableLayoutPanelEtapes.Name = "tableLayoutPanelEtapes";
            tableLayoutPanelEtapes.RowCount = 1;
            tableLayoutPanelEtapes.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelEtapes.Size = new Size(602, 216);
            tableLayoutPanelEtapes.TabIndex = 2;
            // 
            // labelEtape
            // 
            labelEtape.AutoSize = true;
            labelEtape.Dock = DockStyle.Fill;
            labelEtape.Location = new Point(3, 0);
            labelEtape.Name = "labelEtape";
            labelEtape.Size = new Size(77, 216);
            labelEtape.TabIndex = 0;
            labelEtape.Text = "numero";
            // 
            // textBoxEtape
            // 
            textBoxEtape.Dock = DockStyle.Fill;
            textBoxEtape.Location = new Point(86, 3);
            textBoxEtape.Multiline = true;
            textBoxEtape.Name = "textBoxEtape";
            textBoxEtape.PlaceholderText = "Description Etape";
            textBoxEtape.Size = new Size(513, 210);
            textBoxEtape.TabIndex = 1;
            // 
            // labelNoteMoyenne
            // 
            labelNoteMoyenne.AutoSize = true;
            labelNoteMoyenne.Dock = DockStyle.Fill;
            labelNoteMoyenne.Location = new Point(3, 222);
            labelNoteMoyenne.Name = "labelNoteMoyenne";
            labelNoteMoyenne.Size = new Size(602, 26);
            labelNoteMoyenne.TabIndex = 0;
            labelNoteMoyenne.Text = "Note moyenne :";
            // 
            // tableLayoutPanelAvis
            // 
            tableLayoutPanelAvis.AutoScroll = true;
            tableLayoutPanelAvis.AutoSize = true;
            tableLayoutPanelAvis.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanelAvis.ColumnCount = 3;
            tableLayoutPanelAvis.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 29.2947559F));
            tableLayoutPanelAvis.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 59.6745033F));
            tableLayoutPanelAvis.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.0307417F));
            tableLayoutPanelAvis.Controls.Add(labelUtilisateur, 0, 0);
            tableLayoutPanelAvis.Controls.Add(labelNote, 2, 0);
            tableLayoutPanelAvis.Controls.Add(textBoxAvis, 1, 0);
            tableLayoutPanelAvis.Dock = DockStyle.Fill;
            tableLayoutPanelAvis.Location = new Point(3, 251);
            tableLayoutPanelAvis.Name = "tableLayoutPanelAvis";
            tableLayoutPanelAvis.RowCount = 1;
            tableLayoutPanelAvis.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelAvis.Size = new Size(602, 120);
            tableLayoutPanelAvis.TabIndex = 1;
            // 
            // labelUtilisateur
            // 
            labelUtilisateur.AutoSize = true;
            labelUtilisateur.Dock = DockStyle.Fill;
            labelUtilisateur.Location = new Point(3, 0);
            labelUtilisateur.Name = "labelUtilisateur";
            labelUtilisateur.Size = new Size(170, 120);
            labelUtilisateur.TabIndex = 0;
            labelUtilisateur.Text = "utilisateur";
            // 
            // labelNote
            // 
            labelNote.AutoSize = true;
            labelNote.Dock = DockStyle.Fill;
            labelNote.Location = new Point(538, 0);
            labelNote.Name = "labelNote";
            labelNote.Size = new Size(61, 120);
            labelNote.TabIndex = 1;
            labelNote.Text = "note";
            // 
            // textBoxAvis
            // 
            textBoxAvis.Dock = DockStyle.Fill;
            textBoxAvis.Location = new Point(179, 3);
            textBoxAvis.Multiline = true;
            textBoxAvis.Name = "textBoxAvis";
            textBoxAvis.PlaceholderText = "commentaire";
            textBoxAvis.Size = new Size(353, 114);
            textBoxAvis.TabIndex = 2;
            // 
            // FormRecetteDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1039, 655);
            Controls.Add(panelFormRecetteDetails);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormRecetteDetails";
            Text = "FormRecetteDetails";
            Load += FormRecetteDetails_FormLoad;
            panelFormRecetteDetails.ResumeLayout(false);
            tableLayoutPanelFormRecetteDetails.ResumeLayout(false);
            tableLayoutPanelRecetteSummary.ResumeLayout(false);
            tableLayoutPanelRecetteSummary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImgRecette).EndInit();
            tableLayoutPanelRightPartDetails.ResumeLayout(false);
            tableLayoutPanelRightPartDetails.PerformLayout();
            tableLayoutPanelTempsIngredients.ResumeLayout(false);
            tableLayoutPanelTempsIngredients.PerformLayout();
            tableLayoutPanelTemps.ResumeLayout(false);
            tableLayoutPanelTemps.PerformLayout();
            ScrollPanel.ResumeLayout(false);
            ScrollPanel.PerformLayout();
            tableLayoutPanelIngredients.ResumeLayout(false);
            tableLayoutPanelIngredients.PerformLayout();
            tableLayoutPanelCategories.ResumeLayout(false);
            tableLayoutPanelCategories.PerformLayout();
            tableLayoutPanelLeftPartDetails.ResumeLayout(false);
            tableLayoutPanelLeftPartDetails.PerformLayout();
            tableLayoutPanelEtapes.ResumeLayout(false);
            tableLayoutPanelEtapes.PerformLayout();
            tableLayoutPanelAvis.ResumeLayout(false);
            tableLayoutPanelAvis.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelFormRecetteDetails;
        private TableLayoutPanel tableLayoutPanelFormRecetteDetails;
        private TableLayoutPanel tableLayoutPanelRecetteSummary;
        private PictureBox pictureBoxImgRecette;
        private TableLayoutPanel tableLayoutPanelRightPartDetails;
        private TableLayoutPanel tableLayoutPanelLeftPartDetails;
        private Label labelNomRecette;
        private Label labelCreateur;
        private TableLayoutPanel tableLayoutPanelTempsIngredients;
        private Label labelNoteMoyenne;
        private TableLayoutPanel tableLayoutPanelTemps;
        private TableLayoutPanel tableLayoutPanelCategories;
        private TableLayoutPanel tableLayoutPanelAvis;
        private TextBox textBoxDecriptionRecette;
        private TableLayoutPanel tableLayoutPanelEtapes;
        private Label labelTitreTempsPrepa;
        private Label labelTempsPrepa;
        private Label labelTitreTempsCui;
        private Label labelTempsCui;
        private Label labelTitreTempsTotal;
        private Label labelTempsTotal;
        private Label labelCategorie;
        private Label labelUtilisateur;
        private Label labelNote;
        private TextBox textBoxAvis;
        private Label labelEtape;
        private TextBox textBoxEtape;
        private Panel ScrollPanel;
        private TableLayoutPanel tableLayoutPanelIngredients;
        private Label labelIngredient;
        private Label labelQuantite;
    }
}