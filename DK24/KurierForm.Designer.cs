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
            SuspendLayout();
            // 
            // btnStworzZamowienie
            // 
            btnStworzZamowienie.Location = new Point(157, 96);
            btnStworzZamowienie.Name = "btnStworzZamowienie";
            btnStworzZamowienie.Size = new Size(136, 56);
            btnStworzZamowienie.TabIndex = 0;
            btnStworzZamowienie.Text = "Zamów kuriera i wygeneruj etykietę";
            btnStworzZamowienie.UseVisualStyleBackColor = true;
            btnStworzZamowienie.Click += button1_Click;
            // 
            // rchBoxLogi
            // 
            rchBoxLogi.Location = new Point(15, 210);
            rchBoxLogi.Name = "rchBoxLogi";
            rchBoxLogi.Size = new Size(420, 110);
            rchBoxLogi.TabIndex = 2;
            rchBoxLogi.Text = "";
            // 
            // btnAnuluj
            // 
            btnAnuluj.Image = (Image)resources.GetObject("btnAnuluj.Image");
            btnAnuluj.Location = new Point(202, 158);
            btnAnuluj.Name = "btnAnuluj";
            btnAnuluj.Size = new Size(44, 33);
            btnAnuluj.TabIndex = 7;
            btnAnuluj.UseVisualStyleBackColor = true;
            btnAnuluj.Click += btnAnuluj_Click;
            // 
            // KurierForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(450, 330);
            Controls.Add(btnAnuluj);
            Controls.Add(rchBoxLogi);
            Controls.Add(btnStworzZamowienie);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "KurierForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DHLForm";
            ResumeLayout(false);
        }

        #endregion

        private Button btnStworzZamowienie;
        private RichTextBox rchBoxLogi;
        private Button btnAnuluj;
    }
}