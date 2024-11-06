namespace DK24
{
    partial class WyborKlient_KontrahentZamowienieForm
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
            btnJakoKlient = new Button();
            btnJakoKnt = new Button();
            SuspendLayout();
            // 
            // btnJakoKlient
            // 
            btnJakoKlient.Location = new Point(37, 106);
            btnJakoKlient.Name = "btnJakoKlient";
            btnJakoKlient.Size = new Size(153, 94);
            btnJakoKlient.TabIndex = 0;
            btnJakoKlient.Text = "Złóż zamówienie jako klient ";
            btnJakoKlient.UseVisualStyleBackColor = true;
            btnJakoKlient.Click += btnJakoKlient_Click;
            // 
            // btnJakoKnt
            // 
            btnJakoKnt.Location = new Point(287, 106);
            btnJakoKnt.Name = "btnJakoKnt";
            btnJakoKnt.Size = new Size(150, 94);
            btnJakoKnt.TabIndex = 1;
            btnJakoKnt.Text = "Złóż zamówienie jako kontrahent";
            btnJakoKnt.UseVisualStyleBackColor = true;
            btnJakoKnt.Click += btnJakoKnt_Click;
            // 
            // WyborKlient_KontrahentZamowienieForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(472, 299);
            Controls.Add(btnJakoKnt);
            Controls.Add(btnJakoKlient);
            FormBorderStyle = FormBorderStyle.None;
            Name = "WyborKlient_KontrahentZamowienieForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "WyborKlient_KontrahentZamowienieForm";
            ResumeLayout(false);
        }

        #endregion

        private Button btnJakoKlient;
        private Button btnJakoKnt;
    }
}