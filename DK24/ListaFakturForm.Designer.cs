namespace DK24
{
    partial class ListaFakturForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaFakturForm));
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            pnlPrzyciski = new Panel();
            btnCofnij = new Button();
            btnUsun = new Button();
            btnEdytuj = new Button();
            btnDodaj = new Button();
            txtBoxFilter = new TextBox();
            label2 = new Label();
            numericUpDown1 = new NumericUpDown();
            comboBox1 = new ComboBox();
            chckBoxRok = new CheckBox();
            chckBoxMiesiac = new CheckBox();
            label1 = new Label();
            lblZalogowanoJako = new Label();
            panelZalogowania = new Panel();
            linkLabel1 = new LinkLabel();
            pictureBox1 = new PictureBox();
            panel4 = new Panel();
            panel2 = new Panel();
            menuStrip = new MenuStrip();
            zamówieniaToolStripMenuItem = new ToolStripMenuItem();
            fakturyToolStripMenuItem = new ToolStripMenuItem();
            kontrahenciToolStripMenuItem = new ToolStripMenuItem();
            wysyłkiToolStripMenuItem = new ToolStripMenuItem();
            towaryToolStripMenuItem = new ToolStripMenuItem();
            pnlDtGridZamowienia = new Panel();
            dtGridLstFakt = new DataGridView();
            pnlPrzyciski.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            panelZalogowania.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menuStrip.SuspendLayout();
            pnlDtGridZamowienia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtGridLstFakt).BeginInit();
            SuspendLayout();
            // 
            // pnlPrzyciski
            // 
            pnlPrzyciski.BackgroundImage = (Image)resources.GetObject("pnlPrzyciski.BackgroundImage");
            pnlPrzyciski.Controls.Add(btnCofnij);
            pnlPrzyciski.Controls.Add(btnUsun);
            pnlPrzyciski.Controls.Add(btnEdytuj);
            pnlPrzyciski.Controls.Add(btnDodaj);
            pnlPrzyciski.Controls.Add(txtBoxFilter);
            pnlPrzyciski.Controls.Add(label2);
            pnlPrzyciski.Controls.Add(numericUpDown1);
            pnlPrzyciski.Controls.Add(comboBox1);
            pnlPrzyciski.Controls.Add(chckBoxRok);
            pnlPrzyciski.Controls.Add(chckBoxMiesiac);
            pnlPrzyciski.Controls.Add(label1);
            pnlPrzyciski.Location = new Point(0, 615);
            pnlPrzyciski.Name = "pnlPrzyciski";
            pnlPrzyciski.Size = new Size(1260, 65);
            pnlPrzyciski.TabIndex = 2;
            // 
            // btnCofnij
            // 
            btnCofnij.BackColor = Color.Transparent;
            btnCofnij.Image = (Image)resources.GetObject("btnCofnij.Image");
            btnCofnij.Location = new Point(1188, 16);
            btnCofnij.Name = "btnCofnij";
            btnCofnij.Size = new Size(44, 33);
            btnCofnij.TabIndex = 10;
            btnCofnij.UseVisualStyleBackColor = false;
            // 
            // btnUsun
            // 
            btnUsun.FlatStyle = FlatStyle.Flat;
            btnUsun.Image = (Image)resources.GetObject("btnUsun.Image");
            btnUsun.Location = new Point(1128, 16);
            btnUsun.Name = "btnUsun";
            btnUsun.Size = new Size(44, 33);
            btnUsun.TabIndex = 9;
            btnUsun.UseVisualStyleBackColor = true;
            // 
            // btnEdytuj
            // 
            btnEdytuj.FlatStyle = FlatStyle.Flat;
            btnEdytuj.Image = (Image)resources.GetObject("btnEdytuj.Image");
            btnEdytuj.Location = new Point(1065, 16);
            btnEdytuj.Name = "btnEdytuj";
            btnEdytuj.Size = new Size(44, 33);
            btnEdytuj.TabIndex = 8;
            btnEdytuj.UseVisualStyleBackColor = true;
            // 
            // btnDodaj
            // 
            btnDodaj.BackColor = Color.Transparent;
            btnDodaj.Image = (Image)resources.GetObject("btnDodaj.Image");
            btnDodaj.Location = new Point(1002, 16);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(44, 33);
            btnDodaj.TabIndex = 7;
            btnDodaj.UseVisualStyleBackColor = false;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // txtBoxFilter
            // 
            txtBoxFilter.Location = new Point(599, 21);
            txtBoxFilter.Name = "txtBoxFilter";
            txtBoxFilter.Size = new Size(273, 23);
            txtBoxFilter.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label2.ForeColor = Color.White;
            label2.Location = new Point(542, 23);
            label2.Name = "label2";
            label2.Size = new Size(56, 18);
            label2.TabIndex = 5;
            label2.Text = "Filtruj:";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(388, 23);
            numericUpDown1.Maximum = new decimal(new int[] { 2100, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 1980, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(66, 23);
            numericUpDown1.TabIndex = 4;
            numericUpDown1.TextAlign = HorizontalAlignment.Center;
            numericUpDown1.Value = new decimal(new int[] { 2024, 0, 0, 0 });
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(183, 22);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(130, 23);
            comboBox1.TabIndex = 3;
            // 
            // chckBoxRok
            // 
            chckBoxRok.AutoSize = true;
            chckBoxRok.BackColor = Color.Transparent;
            chckBoxRok.CheckAlign = ContentAlignment.MiddleRight;
            chckBoxRok.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            chckBoxRok.ForeColor = Color.White;
            chckBoxRok.Location = new Point(330, 24);
            chckBoxRok.Name = "chckBoxRok";
            chckBoxRok.Size = new Size(49, 20);
            chckBoxRok.TabIndex = 2;
            chckBoxRok.Text = "Rok";
            chckBoxRok.UseVisualStyleBackColor = false;
            // 
            // chckBoxMiesiac
            // 
            chckBoxMiesiac.AutoSize = true;
            chckBoxMiesiac.BackColor = Color.Transparent;
            chckBoxMiesiac.CheckAlign = ContentAlignment.MiddleRight;
            chckBoxMiesiac.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            chckBoxMiesiac.ForeColor = Color.White;
            chckBoxMiesiac.Location = new Point(105, 24);
            chckBoxMiesiac.Name = "chckBoxMiesiac";
            chckBoxMiesiac.Size = new Size(74, 20);
            chckBoxMiesiac.TabIndex = 1;
            chckBoxMiesiac.Text = "Miesiąc";
            chckBoxMiesiac.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.ForeColor = Color.FromArgb(255, 128, 0);
            label1.Location = new Point(19, 24);
            label1.Name = "label1";
            label1.Size = new Size(78, 18);
            label1.TabIndex = 0;
            label1.Text = "Lista za:";
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
            // panelZalogowania
            // 
            panelZalogowania.BackgroundImage = (Image)resources.GetObject("panelZalogowania.BackgroundImage");
            panelZalogowania.Controls.Add(linkLabel1);
            panelZalogowania.Controls.Add(pictureBox1);
            panelZalogowania.Controls.Add(lblZalogowanoJako);
            panelZalogowania.Location = new Point(1000, 0);
            panelZalogowania.Name = "panelZalogowania";
            panelZalogowania.Size = new Size(260, 80);
            panelZalogowania.TabIndex = 10;
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
            // panel4
            // 
            panel4.BackgroundImage = (Image)resources.GetObject("panel4.BackgroundImage");
            panel4.Location = new Point(1250, 80);
            panel4.Name = "panel4";
            panel4.Size = new Size(10, 535);
            panel4.TabIndex = 12;
            // 
            // panel2
            // 
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.Location = new Point(0, 80);
            panel2.Name = "panel2";
            panel2.Size = new Size(10, 535);
            panel2.TabIndex = 11;
            // 
            // menuStrip
            // 
            menuStrip.AutoSize = false;
            menuStrip.BackgroundImage = (Image)resources.GetObject("menuStrip.BackgroundImage");
            menuStrip.BackgroundImageLayout = ImageLayout.None;
            menuStrip.Dock = DockStyle.None;
            menuStrip.ImageScalingSize = new Size(20, 20);
            menuStrip.Items.AddRange(new ToolStripItem[] { zamówieniaToolStripMenuItem, fakturyToolStripMenuItem, kontrahenciToolStripMenuItem, wysyłkiToolStripMenuItem, towaryToolStripMenuItem });
            menuStrip.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow;
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Padding = new Padding(250, 35, 0, 5);
            menuStrip.RenderMode = ToolStripRenderMode.Professional;
            menuStrip.Size = new Size(1000, 80);
            menuStrip.Stretch = false;
            menuStrip.TabIndex = 9;
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
            zamówieniaToolStripMenuItem.Click += zamówieniaToolStripMenuItem_Click;
            // 
            // fakturyToolStripMenuItem
            // 
            fakturyToolStripMenuItem.BackColor = Color.Transparent;
            fakturyToolStripMenuItem.Enabled = false;
            fakturyToolStripMenuItem.ForeColor = Color.Silver;
            fakturyToolStripMenuItem.Image = (Image)resources.GetObject("fakturyToolStripMenuItem.Image");
            fakturyToolStripMenuItem.Name = "fakturyToolStripMenuItem";
            fakturyToolStripMenuItem.Size = new Size(58, 40);
            fakturyToolStripMenuItem.Text = "Faktury";
            fakturyToolStripMenuItem.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // kontrahenciToolStripMenuItem
            // 
            kontrahenciToolStripMenuItem.BackColor = Color.Transparent;
            kontrahenciToolStripMenuItem.ForeColor = Color.Silver;
            kontrahenciToolStripMenuItem.Image = (Image)resources.GetObject("kontrahenciToolStripMenuItem.Image");
            kontrahenciToolStripMenuItem.Name = "kontrahenciToolStripMenuItem";
            kontrahenciToolStripMenuItem.Size = new Size(83, 40);
            kontrahenciToolStripMenuItem.Text = "Kontrahenci";
            kontrahenciToolStripMenuItem.TextImageRelation = TextImageRelation.ImageAboveText;
            kontrahenciToolStripMenuItem.Click += kontrahenciToolStripMenuItem_Click;
            // 
            // wysyłkiToolStripMenuItem
            // 
            wysyłkiToolStripMenuItem.BackColor = Color.Transparent;
            wysyłkiToolStripMenuItem.ForeColor = Color.Silver;
            wysyłkiToolStripMenuItem.Image = (Image)resources.GetObject("wysyłkiToolStripMenuItem.Image");
            wysyłkiToolStripMenuItem.Name = "wysyłkiToolStripMenuItem";
            wysyłkiToolStripMenuItem.Size = new Size(59, 40);
            wysyłkiToolStripMenuItem.Text = "Wysyłki";
            wysyłkiToolStripMenuItem.TextImageRelation = TextImageRelation.ImageAboveText;
            wysyłkiToolStripMenuItem.Click += wysyłkiToolStripMenuItem_Click;
            // 
            // towaryToolStripMenuItem
            // 
            towaryToolStripMenuItem.BackColor = Color.Transparent;
            towaryToolStripMenuItem.ForeColor = Color.Silver;
            towaryToolStripMenuItem.Image = (Image)resources.GetObject("towaryToolStripMenuItem.Image");
            towaryToolStripMenuItem.Name = "towaryToolStripMenuItem";
            towaryToolStripMenuItem.Size = new Size(98, 40);
            towaryToolStripMenuItem.Text = "Towary i Usługi";
            towaryToolStripMenuItem.TextImageRelation = TextImageRelation.ImageAboveText;
            towaryToolStripMenuItem.Click += towaryToolStripMenuItem_Click;
            // 
            // pnlDtGridZamowienia
            // 
            pnlDtGridZamowienia.BackColor = Color.White;
            pnlDtGridZamowienia.Controls.Add(dtGridLstFakt);
            pnlDtGridZamowienia.ImeMode = ImeMode.NoControl;
            pnlDtGridZamowienia.Location = new Point(11, 81);
            pnlDtGridZamowienia.Margin = new Padding(3, 2, 3, 2);
            pnlDtGridZamowienia.Name = "pnlDtGridZamowienia";
            pnlDtGridZamowienia.Size = new Size(1238, 533);
            pnlDtGridZamowienia.TabIndex = 13;
            // 
            // dtGridLstFakt
            // 
            dtGridLstFakt.AccessibleRole = AccessibleRole.Caret;
            dtGridLstFakt.AllowUserToAddRows = false;
            dtGridLstFakt.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = Color.LightGray;
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.NullValue = "Brak Danych";
            dtGridLstFakt.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            dtGridLstFakt.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtGridLstFakt.BackgroundColor = SystemColors.ControlDarkDark;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle6.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dtGridLstFakt.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dtGridLstFakt.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.Control;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            dataGridViewCellStyle7.ForeColor = Color.Black;
            dataGridViewCellStyle7.NullValue = "Brak Danych";
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.False;
            dtGridLstFakt.DefaultCellStyle = dataGridViewCellStyle7;
            dtGridLstFakt.Dock = DockStyle.Fill;
            dtGridLstFakt.GridColor = Color.Gray;
            dtGridLstFakt.Location = new Point(0, 0);
            dtGridLstFakt.Margin = new Padding(3, 2, 3, 2);
            dtGridLstFakt.Name = "dtGridLstFakt";
            dtGridLstFakt.ReadOnly = true;
            dtGridLstFakt.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.ControlDark;
            dataGridViewCellStyle8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            dataGridViewCellStyle8.ForeColor = Color.White;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            dtGridLstFakt.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dtGridLstFakt.RowHeadersVisible = false;
            dtGridLstFakt.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dtGridLstFakt.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtGridLstFakt.ShowCellErrors = false;
            dtGridLstFakt.ShowCellToolTips = false;
            dtGridLstFakt.ShowEditingIcon = false;
            dtGridLstFakt.ShowRowErrors = false;
            dtGridLstFakt.Size = new Size(1238, 533);
            dtGridLstFakt.TabIndex = 0;
            // 
            // ListaFakturForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(1260, 680);
            Controls.Add(pnlDtGridZamowienia);
            Controls.Add(panelZalogowania);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(menuStrip);
            Controls.Add(pnlPrzyciski);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(1260, 680);
            MinimumSize = new Size(1260, 680);
            Name = "ListaFakturForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "D&K - Lista Faktur";
            Load += ListaFakturForm_Load;
            pnlPrzyciski.ResumeLayout(false);
            pnlPrzyciski.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            panelZalogowania.ResumeLayout(false);
            panelZalogowania.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            pnlDtGridZamowienia.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtGridLstFakt).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel pnlPrzyciski;
        private CheckBox chckBoxMiesiac;
        private Label label1;
        private CheckBox chckBoxRok;
        private NumericUpDown numericUpDown1;
        private ComboBox comboBox1;
        private Label label2;
        private Button btnDodaj;
        private TextBox txtBoxFilter;
        private Button btnUsun;
        private Button btnEdytuj;
        private Button btnCofnij;
        private Label lblZalogowanoJako;
        private Panel panelZalogowania;
        private LinkLabel linkLabel1;
        private PictureBox pictureBox1;
        private Panel panel4;
        private Panel panel2;
        private MenuStrip menuStrip;
        private ToolStripMenuItem zamówieniaToolStripMenuItem;
        private ToolStripMenuItem fakturyToolStripMenuItem;
        private ToolStripMenuItem kontrahenciToolStripMenuItem;
        private ToolStripMenuItem wysyłkiToolStripMenuItem;
        private ToolStripMenuItem towaryToolStripMenuItem;
        private Panel pnlDtGridZamowienia;
        private DataGridView dtGridLstFakt;
    }
}