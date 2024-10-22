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
            pnlDtGrid = new Panel();
            dataGridView1 = new DataGridView();
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
            pnlDtGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            pnlPrzyciski.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlDtGrid
            // 
            pnlDtGrid.BackColor = Color.FromArgb(255, 128, 0);
            pnlDtGrid.Controls.Add(dataGridView1);
            pnlDtGrid.Location = new Point(0, 28);
            pnlDtGrid.Name = "pnlDtGrid";
            pnlDtGrid.Size = new Size(1244, 543);
            pnlDtGrid.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 48);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1244, 495);
            dataGridView1.TabIndex = 0;
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
            pnlPrzyciski.Location = new Point(0, 568);
            pnlPrzyciski.Name = "pnlPrzyciski";
            pnlPrzyciski.Size = new Size(1244, 55);
            pnlPrzyciski.TabIndex = 2;
            // 
            // btnCofnij
            // 
            btnCofnij.Image = (Image)resources.GetObject("btnCofnij.Image");
            btnCofnij.Location = new Point(1188, 13);
            btnCofnij.Name = "btnCofnij";
            btnCofnij.Size = new Size(44, 33);
            btnCofnij.TabIndex = 10;
            btnCofnij.UseVisualStyleBackColor = true;
            // 
            // btnUsun
            // 
            btnUsun.Image = (Image)resources.GetObject("btnUsun.Image");
            btnUsun.Location = new Point(1128, 13);
            btnUsun.Name = "btnUsun";
            btnUsun.Size = new Size(44, 33);
            btnUsun.TabIndex = 9;
            btnUsun.UseVisualStyleBackColor = true;
            // 
            // btnEdytuj
            // 
            btnEdytuj.Image = (Image)resources.GetObject("btnEdytuj.Image");
            btnEdytuj.Location = new Point(1065, 13);
            btnEdytuj.Name = "btnEdytuj";
            btnEdytuj.Size = new Size(44, 33);
            btnEdytuj.TabIndex = 8;
            btnEdytuj.UseVisualStyleBackColor = true;
            // 
            // btnDodaj
            // 
            btnDodaj.BackColor = Color.Transparent;
            btnDodaj.Image = (Image)resources.GetObject("btnDodaj.Image");
            btnDodaj.Location = new Point(1002, 13);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(44, 33);
            btnDodaj.TabIndex = 7;
            btnDodaj.UseVisualStyleBackColor = false;
            // 
            // txtBoxFilter
            // 
            txtBoxFilter.Location = new Point(599, 18);
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
            label2.Location = new Point(542, 20);
            label2.Name = "label2";
            label2.Size = new Size(56, 18);
            label2.TabIndex = 5;
            label2.Text = "Filtruj:";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(388, 18);
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
            comboBox1.Location = new Point(183, 17);
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
            chckBoxRok.Location = new Point(330, 19);
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
            chckBoxMiesiac.Location = new Point(105, 19);
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
            label1.Location = new Point(17, 18);
            label1.Name = "label1";
            label1.Size = new Size(78, 18);
            label1.TabIndex = 0;
            label1.Text = "Lista za:";
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
            menuStrip1.TabIndex = 3;
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
            // ListaFakturForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1244, 624);
            Controls.Add(menuStrip1);
            Controls.Add(pnlPrzyciski);
            Controls.Add(pnlDtGrid);
            Name = "ListaFakturForm";
            Text = "Lista Faktur";
            pnlDtGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            pnlPrzyciski.ResumeLayout(false);
            pnlPrzyciski.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel pnlDtGrid;
        private DataGridView dataGridView1;
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