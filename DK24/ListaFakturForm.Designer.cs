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
            pnlDol = new Panel();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            chckboxMiesiac = new CheckBox();
            chckboxRok = new CheckBox();
            comboBox1 = new ComboBox();
            numericUpDown1 = new NumericUpDown();
            label2 = new Label();
            textBox1 = new TextBox();
            btnDodaj = new Button();
            btnEdytuj = new Button();
            btnUsun = new Button();
            btnCofnij = new Button();
            toolBarListaFaktur.SuspendLayout();
            pnlDtGrid.SuspendLayout();
            pnlDol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            // pnlDol
            // 
            pnlDol.Controls.Add(btnCofnij);
            pnlDol.Controls.Add(btnUsun);
            pnlDol.Controls.Add(btnEdytuj);
            pnlDol.Controls.Add(btnDodaj);
            pnlDol.Controls.Add(textBox1);
            pnlDol.Controls.Add(label2);
            pnlDol.Controls.Add(numericUpDown1);
            pnlDol.Controls.Add(comboBox1);
            pnlDol.Controls.Add(chckboxRok);
            pnlDol.Controls.Add(chckboxMiesiac);
            pnlDol.Controls.Add(label1);
            pnlDol.Location = new Point(0, 568);
            pnlDol.Name = "pnlDol";
            pnlDol.Size = new Size(1244, 55);
            pnlDol.TabIndex = 2;
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
            // chckboxMiesiac
            // 
            chckboxMiesiac.AutoSize = true;
            chckboxMiesiac.CheckAlign = ContentAlignment.MiddleRight;
            chckboxMiesiac.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            chckboxMiesiac.Location = new Point(87, 19);
            chckboxMiesiac.Name = "chckboxMiesiac";
            chckboxMiesiac.Size = new Size(71, 21);
            chckboxMiesiac.TabIndex = 1;
            chckboxMiesiac.Text = "Miesiąc";
            chckboxMiesiac.UseVisualStyleBackColor = true;
            // 
            // chckboxRok
            // 
            chckboxRok.AutoSize = true;
            chckboxRok.CheckAlign = ContentAlignment.MiddleRight;
            chckboxRok.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            chckboxRok.Location = new Point(314, 19);
            chckboxRok.Name = "chckboxRok";
            chckboxRok.Size = new Size(49, 21);
            chckboxRok.TabIndex = 2;
            chckboxRok.Text = "Rok";
            chckboxRok.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(167, 17);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(130, 23);
            comboBox1.TabIndex = 3;
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
            // textBox1
            // 
            textBox1.Location = new Point(599, 18);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(273, 23);
            textBox1.TabIndex = 6;
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
            // btnEdytuj
            // 
            btnEdytuj.Image = (Image)resources.GetObject("btnEdytuj.Image");
            btnEdytuj.Location = new Point(1065, 13);
            btnEdytuj.Name = "btnEdytuj";
            btnEdytuj.Size = new Size(44, 33);
            btnEdytuj.TabIndex = 8;
            btnEdytuj.UseVisualStyleBackColor = true;
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
            // btnCofnij
            // 
            btnCofnij.Image = (Image)resources.GetObject("btnCofnij.Image");
            btnCofnij.Location = new Point(1188, 13);
            btnCofnij.Name = "btnCofnij";
            btnCofnij.Size = new Size(44, 33);
            btnCofnij.TabIndex = 10;
            btnCofnij.UseVisualStyleBackColor = true;
            // 
            // ListaFakturForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1244, 624);
            Controls.Add(pnlDol);
            Controls.Add(pnlDtGrid);
            Controls.Add(toolBarListaFaktur);
            Name = "ListaFakturForm";
            Text = "Lista Faktur";
            toolBarListaFaktur.ResumeLayout(false);
            toolBarListaFaktur.PerformLayout();
            pnlDtGrid.ResumeLayout(false);
            pnlDol.ResumeLayout(false);
            pnlDol.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private Panel pnlDol;
        private CheckBox chckboxMiesiac;
        private Label label1;
        private CheckBox chckboxRok;
        private NumericUpDown numericUpDown1;
        private ComboBox comboBox1;
        private Label label2;
        private Button btnDodaj;
        private TextBox textBox1;
        private Button btnUsun;
        private Button btnEdytuj;
        private Button btnCofnij;
    }
}