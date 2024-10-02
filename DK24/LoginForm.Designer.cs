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
            lblDK = new Label();
            btnZaloguj = new Button();
            txtBoxLogin = new TextBox();
            txtBoxHaslo = new TextBox();
            lblLogin = new Label();
            lblHaslo = new Label();
            lblWitaj = new Label();
            SuspendLayout();
            // 
            // lblDK
            // 
            lblDK.AutoSize = true;
            lblDK.BackColor = Color.Transparent;
            lblDK.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblDK.Location = new Point(380, 118);
            lblDK.Name = "lblDK";
            lblDK.Size = new Size(480, 36);
            lblDK.TabIndex = 1;
            lblDK.Text = "D&&K MANAGEMENT SYSTEM";
            lblDK.Click += label1_Click;
            // 
            // btnZaloguj
            // 
            btnZaloguj.Location = new Point(571, 492);
            btnZaloguj.Name = "btnZaloguj";
            btnZaloguj.Size = new Size(154, 61);
            btnZaloguj.TabIndex = 2;
            btnZaloguj.Text = "&Zaloguj";
            btnZaloguj.UseVisualStyleBackColor = true;
            btnZaloguj.Click += btnZaloguj_Click;
            // 
            // txtBoxLogin
            // 
            txtBoxLogin.Location = new Point(560, 235);
            txtBoxLogin.Name = "txtBoxLogin";
            txtBoxLogin.Size = new Size(165, 27);
            txtBoxLogin.TabIndex = 3;
            // 
            // txtBoxHaslo
            // 
            txtBoxHaslo.Location = new Point(560, 309);
            txtBoxHaslo.Name = "txtBoxHaslo";
            txtBoxHaslo.Size = new Size(165, 27);
            txtBoxHaslo.TabIndex = 4;
            txtBoxHaslo.TextChanged += textBox2_TextChanged;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Location = new Point(466, 242);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(49, 20);
            lblLogin.TabIndex = 5;
            lblLogin.Text = "Login:";
            // 
            // lblHaslo
            // 
            lblHaslo.AutoSize = true;
            lblHaslo.Location = new Point(466, 312);
            lblHaslo.Name = "lblHaslo";
            lblHaslo.Size = new Size(50, 20);
            lblHaslo.TabIndex = 6;
            lblHaslo.Text = "Hasło:";
            // 
            // lblWitaj
            // 
            lblWitaj.AutoSize = true;
            lblWitaj.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblWitaj.Location = new Point(560, 40);
            lblWitaj.Name = "lblWitaj";
            lblWitaj.Size = new Size(117, 36);
            lblWitaj.TabIndex = 8;
            lblWitaj.Text = "Witaj!";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1325, 627);
            Controls.Add(lblWitaj);
            Controls.Add(lblHaslo);
            Controls.Add(lblLogin);
            Controls.Add(txtBoxHaslo);
            Controls.Add(txtBoxLogin);
            Controls.Add(btnZaloguj);
            Controls.Add(lblDK);
            Name = "LoginForm";
            Text = "D&K";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblDK;
        private Button btnZaloguj;
        private TextBox txtBoxLogin;
        private TextBox txtBoxHaslo;
        private Label lblLogin;
        private Label lblHaslo;
        private Label lblWitaj;
    }
}
