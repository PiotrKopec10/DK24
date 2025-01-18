namespace DK24
{
    partial class MainForm
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            dtGridViewZamowienia = new DataGridView();
            pnlDtGridZamowienia = new Panel();
            panel1 = new Panel();
            cbxNowe = new CheckBox();
            cbxWrealizacji = new CheckBox();
            cbxZakonczone = new CheckBox();
            lblRefreshTimeLeft = new Label();
            button1 = new Button();
            btnDodaj = new Button();
            btnRefresh = new Button();
            lblZalogowanoJako = new Label();
            fakturyToolStripMenuItem = new ToolStripMenuItem();
            edytujToolStripMenuItem = new ToolStripDropDownMenu();
            kontrahenciToolStripMenuItem = new ToolStripMenuItem();
            towaryToolStripMenuItem = new ToolStripMenuItem();
            zamówieniaToolStripMenuItem = new ToolStripMenuItem();
            menuStrip = new MenuStrip();
            ZarzadzajPracownikamiToolStripMenuItem = new ToolStripMenuItem();
            panel2 = new Panel();
            panelZalogowania = new Panel();
            linkLabel1 = new LinkLabel();
            pictureBox1 = new PictureBox();
            panel4 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dtGridViewZamowienia).BeginInit();
            pnlDtGridZamowienia.SuspendLayout();
            panel1.SuspendLayout();
            menuStrip.SuspendLayout();
            panelZalogowania.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dtGridViewZamowienia
            // 
            dtGridViewZamowienia.AllowUserToAddRows = false;
            dtGridViewZamowienia.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = Color.LightGray;
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.NullValue = "Brak Danych";
            dtGridViewZamowienia.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            dtGridViewZamowienia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtGridViewZamowienia.BackgroundColor = SystemColors.ControlDarkDark;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle6.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dtGridViewZamowienia.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dtGridViewZamowienia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.Control;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            dataGridViewCellStyle7.ForeColor = Color.Black;
            dataGridViewCellStyle7.NullValue = "Brak Danych";
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.False;
            dtGridViewZamowienia.DefaultCellStyle = dataGridViewCellStyle7;
            dtGridViewZamowienia.Dock = DockStyle.Fill;
            dtGridViewZamowienia.EnableHeadersVisualStyles = false;
            dtGridViewZamowienia.GridColor = Color.Gray;
            dtGridViewZamowienia.Location = new Point(0, 0);
            dtGridViewZamowienia.Margin = new Padding(3, 2, 3, 2);
            dtGridViewZamowienia.Name = "dtGridViewZamowienia";
            dtGridViewZamowienia.ReadOnly = true;
            dtGridViewZamowienia.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.ControlDark;
            dataGridViewCellStyle8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            dataGridViewCellStyle8.ForeColor = Color.White;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            dtGridViewZamowienia.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dtGridViewZamowienia.RowHeadersVisible = false;
            dtGridViewZamowienia.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dtGridViewZamowienia.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtGridViewZamowienia.Size = new Size(1238, 533);
            dtGridViewZamowienia.TabIndex = 1;
            dtGridViewZamowienia.CellFormatting += dtGridViewZamowienia_CellFormatting;
            // 
            // pnlDtGridZamowienia
            // 
            pnlDtGridZamowienia.BackColor = Color.White;
            pnlDtGridZamowienia.Controls.Add(dtGridViewZamowienia);
            pnlDtGridZamowienia.ImeMode = ImeMode.NoControl;
            pnlDtGridZamowienia.Location = new Point(11, 81);
            pnlDtGridZamowienia.Margin = new Padding(3, 2, 3, 2);
            pnlDtGridZamowienia.Name = "pnlDtGridZamowienia";
            pnlDtGridZamowienia.Size = new Size(1238, 533);
            pnlDtGridZamowienia.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(cbxNowe);
            panel1.Controls.Add(cbxWrealizacji);
            panel1.Controls.Add(cbxZakonczone);
            panel1.Controls.Add(lblRefreshTimeLeft);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btnDodaj);
            panel1.Controls.Add(btnRefresh);
            panel1.Location = new Point(0, 615);
            panel1.Name = "panel1";
            panel1.Size = new Size(1260, 65);
            panel1.TabIndex = 3;
            // 
            // cbxNowe
            // 
            cbxNowe.AutoSize = true;
            cbxNowe.BackColor = Color.Transparent;
            cbxNowe.ForeColor = Color.White;
            cbxNowe.Location = new Point(173, 22);
            cbxNowe.Name = "cbxNowe";
            cbxNowe.Size = new Size(61, 19);
            cbxNowe.TabIndex = 19;
            cbxNowe.Text = "NOWE";
            cbxNowe.UseVisualStyleBackColor = false;
            // 
            // cbxWrealizacji
            // 
            cbxWrealizacji.AutoSize = true;
            cbxWrealizacji.BackColor = Color.Transparent;
            cbxWrealizacji.ForeColor = Color.White;
            cbxWrealizacji.Location = new Point(249, 22);
            cbxWrealizacji.Name = "cbxWrealizacji";
            cbxWrealizacji.Size = new Size(100, 19);
            cbxWrealizacji.TabIndex = 18;
            cbxWrealizacji.Text = "W REALIZACJI";
            cbxWrealizacji.UseVisualStyleBackColor = false;
            // 
            // cbxZakonczone
            // 
            cbxZakonczone.AutoSize = true;
            cbxZakonczone.BackColor = Color.Transparent;
            cbxZakonczone.ForeColor = Color.White;
            cbxZakonczone.Location = new Point(362, 22);
            cbxZakonczone.Name = "cbxZakonczone";
            cbxZakonczone.Size = new Size(104, 19);
            cbxZakonczone.TabIndex = 17;
            cbxZakonczone.Text = "ZAKOŃCZONE";
            cbxZakonczone.UseVisualStyleBackColor = false;
            // 
            // lblRefreshTimeLeft
            // 
            lblRefreshTimeLeft.AutoSize = true;
            lblRefreshTimeLeft.BackColor = Color.Transparent;
            lblRefreshTimeLeft.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lblRefreshTimeLeft.ForeColor = SystemColors.Control;
            lblRefreshTimeLeft.Location = new Point(127, 34);
            lblRefreshTimeLeft.Name = "lblRefreshTimeLeft";
            lblRefreshTimeLeft.Size = new Size(30, 13);
            lblRefreshTimeLeft.TabIndex = 16;
            lblRefreshTimeLeft.Text = "(... s)";
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(1000, 10);
            button1.Name = "button1";
            button1.Size = new Size(120, 40);
            button1.TabIndex = 13;
            button1.Text = "SZCZEGÓŁY";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnDodaj
            // 
            btnDodaj.BackColor = Color.FromArgb(192, 255, 192);
            btnDodaj.Font = new Font("Verdana", 8F);
            btnDodaj.Image = (Image)resources.GetObject("btnDodaj.Image");
            btnDodaj.ImageAlign = ContentAlignment.TopCenter;
            btnDodaj.Location = new Point(1135, 5);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(105, 51);
            btnDodaj.TabIndex = 12;
            btnDodaj.Text = "DODAJ ZAMÓWIENIE";
            btnDodaj.TextAlign = ContentAlignment.BottomCenter;
            btnDodaj.UseVisualStyleBackColor = false;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.Transparent;
            btnRefresh.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            btnRefresh.Image = (Image)resources.GetObject("btnRefresh.Image");
            btnRefresh.Location = new Point(20, 12);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(105, 36);
            btnRefresh.TabIndex = 0;
            btnRefresh.Text = "REFRESH";
            btnRefresh.TextAlign = ContentAlignment.MiddleRight;
            btnRefresh.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
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
            // edytujToolStripMenuItem
            // 
            edytujToolStripMenuItem.AutoClose = false;
            edytujToolStripMenuItem.ImageScalingSize = new Size(20, 20);
            edytujToolStripMenuItem.Name = "edytujToolStripMenuItem";
            edytujToolStripMenuItem.Size = new Size(61, 4);
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
            // zamówieniaToolStripMenuItem
            // 
            zamówieniaToolStripMenuItem.BackColor = Color.Transparent;
            zamówieniaToolStripMenuItem.Enabled = false;
            zamówieniaToolStripMenuItem.ForeColor = Color.FromArgb(255, 128, 0);
            zamówieniaToolStripMenuItem.Image = (Image)resources.GetObject("zamówieniaToolStripMenuItem.Image");
            zamówieniaToolStripMenuItem.ImageAlign = ContentAlignment.TopCenter;
            zamówieniaToolStripMenuItem.Name = "zamówieniaToolStripMenuItem";
            zamówieniaToolStripMenuItem.Size = new Size(84, 40);
            zamówieniaToolStripMenuItem.Text = "Zamówienia";
            zamówieniaToolStripMenuItem.TextImageRelation = TextImageRelation.ImageAboveText;
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
            menuStrip.TabIndex = 0;
            menuStrip.Text = "menuStrip1";
            // 
            // ZarzadzajPracownikamiToolStripMenuItem
            // 
            ZarzadzajPracownikamiToolStripMenuItem.ForeColor = Color.Silver;
            ZarzadzajPracownikamiToolStripMenuItem.Image = (Image)resources.GetObject("ZarzadzajPracownikamiToolStripMenuItem.Image");
            ZarzadzajPracownikamiToolStripMenuItem.Name = "ZarzadzajPracownikamiToolStripMenuItem";
            ZarzadzajPracownikamiToolStripMenuItem.Size = new Size(146, 40);
            ZarzadzajPracownikamiToolStripMenuItem.Text = "Zarządzaj Pracownikami";
            ZarzadzajPracownikamiToolStripMenuItem.TextImageRelation = TextImageRelation.ImageAboveText;
            ZarzadzajPracownikamiToolStripMenuItem.Click += ądzajPracownikamiToolStripMenuItem_Click;
            // 
            // panel2
            // 
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.Location = new Point(0, 80);
            panel2.Name = "panel2";
            panel2.Size = new Size(10, 535);
            panel2.TabIndex = 4;
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
            panelZalogowania.TabIndex = 2;
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
            panel4.TabIndex = 5;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(1260, 680);
            Controls.Add(panel4);
            Controls.Add(panelZalogowania);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pnlDtGridZamowienia);
            Controls.Add(menuStrip);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip;
            Margin = new Padding(3, 2, 3, 2);
            MaximumSize = new Size(1260, 680);
            MinimumSize = new Size(1260, 680);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "D&K - Zamówienia";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)dtGridViewZamowienia).EndInit();
            pnlDtGridZamowienia.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            panelZalogowania.ResumeLayout(false);
            panelZalogowania.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dtGridViewZamowienia;
        private Panel pnlDtGridZamowienia;
        private ToolStripMenuItem fakturyToolStripMenuItem;
        private ToolStripDropDownMenu edytujToolStripMenuItem;
        private ToolStripMenuItem kontrahenciToolStripMenuItem;
        private ToolStripMenuItem towaryToolStripMenuItem;
        private ToolStripMenuItem zamówieniaToolStripMenuItem;
        private MenuStrip menuStrip;
        private Button btnRefresh;
        private Button btnDodaj;
        private Panel panel1;
        private Button button1;
        private Label lblZalogowanoJako;
        private Panel panel2;
        private Panel panelZalogowania;
        private Panel panel4;
        private PictureBox pictureBox1;
        private LinkLabel linkLabel1;
        private ToolStripMenuItem ZarzadzajPracownikamiToolStripMenuItem;
        private Label lblRefreshTimeLeft;
        private CheckBox cbxNowe;
        private CheckBox cbxWrealizacji;
        private CheckBox cbxZakonczone;
    }
}