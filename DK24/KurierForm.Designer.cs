namespace DK24
{
    partial class KurierForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KurierForm));
            btnStworzZamowienie = new Button();
            rchBoxLogi = new RichTextBox();
            btnAnuluj = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnStworzZamowienie
            // 
            btnStworzZamowienie.Location = new Point(152, 247);
            btnStworzZamowienie.Name = "btnStworzZamowienie";
            btnStworzZamowienie.Size = new Size(136, 56);
            btnStworzZamowienie.TabIndex = 0;
            btnStworzZamowienie.Text = "Zamów kuriera i wygeneruj etykietę";
            btnStworzZamowienie.UseVisualStyleBackColor = true;
            btnStworzZamowienie.Click += button1_Click;
            // 
            // rchBoxLogi
            // 
            rchBoxLogi.Enabled = false;
            rchBoxLogi.Location = new Point(11, 58);
            rchBoxLogi.Name = "rchBoxLogi";
            rchBoxLogi.Size = new Size(430, 156);
            rchBoxLogi.TabIndex = 2;
            rchBoxLogi.Text = "";
            // 
            // btnAnuluj
            // 
            btnAnuluj.Image = (Image)resources.GetObject("btnAnuluj.Image");
            btnAnuluj.Location = new Point(388, 270);
            btnAnuluj.Name = "btnAnuluj";
            btnAnuluj.Size = new Size(44, 33);
            btnAnuluj.TabIndex = 7;
            btnAnuluj.UseVisualStyleBackColor = true;
            btnAnuluj.Click += btnAnuluj_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Enabled = false;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, -13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(132, 82);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // KurierForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(452, 332);
            Controls.Add(rchBoxLogi);
            Controls.Add(pictureBox1);
            Controls.Add(btnAnuluj);
            Controls.Add(btnStworzZamowienie);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Location = new Point(0, 200);
            Name = "KurierForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "DHLForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnStworzZamowienie;
        private RichTextBox rchBoxLogi;
        private Button btnAnuluj;
        private PictureBox pictureBox1;
    }
}