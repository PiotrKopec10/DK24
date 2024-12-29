namespace DK24
{
    partial class ResetujHasloForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResetujHasloForm));
            panel3 = new Panel();
            btnCofnij = new Button();
            txtBoxStworzHaslo = new TextBox();
            txtBoxPowtorzHaslo = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnReset = new Button();
            pictureBox1 = new PictureBox();
            lblWymaganiaHasla = new LinkLabel();
            pictureBox2 = new PictureBox();
            imgPassword = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgPassword).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackgroundImage = (Image)resources.GetObject("panel3.BackgroundImage");
            panel3.Location = new Point(-35, 19);
            panel3.Name = "panel3";
            panel3.Size = new Size(10, 300);
            panel3.TabIndex = 16;
            // 
            // btnCofnij
            // 
            btnCofnij.Image = (Image)resources.GetObject("btnCofnij.Image");
            btnCofnij.Location = new Point(289, 239);
            btnCofnij.Name = "btnCofnij";
            btnCofnij.Size = new Size(44, 33);
            btnCofnij.TabIndex = 14;
            btnCofnij.UseVisualStyleBackColor = true;
            btnCofnij.Click += btnCofnij_Click;
            // 
            // txtBoxStworzHaslo
            // 
            txtBoxStworzHaslo.Location = new Point(60, 80);
            txtBoxStworzHaslo.Name = "txtBoxStworzHaslo";
            txtBoxStworzHaslo.Size = new Size(229, 23);
            txtBoxStworzHaslo.TabIndex = 18;
            // 
            // txtBoxPowtorzHaslo
            // 
            txtBoxPowtorzHaslo.Location = new Point(60, 143);
            txtBoxPowtorzHaslo.Name = "txtBoxPowtorzHaslo";
            txtBoxPowtorzHaslo.Size = new Size(229, 23);
            txtBoxPowtorzHaslo.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = Color.White;
            label1.Location = new Point(60, 62);
            label1.Name = "label1";
            label1.Size = new Size(110, 15);
            label1.TabIndex = 20;
            label1.Text = "Utwórz nowe hasło:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = Color.White;
            label2.Location = new Point(60, 125);
            label2.Name = "label2";
            label2.Size = new Size(116, 15);
            label2.TabIndex = 21;
            label2.Text = "Powtórz nowe hasło:";
            // 
            // btnReset
            // 
            btnReset.Location = new Point(125, 209);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(94, 39);
            btnReset.TabIndex = 22;
            btnReset.Text = "Resetuj hasło";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Enabled = false;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, -12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(132, 82);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // lblWymaganiaHasla
            // 
            lblWymaganiaHasla.ActiveLinkColor = Color.FromArgb(255, 128, 0);
            lblWymaganiaHasla.AutoSize = true;
            lblWymaganiaHasla.BackColor = Color.Transparent;
            lblWymaganiaHasla.Font = new Font("Segoe UI", 8.25F, FontStyle.Italic, GraphicsUnit.Point, 238);
            lblWymaganiaHasla.ImeMode = ImeMode.NoControl;
            lblWymaganiaHasla.LinkColor = Color.DarkGray;
            lblWymaganiaHasla.Location = new Point(47, 173);
            lblWymaganiaHasla.Name = "lblWymaganiaHasla";
            lblWymaganiaHasla.Size = new Size(256, 13);
            lblWymaganiaHasla.TabIndex = 24;
            lblWymaganiaHasla.TabStop = true;
            lblWymaganiaHasla.Text = "WYMAGANIA: 1 znak specjalny, 1 cyfra i długość > 5\r\n";
            lblWymaganiaHasla.VisitedLinkColor = Color.FromArgb(255, 128, 0);
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.ImeMode = ImeMode.NoControl;
            pictureBox2.Location = new Point(29, 143);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(25, 23);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 26;
            pictureBox2.TabStop = false;
            // 
            // imgPassword
            // 
            imgPassword.BackColor = Color.Transparent;
            imgPassword.Image = (Image)resources.GetObject("imgPassword.Image");
            imgPassword.ImeMode = ImeMode.NoControl;
            imgPassword.Location = new Point(29, 80);
            imgPassword.Name = "imgPassword";
            imgPassword.Size = new Size(25, 23);
            imgPassword.SizeMode = PictureBoxSizeMode.Zoom;
            imgPassword.TabIndex = 25;
            imgPassword.TabStop = false;
            // 
            // ResetujHasloForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(355, 289);
            Controls.Add(pictureBox2);
            Controls.Add(imgPassword);
            Controls.Add(lblWymaganiaHasla);
            Controls.Add(btnCofnij);
            Controls.Add(btnReset);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtBoxPowtorzHaslo);
            Controls.Add(txtBoxStworzHaslo);
            Controls.Add(panel3);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ResetujHasloForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ResetujHasloForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgPassword).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel3;
        private Button btnCofnij;
        private TextBox txtBoxStworzHaslo;
        private TextBox txtBoxPowtorzHaslo;
        private Label label1;
        private Label label2;
        private Button btnReset;
        private PictureBox pictureBox1;
        private LinkLabel lblWymaganiaHasla;
        private PictureBox pictureBox2;
        private PictureBox imgPassword;
    }
}