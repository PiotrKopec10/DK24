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
            panel2 = new Panel();
            panelGorny = new Panel();
            pnlPrzyciski = new Panel();
            btnCofnij = new Button();
            panel1 = new Panel();
            txtBoxStworzHaslo = new TextBox();
            txtBoxPowtorzHaslo = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnReset = new Button();
            pnlPrzyciski.SuspendLayout();
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
            // panel2
            // 
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.Location = new Point(680, 25);
            panel2.Name = "panel2";
            panel2.Size = new Size(10, 300);
            panel2.TabIndex = 15;
            // 
            // panelGorny
            // 
            panelGorny.BackgroundImage = (Image)resources.GetObject("panelGorny.BackgroundImage");
            panelGorny.Location = new Point(0, 0);
            panelGorny.Name = "panelGorny";
            panelGorny.Size = new Size(690, 25);
            panelGorny.TabIndex = 14;
            // 
            // pnlPrzyciski
            // 
            pnlPrzyciski.BackgroundImage = (Image)resources.GetObject("pnlPrzyciski.BackgroundImage");
            pnlPrzyciski.Controls.Add(btnCofnij);
            pnlPrzyciski.Location = new Point(0, 325);
            pnlPrzyciski.Name = "pnlPrzyciski";
            pnlPrzyciski.Size = new Size(690, 65);
            pnlPrzyciski.TabIndex = 13;
            // 
            // btnCofnij
            // 
            btnCofnij.Image = (Image)resources.GetObject("btnCofnij.Image");
            btnCofnij.Location = new Point(628, 19);
            btnCofnij.Name = "btnCofnij";
            btnCofnij.Size = new Size(44, 33);
            btnCofnij.TabIndex = 14;
            btnCofnij.UseVisualStyleBackColor = true;
            btnCofnij.Click += btnCofnij_Click;
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Location = new Point(0, 25);
            panel1.Name = "panel1";
            panel1.Size = new Size(10, 300);
            panel1.TabIndex = 17;
            // 
            // txtBoxStworzHaslo
            // 
            txtBoxStworzHaslo.Location = new Point(223, 106);
            txtBoxStworzHaslo.Name = "txtBoxStworzHaslo";
            txtBoxStworzHaslo.Size = new Size(229, 23);
            txtBoxStworzHaslo.TabIndex = 18;
            // 
            // txtBoxPowtorzHaslo
            // 
            txtBoxPowtorzHaslo.Location = new Point(223, 179);
            txtBoxPowtorzHaslo.Name = "txtBoxPowtorzHaslo";
            txtBoxPowtorzHaslo.Size = new Size(229, 23);
            txtBoxPowtorzHaslo.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(288, 77);
            label1.Name = "label1";
            label1.Size = new Size(110, 15);
            label1.TabIndex = 20;
            label1.Text = "Utwórz nowe hasło:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(282, 152);
            label2.Name = "label2";
            label2.Size = new Size(116, 15);
            label2.TabIndex = 21;
            label2.Text = "Powtórz nowe hasło:";
            // 
            // btnReset
            // 
            btnReset.Location = new Point(288, 233);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(94, 28);
            btnReset.TabIndex = 22;
            btnReset.Text = "Resetuj hasło";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // ResetujHasloForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(690, 390);
            Controls.Add(btnReset);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtBoxPowtorzHaslo);
            Controls.Add(txtBoxStworzHaslo);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panelGorny);
            Controls.Add(pnlPrzyciski);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ResetujHasloForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ResetujHasloForm";
            pnlPrzyciski.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel3;
        private Panel panel2;
        private Panel panelGorny;
        private Panel pnlPrzyciski;
        private Button btnCofnij;
        private Panel panel1;
        private TextBox txtBoxStworzHaslo;
        private TextBox txtBoxPowtorzHaslo;
        private Label label1;
        private Label label2;
        private Button btnReset;
    }
}