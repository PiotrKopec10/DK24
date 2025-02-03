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
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            pnlPrzyciski = new Panel();
            btnZaznacz = new Button();
            btnCofnij = new Button();
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
            towaryToolStripMenuItem = new ToolStripMenuItem();
            pnlDtGridZamowienia = new Panel();
            dtGridLstFakt = new DataGridView();
            imgMinimalize = new PictureBox();
            pnlPrzyciski.SuspendLayout();
            panelZalogowania.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menuStrip.SuspendLayout();
            pnlDtGridZamowienia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtGridLstFakt).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgMinimalize).BeginInit();
            SuspendLayout();
            // 
            // pnlPrzyciski
            // 
            pnlPrzyciski.BackgroundImage = (Image)resources.GetObject("pnlPrzyciski.BackgroundImage");
            pnlPrzyciski.Controls.Add(btnZaznacz);
            pnlPrzyciski.Controls.Add(btnCofnij);
            pnlPrzyciski.Location = new Point(0, 615);
            pnlPrzyciski.Name = "pnlPrzyciski";
            pnlPrzyciski.Size = new Size(1260, 65);
            pnlPrzyciski.TabIndex = 2;
            // 
            // btnZaznacz
            // 
            btnZaznacz.Image = (Image)resources.GetObject("btnZaznacz.Image");
            btnZaznacz.Location = new Point(1128, 16);
            btnZaznacz.Name = "btnZaznacz";
            btnZaznacz.Size = new Size(44, 33);
            btnZaznacz.TabIndex = 16;
            btnZaznacz.UseVisualStyleBackColor = true;
            btnZaznacz.Click += btnZaznacz_Click;
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
            btnCofnij.Click += btnCofnij_Click;
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
            panelZalogowania.Controls.Add(imgMinimalize);
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
            menuStrip.Items.AddRange(new ToolStripItem[] { zamówieniaToolStripMenuItem, fakturyToolStripMenuItem, kontrahenciToolStripMenuItem, towaryToolStripMenuItem });
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
            dataGridViewCellStyle9.BackColor = Color.LightGray;
            dataGridViewCellStyle9.ForeColor = Color.Black;
            dataGridViewCellStyle9.NullValue = "Brak Danych";
            dtGridLstFakt.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            dtGridLstFakt.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtGridLstFakt.BackgroundColor = SystemColors.ControlDarkDark;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle10.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            dataGridViewCellStyle10.ForeColor = Color.White;
            dataGridViewCellStyle10.SelectionBackColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
            dtGridLstFakt.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            dtGridLstFakt.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = SystemColors.Control;
            dataGridViewCellStyle11.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            dataGridViewCellStyle11.ForeColor = Color.Black;
            dataGridViewCellStyle11.NullValue = "Brak Danych";
            dataGridViewCellStyle11.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.False;
            dtGridLstFakt.DefaultCellStyle = dataGridViewCellStyle11;
            dtGridLstFakt.Dock = DockStyle.Fill;
            dtGridLstFakt.GridColor = Color.Gray;
            dtGridLstFakt.Location = new Point(0, 0);
            dtGridLstFakt.Margin = new Padding(3, 2, 3, 2);
            dtGridLstFakt.Name = "dtGridLstFakt";
            dtGridLstFakt.ReadOnly = true;
            dtGridLstFakt.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = SystemColors.ControlDark;
            dataGridViewCellStyle12.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            dataGridViewCellStyle12.ForeColor = Color.White;
            dataGridViewCellStyle12.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.True;
            dtGridLstFakt.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
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
            panelZalogowania.ResumeLayout(false);
            panelZalogowania.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            pnlDtGridZamowienia.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtGridLstFakt).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgMinimalize).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel pnlPrzyciski;
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
        private ToolStripMenuItem towaryToolStripMenuItem;
        private Panel pnlDtGridZamowienia;
        private DataGridView dtGridLstFakt;
        private Button btnZaznacz;
        private PictureBox imgMinimalize;
    }
}