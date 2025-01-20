namespace DK24
{
    partial class ListaTowary_UslugiForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaTowary_UslugiForm));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panelZalogowania = new Panel();
            linkLabel1 = new LinkLabel();
            pictureBox1 = new PictureBox();
            lblZalogowanoJako = new Label();
            menuStrip = new MenuStrip();
            zamówieniaToolStripMenuItem = new ToolStripMenuItem();
            fakturyToolStripMenuItem = new ToolStripMenuItem();
            kontrahenciToolStripMenuItem = new ToolStripMenuItem();
            towaryToolStripMenuItem = new ToolStripMenuItem();
            panel2 = new Panel();
            pnlPrzyciski = new Panel();
            radioButtonTowary = new RadioButton();
            radioButtonUslugi = new RadioButton();
            radioButtonWszystko = new RadioButton();
            btnCofnij = new Button();
            label1 = new Label();
            panel4 = new Panel();
            pnlDtGridZamowienia = new Panel();
            dtGridLsTowary = new DataGridView();
            panelZalogowania.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menuStrip.SuspendLayout();
            pnlPrzyciski.SuspendLayout();
            pnlDtGridZamowienia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtGridLsTowary).BeginInit();
            SuspendLayout();
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
            panelZalogowania.TabIndex = 8;
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
            menuStrip.TabIndex = 7;
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
            towaryToolStripMenuItem.Enabled = false;
            towaryToolStripMenuItem.ForeColor = Color.Silver;
            towaryToolStripMenuItem.Image = (Image)resources.GetObject("towaryToolStripMenuItem.Image");
            towaryToolStripMenuItem.Name = "towaryToolStripMenuItem";
            towaryToolStripMenuItem.Size = new Size(98, 40);
            towaryToolStripMenuItem.Text = "Towary i Usługi";
            towaryToolStripMenuItem.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // panel2
            // 
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.Location = new Point(0, 80);
            panel2.Name = "panel2";
            panel2.Size = new Size(10, 535);
            panel2.TabIndex = 9;
            // 
            // pnlPrzyciski
            // 
            pnlPrzyciski.BackgroundImage = (Image)resources.GetObject("pnlPrzyciski.BackgroundImage");
            pnlPrzyciski.Controls.Add(radioButtonTowary);
            pnlPrzyciski.Controls.Add(radioButtonUslugi);
            pnlPrzyciski.Controls.Add(radioButtonWszystko);
            pnlPrzyciski.Controls.Add(btnCofnij);
            pnlPrzyciski.Controls.Add(label1);
            pnlPrzyciski.Location = new Point(0, 615);
            pnlPrzyciski.Name = "pnlPrzyciski";
            pnlPrzyciski.Size = new Size(1260, 65);
            pnlPrzyciski.TabIndex = 10;
            // 
            // radioButtonTowary
            // 
            radioButtonTowary.AutoSize = true;
            radioButtonTowary.BackColor = Color.Transparent;
            radioButtonTowary.ForeColor = Color.White;
            radioButtonTowary.Location = new Point(225, 25);
            radioButtonTowary.Name = "radioButtonTowary";
            radioButtonTowary.Size = new Size(72, 19);
            radioButtonTowary.TabIndex = 17;
            radioButtonTowary.Text = "TOWARY";
            radioButtonTowary.UseVisualStyleBackColor = false;
            radioButtonTowary.CheckedChanged += radioButtonTowary_CheckedChanged_1;
            // 
            // radioButtonUslugi
            // 
            radioButtonUslugi.AutoSize = true;
            radioButtonUslugi.BackColor = Color.Transparent;
            radioButtonUslugi.ForeColor = Color.White;
            radioButtonUslugi.Location = new Point(311, 25);
            radioButtonUslugi.Name = "radioButtonUslugi";
            radioButtonUslugi.Size = new Size(64, 19);
            radioButtonUslugi.TabIndex = 16;
            radioButtonUslugi.Text = "USŁUGI";
            radioButtonUslugi.UseVisualStyleBackColor = false;
            radioButtonUslugi.CheckedChanged += radioButtonUslugi_CheckedChanged;
            // 
            // radioButtonWszystko
            // 
            radioButtonWszystko.AutoSize = true;
            radioButtonWszystko.BackColor = Color.Transparent;
            radioButtonWszystko.Checked = true;
            radioButtonWszystko.ForeColor = Color.White;
            radioButtonWszystko.Location = new Point(132, 25);
            radioButtonWszystko.Name = "radioButtonWszystko";
            radioButtonWszystko.Size = new Size(83, 19);
            radioButtonWszystko.TabIndex = 15;
            radioButtonWszystko.TabStop = true;
            radioButtonWszystko.Text = "WSZYSTKO";
            radioButtonWszystko.UseVisualStyleBackColor = false;
            radioButtonWszystko.CheckedChanged += radioButtonWszystko_CheckedChanged;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.ForeColor = Color.FromArgb(255, 128, 0);
            label1.Location = new Point(25, 24);
            label1.Name = "label1";
            label1.Size = new Size(90, 18);
            label1.TabIndex = 0;
            label1.Text = "Sortuj po:";
            // 
            // panel4
            // 
            panel4.BackgroundImage = (Image)resources.GetObject("panel4.BackgroundImage");
            panel4.Location = new Point(1250, 80);
            panel4.Name = "panel4";
            panel4.Size = new Size(10, 535);
            panel4.TabIndex = 11;
            // 
            // pnlDtGridZamowienia
            // 
            pnlDtGridZamowienia.BackColor = Color.White;
            pnlDtGridZamowienia.Controls.Add(dtGridLsTowary);
            pnlDtGridZamowienia.ImeMode = ImeMode.NoControl;
            pnlDtGridZamowienia.Location = new Point(11, 81);
            pnlDtGridZamowienia.Margin = new Padding(3, 2, 3, 2);
            pnlDtGridZamowienia.Name = "pnlDtGridZamowienia";
            pnlDtGridZamowienia.Size = new Size(1238, 533);
            pnlDtGridZamowienia.TabIndex = 12;
            // 
            // dtGridLsTowary
            // 
            dtGridLsTowary.AccessibleRole = AccessibleRole.Caret;
            dtGridLsTowary.AllowUserToAddRows = false;
            dtGridLsTowary.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.LightGray;
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.NullValue = "Brak Danych";
            dtGridLsTowary.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dtGridLsTowary.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtGridLsTowary.BackgroundColor = SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dtGridLsTowary.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dtGridLsTowary.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.NullValue = "Brak Danych";
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dtGridLsTowary.DefaultCellStyle = dataGridViewCellStyle3;
            dtGridLsTowary.Dock = DockStyle.Fill;
            dtGridLsTowary.GridColor = Color.Gray;
            dtGridLsTowary.Location = new Point(0, 0);
            dtGridLsTowary.Margin = new Padding(3, 2, 3, 2);
            dtGridLsTowary.Name = "dtGridLsTowary";
            dtGridLsTowary.ReadOnly = true;
            dtGridLsTowary.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.ControlDark;
            dataGridViewCellStyle4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dtGridLsTowary.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dtGridLsTowary.RowHeadersVisible = false;
            dtGridLsTowary.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dtGridLsTowary.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtGridLsTowary.ShowCellErrors = false;
            dtGridLsTowary.ShowCellToolTips = false;
            dtGridLsTowary.ShowEditingIcon = false;
            dtGridLsTowary.ShowRowErrors = false;
            dtGridLsTowary.Size = new Size(1238, 533);
            dtGridLsTowary.TabIndex = 0;
            // 
            // ListaTowary_UslugiForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(1260, 680);
            Controls.Add(pnlDtGridZamowienia);
            Controls.Add(panel4);
            Controls.Add(pnlPrzyciski);
            Controls.Add(panel2);
            Controls.Add(panelZalogowania);
            Controls.Add(menuStrip);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ListaTowary_UslugiForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ListaTowary_UslugiForm";
            Load += ListaTowary_UslugiForm_Load;
            panelZalogowania.ResumeLayout(false);
            panelZalogowania.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            pnlPrzyciski.ResumeLayout(false);
            pnlPrzyciski.PerformLayout();
            pnlDtGridZamowienia.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtGridLsTowary).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelZalogowania;
        private LinkLabel linkLabel1;
        private PictureBox pictureBox1;
        private Label lblZalogowanoJako;
        private MenuStrip menuStrip;
        private ToolStripMenuItem zamówieniaToolStripMenuItem;
        private ToolStripMenuItem fakturyToolStripMenuItem;
        private ToolStripMenuItem kontrahenciToolStripMenuItem;
        private ToolStripMenuItem towaryToolStripMenuItem;
        private Panel panel2;
        private Panel pnlPrzyciski;
        private Button btnCofnij;
        private Label label1;
        private Panel panel4;
        private Panel pnlDtGridZamowienia;
        private DataGridView dtGridLsTowary;
        private RadioButton radioButtonTowary;
        private RadioButton radioButtonUslugi;
        private RadioButton radioButtonWszystko;
    }
}