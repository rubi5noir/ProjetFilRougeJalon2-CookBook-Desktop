namespace CookBookAppDesktop
{
    partial class FormLogin
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
            tableLayoutPanelFormLogin = new TableLayoutPanel();
            tableLayoutPanelFormLoginUsable = new TableLayoutPanel();
            tableLayoutPanelFormLoginInputs = new TableLayoutPanel();
            labelUsername = new Label();
            labelMotDePasse = new Label();
            textBoxUsername = new TextBox();
            textBoxMotDePasse = new TextBox();
            flowLayoutPanelFormLoginButtons = new FlowLayoutPanel();
            buttonLogIn = new Button();
            tableLayoutPanelFormLogin.SuspendLayout();
            tableLayoutPanelFormLoginUsable.SuspendLayout();
            tableLayoutPanelFormLoginInputs.SuspendLayout();
            flowLayoutPanelFormLoginButtons.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanelFormLogin
            // 
            tableLayoutPanelFormLogin.ColumnCount = 1;
            tableLayoutPanelFormLogin.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelFormLogin.Controls.Add(tableLayoutPanelFormLoginUsable, 0, 0);
            tableLayoutPanelFormLogin.Dock = DockStyle.Fill;
            tableLayoutPanelFormLogin.Location = new Point(0, 0);
            tableLayoutPanelFormLogin.Name = "tableLayoutPanelFormLogin";
            tableLayoutPanelFormLogin.RowCount = 1;
            tableLayoutPanelFormLogin.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelFormLogin.Size = new Size(484, 121);
            tableLayoutPanelFormLogin.TabIndex = 0;
            // 
            // tableLayoutPanelFormLoginUsable
            // 
            tableLayoutPanelFormLoginUsable.ColumnCount = 1;
            tableLayoutPanelFormLoginUsable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelFormLoginUsable.Controls.Add(tableLayoutPanelFormLoginInputs, 0, 0);
            tableLayoutPanelFormLoginUsable.Controls.Add(flowLayoutPanelFormLoginButtons, 0, 1);
            tableLayoutPanelFormLoginUsable.Dock = DockStyle.Fill;
            tableLayoutPanelFormLoginUsable.Location = new Point(3, 3);
            tableLayoutPanelFormLoginUsable.Name = "tableLayoutPanelFormLoginUsable";
            tableLayoutPanelFormLoginUsable.RowCount = 2;
            tableLayoutPanelFormLoginUsable.RowStyles.Add(new RowStyle(SizeType.Percent, 66.6666641F));
            tableLayoutPanelFormLoginUsable.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanelFormLoginUsable.Size = new Size(478, 115);
            tableLayoutPanelFormLoginUsable.TabIndex = 0;
            // 
            // tableLayoutPanelFormLoginInputs
            // 
            tableLayoutPanelFormLoginInputs.ColumnCount = 2;
            tableLayoutPanelFormLoginInputs.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanelFormLoginInputs.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelFormLoginInputs.Controls.Add(labelUsername, 0, 0);
            tableLayoutPanelFormLoginInputs.Controls.Add(labelMotDePasse, 0, 1);
            tableLayoutPanelFormLoginInputs.Controls.Add(textBoxUsername, 1, 0);
            tableLayoutPanelFormLoginInputs.Controls.Add(textBoxMotDePasse, 1, 1);
            tableLayoutPanelFormLoginInputs.Dock = DockStyle.Fill;
            tableLayoutPanelFormLoginInputs.Location = new Point(3, 3);
            tableLayoutPanelFormLoginInputs.Name = "tableLayoutPanelFormLoginInputs";
            tableLayoutPanelFormLoginInputs.RowCount = 2;
            tableLayoutPanelFormLoginInputs.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelFormLoginInputs.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelFormLoginInputs.Size = new Size(472, 70);
            tableLayoutPanelFormLoginInputs.TabIndex = 0;
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Dock = DockStyle.Fill;
            labelUsername.Location = new Point(3, 0);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(83, 35);
            labelUsername.TabIndex = 0;
            labelUsername.Text = "Username :";
            // 
            // labelMotDePasse
            // 
            labelMotDePasse.AutoSize = true;
            labelMotDePasse.Dock = DockStyle.Fill;
            labelMotDePasse.Location = new Point(3, 35);
            labelMotDePasse.Name = "labelMotDePasse";
            labelMotDePasse.Size = new Size(83, 35);
            labelMotDePasse.TabIndex = 1;
            labelMotDePasse.Text = "Mot de passe :";
            // 
            // textBoxUsername
            // 
            textBoxUsername.Dock = DockStyle.Fill;
            textBoxUsername.Location = new Point(92, 3);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(377, 23);
            textBoxUsername.TabIndex = 2;
            // 
            // textBoxMotDePasse
            // 
            textBoxMotDePasse.Dock = DockStyle.Fill;
            textBoxMotDePasse.Location = new Point(92, 38);
            textBoxMotDePasse.Name = "textBoxMotDePasse";
            textBoxMotDePasse.Size = new Size(377, 23);
            textBoxMotDePasse.TabIndex = 3;
            textBoxMotDePasse.UseSystemPasswordChar = true;
            // 
            // flowLayoutPanelFormLoginButtons
            // 
            flowLayoutPanelFormLoginButtons.Controls.Add(buttonLogIn);
            flowLayoutPanelFormLoginButtons.Dock = DockStyle.Fill;
            flowLayoutPanelFormLoginButtons.Location = new Point(3, 79);
            flowLayoutPanelFormLoginButtons.Name = "flowLayoutPanelFormLoginButtons";
            flowLayoutPanelFormLoginButtons.RightToLeft = RightToLeft.Yes;
            flowLayoutPanelFormLoginButtons.Size = new Size(472, 33);
            flowLayoutPanelFormLoginButtons.TabIndex = 1;
            // 
            // buttonLogIn
            // 
            buttonLogIn.Location = new Point(394, 3);
            buttonLogIn.Name = "buttonLogIn";
            buttonLogIn.Size = new Size(75, 23);
            buttonLogIn.TabIndex = 1;
            buttonLogIn.Text = "LogIn";
            buttonLogIn.UseVisualStyleBackColor = true;
            buttonLogIn.Click += ButtonLogIn_Click;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 121);
            Controls.Add(tableLayoutPanelFormLogin);
            MaximumSize = new Size(500, 160);
            MinimumSize = new Size(500, 160);
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormLogin";
            tableLayoutPanelFormLogin.ResumeLayout(false);
            tableLayoutPanelFormLoginUsable.ResumeLayout(false);
            tableLayoutPanelFormLoginInputs.ResumeLayout(false);
            tableLayoutPanelFormLoginInputs.PerformLayout();
            flowLayoutPanelFormLoginButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanelFormLogin;
        private TableLayoutPanel tableLayoutPanelFormLoginUsable;
        private TableLayoutPanel tableLayoutPanelFormLoginInputs;
        private Label labelUsername;
        private Label labelMotDePasse;
        private TextBox textBoxUsername;
        private TextBox textBoxMotDePasse;
        private FlowLayoutPanel flowLayoutPanelFormLoginButtons;
        private Button buttonLogIn;
    }
}