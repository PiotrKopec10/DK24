﻿namespace DK24
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
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
            menuStrip = new MenuStrip();
            zamówieniaToolStripMenuItem = new ToolStripMenuItem();
            fakturyToolStripMenuItem = new ToolStripMenuItem();
            kontrahenciToolStripMenuItem = new ToolStripMenuItem();
            towaryToolStripMenuItem = new ToolStripMenuItem();
            panelZalogowania = new Panel();
            imgMinimalize = new PictureBox();
            linkLabel1 = new LinkLabel();
            pictureBox1 = new PictureBox();
            lblZalogowanoJako = new Label();
            panel4 = new Panel();
            panel2 = new Panel();
            pnlDtGridZamowienia = new Panel();
            dtGridLstKnt = new DataGridView();
            ZarzadzajPracownikamiToolStripMenuItem = new ToolStripMenuItem();
            pnlPrzyciski.SuspendLayout();
            menuStrip.SuspendLayout();
            panelZalogowania.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgMinimalize).BeginInit();
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
            btnCofnij.Click += btnCofnij_Click;
            // 
            // btnUsun
            // 
            btnUsun.Image = (Image)resources.GetObject("btnUsun.Image");
            btnUsun.Location = new Point(1130, 16);
            btnUsun.Name = "btnUsun";
            btnUsun.Size = new Size(44, 33);
            btnUsun.TabIndex = 13;
            btnUsun.UseVisualStyleBackColor = true;
            btnUsun.Click += btnUsun_Click;
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
            chckBoxNazwa.CheckedChanged += chckBoxNazwa_CheckedChanged;
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
            chckBoxAkronim.CheckedChanged += chckBoxAkronim_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = Color.Silver;
            label2.Location = new Point(382, 27);
            label2.Name = "label2";
            label2.Size = new Size(120, 15);
            label2.TabIndex = 2;
            label2.Text = "(używaj checkboxów)";
            // 
            // txtBoxWyszukaj
            // 
            txtBoxWyszukaj.Location = new Point(126, 22);
            txtBoxWyszukaj.Name = "txtBoxWyszukaj";
            txtBoxWyszukaj.Size = new Size(252, 23);
            txtBoxWyszukaj.TabIndex = 1;
            txtBoxWyszukaj.TextChanged += txtBoxWyszukaj_TextChanged;
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
            // menuStrip
            // 
            menuStrip.AutoSize = false;
            menuStrip.BackgroundImage = (Image)resources.GetObject("menuStrip.BackgroundImage");
            menuStrip.BackgroundImageLayout = ImageLayout.None;
            menuStrip.Dock = DockStyle.None;
            menuStrip.ImageScalingSize = new Size(20, 20);
            menuStrip.Items.AddRange(new ToolStripItem[] { zamówieniaToolStripMenuItem, fakturyToolStripMenuItem, kontrahenciToolStripMenuItem, towaryToolStripMenuItem, ZarzadzajPracownikamiToolStripMenuItem });
            menuStrip.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow;
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Padding = new Padding(250, 35, 0, 5);
            menuStrip.RenderMode = ToolStripRenderMode.Professional;
            menuStrip.Size = new Size(1000, 80);
            menuStrip.Stretch = false;
            menuStrip.TabIndex = 1;
            menuStrip.Text = "menuStrip1";
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
            fakturyToolStripMenuItem.ForeColor = Color.Silver;
            fakturyToolStripMenuItem.Image = (Image)resources.GetObject("fakturyToolStripMenuItem.Image");
            fakturyToolStripMenuItem.Name = "fakturyToolStripMenuItem";
            fakturyToolStripMenuItem.Size = new Size(58, 40);
            fakturyToolStripMenuItem.Text = "Faktury";
            fakturyToolStripMenuItem.TextImageRelation = TextImageRelation.ImageAboveText;
            fakturyToolStripMenuItem.Click += fakturyToolStripMenuItem_Click;
            // 
            // kontrahenciToolStripMenuItem
            // 
            kontrahenciToolStripMenuItem.BackColor = Color.Transparent;
            kontrahenciToolStripMenuItem.Enabled = false;
            kontrahenciToolStripMenuItem.ForeColor = Color.Silver;
            kontrahenciToolStripMenuItem.Image = (Image)resources.GetObject("kontrahenciToolStripMenuItem.Image");
            kontrahenciToolStripMenuItem.Name = "kontrahenciToolStripMenuItem";
            kontrahenciToolStripMenuItem.Size = new Size(83, 40);
            kontrahenciToolStripMenuItem.Text = "Kontrahenci";
            kontrahenciToolStripMenuItem.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // towaryToolStripMenuItem
            // 
            towaryToolStripMenuItem.BackColor = Color.Transparent;
            towaryToolStripMenuItem.ForeColor = Color.Silver;
            towaryToolStripMenuItem.Image = (Image)resources.GetObject("towaryToolStripMenuItem.Image");
            towaryToolStripMenuItem.Name = "towaryToolStripMenuItem";
            towaryToolStripMenuItem.Size = new Size(99, 40);
            towaryToolStripMenuItem.Text = "Towary i Usługi";
            towaryToolStripMenuItem.TextImageRelation = TextImageRelation.ImageAboveText;
            towaryToolStripMenuItem.Click += towaryToolStripMenuItem_Click;
            // 
            // panelZalogowania
            // 
            panelZalogowania.BackgroundImage = (Image)resources.GetObject("panelZalogowania.BackgroundImage");
            panelZalogowania.Controls.Add(imgMinimalize);
            panelZalogowania.Controls.Add(linkLabel1);
            panelZalogowania.Controls.Add(pictureBox1);
            panelZalogowania.Controls.Add(lblZalogowanoJako);
            panelZalogowania.Location = new Point(1000, 0);
            panelZalogowania.Name = "panelZalogowania";
            panelZalogowania.Size = new Size(260, 80);
            panelZalogowania.TabIndex = 6;
            // 
            // imgMinimalize
            // 
            imgMinimalize.BackColor = Color.Transparent;
            imgMinimalize.Image = (Image)resources.GetObject("imgMinimalize.Image");
            imgMinimalize.Location = new Point(234, 3);
            imgMinimalize.Name = "imgMinimalize";
            imgMinimalize.Size = new Size(23, 20);
            imgMinimalize.SizeMode = PictureBoxSizeMode.Zoom;
            imgMinimalize.TabIndex = 16;
            imgMinimalize.TabStop = false;
            imgMinimalize.Click += imgMinimalize_Click;
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
            dataGridViewCellStyle5.BackColor = Color.LightGray;
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.NullValue = "Brak Danych";
            dtGridLstKnt.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            dtGridLstKnt.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtGridLstKnt.BackgroundColor = SystemColors.ControlDarkDark;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle6.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dtGridLstKnt.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dtGridLstKnt.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.Control;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            dataGridViewCellStyle7.ForeColor = Color.Black;
            dataGridViewCellStyle7.NullValue = "Brak Danych";
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.False;
            dtGridLstKnt.DefaultCellStyle = dataGridViewCellStyle7;
            dtGridLstKnt.Dock = DockStyle.Fill;
            dtGridLstKnt.GridColor = Color.Gray;
            dtGridLstKnt.Location = new Point(0, 0);
            dtGridLstKnt.Margin = new Padding(3, 2, 3, 2);
            dtGridLstKnt.Name = "dtGridLstKnt";
            dtGridLstKnt.ReadOnly = true;
            dtGridLstKnt.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.ControlDark;
            dataGridViewCellStyle8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            dataGridViewCellStyle8.ForeColor = Color.White;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            dtGridLstKnt.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
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
            // ZarzadzajPracownikamiToolStripMenuItem
            // 
            ZarzadzajPracownikamiToolStripMenuItem.ForeColor = Color.Silver;
            ZarzadzajPracownikamiToolStripMenuItem.Image = (Image)resources.GetObject("ZarzadzajPracownikamiToolStripMenuItem.Image");
            ZarzadzajPracownikamiToolStripMenuItem.Name = "ZarzadzajPracownikamiToolStripMenuItem";
            ZarzadzajPracownikamiToolStripMenuItem.Size = new Size(146, 40);
            ZarzadzajPracownikamiToolStripMenuItem.Text = "Zarządzaj Pracownikami";
            ZarzadzajPracownikamiToolStripMenuItem.TextImageRelation = TextImageRelation.ImageAboveText;
            ZarzadzajPracownikamiToolStripMenuItem.Click += ZarzadzajPracownikamiToolStripMenuItem_Click;
            // 
            // ListaKontrahentowForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(1260, 680);
            Controls.Add(pnlDtGridZamowienia);
            Controls.Add(pnlPrzyciski);
            Controls.Add(panelZalogowania);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(menuStrip);
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
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            panelZalogowania.ResumeLayout(false);
            panelZalogowania.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imgMinimalize).EndInit();
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
        private MenuStrip menuStrip;
        private ToolStripMenuItem zamówieniaToolStripMenuItem;
        private ToolStripMenuItem fakturyToolStripMenuItem;
        private ToolStripMenuItem kontrahenciToolStripMenuItem;
        private ToolStripMenuItem towaryToolStripMenuItem;
        private Panel panelZalogowania;
        private LinkLabel linkLabel1;
        private PictureBox pictureBox1;
        private Label lblZalogowanoJako;
        private Panel panel4;
        private Panel panel2;
        private Panel pnlDtGridZamowienia;
        private DataGridView dtGridLstKnt;
        private PictureBox imgMinimalize;
        private ToolStripMenuItem ZarzadzajPracownikamiToolStripMenuItem;
    }
}