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
            btnDodajZamowienie = new Button();
            radioButtonArchiwalne = new RadioButton();
            radioButtonAktualne = new RadioButton();
            btnRefresh = new Button();
            fakturyToolStripMenuItem = new ToolStripMenuItem();
            dodajToolStripMenuItem = new ToolStripMenuItem();
            archiwumToolStripMenuItem1 = new ToolStripMenuItem();
            edytujToolStripMenuItem = new ToolStripDropDownMenu();
            kontrahenciToolStripMenuItem = new ToolStripMenuItem();
            dodajKontrahentaToolStripMenuItem = new ToolStripMenuItem();
            zobaczKontrahentówToolStripMenuItem = new ToolStripMenuItem();
            archiwumToolStripMenuItem2 = new ToolStripMenuItem();
            towaryToolStripMenuItem = new ToolStripMenuItem();
            dodajTowarToolStripMenuItem = new ToolStripMenuItem();
            zobaczToolStripMenuItem = new ToolStripMenuItem();
            wysyłkiToolStripMenuItem = new ToolStripMenuItem();
            stwórzPaczkęToolStripMenuItem = new ToolStripMenuItem();
            zobaczPaczkiToolStripMenuItem = new ToolStripMenuItem();
            archiwumToolStripMenuItem = new ToolStripMenuItem();
            zamówieniaToolStripMenuItem = new ToolStripMenuItem();
            noweZamToolStripMenuItem = new ToolStripMenuItem();
            zamówieniaArchiwalneToolStripMenuItem = new ToolStripMenuItem();
            zobaczZamówieniaToolStripMenuItem = new ToolStripMenuItem();
            drukarkiToolStripMenuItem = new ToolStripMenuItem();
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
            dtGridViewZamowienia.Size = new Size(1244, 548);
            dtGridViewZamowienia.TabIndex = 1;
            // 
            // pnlDtGridZamowienia
            // 
            pnlDtGridZamowienia.Controls.Add(dtGridViewZamowienia);
            pnlDtGridZamowienia.ImeMode = ImeMode.NoControl;
            pnlDtGridZamowienia.Location = new Point(0, 78);
            pnlDtGridZamowienia.Margin = new Padding(3, 2, 3, 2);
            pnlDtGridZamowienia.Name = "pnlDtGridZamowienia";
            pnlDtGridZamowienia.Size = new Size(1244, 473);
            pnlDtGridZamowienia.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(btnDodajZamowienie);
            panel1.Controls.Add(radioButtonArchiwalne);
            panel1.Controls.Add(radioButtonAktualne);
            panel1.Controls.Add(btnRefresh);
            panel1.Location = new Point(0, 551);
            panel1.Name = "panel1";
            panel1.Size = new Size(1244, 75);
            panel1.TabIndex = 3;
            // 
            // btnDodajZamowienie
            // 
            btnDodajZamowienie.BackColor = Color.FromArgb(192, 255, 192);
            btnDodajZamowienie.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            btnDodajZamowienie.Image = (Image)resources.GetObject("btnDodajZamowienie.Image");
            btnDodajZamowienie.Location = new Point(1108, 6);
            btnDodajZamowienie.Margin = new Padding(0);
            btnDodajZamowienie.Name = "btnDodajZamowienie";
            btnDodajZamowienie.Size = new Size(127, 60);
            btnDodajZamowienie.TabIndex = 3;
            btnDodajZamowienie.Text = "DODAJ ZAMÓWIENIE";
            btnDodajZamowienie.TextImageRelation = TextImageRelation.ImageAboveText;
            btnDodajZamowienie.UseVisualStyleBackColor = false;
            // 
            // radioButtonArchiwalne
            // 
            radioButtonArchiwalne.AutoSize = true;
            radioButtonArchiwalne.ForeColor = Color.White;
            radioButtonArchiwalne.Location = new Point(240, 31);
            radioButtonArchiwalne.Name = "radioButtonArchiwalne";
            radioButtonArchiwalne.Size = new Size(100, 19);
            radioButtonArchiwalne.TabIndex = 2;
            radioButtonArchiwalne.Text = "ARCHIWALNE";
            radioButtonArchiwalne.UseVisualStyleBackColor = true;
            // 
            // radioButtonAktualne
            // 
            radioButtonAktualne.AutoSize = true;
            radioButtonAktualne.Checked = true;
            radioButtonAktualne.ForeColor = Color.White;
            radioButtonAktualne.Location = new Point(142, 31);
            radioButtonAktualne.Name = "radioButtonAktualne";
            radioButtonAktualne.Size = new Size(83, 19);
            radioButtonAktualne.TabIndex = 1;
            radioButtonAktualne.TabStop = true;
            radioButtonAktualne.Text = "AKTUALNE";
            radioButtonAktualne.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.Transparent;
            btnRefresh.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            btnRefresh.Image = (Image)resources.GetObject("btnRefresh.Image");
            btnRefresh.Location = new Point(12, 21);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(109, 39);
            btnRefresh.TabIndex = 0;
            btnRefresh.Text = "REFRESH";
            btnRefresh.TextAlign = ContentAlignment.MiddleRight;
            btnRefresh.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRefresh.UseVisualStyleBackColor = false;
            // 
            // fakturyToolStripMenuItem
            // 
            fakturyToolStripMenuItem.BackColor = Color.Transparent;
            fakturyToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { dodajToolStripMenuItem, archiwumToolStripMenuItem1 });
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
            dodajToolStripMenuItem.Size = new Size(129, 22);
            dodajToolStripMenuItem.Text = "Dodaj";
            dodajToolStripMenuItem.Click += dodajToolStripMenuItem_Click;
            // 
            // archiwumToolStripMenuItem1
            // 
            archiwumToolStripMenuItem1.Name = "archiwumToolStripMenuItem1";
            archiwumToolStripMenuItem1.Size = new Size(129, 22);
            archiwumToolStripMenuItem1.Text = "Archiwum";
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
            kontrahenciToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { dodajKontrahentaToolStripMenuItem, zobaczKontrahentówToolStripMenuItem, archiwumToolStripMenuItem2 });
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
            // 
            // zobaczKontrahentówToolStripMenuItem
            // 
            zobaczKontrahentówToolStripMenuItem.Name = "zobaczKontrahentówToolStripMenuItem";
            zobaczKontrahentówToolStripMenuItem.Size = new Size(190, 22);
            zobaczKontrahentówToolStripMenuItem.Text = "Zobacz Kontrahentów";
            // 
            // archiwumToolStripMenuItem2
            // 
            archiwumToolStripMenuItem2.Name = "archiwumToolStripMenuItem2";
            archiwumToolStripMenuItem2.Size = new Size(190, 22);
            archiwumToolStripMenuItem2.Text = "Archiwum";
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
            wysyłkiToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { stwórzPaczkęToolStripMenuItem, zobaczPaczkiToolStripMenuItem, archiwumToolStripMenuItem });
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
            // archiwumToolStripMenuItem
            // 
            archiwumToolStripMenuItem.Name = "archiwumToolStripMenuItem";
            archiwumToolStripMenuItem.Size = new Size(148, 22);
            archiwumToolStripMenuItem.Text = "Archiwum";
            // 
            // zamówieniaToolStripMenuItem
            // 
            zamówieniaToolStripMenuItem.BackColor = Color.Transparent;
            zamówieniaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { noweZamToolStripMenuItem, zamówieniaArchiwalneToolStripMenuItem, zobaczZamówieniaToolStripMenuItem });
            zamówieniaToolStripMenuItem.ForeColor = Color.Silver;
            zamówieniaToolStripMenuItem.Image = (Image)resources.GetObject("zamówieniaToolStripMenuItem.Image");
            zamówieniaToolStripMenuItem.ImageAlign = ContentAlignment.TopCenter;
            zamówieniaToolStripMenuItem.Name = "zamówieniaToolStripMenuItem";
            zamówieniaToolStripMenuItem.Size = new Size(84, 39);
            zamówieniaToolStripMenuItem.Text = "Zamówienia";
            zamówieniaToolStripMenuItem.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // noweZamToolStripMenuItem
            // 
            noweZamToolStripMenuItem.Name = "noweZamToolStripMenuItem";
            noweZamToolStripMenuItem.Size = new Size(201, 22);
            noweZamToolStripMenuItem.Text = "Nowe Zamówienia";
            // 
            // zamówieniaArchiwalneToolStripMenuItem
            // 
            zamówieniaArchiwalneToolStripMenuItem.Name = "zamówieniaArchiwalneToolStripMenuItem";
            zamówieniaArchiwalneToolStripMenuItem.Size = new Size(201, 22);
            zamówieniaArchiwalneToolStripMenuItem.Text = "Zobacz Zamówienia";
            // 
            // zobaczZamówieniaToolStripMenuItem
            // 
            zobaczZamówieniaToolStripMenuItem.Name = "zobaczZamówieniaToolStripMenuItem";
            zobaczZamówieniaToolStripMenuItem.Size = new Size(201, 22);
            zobaczZamówieniaToolStripMenuItem.Text = "Zamówienia Archiwalne";
            // 
            // drukarkiToolStripMenuItem
            // 
            drukarkiToolStripMenuItem.BackColor = Color.Transparent;
            drukarkiToolStripMenuItem.ForeColor = Color.Silver;
            drukarkiToolStripMenuItem.Image = (Image)resources.GetObject("drukarkiToolStripMenuItem.Image");
            drukarkiToolStripMenuItem.Name = "drukarkiToolStripMenuItem";
            drukarkiToolStripMenuItem.Size = new Size(63, 39);
            drukarkiToolStripMenuItem.Text = "Drukarki";
            drukarkiToolStripMenuItem.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // menuStrip1
            // 
            menuStrip1.BackgroundImage = (Image)resources.GetObject("menuStrip1.BackgroundImage");
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { zamówieniaToolStripMenuItem, fakturyToolStripMenuItem, kontrahenciToolStripMenuItem, wysyłkiToolStripMenuItem, towaryToolStripMenuItem, drukarkiToolStripMenuItem });
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
            ClientSize = new Size(1244, 624);
            Controls.Add(panel1);
            Controls.Add(pnlDtGridZamowienia);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "D&K";
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
        private ToolStripMenuItem archiwumToolStripMenuItem1;
        private ToolStripDropDownMenu edytujToolStripMenuItem;
        private ToolStripMenuItem kontrahenciToolStripMenuItem;
        private ToolStripMenuItem dodajKontrahentaToolStripMenuItem;
        private ToolStripMenuItem zobaczKontrahentówToolStripMenuItem;
        private ToolStripMenuItem archiwumToolStripMenuItem2;
        private ToolStripMenuItem towaryToolStripMenuItem;
        private ToolStripMenuItem dodajTowarToolStripMenuItem;
        private ToolStripMenuItem zobaczToolStripMenuItem;
        private ToolStripMenuItem wysyłkiToolStripMenuItem;
        private ToolStripMenuItem stwórzPaczkęToolStripMenuItem;
        private ToolStripMenuItem zobaczPaczkiToolStripMenuItem;
        private ToolStripMenuItem archiwumToolStripMenuItem;
        private ToolStripMenuItem zamówieniaToolStripMenuItem;
        private ToolStripMenuItem noweZamToolStripMenuItem;
        private ToolStripMenuItem zamówieniaArchiwalneToolStripMenuItem;
        private ToolStripMenuItem zobaczZamówieniaToolStripMenuItem;
        private ToolStripMenuItem drukarkiToolStripMenuItem;
        private MenuStrip menuStrip1;
        private Panel panel1;
        private Button btnRefresh;
        private RadioButton radioButtonArchiwalne;
        private RadioButton radioButtonAktualne;
        private Button btnDodajZamowienie;
    }
}