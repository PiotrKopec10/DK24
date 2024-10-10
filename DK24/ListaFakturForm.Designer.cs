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
            toolBarListaFaktur = new ToolStrip();
            toolBarBtnLstKnt = new ToolStripButton();
            toolBarBtnLstTwr = new ToolStripButton();
            toolBarBtnDrukuj = new ToolStripButton();
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
            toolBarListaFaktur.SuspendLayout();
            pnlDtGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            pnlPrzyciski.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // toolBarListaFaktur
            // 
            toolBarListaFaktur.Items.AddRange(new ToolStripItem[] { toolBarBtnLstKnt, toolBarBtnLstTwr, toolBarBtnDrukuj });
            toolBarListaFaktur.Location = new Point(0, 0);
            toolBarListaFaktur.Name = "toolBarListaFaktur";
            toolBarListaFaktur.Size = new Size(1244, 25);
            toolBarListaFaktur.TabIndex = 0;
            toolBarListaFaktur.Text = "toolStrip1";
            // 
            // toolBarBtnLstKnt
            // 
            toolBarBtnLstKnt.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolBarBtnLstKnt.Image = (Image)resources.GetObject("toolBarBtnLstKnt.Image");
            toolBarBtnLstKnt.ImageTransparentColor = Color.Magenta;
            toolBarBtnLstKnt.Name = "toolBarBtnLstKnt";
            toolBarBtnLstKnt.Size = new Size(23, 22);
            toolBarBtnLstKnt.Text = "Lista Kontrahentów";
            // 
            // toolBarBtnLstTwr
            // 
            toolBarBtnLstTwr.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolBarBtnLstTwr.Image = (Image)resources.GetObject("toolBarBtnLstTwr.Image");
            toolBarBtnLstTwr.ImageTransparentColor = Color.Magenta;
            toolBarBtnLstTwr.Name = "toolBarBtnLstTwr";
            toolBarBtnLstTwr.Size = new Size(23, 22);
            toolBarBtnLstTwr.Text = "Lista Towarów i Usług";
            // 
            // toolBarBtnDrukuj
            // 
            toolBarBtnDrukuj.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolBarBtnDrukuj.Image = (Image)resources.GetObject("toolBarBtnDrukuj.Image");
            toolBarBtnDrukuj.ImageTransparentColor = Color.Magenta;
            toolBarBtnDrukuj.Name = "toolBarBtnDrukuj";
            toolBarBtnDrukuj.Size = new Size(23, 22);
            toolBarBtnDrukuj.Text = "Drukuj Fakture";
            // 
            // pnlDtGrid
            // 
            pnlDtGrid.Controls.Add(dataGridView1);
            pnlDtGrid.Location = new Point(0, 28);
            pnlDtGrid.Name = "pnlDtGrid";
            pnlDtGrid.Size = new Size(1244, 543);
            pnlDtGrid.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1244, 543);
            dataGridView1.TabIndex = 0;
            // 
            // pnlPrzyciski
            // 
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
            btnDodaj.Image = (Image)resources.GetObject("btnDodaj.Image");
            btnDodaj.Location = new Point(1002, 13);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(44, 33);
            btnDodaj.TabIndex = 7;
            btnDodaj.UseVisualStyleBackColor = true;
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
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label2.Location = new Point(548, 18);
            label2.Name = "label2";
            label2.Size = new Size(45, 20);
            label2.TabIndex = 5;
            label2.Text = "Filter:";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(373, 18);
            numericUpDown1.Maximum = new decimal(new int[] { 2100, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 1980, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(66, 23);
            numericUpDown1.TabIndex = 4;
            numericUpDown1.Value = new decimal(new int[] { 2024, 0, 0, 0 });
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(167, 17);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(130, 23);
            comboBox1.TabIndex = 3;
            // 
            // chckBoxRok
            // 
            chckBoxRok.AutoSize = true;
            chckBoxRok.CheckAlign = ContentAlignment.MiddleRight;
            chckBoxRok.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            chckBoxRok.Location = new Point(314, 19);
            chckBoxRok.Name = "chckBoxRok";
            chckBoxRok.Size = new Size(49, 21);
            chckBoxRok.TabIndex = 2;
            chckBoxRok.Text = "Rok";
            chckBoxRok.UseVisualStyleBackColor = true;
            // 
            // chckBoxMiesiac
            // 
            chckBoxMiesiac.AutoSize = true;
            chckBoxMiesiac.CheckAlign = ContentAlignment.MiddleRight;
            chckBoxMiesiac.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            chckBoxMiesiac.Location = new Point(87, 19);
            chckBoxMiesiac.Name = "chckBoxMiesiac";
            chckBoxMiesiac.Size = new Size(71, 21);
            chckBoxMiesiac.TabIndex = 1;
            chckBoxMiesiac.Text = "Miesiąc";
            chckBoxMiesiac.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.Location = new Point(17, 18);
            label1.Name = "label1";
            label1.Size = new Size(61, 20);
            label1.TabIndex = 0;
            label1.Text = "Lista za:";
            // 
            // ListaFakturForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1244, 624);
            Controls.Add(pnlPrzyciski);
            Controls.Add(pnlDtGrid);
            Controls.Add(toolBarListaFaktur);
            Name = "ListaFakturForm";
            Text = "Lista Faktur";
            toolBarListaFaktur.ResumeLayout(false);
            toolBarListaFaktur.PerformLayout();
            pnlDtGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            pnlPrzyciski.ResumeLayout(false);
            pnlPrzyciski.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolBarListaFaktur;
        private ToolStripButton toolBarBtnLstKnt;
        private ToolStripButton toolBarBtnLstTwr;
        private ToolStripButton toolBarBtnDrukuj;
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
    }
}