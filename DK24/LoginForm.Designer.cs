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
            lblWitaj = new Label();
            lblHaslo = new Label();
            SuspendLayout();
            // 
            // lblDK
            // 
            lblDK.AutoSize = true;
            lblDK.BackColor = Color.Transparent;
            lblDK.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblDK.Location = new Point(75, 89);
            lblDK.Name = "lblDK";
            lblDK.Size = new Size(387, 29);
            lblDK.TabIndex = 1;
            lblDK.Text = "D&&K MANAGEMENT SYSTEM";
            lblDK.Click += label1_Click;
            // 
            // btnZaloguj
            // 
            btnZaloguj.Location = new Point(243, 370);
            btnZaloguj.Margin = new Padding(3, 2, 3, 2);
            btnZaloguj.Name = "btnZaloguj";
            btnZaloguj.Size = new Size(135, 46);
            btnZaloguj.TabIndex = 2;
            btnZaloguj.Text = "&Zaloguj";
            btnZaloguj.UseVisualStyleBackColor = true;
            btnZaloguj.Click += btnZaloguj_Click;
            // 
            // txtBoxLogin
            // 
            txtBoxLogin.Location = new Point(233, 177);
            txtBoxLogin.Margin = new Padding(3, 2, 3, 2);
            txtBoxLogin.Name = "txtBoxLogin";
            txtBoxLogin.Size = new Size(145, 23);
            txtBoxLogin.TabIndex = 3;
            // 
            // txtBoxHaslo
            // 
            txtBoxHaslo.Location = new Point(233, 233);
            txtBoxHaslo.Margin = new Padding(3, 2, 3, 2);
            txtBoxHaslo.Name = "txtBoxHaslo";
            txtBoxHaslo.Size = new Size(145, 23);
            txtBoxHaslo.TabIndex = 4;
            txtBoxHaslo.TextChanged += textBox2_TextChanged;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Location = new Point(151, 183);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(40, 15);
            lblLogin.TabIndex = 5;
            lblLogin.Text = "Login:";
            // 
            // lblWitaj
            // 
            lblWitaj.AutoSize = true;
            lblWitaj.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblWitaj.Location = new Point(233, 31);
            lblWitaj.Name = "lblWitaj";
            lblWitaj.Size = new Size(95, 29);
            lblWitaj.TabIndex = 8;
            lblWitaj.Text = "Witaj!";
            // 
            // lblHaslo
            // 
            lblHaslo.AutoSize = true;
            lblHaslo.Location = new Point(151, 235);
            lblHaslo.Name = "lblHaslo";
            lblHaslo.Size = new Size(40, 15);
            lblHaslo.TabIndex = 6;
            lblHaslo.Text = "Hasło:";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(583, 484);
            Controls.Add(lblWitaj);
            Controls.Add(lblHaslo);
            Controls.Add(lblLogin);
            Controls.Add(txtBoxHaslo);
            Controls.Add(txtBoxLogin);
            Controls.Add(btnZaloguj);
            Controls.Add(lblDK);
            Margin = new Padding(3, 2, 3, 2);
            Name = "LoginForm";
            Text = "D&K";
            FormClosing += LoginForm_FormClosing;
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
        private Label lblWitaj;
        private Label lblHaslo;
    }
}
