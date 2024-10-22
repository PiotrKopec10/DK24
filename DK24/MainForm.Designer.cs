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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            dtGridViewZamowienia = new DataGridView();
            pnlDtGridZamowienia = new Panel();
            panel1 = new Panel();
            radioButtonArchiwalne = new RadioButton();
            radioButtonAktualne = new RadioButton();
            btnDodaj = new Button();
            btnRefresh = new Button();
            fakturyToolStripMenuItem = new ToolStripMenuItem();
            dodajToolStripMenuItem = new ToolStripMenuItem();
            zobaczFakturyToolStripMenuItem = new ToolStripMenuItem();
            edytujToolStripMenuItem = new ToolStripDropDownMenu();
            kontrahenciToolStripMenuItem = new ToolStripMenuItem();
            dodajKontrahentaToolStripMenuItem = new ToolStripMenuItem();
            zobaczKontrahentówToolStripMenuItem = new ToolStripMenuItem();
            towaryToolStripMenuItem = new ToolStripMenuItem();
            dodajTowarToolStripMenuItem = new ToolStripMenuItem();
            zobaczToolStripMenuItem = new ToolStripMenuItem();
            wysyłkiToolStripMenuItem = new ToolStripMenuItem();
            stwórzPaczkęToolStripMenuItem = new ToolStripMenuItem();
            zobaczPaczkiToolStripMenuItem = new ToolStripMenuItem();
            zamówieniaToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            ((System.ComponentModel.ISupportInitialize)dtGridViewZamowienia).BeginInit();
            pnlDtGridZamowienia.SuspendLayout();
            panel1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dtGridViewZamowienia
            // 
            dtGridViewZamowienia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtGridViewZamowienia.Location = new Point(0, 0);
            dtGridViewZamowienia.Margin = new Padding(3, 2, 3, 2);
            dtGridViewZamowienia.Name = "dtGridViewZamowienia";
            dtGridViewZamowienia.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dtGridViewZamowienia.RowHeadersWidth = 51;
            dtGridViewZamowienia.Size = new Size(1244, 505);
            dtGridViewZamowienia.TabIndex = 1;
            // 
            // pnlDtGridZamowienia
            // 
            pnlDtGridZamowienia.Controls.Add(panel1);
            pnlDtGridZamowienia.Controls.Add(dtGridViewZamowienia);
            pnlDtGridZamowienia.Dock = DockStyle.Fill;
            pnlDtGridZamowienia.ImeMode = ImeMode.NoControl;
            pnlDtGridZamowienia.Location = new Point(0, 76);
            pnlDtGridZamowienia.Margin = new Padding(3, 2, 3, 2);
            pnlDtGridZamowienia.Name = "pnlDtGridZamowienia";
            pnlDtGridZamowienia.Size = new Size(1244, 565);
            pnlDtGridZamowienia.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(radioButtonArchiwalne);
            panel1.Controls.Add(radioButtonAktualne);
            panel1.Controls.Add(btnDodaj);
            panel1.Controls.Add(btnRefresh);
            panel1.Location = new Point(0, 503);
            panel1.Name = "panel1";
            panel1.Size = new Size(1244, 62);
            panel1.TabIndex = 3;
            // 
            // radioButtonArchiwalne
            // 
            radioButtonArchiwalne.AutoSize = true;
            radioButtonArchiwalne.BackColor = Color.Transparent;
            radioButtonArchiwalne.ForeColor = Color.White;
            radioButtonArchiwalne.Location = new Point(231, 23);
            radioButtonArchiwalne.Name = "radioButtonArchiwalne";
            radioButtonArchiwalne.Size = new Size(100, 19);
            radioButtonArchiwalne.TabIndex = 2;
            radioButtonArchiwalne.Text = "ARCHIWALNE";
            radioButtonArchiwalne.UseVisualStyleBackColor = false;
            // 
            // radioButtonAktualne
            // 
            radioButtonAktualne.AutoSize = true;
            radioButtonAktualne.BackColor = Color.Transparent;
            radioButtonAktualne.Checked = true;
            radioButtonAktualne.ForeColor = Color.White;
            radioButtonAktualne.Location = new Point(133, 23);
            radioButtonAktualne.Name = "radioButtonAktualne";
            radioButtonAktualne.Size = new Size(83, 19);
            radioButtonAktualne.TabIndex = 1;
            radioButtonAktualne.TabStop = true;
            radioButtonAktualne.Text = "AKTUALNE";
            radioButtonAktualne.UseVisualStyleBackColor = false;
            // 
            // btnDodaj
            // 
            btnDodaj.BackColor = Color.FromArgb(192, 255, 192);
            btnDodaj.Font = new Font("Verdana", 8F);
            btnDodaj.Image = (Image)resources.GetObject("btnDodaj.Image");
            btnDodaj.ImageAlign = ContentAlignment.TopCenter;
            btnDodaj.Location = new Point(1133, 5);
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
            btnRefresh.Location = new Point(10, 14);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(105, 36);
            btnRefresh.TabIndex = 0;
            btnRefresh.Text = "REFRESH";
            btnRefresh.TextAlign = ContentAlignment.MiddleRight;
            btnRefresh.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRefresh.UseVisualStyleBackColor = false;
            // 
            // fakturyToolStripMenuItem
            // 
            fakturyToolStripMenuItem.BackColor = Color.Transparent;
            fakturyToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { dodajToolStripMenuItem, zobaczFakturyToolStripMenuItem });
            fakturyToolStripMenuItem.ForeColor = Color.Silver;
            fakturyToolStripMenuItem.Image = (Image)resources.GetObject("fakturyToolStripMenuItem.Image");
            fakturyToolStripMenuItem.Name = "fakturyToolStripMenuItem";
            fakturyToolStripMenuItem.Size = new Size(58, 39);
            fakturyToolStripMenuItem.Text = "Faktury";
            fakturyToolStripMenuItem.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // dodajToolStripMenuItem
            // 
            dodajToolStripMenuItem.Name = "dodajToolStripMenuItem";
            dodajToolStripMenuItem.Size = new Size(180, 22);
            dodajToolStripMenuItem.Text = "Dodaj";
            dodajToolStripMenuItem.Click += dodajToolStripMenuItem_Click;
            // 
            // zobaczFakturyToolStripMenuItem
            // 
            zobaczFakturyToolStripMenuItem.Name = "zobaczFakturyToolStripMenuItem";
            zobaczFakturyToolStripMenuItem.Size = new Size(180, 22);
            zobaczFakturyToolStripMenuItem.Text = "Zobacz Faktury";
            zobaczFakturyToolStripMenuItem.Click += zobaczFakturyToolStripMenuItem_Click;
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
            kontrahenciToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { dodajKontrahentaToolStripMenuItem, zobaczKontrahentówToolStripMenuItem });
            kontrahenciToolStripMenuItem.ForeColor = Color.Silver;
            kontrahenciToolStripMenuItem.Image = (Image)resources.GetObject("kontrahenciToolStripMenuItem.Image");
            kontrahenciToolStripMenuItem.Name = "kontrahenciToolStripMenuItem";
            kontrahenciToolStripMenuItem.Size = new Size(83, 39);
            kontrahenciToolStripMenuItem.Text = "Kontrahenci";
            kontrahenciToolStripMenuItem.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // dodajKontrahentaToolStripMenuItem
            // 
            dodajKontrahentaToolStripMenuItem.Name = "dodajKontrahentaToolStripMenuItem";
            dodajKontrahentaToolStripMenuItem.Size = new Size(190, 22);
            dodajKontrahentaToolStripMenuItem.Text = "Dodaj Kontrahenta";
            dodajKontrahentaToolStripMenuItem.Click += dodajKontrahentaToolStripMenuItem_Click;
            // 
            // zobaczKontrahentówToolStripMenuItem
            // 
            zobaczKontrahentówToolStripMenuItem.Name = "zobaczKontrahentówToolStripMenuItem";
            zobaczKontrahentówToolStripMenuItem.Size = new Size(190, 22);
            zobaczKontrahentówToolStripMenuItem.Text = "Zobacz Kontrahentów";
            zobaczKontrahentówToolStripMenuItem.Click += zobaczKontrahentówToolStripMenuItem_Click;
            // 
            // towaryToolStripMenuItem
            // 
            towaryToolStripMenuItem.BackColor = Color.Transparent;
            towaryToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { dodajTowarToolStripMenuItem, zobaczToolStripMenuItem });
            towaryToolStripMenuItem.ForeColor = Color.Silver;
            towaryToolStripMenuItem.Image = (Image)resources.GetObject("towaryToolStripMenuItem.Image");
            towaryToolStripMenuItem.Name = "towaryToolStripMenuItem";
            towaryToolStripMenuItem.Size = new Size(98, 39);
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
            // wysyłkiToolStripMenuItem
            // 
            wysyłkiToolStripMenuItem.BackColor = Color.Transparent;
            wysyłkiToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { stwórzPaczkęToolStripMenuItem, zobaczPaczkiToolStripMenuItem });
            wysyłkiToolStripMenuItem.ForeColor = Color.Silver;
            wysyłkiToolStripMenuItem.Image = (Image)resources.GetObject("wysyłkiToolStripMenuItem.Image");
            wysyłkiToolStripMenuItem.Name = "wysyłkiToolStripMenuItem";
            wysyłkiToolStripMenuItem.Size = new Size(59, 39);
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
            // zamówieniaToolStripMenuItem
            // 
            zamówieniaToolStripMenuItem.BackColor = Color.Transparent;
            zamówieniaToolStripMenuItem.Enabled = false;
            zamówieniaToolStripMenuItem.ForeColor = Color.FromArgb(255, 128, 0);
            zamówieniaToolStripMenuItem.Image = (Image)resources.GetObject("zamówieniaToolStripMenuItem.Image");
            zamówieniaToolStripMenuItem.ImageAlign = ContentAlignment.TopCenter;
            zamówieniaToolStripMenuItem.Name = "zamówieniaToolStripMenuItem";
            zamówieniaToolStripMenuItem.Size = new Size(84, 39);
            zamówieniaToolStripMenuItem.Text = "Zamówienia";
            zamówieniaToolStripMenuItem.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // menuStrip1
            // 
            menuStrip1.BackgroundImage = (Image)resources.GetObject("menuStrip1.BackgroundImage");
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { zamówieniaToolStripMenuItem, fakturyToolStripMenuItem, kontrahenciToolStripMenuItem, wysyłkiToolStripMenuItem, towaryToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(250, 35, 0, 2);
            menuStrip1.RenderMode = ToolStripRenderMode.Professional;
            menuStrip1.Size = new Size(1244, 76);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 0);
            ClientSize = new Size(1244, 641);
            Controls.Add(pnlDtGridZamowienia);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            MaximumSize = new Size(1260, 680);
            MinimumSize = new Size(1260, 680);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "D&K - Zamówienia";
            FormClosing += MainForm_FormClosing;
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)dtGridViewZamowienia).EndInit();
            pnlDtGridZamowienia.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dtGridViewZamowienia;
        private Panel pnlDtGridZamowienia;
        private ToolStripMenuItem fakturyToolStripMenuItem;
        private ToolStripMenuItem dodajToolStripMenuItem;
        private ToolStripDropDownMenu edytujToolStripMenuItem;
        private ToolStripMenuItem kontrahenciToolStripMenuItem;
        private ToolStripMenuItem dodajKontrahentaToolStripMenuItem;
        private ToolStripMenuItem zobaczKontrahentówToolStripMenuItem;
        private ToolStripMenuItem towaryToolStripMenuItem;
        private ToolStripMenuItem dodajTowarToolStripMenuItem;
        private ToolStripMenuItem zobaczToolStripMenuItem;
        private ToolStripMenuItem wysyłkiToolStripMenuItem;
        private ToolStripMenuItem stwórzPaczkęToolStripMenuItem;
        private ToolStripMenuItem zobaczPaczkiToolStripMenuItem;
        private ToolStripMenuItem zamówieniaToolStripMenuItem;
        private MenuStrip menuStrip1;
        private Button btnRefresh;
        private RadioButton radioButtonArchiwalne;
        private RadioButton radioButtonAktualne;
        private ToolStripMenuItem zobaczFakturyToolStripMenuItem;
        private Button btnDodaj;
        private Panel panel1;
    }
}