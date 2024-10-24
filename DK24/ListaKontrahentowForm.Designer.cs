namespace DK24
{
    partial class ListaKontrahentowForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaKontrahentowForm));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            pnlPrzyciski = new Panel();
            btnZaznacz = new Button();
            btnCofnij = new Button();
            btnUsun = new Button();
            btnEdytuj = new Button();
            btnDodaj = new Button();
            chckBoxNazwa = new CheckBox();
            chckBoxAkronim = new CheckBox();
            label2 = new Label();
            txtBoxWyszukaj = new TextBox();
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            zamówieniaToolStripMenuItem = new ToolStripMenuItem();
            fakturyToolStripMenuItem = new ToolStripMenuItem();
            dodajToolStripMenuItem = new ToolStripMenuItem();
            zobaczFakturyToolStripMenuItem = new ToolStripMenuItem();
            kontrahenciToolStripMenuItem = new ToolStripMenuItem();
            dodajKontrahentaToolStripMenuItem = new ToolStripMenuItem();
            zobaczKontrahentówToolStripMenuItem = new ToolStripMenuItem();
            wysyłkiToolStripMenuItem = new ToolStripMenuItem();
            stwórzPaczkęToolStripMenuItem = new ToolStripMenuItem();
            zobaczPaczkiToolStripMenuItem = new ToolStripMenuItem();
            towaryToolStripMenuItem = new ToolStripMenuItem();
            dodajTowarToolStripMenuItem = new ToolStripMenuItem();
            zobaczToolStripMenuItem = new ToolStripMenuItem();
            panel3 = new Panel();
            linkLabel1 = new LinkLabel();
            pictureBox1 = new PictureBox();
            lblZalogowanoJako = new Label();
            panel4 = new Panel();
            panel2 = new Panel();
            pnlDtGridZamowienia = new Panel();
            dtGridLstKnt = new DataGridView();
            pnlPrzyciski.SuspendLayout();
            menuStrip1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlDtGridZamowienia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtGridLstKnt).BeginInit();
            SuspendLayout();
            // 
            // pnlPrzyciski
            // 
            pnlPrzyciski.BackgroundImage = (Image)resources.GetObject("pnlPrzyciski.BackgroundImage");
            pnlPrzyciski.Controls.Add(btnZaznacz);
            pnlPrzyciski.Controls.Add(btnCofnij);
            pnlPrzyciski.Controls.Add(btnUsun);
            pnlPrzyciski.Controls.Add(btnEdytuj);
            pnlPrzyciski.Controls.Add(btnDodaj);
            pnlPrzyciski.Controls.Add(chckBoxNazwa);
            pnlPrzyciski.Controls.Add(chckBoxAkronim);
            pnlPrzyciski.Controls.Add(label2);
            pnlPrzyciski.Controls.Add(txtBoxWyszukaj);
            pnlPrzyciski.Controls.Add(label1);
            pnlPrzyciski.Location = new Point(0, 615);
            pnlPrzyciski.Name = "pnlPrzyciski";
            pnlPrzyciski.Size = new Size(1260, 65);
            pnlPrzyciski.TabIndex = 1;
            // 
            // btnZaznacz
            // 
            btnZaznacz.Image = (Image)resources.GetObject("btnZaznacz.Image");
            btnZaznacz.Location = new Point(941, 16);
            btnZaznacz.Name = "btnZaznacz";
            btnZaznacz.Size = new Size(44, 33);
            btnZaznacz.TabIndex = 15;
            btnZaznacz.UseVisualStyleBackColor = true;
            btnZaznacz.Click += btnZaznacz_Click;
            // 
            // btnCofnij
            // 
            btnCofnij.Image = (Image)resources.GetObject("btnCofnij.Image");
            btnCofnij.Location = new Point(1190, 16);
            btnCofnij.Name = "btnCofnij";
            btnCofnij.Size = new Size(44, 33);
            btnCofnij.TabIndex = 14;
            btnCofnij.UseVisualStyleBackColor = true;
            // 
            // btnUsun
            // 
            btnUsun.Image = (Image)resources.GetObject("btnUsun.Image");
            btnUsun.Location = new Point(1130, 16);
            btnUsun.Name = "btnUsun";
            btnUsun.Size = new Size(44, 33);
            btnUsun.TabIndex = 13;
            btnUsun.UseVisualStyleBackColor = true;
            // 
            // btnEdytuj
            // 
            btnEdytuj.Image = (Image)resources.GetObject("btnEdytuj.Image");
            btnEdytuj.Location = new Point(1067, 16);
            btnEdytuj.Name = "btnEdytuj";
            btnEdytuj.Size = new Size(44, 33);
            btnEdytuj.TabIndex = 12;
            btnEdytuj.UseVisualStyleBackColor = true;
            btnEdytuj.Click += btnEdytuj_Click;
            // 
            // btnDodaj
            // 
            btnDodaj.Image = (Image)resources.GetObject("btnDodaj.Image");
            btnDodaj.Location = new Point(1004, 16);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(44, 33);
            btnDodaj.TabIndex = 11;
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // chckBoxNazwa
            // 
            chckBoxNazwa.AutoSize = true;
            chckBoxNazwa.BackColor = Color.Transparent;
            chckBoxNazwa.CheckAlign = ContentAlignment.MiddleRight;
            chckBoxNazwa.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            chckBoxNazwa.ForeColor = Color.White;
            chckBoxNazwa.Location = new Point(647, 27);
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
            chckBoxAkronim.Location = new Point(551, 27);
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
            label2.Location = new Point(382, 27);
            label2.Name = "label2";
            label2.Size = new Size(121, 15);
            label2.TabIndex = 2;
            label2.Text = "(używaj checkboxów)";
            // 
            // txtBoxWyszukaj
            // 
            txtBoxWyszukaj.Location = new Point(126, 22);
            txtBoxWyszukaj.Name = "txtBoxWyszukaj";
            txtBoxWyszukaj.Size = new Size(252, 23);
            txtBoxWyszukaj.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.ForeColor = Color.FromArgb(255, 128, 0);
            label1.Location = new Point(25, 24);
            label1.Name = "label1";
            label1.Size = new Size(94, 18);
            label1.TabIndex = 0;
            label1.Text = "Wyszukaj:";
            // 
            // menuStrip1
            // 
            menuStrip1.AutoSize = false;
            menuStrip1.BackgroundImage = (Image)resources.GetObject("menuStrip1.BackgroundImage");
            menuStrip1.BackgroundImageLayout = ImageLayout.None;
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { zamówieniaToolStripMenuItem, fakturyToolStripMenuItem, kontrahenciToolStripMenuItem, wysyłkiToolStripMenuItem, towaryToolStripMenuItem });
            menuStrip1.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow;
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(250, 35, 0, 5);
            menuStrip1.RenderMode = ToolStripRenderMode.Professional;
            menuStrip1.Size = new Size(1000, 80);
            menuStrip1.Stretch = false;
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // zamówieniaToolStripMenuItem
            // 
            zamówieniaToolStripMenuItem.BackColor = Color.Transparent;
            zamówieniaToolStripMenuItem.ForeColor = Color.Silver;
            zamówieniaToolStripMenuItem.Image = (Image)resources.GetObject("zamówieniaToolStripMenuItem.Image");
            zamówieniaToolStripMenuItem.ImageAlign = ContentAlignment.TopCenter;
            zamówieniaToolStripMenuItem.Name = "zamówieniaToolStripMenuItem";
            zamówieniaToolStripMenuItem.Size = new Size(84, 40);
            zamówieniaToolStripMenuItem.Text = "Zamówienia";
            zamówieniaToolStripMenuItem.TextImageRelation = TextImageRelation.ImageAboveText;
            zamówieniaToolStripMenuItem.Click += zamówieniaToolStripMenuItem_Click_1;
            // 
            // fakturyToolStripMenuItem
            // 
            fakturyToolStripMenuItem.BackColor = Color.Transparent;
            fakturyToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { dodajToolStripMenuItem, zobaczFakturyToolStripMenuItem });
            fakturyToolStripMenuItem.ForeColor = Color.Silver;
            fakturyToolStripMenuItem.Image = (Image)resources.GetObject("fakturyToolStripMenuItem.Image");
            fakturyToolStripMenuItem.Name = "fakturyToolStripMenuItem";
            fakturyToolStripMenuItem.Size = new Size(58, 40);
            fakturyToolStripMenuItem.Text = "Faktury";
            fakturyToolStripMenuItem.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // dodajToolStripMenuItem
            // 
            dodajToolStripMenuItem.Name = "dodajToolStripMenuItem";
            dodajToolStripMenuItem.Size = new Size(154, 22);
            dodajToolStripMenuItem.Text = "Dodaj";
            dodajToolStripMenuItem.Click += dodajToolStripMenuItem_Click_1;
            // 
            // zobaczFakturyToolStripMenuItem
            // 
            zobaczFakturyToolStripMenuItem.Name = "zobaczFakturyToolStripMenuItem";
            zobaczFakturyToolStripMenuItem.Size = new Size(154, 22);
            zobaczFakturyToolStripMenuItem.Text = "Zobacz Faktury";
            zobaczFakturyToolStripMenuItem.Click += zobaczFakturyToolStripMenuItem_Click_1;
            // 
            // kontrahenciToolStripMenuItem
            // 
            kontrahenciToolStripMenuItem.BackColor = Color.Transparent;
            kontrahenciToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { dodajKontrahentaToolStripMenuItem, zobaczKontrahentówToolStripMenuItem });
            kontrahenciToolStripMenuItem.Enabled = false;
            kontrahenciToolStripMenuItem.ForeColor = Color.Silver;
            kontrahenciToolStripMenuItem.Image = (Image)resources.GetObject("kontrahenciToolStripMenuItem.Image");
            kontrahenciToolStripMenuItem.Name = "kontrahenciToolStripMenuItem";
            kontrahenciToolStripMenuItem.Size = new Size(83, 40);
            kontrahenciToolStripMenuItem.Text = "Kontrahenci";
            kontrahenciToolStripMenuItem.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // dodajKontrahentaToolStripMenuItem
            // 
            dodajKontrahentaToolStripMenuItem.Name = "dodajKontrahentaToolStripMenuItem";
            dodajKontrahentaToolStripMenuItem.Size = new Size(190, 22);
            dodajKontrahentaToolStripMenuItem.Text = "Dodaj Kontrahenta";
            // 
            // zobaczKontrahentówToolStripMenuItem
            // 
            zobaczKontrahentówToolStripMenuItem.Name = "zobaczKontrahentówToolStripMenuItem";
            zobaczKontrahentówToolStripMenuItem.Size = new Size(190, 22);
            zobaczKontrahentówToolStripMenuItem.Text = "Zobacz Kontrahentów";
            // 
            // wysyłkiToolStripMenuItem
            // 
            wysyłkiToolStripMenuItem.BackColor = Color.Transparent;
            wysyłkiToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { stwórzPaczkęToolStripMenuItem, zobaczPaczkiToolStripMenuItem });
            wysyłkiToolStripMenuItem.ForeColor = Color.Silver;
            wysyłkiToolStripMenuItem.Image = (Image)resources.GetObject("wysyłkiToolStripMenuItem.Image");
            wysyłkiToolStripMenuItem.Name = "wysyłkiToolStripMenuItem";
            wysyłkiToolStripMenuItem.Size = new Size(59, 40);
            wysyłkiToolStripMenuItem.Text = "Wysyłki";
            wysyłkiToolStripMenuItem.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // stwórzPaczkęToolStripMenuItem
            // 
            stwórzPaczkęToolStripMenuItem.Name = "stwórzPaczkęToolStripMenuItem";
            stwórzPaczkęToolStripMenuItem.Size = new Size(148, 22);
            stwórzPaczkęToolStripMenuItem.Text = "Stwórz paczkę";
            // 
            // zobaczPaczkiToolStripMenuItem
            // 
            zobaczPaczkiToolStripMenuItem.Name = "zobaczPaczkiToolStripMenuItem";
            zobaczPaczkiToolStripMenuItem.Size = new Size(148, 22);
            zobaczPaczkiToolStripMenuItem.Text = "Zobacz paczki";
            // 
            // towaryToolStripMenuItem
            // 
            towaryToolStripMenuItem.BackColor = Color.Transparent;
            towaryToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { dodajTowarToolStripMenuItem, zobaczToolStripMenuItem });
            towaryToolStripMenuItem.ForeColor = Color.Silver;
            towaryToolStripMenuItem.Image = (Image)resources.GetObject("towaryToolStripMenuItem.Image");
            towaryToolStripMenuItem.Name = "towaryToolStripMenuItem";
            towaryToolStripMenuItem.Size = new Size(98, 40);
            towaryToolStripMenuItem.Text = "Towary i Usługi";
            towaryToolStripMenuItem.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // dodajTowarToolStripMenuItem
            // 
            dodajTowarToolStripMenuItem.Name = "dodajTowarToolStripMenuItem";
            dodajTowarToolStripMenuItem.Size = new Size(190, 22);
            dodajTowarToolStripMenuItem.Text = "Dodaj Towar/Usługę";
            // 
            // zobaczToolStripMenuItem
            // 
            zobaczToolStripMenuItem.Name = "zobaczToolStripMenuItem";
            zobaczToolStripMenuItem.Size = new Size(190, 22);
            zobaczToolStripMenuItem.Text = "Zobacz Towary/Usługi";
            // 
            // panel3
            // 
            panel3.BackgroundImage = (Image)resources.GetObject("panel3.BackgroundImage");
            panel3.Controls.Add(linkLabel1);
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(lblZalogowanoJako);
            panel3.Location = new Point(1000, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(260, 80);
            panel3.TabIndex = 6;
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.Silver;
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.Transparent;
            linkLabel1.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            linkLabel1.LinkColor = Color.FromArgb(255, 192, 128);
            linkLabel1.Location = new Point(89, 61);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(73, 13);
            linkLabel1.TabIndex = 2;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Wyloguj się";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(111, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(35, 35);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // lblZalogowanoJako
            // 
            lblZalogowanoJako.AutoSize = true;
            lblZalogowanoJako.BackColor = Color.Transparent;
            lblZalogowanoJako.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lblZalogowanoJako.ForeColor = Color.FromArgb(255, 128, 0);
            lblZalogowanoJako.Location = new Point(0, 43);
            lblZalogowanoJako.Name = "lblZalogowanoJako";
            lblZalogowanoJako.Size = new Size(110, 13);
            lblZalogowanoJako.TabIndex = 14;
            lblZalogowanoJako.Text = "Zalogowano jako:";
            // 
            // panel4
            // 
            panel4.BackgroundImage = (Image)resources.GetObject("panel4.BackgroundImage");
            panel4.Location = new Point(1250, 80);
            panel4.Name = "panel4";
            panel4.Size = new Size(10, 535);
            panel4.TabIndex = 8;
            // 
            // panel2
            // 
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.Location = new Point(0, 80);
            panel2.Name = "panel2";
            panel2.Size = new Size(10, 535);
            panel2.TabIndex = 7;
            // 
            // pnlDtGridZamowienia
            // 
            pnlDtGridZamowienia.BackColor = Color.White;
            pnlDtGridZamowienia.Controls.Add(dtGridLstKnt);
            pnlDtGridZamowienia.ImeMode = ImeMode.NoControl;
            pnlDtGridZamowienia.Location = new Point(11, 81);
            pnlDtGridZamowienia.Margin = new Padding(3, 2, 3, 2);
            pnlDtGridZamowienia.Name = "pnlDtGridZamowienia";
            pnlDtGridZamowienia.Size = new Size(1238, 533);
            pnlDtGridZamowienia.TabIndex = 9;
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
            dtGridLstKnt.Size = new Size(1238, 533);
            dtGridLstKnt.TabIndex = 0;
            // 
            // ListaKontrahentowForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(1260, 680);
            Controls.Add(pnlDtGridZamowienia);
            Controls.Add(pnlPrzyciski);
            Controls.Add(panel3);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(1260, 680);
            MinimumSize = new Size(1260, 680);
            Name = "ListaKontrahentowForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "D&K - Lista Kontrahentów";
            Load += ListaKontrahentowForm_Load;
            pnlPrzyciski.ResumeLayout(false);
            pnlPrzyciski.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlDtGridZamowienia.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtGridLstKnt).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel pnlPrzyciski;
        private CheckBox chckBoxNazwa;
        private CheckBox chckBoxAkronim;
        private Label label2;
        private TextBox txtBoxWyszukaj;
        private Label label1;
        private Button btnZaznacz;
        private Button btnCofnij;
        private Button btnUsun;
        private Button btnEdytuj;
        private Button btnDodaj;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem zamówieniaToolStripMenuItem;
        private ToolStripMenuItem fakturyToolStripMenuItem;
        private ToolStripMenuItem dodajToolStripMenuItem;
        private ToolStripMenuItem zobaczFakturyToolStripMenuItem;
        private ToolStripMenuItem kontrahenciToolStripMenuItem;
        private ToolStripMenuItem dodajKontrahentaToolStripMenuItem;
        private ToolStripMenuItem zobaczKontrahentówToolStripMenuItem;
        private ToolStripMenuItem wysyłkiToolStripMenuItem;
        private ToolStripMenuItem stwórzPaczkęToolStripMenuItem;
        private ToolStripMenuItem zobaczPaczkiToolStripMenuItem;
        private ToolStripMenuItem towaryToolStripMenuItem;
        private ToolStripMenuItem dodajTowarToolStripMenuItem;
        private ToolStripMenuItem zobaczToolStripMenuItem;
        private Panel panel3;
        private LinkLabel linkLabel1;
        private PictureBox pictureBox1;
        private Label lblZalogowanoJako;
        private Panel panel4;
        private Panel panel2;
        private Panel pnlDtGridZamowienia;
        private DataGridView dtGridLstKnt;
    }
}