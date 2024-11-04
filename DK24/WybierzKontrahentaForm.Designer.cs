namespace DK24
{
    partial class WybierzKontrahentaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WybierzKontrahentaForm));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            pnlPrzyciski = new Panel();
            btnZaznacz = new Button();
            btnCofnij = new Button();
            chckBoxNazwa = new CheckBox();
            chckBoxAkronim = new CheckBox();
            label2 = new Label();
            txtBoxWyszukaj = new TextBox();
            label1 = new Label();
            panelGorny = new Panel();
            pnlDtGridZamowienia = new Panel();
            dtGridLstKnt = new DataGridView();
            panel2 = new Panel();
            panel3 = new Panel();
            pnlPrzyciski.SuspendLayout();
            pnlDtGridZamowienia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtGridLstKnt).BeginInit();
            SuspendLayout();
            // 
            // pnlPrzyciski
            // 
            pnlPrzyciski.BackgroundImage = (Image)resources.GetObject("pnlPrzyciski.BackgroundImage");
            pnlPrzyciski.Controls.Add(btnZaznacz);
            pnlPrzyciski.Controls.Add(btnCofnij);
            pnlPrzyciski.Controls.Add(chckBoxNazwa);
            pnlPrzyciski.Controls.Add(chckBoxAkronim);
            pnlPrzyciski.Controls.Add(label2);
            pnlPrzyciski.Controls.Add(txtBoxWyszukaj);
            pnlPrzyciski.Controls.Add(label1);
            pnlPrzyciski.Location = new Point(0, 325);
            pnlPrzyciski.Name = "pnlPrzyciski";
            pnlPrzyciski.Size = new Size(690, 65);
            pnlPrzyciski.TabIndex = 2;
            // 
            // btnZaznacz
            // 
            btnZaznacz.Image = (Image)resources.GetObject("btnZaznacz.Image");
            btnZaznacz.Location = new Point(564, 18);
            btnZaznacz.Name = "btnZaznacz";
            btnZaznacz.Size = new Size(44, 33);
            btnZaznacz.TabIndex = 15;
            btnZaznacz.UseVisualStyleBackColor = true;
            btnZaznacz.Click += btnZaznacz_Click;
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
            // chckBoxNazwa
            // 
            chckBoxNazwa.AutoSize = true;
            chckBoxNazwa.BackColor = Color.Transparent;
            chckBoxNazwa.CheckAlign = ContentAlignment.MiddleRight;
            chckBoxNazwa.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            chckBoxNazwa.ForeColor = Color.White;
            chckBoxNazwa.Location = new Point(391, 26);
            chckBoxNazwa.Name = "chckBoxNazwa";
            chckBoxNazwa.Size = new Size(74, 18);
            chckBoxNazwa.TabIndex = 4;
            chckBoxNazwa.Text = "Nazwa:";
            chckBoxNazwa.UseVisualStyleBackColor = false;
            // 
            // chckBoxAkronim
            // 
            chckBoxAkronim.AutoSize = true;
            chckBoxAkronim.BackColor = Color.Transparent;
            chckBoxAkronim.CheckAlign = ContentAlignment.MiddleRight;
            chckBoxAkronim.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            chckBoxAkronim.ForeColor = Color.White;
            chckBoxAkronim.Location = new Point(294, 26);
            chckBoxAkronim.Name = "chckBoxAkronim";
            chckBoxAkronim.Size = new Size(81, 18);
            chckBoxAkronim.TabIndex = 3;
            chckBoxAkronim.Text = "Akronim:";
            chckBoxAkronim.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = Color.Silver;
            label2.Location = new Point(108, 6);
            label2.Name = "label2";
            label2.Size = new Size(121, 15);
            label2.TabIndex = 2;
            label2.Text = "(używaj checkboxów)";
            // 
            // txtBoxWyszukaj
            // 
            txtBoxWyszukaj.Location = new Point(20, 27);
            txtBoxWyszukaj.Name = "txtBoxWyszukaj";
            txtBoxWyszukaj.Size = new Size(252, 23);
            txtBoxWyszukaj.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.ForeColor = Color.FromArgb(255, 128, 0);
            label1.Location = new Point(20, 6);
            label1.Name = "label1";
            label1.Size = new Size(82, 16);
            label1.TabIndex = 0;
            label1.Text = "Wyszukaj:";
            // 
            // panelGorny
            // 
            panelGorny.BackgroundImage = (Image)resources.GetObject("panelGorny.BackgroundImage");
            panelGorny.Location = new Point(0, 0);
            panelGorny.Name = "panelGorny";
            panelGorny.Size = new Size(690, 25);
            panelGorny.TabIndex = 3;
            // 
            // pnlDtGridZamowienia
            // 
            pnlDtGridZamowienia.BackColor = Color.White;
            pnlDtGridZamowienia.Controls.Add(dtGridLstKnt);
            pnlDtGridZamowienia.ImeMode = ImeMode.NoControl;
            pnlDtGridZamowienia.Location = new Point(11, 26);
            pnlDtGridZamowienia.Margin = new Padding(3, 2, 3, 2);
            pnlDtGridZamowienia.Name = "pnlDtGridZamowienia";
            pnlDtGridZamowienia.Size = new Size(668, 298);
            pnlDtGridZamowienia.TabIndex = 10;
            // 
            // dtGridLstKnt
            // 
            dtGridLstKnt.AccessibleRole = AccessibleRole.Caret;
            dtGridLstKnt.AllowUserToAddRows = false;
            dtGridLstKnt.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.LightGray;
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.NullValue = "Brak Danych";
            dtGridLstKnt.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dtGridLstKnt.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtGridLstKnt.BackgroundColor = SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dtGridLstKnt.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dtGridLstKnt.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.NullValue = "Brak Danych";
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dtGridLstKnt.DefaultCellStyle = dataGridViewCellStyle3;
            dtGridLstKnt.Dock = DockStyle.Fill;
            dtGridLstKnt.GridColor = Color.Gray;
            dtGridLstKnt.Location = new Point(0, 0);
            dtGridLstKnt.Margin = new Padding(3, 2, 3, 2);
            dtGridLstKnt.Name = "dtGridLstKnt";
            dtGridLstKnt.ReadOnly = true;
            dtGridLstKnt.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.ControlDark;
            dataGridViewCellStyle4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dtGridLstKnt.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dtGridLstKnt.RowHeadersVisible = false;
            dtGridLstKnt.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dtGridLstKnt.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtGridLstKnt.ShowCellErrors = false;
            dtGridLstKnt.ShowCellToolTips = false;
            dtGridLstKnt.ShowEditingIcon = false;
            dtGridLstKnt.ShowRowErrors = false;
            dtGridLstKnt.Size = new Size(668, 298);
            dtGridLstKnt.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.Location = new Point(680, 25);
            panel2.Name = "panel2";
            panel2.Size = new Size(10, 300);
            panel2.TabIndex = 11;
            // 
            // panel3
            // 
            panel3.BackgroundImage = (Image)resources.GetObject("panel3.BackgroundImage");
            panel3.Location = new Point(0, 25);
            panel3.Name = "panel3";
            panel3.Size = new Size(10, 300);
            panel3.TabIndex = 12;
            // 
            // WybierzKontrahentaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(690, 390);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(pnlDtGridZamowienia);
            Controls.Add(panelGorny);
            Controls.Add(pnlPrzyciski);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "WybierzKontrahentaForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "WybierzKontrahenta";
            Load += WybierzKontrahentaForm_Load;
            pnlPrzyciski.ResumeLayout(false);
            pnlPrzyciski.PerformLayout();
            pnlDtGridZamowienia.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtGridLstKnt).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlPrzyciski;
        private Button btnZaznacz;
        private Button btnCofnij;
        private CheckBox chckBoxNazwa;
        private CheckBox chckBoxAkronim;
        private Label label2;
        private TextBox txtBoxWyszukaj;
        private Label label1;
        private Panel panelGorny;
        private Panel pnlDtGridZamowienia;
        private DataGridView dtGridLstKnt;
        private Panel panel2;
        private Panel panel3;
    }
}