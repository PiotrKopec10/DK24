namespace DK24
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            lblWitaj = new Label();
            lblLogin = new Label();
            txtBoxLogin = new TextBox();
            imgLogo = new PictureBox();
            panel1 = new Panel();
            imgLogin = new PictureBox();
            imgPassword = new PictureBox();
            txtBoxPassword = new TextBox();
            lblPassword = new Label();
            btnZaloguj = new Button();
            lblWyjdz = new LinkLabel();
            lblZleHaslo = new Label();
            imgOdszyfruj = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)imgLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgLogin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgPassword).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgOdszyfruj).BeginInit();
            SuspendLayout();
            // 
            // lblWitaj
            // 
            resources.ApplyResources(lblWitaj, "lblWitaj");
            lblWitaj.BackColor = Color.Transparent;
            lblWitaj.ForeColor = Color.FromArgb(255, 128, 0);
            lblWitaj.Name = "lblWitaj";
            // 
            // lblLogin
            // 
            resources.ApplyResources(lblLogin, "lblLogin");
            lblLogin.BackColor = Color.Transparent;
            lblLogin.ForeColor = Color.White;
            lblLogin.Name = "lblLogin";
            // 
            // txtBoxLogin
            // 
            resources.ApplyResources(txtBoxLogin, "txtBoxLogin");
            txtBoxLogin.Name = "txtBoxLogin";
            txtBoxLogin.Enter += txtBoxLogin_Enter;
            // 
            // imgLogo
            // 
            imgLogo.BackColor = Color.Transparent;
            imgLogo.Image = Properties.Resources.dk;
            resources.ApplyResources(imgLogo, "imgLogo");
            imgLogo.Name = "imgLogo";
            imgLogo.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(192, 64, 0);
            resources.ApplyResources(panel1, "panel1");
            panel1.Name = "panel1";
            // 
            // imgLogin
            // 
            imgLogin.BackColor = Color.Transparent;
            resources.ApplyResources(imgLogin, "imgLogin");
            imgLogin.Name = "imgLogin";
            imgLogin.TabStop = false;
            // 
            // imgPassword
            // 
            imgPassword.BackColor = Color.Transparent;
            resources.ApplyResources(imgPassword, "imgPassword");
            imgPassword.Name = "imgPassword";
            imgPassword.TabStop = false;
            // 
            // txtBoxPassword
            // 
            resources.ApplyResources(txtBoxPassword, "txtBoxPassword");
            txtBoxPassword.Name = "txtBoxPassword";
            txtBoxPassword.Enter += txtBoxPassword_Enter;
            // 
            // lblPassword
            // 
            resources.ApplyResources(lblPassword, "lblPassword");
            lblPassword.BackColor = Color.Transparent;
            lblPassword.ForeColor = Color.White;
            lblPassword.Name = "lblPassword";
            // 
            // btnZaloguj
            // 
            resources.ApplyResources(btnZaloguj, "btnZaloguj");
            btnZaloguj.Name = "btnZaloguj";
            btnZaloguj.UseVisualStyleBackColor = true;
            btnZaloguj.Click += btnZaloguj_Click;
            // 
            // lblWyjdz
            // 
            lblWyjdz.ActiveLinkColor = Color.FromArgb(255, 128, 0);
            resources.ApplyResources(lblWyjdz, "lblWyjdz");
            lblWyjdz.BackColor = Color.Transparent;
            lblWyjdz.LinkColor = Color.DarkGray;
            lblWyjdz.Name = "lblWyjdz";
            lblWyjdz.TabStop = true;
            lblWyjdz.VisitedLinkColor = Color.FromArgb(255, 128, 0);
            lblWyjdz.LinkClicked += lblWyjdz_LinkClicked;
            // 
            // lblZleHaslo
            // 
            resources.ApplyResources(lblZleHaslo, "lblZleHaslo");
            lblZleHaslo.BackColor = Color.Transparent;
            lblZleHaslo.ForeColor = Color.Red;
            lblZleHaslo.Name = "lblZleHaslo";
            // 
            // imgOdszyfruj
            // 
            imgOdszyfruj.BackColor = Color.Transparent;
            resources.ApplyResources(imgOdszyfruj, "imgOdszyfruj");
            imgOdszyfruj.Name = "imgOdszyfruj";
            imgOdszyfruj.TabStop = false;
            // 
            // LoginForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ControlBox = false;
            Controls.Add(txtBoxPassword);
            Controls.Add(imgOdszyfruj);
            Controls.Add(lblZleHaslo);
            Controls.Add(lblWyjdz);
            Controls.Add(imgPassword);
            Controls.Add(lblPassword);
            Controls.Add(imgLogin);
            Controls.Add(panel1);
            Controls.Add(imgLogo);
            Controls.Add(btnZaloguj);
            Controls.Add(txtBoxLogin);
            Controls.Add(lblLogin);
            Controls.Add(lblWitaj);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            FormClosing += LoginForm_FormClosing;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)imgLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgLogin).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgPassword).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgOdszyfruj).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblWitaj;
        private Label lblLogin;
        private TextBox txtBoxLogin;
        private PictureBox imgLogo;
        private Panel panel1;
        private PictureBox imgLogin;
        private PictureBox imgPassword;
        private TextBox txtBoxPassword;
        private Label lblPassword;
        private Button btnZaloguj;
        private LinkLabel lblWyjdz;
        private Label lblZleHaslo;
        private PictureBox imgOdszyfruj;
    }
}
