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
            dtGridViewZamowienia = new DataGridView();
            pnlDtGridZamowienia = new Panel();
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
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dtGridViewZamowienia
            // 
            dtGridViewZamowienia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtGridViewZamowienia.Dock = DockStyle.Fill;
            dtGridViewZamowienia.Location = new Point(0, 24);
            dtGridViewZamowienia.Margin = new Padding(3, 2, 3, 2);
            dtGridViewZamowienia.Name = "dtGridViewZamowienia";
            dtGridViewZamowienia.RowHeadersWidth = 51;
            dtGridViewZamowienia.Size = new Size(1244, 600);
            dtGridViewZamowienia.TabIndex = 1;
            // 
            // pnlDtGridZamowienia
            // 
            pnlDtGridZamowienia.Dock = DockStyle.Fill;
            pnlDtGridZamowienia.Location = new Point(0, 24);
            pnlDtGridZamowienia.Margin = new Padding(3, 2, 3, 2);
            pnlDtGridZamowienia.Name = "pnlDtGridZamowienia";
            pnlDtGridZamowienia.Size = new Size(1244, 600);
            pnlDtGridZamowienia.TabIndex = 2;
            // 
            // fakturyToolStripMenuItem
            // 
            fakturyToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { dodajToolStripMenuItem, archiwumToolStripMenuItem1 });
            fakturyToolStripMenuItem.Name = "fakturyToolStripMenuItem";
            fakturyToolStripMenuItem.Size = new Size(58, 20);
            fakturyToolStripMenuItem.Text = "Faktury";
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
            edytujToolStripMenuItem.OwnerItem = fakturyToolStripMenuItem;
            edytujToolStripMenuItem.Size = new Size(61, 4);
            // 
            // kontrahenciToolStripMenuItem
            // 
            kontrahenciToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { dodajKontrahentaToolStripMenuItem, zobaczKontrahentówToolStripMenuItem, archiwumToolStripMenuItem2 });
            kontrahenciToolStripMenuItem.Name = "kontrahenciToolStripMenuItem";
            kontrahenciToolStripMenuItem.Size = new Size(83, 20);
            kontrahenciToolStripMenuItem.Text = "Kontrahenci";
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
            towaryToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { dodajTowarToolStripMenuItem, zobaczToolStripMenuItem });
            towaryToolStripMenuItem.Name = "towaryToolStripMenuItem";
            towaryToolStripMenuItem.Size = new Size(98, 20);
            towaryToolStripMenuItem.Text = "Towary i Usługi";
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
            wysyłkiToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { stwórzPaczkęToolStripMenuItem, zobaczPaczkiToolStripMenuItem, archiwumToolStripMenuItem });
            wysyłkiToolStripMenuItem.Name = "wysyłkiToolStripMenuItem";
            wysyłkiToolStripMenuItem.Size = new Size(59, 20);
            wysyłkiToolStripMenuItem.Text = "Wysyłki";
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
            zamówieniaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { noweZamToolStripMenuItem, zamówieniaArchiwalneToolStripMenuItem, zobaczZamówieniaToolStripMenuItem });
            zamówieniaToolStripMenuItem.Name = "zamówieniaToolStripMenuItem";
            zamówieniaToolStripMenuItem.Size = new Size(84, 20);
            zamówieniaToolStripMenuItem.Text = "Zamówienia";
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
            drukarkiToolStripMenuItem.Name = "drukarkiToolStripMenuItem";
            drukarkiToolStripMenuItem.Size = new Size(63, 20);
            drukarkiToolStripMenuItem.Text = "Drukarki";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { zamówieniaToolStripMenuItem, fakturyToolStripMenuItem, kontrahenciToolStripMenuItem, wysyłkiToolStripMenuItem, towaryToolStripMenuItem, drukarkiToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(1244, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1244, 624);
            Controls.Add(dtGridViewZamowienia);
            Controls.Add(pnlDtGridZamowienia);
            Controls.Add(menuStrip1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "MainForm";
            Text = "D&K";
            FormClosing += MainForm_FormClosing;
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)dtGridViewZamowienia).EndInit();
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
    }
}