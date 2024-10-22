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
            pnlDataGrid = new Panel();
            dtGridLstKnt = new DataGridView();
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
            noweZamToolStripMenuItem = new ToolStripMenuItem();
            zamówieniaArchiwalneToolStripMenuItem = new ToolStripMenuItem();
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
            drukarkiToolStripMenuItem = new ToolStripMenuItem();
            pnlDataGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtGridLstKnt).BeginInit();
            pnlPrzyciski.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlDataGrid
            // 
            pnlDataGrid.BackColor = Color.FromArgb(255, 128, 0);
            pnlDataGrid.Controls.Add(dtGridLstKnt);
            pnlDataGrid.Location = new Point(0, 0);
            pnlDataGrid.Name = "pnlDataGrid";
            pnlDataGrid.Size = new Size(1244, 573);
            pnlDataGrid.TabIndex = 0;
            // 
            // dtGridLstKnt
            // 
            dtGridLstKnt.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtGridLstKnt.Location = new Point(0, 72);
            dtGridLstKnt.Name = "dtGridLstKnt";
            dtGridLstKnt.Size = new Size(1244, 503);
            dtGridLstKnt.TabIndex = 0;
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
            pnlPrzyciski.Location = new Point(0, 572);
            pnlPrzyciski.Name = "pnlPrzyciski";
            pnlPrzyciski.Size = new Size(1244, 51);
            pnlPrzyciski.TabIndex = 1;
            // 
            // btnZaznacz
            // 
            btnZaznacz.Image = (Image)resources.GetObject("btnZaznacz.Image");
            btnZaznacz.Location = new Point(939, 9);
            btnZaznacz.Name = "btnZaznacz";
            btnZaznacz.Size = new Size(44, 33);
            btnZaznacz.TabIndex = 15;
            btnZaznacz.UseVisualStyleBackColor = true;
            // 
            // btnCofnij
            // 
            btnCofnij.Image = (Image)resources.GetObject("btnCofnij.Image");
            btnCofnij.Location = new Point(1188, 9);
            btnCofnij.Name = "btnCofnij";
            btnCofnij.Size = new Size(44, 33);
            btnCofnij.TabIndex = 14;
            btnCofnij.UseVisualStyleBackColor = true;
            // 
            // btnUsun
            // 
            btnUsun.Image = (Image)resources.GetObject("btnUsun.Image");
            btnUsun.Location = new Point(1128, 9);
            btnUsun.Name = "btnUsun";
            btnUsun.Size = new Size(44, 33);
            btnUsun.TabIndex = 13;
            btnUsun.UseVisualStyleBackColor = true;
            // 
            // btnEdytuj
            // 
            btnEdytuj.Image = (Image)resources.GetObject("btnEdytuj.Image");
            btnEdytuj.Location = new Point(1065, 9);
            btnEdytuj.Name = "btnEdytuj";
            btnEdytuj.Size = new Size(44, 33);
            btnEdytuj.TabIndex = 12;
            btnEdytuj.UseVisualStyleBackColor = true;
            // 
            // btnDodaj
            // 
            btnDodaj.Image = (Image)resources.GetObject("btnDodaj.Image");
            btnDodaj.Location = new Point(1002, 9);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(44, 33);
            btnDodaj.TabIndex = 11;
            btnDodaj.UseVisualStyleBackColor = true;
            // 
            // chckBoxNazwa
            // 
            chckBoxNazwa.AutoSize = true;
            chckBoxNazwa.BackColor = Color.Transparent;
            chckBoxNazwa.CheckAlign = ContentAlignment.MiddleRight;
            chckBoxNazwa.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            chckBoxNazwa.ForeColor = Color.White;
            chckBoxNazwa.Location = new Point(645, 20);
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
            chckBoxAkronim.Location = new Point(549, 20);
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
            label2.Location = new Point(380, 20);
            label2.Name = "label2";
            label2.Size = new Size(121, 15);
            label2.TabIndex = 2;
            label2.Text = "(używaj checkboxów)";
            // 
            // txtBoxWyszukaj
            // 
            txtBoxWyszukaj.Location = new Point(124, 15);
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
            label1.Location = new Point(23, 17);
            label1.Name = "label1";
            label1.Size = new Size(94, 18);
            label1.TabIndex = 0;
            label1.Text = "Wyszukaj:";
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
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // zamówieniaToolStripMenuItem
            // 
            zamówieniaToolStripMenuItem.BackColor = Color.Transparent;
            zamówieniaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { noweZamToolStripMenuItem, zamówieniaArchiwalneToolStripMenuItem });
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
            noweZamToolStripMenuItem.Size = new Size(180, 22);
            noweZamToolStripMenuItem.Text = "Nowe Zamówienia";
            // 
            // zamówieniaArchiwalneToolStripMenuItem
            // 
            zamówieniaArchiwalneToolStripMenuItem.Name = "zamówieniaArchiwalneToolStripMenuItem";
            zamówieniaArchiwalneToolStripMenuItem.Size = new Size(180, 22);
            zamówieniaArchiwalneToolStripMenuItem.Text = "Zobacz Zamówienia";
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
            dodajToolStripMenuItem.Size = new Size(154, 22);
            dodajToolStripMenuItem.Text = "Dodaj";
            // 
            // zobaczFakturyToolStripMenuItem
            // 
            zobaczFakturyToolStripMenuItem.Name = "zobaczFakturyToolStripMenuItem";
            zobaczFakturyToolStripMenuItem.Size = new Size(154, 22);
            zobaczFakturyToolStripMenuItem.Text = "Zobacz Faktury";
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
            // ListaKontrahentowForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1244, 624);
            Controls.Add(menuStrip1);
            Controls.Add(pnlPrzyciski);
            Controls.Add(pnlDataGrid);
            Name = "ListaKontrahentowForm";
            Text = "Lista Kontrahentów";
            pnlDataGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtGridLstKnt).EndInit();
            pnlPrzyciski.ResumeLayout(false);
            pnlPrzyciski.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlDataGrid;
        private Panel pnlPrzyciski;
        private DataGridView dtGridLstKnt;
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
        private ToolStripMenuItem noweZamToolStripMenuItem;
        private ToolStripMenuItem zamówieniaArchiwalneToolStripMenuItem;
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
        private ToolStripMenuItem drukarkiToolStripMenuItem;
    }
}