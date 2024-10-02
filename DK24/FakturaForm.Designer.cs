namespace DK24
{
    partial class FakturaForm
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
            pnlGoraDane = new Panel();
            pnlDataGrid = new Panel();
            pnlPrzyciski = new Panel();
            grpBoxNaglowek = new GroupBox();
            grpBoxWartDok = new GroupBox();
            label1 = new Label();
            cmbBoxTypDokumentu = new ComboBox();
            numBoxNrDok = new NumericUpDown();
            numBoxRok = new NumericUpDown();
            numBoxDzien = new NumericUpDown();
            numBoxMiesiac = new NumericUpDown();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            lblCenaNetto = new Label();
            lblCenaBrutto = new Label();
            label9 = new Label();
            txtBoxAkronimKnt = new TextBox();
            txtBoxNazwaKnt = new TextBox();
            txtBoxPrefixNipKnt = new TextBox();
            txtBoxNipKnt = new TextBox();
            txtBoxAdresKnt = new TextBox();
            txtBoxKodPoczKnt = new TextBox();
            txtBoxMiastoKnt = new TextBox();
            btnKontrahent = new Button();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            richTxtBoxOpis = new RichTextBox();
            cmbBoxPlatnosc = new ComboBox();
            numBoxIloscDni = new NumericUpDown();
            label10 = new Label();
            btnDo = new Button();
            dtPickerDo = new DateTimePicker();
            dtPickerDataWys = new DateTimePicker();
            btnDataWys = new Button();
            dtPickerDataSprzed = new DateTimePicker();
            btnDataSprzed = new Button();
            dtGridDokument = new DataGridView();
            chckBoxArchiwalny = new CheckBox();
            pnlGoraDane.SuspendLayout();
            pnlDataGrid.SuspendLayout();
            grpBoxNaglowek.SuspendLayout();
            grpBoxWartDok.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numBoxNrDok).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numBoxRok).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numBoxDzien).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numBoxMiesiac).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numBoxIloscDni).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtGridDokument).BeginInit();
            SuspendLayout();
            // 
            // pnlGoraDane
            // 
            pnlGoraDane.Controls.Add(chckBoxArchiwalny);
            pnlGoraDane.Controls.Add(dtPickerDataSprzed);
            pnlGoraDane.Controls.Add(btnDataSprzed);
            pnlGoraDane.Controls.Add(dtPickerDataWys);
            pnlGoraDane.Controls.Add(btnDataWys);
            pnlGoraDane.Controls.Add(dtPickerDo);
            pnlGoraDane.Controls.Add(btnDo);
            pnlGoraDane.Controls.Add(label10);
            pnlGoraDane.Controls.Add(numBoxIloscDni);
            pnlGoraDane.Controls.Add(cmbBoxPlatnosc);
            pnlGoraDane.Controls.Add(richTxtBoxOpis);
            pnlGoraDane.Controls.Add(label8);
            pnlGoraDane.Controls.Add(label7);
            pnlGoraDane.Controls.Add(label6);
            pnlGoraDane.Controls.Add(btnKontrahent);
            pnlGoraDane.Controls.Add(txtBoxMiastoKnt);
            pnlGoraDane.Controls.Add(txtBoxKodPoczKnt);
            pnlGoraDane.Controls.Add(txtBoxAdresKnt);
            pnlGoraDane.Controls.Add(txtBoxNipKnt);
            pnlGoraDane.Controls.Add(txtBoxPrefixNipKnt);
            pnlGoraDane.Controls.Add(txtBoxNazwaKnt);
            pnlGoraDane.Controls.Add(txtBoxAkronimKnt);
            pnlGoraDane.Controls.Add(grpBoxWartDok);
            pnlGoraDane.Controls.Add(grpBoxNaglowek);
            pnlGoraDane.Location = new Point(1, 2);
            pnlGoraDane.Name = "pnlGoraDane";
            pnlGoraDane.Size = new Size(1203, 340);
            pnlGoraDane.TabIndex = 0;
            // 
            // pnlDataGrid
            // 
            pnlDataGrid.Controls.Add(dtGridDokument);
            pnlDataGrid.Location = new Point(1, 339);
            pnlDataGrid.Name = "pnlDataGrid";
            pnlDataGrid.Size = new Size(1203, 252);
            pnlDataGrid.TabIndex = 1;
            // 
            // pnlPrzyciski
            // 
            pnlPrzyciski.Location = new Point(1, 587);
            pnlPrzyciski.Name = "pnlPrzyciski";
            pnlPrzyciski.Size = new Size(1203, 53);
            pnlPrzyciski.TabIndex = 2;
            // 
            // grpBoxNaglowek
            // 
            grpBoxNaglowek.Controls.Add(label4);
            grpBoxNaglowek.Controls.Add(label3);
            grpBoxNaglowek.Controls.Add(label2);
            grpBoxNaglowek.Controls.Add(numBoxMiesiac);
            grpBoxNaglowek.Controls.Add(numBoxDzien);
            grpBoxNaglowek.Controls.Add(numBoxRok);
            grpBoxNaglowek.Controls.Add(numBoxNrDok);
            grpBoxNaglowek.Controls.Add(cmbBoxTypDokumentu);
            grpBoxNaglowek.Controls.Add(label1);
            grpBoxNaglowek.Location = new Point(3, 3);
            grpBoxNaglowek.Name = "grpBoxNaglowek";
            grpBoxNaglowek.Size = new Size(734, 83);
            grpBoxNaglowek.TabIndex = 0;
            grpBoxNaglowek.TabStop = false;
            grpBoxNaglowek.Text = "Nagłówek";
            // 
            // grpBoxWartDok
            // 
            grpBoxWartDok.Controls.Add(label9);
            grpBoxWartDok.Controls.Add(lblCenaBrutto);
            grpBoxWartDok.Controls.Add(lblCenaNetto);
            grpBoxWartDok.Controls.Add(label5);
            grpBoxWartDok.Location = new Point(813, 10);
            grpBoxWartDok.Name = "grpBoxWartDok";
            grpBoxWartDok.Size = new Size(368, 199);
            grpBoxWartDok.TabIndex = 1;
            grpBoxWartDok.TabStop = false;
            grpBoxWartDok.Text = "Wartość Dokumentu:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 35);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 0;
            label1.Text = "Numer:";
            // 
            // cmbBoxTypDokumentu
            // 
            cmbBoxTypDokumentu.FormattingEnabled = true;
            cmbBoxTypDokumentu.Location = new Point(66, 32);
            cmbBoxTypDokumentu.Name = "cmbBoxTypDokumentu";
            cmbBoxTypDokumentu.Size = new Size(68, 23);
            cmbBoxTypDokumentu.TabIndex = 1;
            // 
            // numBoxNrDok
            // 
            numBoxNrDok.Location = new Point(152, 32);
            numBoxNrDok.Name = "numBoxNrDok";
            numBoxNrDok.Size = new Size(53, 23);
            numBoxNrDok.TabIndex = 2;
            // 
            // numBoxRok
            // 
            numBoxRok.Location = new Point(503, 35);
            numBoxRok.Name = "numBoxRok";
            numBoxRok.Size = new Size(82, 23);
            numBoxRok.TabIndex = 3;
            // 
            // numBoxDzien
            // 
            numBoxDzien.Location = new Point(355, 35);
            numBoxDzien.Name = "numBoxDzien";
            numBoxDzien.Size = new Size(48, 23);
            numBoxDzien.TabIndex = 4;
            // 
            // numBoxMiesiac
            // 
            numBoxMiesiac.Location = new Point(424, 35);
            numBoxMiesiac.Name = "numBoxMiesiac";
            numBoxMiesiac.Size = new Size(56, 23);
            numBoxMiesiac.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(273, 37);
            label2.Name = "label2";
            label2.Size = new Size(76, 15);
            label2.TabIndex = 6;
            label2.Text = "Seria(D/M/R)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label3.Location = new Point(402, 32);
            label3.Name = "label3";
            label3.Size = new Size(20, 25);
            label3.TabIndex = 7;
            label3.Text = "/";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label4.Location = new Point(480, 32);
            label4.Name = "label4";
            label4.Size = new Size(20, 25);
            label4.TabIndex = 8;
            label4.Text = "/";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 238);
            label5.Location = new Point(23, 50);
            label5.Name = "label5";
            label5.Size = new Size(55, 21);
            label5.TabIndex = 0;
            label5.Text = "Netto:";
            // 
            // lblCenaNetto
            // 
            lblCenaNetto.AutoSize = true;
            lblCenaNetto.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblCenaNetto.Location = new Point(120, 49);
            lblCenaNetto.Name = "lblCenaNetto";
            lblCenaNetto.Size = new Size(37, 20);
            lblCenaNetto.TabIndex = 2;
            lblCenaNetto.Text = "0,00";
            // 
            // lblCenaBrutto
            // 
            lblCenaBrutto.AutoSize = true;
            lblCenaBrutto.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblCenaBrutto.Location = new Point(120, 131);
            lblCenaBrutto.Name = "lblCenaBrutto";
            lblCenaBrutto.Size = new Size(37, 20);
            lblCenaBrutto.TabIndex = 3;
            lblCenaBrutto.Text = "0,00";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 238);
            label9.Location = new Point(23, 130);
            label9.Name = "label9";
            label9.Size = new Size(60, 21);
            label9.TabIndex = 4;
            label9.Text = "Brutto:";
            // 
            // txtBoxAkronimKnt
            // 
            txtBoxAkronimKnt.Location = new Point(111, 102);
            txtBoxAkronimKnt.Name = "txtBoxAkronimKnt";
            txtBoxAkronimKnt.Size = new Size(295, 23);
            txtBoxAkronimKnt.TabIndex = 2;
            // 
            // txtBoxNazwaKnt
            // 
            txtBoxNazwaKnt.Location = new Point(440, 102);
            txtBoxNazwaKnt.Name = "txtBoxNazwaKnt";
            txtBoxNazwaKnt.Size = new Size(266, 23);
            txtBoxNazwaKnt.TabIndex = 3;
            // 
            // txtBoxPrefixNipKnt
            // 
            txtBoxPrefixNipKnt.Location = new Point(111, 141);
            txtBoxPrefixNipKnt.Name = "txtBoxPrefixNipKnt";
            txtBoxPrefixNipKnt.Size = new Size(35, 23);
            txtBoxPrefixNipKnt.TabIndex = 4;
            // 
            // txtBoxNipKnt
            // 
            txtBoxNipKnt.Location = new Point(152, 141);
            txtBoxNipKnt.Name = "txtBoxNipKnt";
            txtBoxNipKnt.Size = new Size(254, 23);
            txtBoxNipKnt.TabIndex = 5;
            // 
            // txtBoxAdresKnt
            // 
            txtBoxAdresKnt.Location = new Point(440, 141);
            txtBoxAdresKnt.Name = "txtBoxAdresKnt";
            txtBoxAdresKnt.Size = new Size(266, 23);
            txtBoxAdresKnt.TabIndex = 6;
            // 
            // txtBoxKodPoczKnt
            // 
            txtBoxKodPoczKnt.Location = new Point(111, 170);
            txtBoxKodPoczKnt.Name = "txtBoxKodPoczKnt";
            txtBoxKodPoczKnt.Size = new Size(73, 23);
            txtBoxKodPoczKnt.TabIndex = 7;
            // 
            // txtBoxMiastoKnt
            // 
            txtBoxMiastoKnt.Location = new Point(190, 170);
            txtBoxMiastoKnt.Name = "txtBoxMiastoKnt";
            txtBoxMiastoKnt.Size = new Size(216, 23);
            txtBoxMiastoKnt.TabIndex = 8;
            // 
            // btnKontrahent
            // 
            btnKontrahent.Location = new Point(16, 101);
            btnKontrahent.Name = "btnKontrahent";
            btnKontrahent.Size = new Size(86, 23);
            btnKontrahent.TabIndex = 9;
            btnKontrahent.Text = "&Kontrahent";
            btnKontrahent.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(69, 149);
            label6.Name = "label6";
            label6.Size = new Size(29, 15);
            label6.TabIndex = 10;
            label6.Text = "NIP:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(43, 211);
            label7.Name = "label7";
            label7.Size = new Size(55, 15);
            label7.TabIndex = 11;
            label7.Text = "Płatność:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(38, 237);
            label8.Name = "label8";
            label8.Size = new Size(34, 15);
            label8.TabIndex = 12;
            label8.Text = "Opis:";
            // 
            // richTxtBoxOpis
            // 
            richTxtBoxOpis.Location = new Point(78, 237);
            richTxtBoxOpis.Name = "richTxtBoxOpis";
            richTxtBoxOpis.Size = new Size(659, 96);
            richTxtBoxOpis.TabIndex = 13;
            richTxtBoxOpis.Text = "";
            // 
            // cmbBoxPlatnosc
            // 
            cmbBoxPlatnosc.FormattingEnabled = true;
            cmbBoxPlatnosc.Location = new Point(111, 208);
            cmbBoxPlatnosc.Name = "cmbBoxPlatnosc";
            cmbBoxPlatnosc.Size = new Size(121, 23);
            cmbBoxPlatnosc.TabIndex = 14;
            // 
            // numBoxIloscDni
            // 
            numBoxIloscDni.Location = new Point(249, 208);
            numBoxIloscDni.Name = "numBoxIloscDni";
            numBoxIloscDni.Size = new Size(45, 23);
            numBoxIloscDni.TabIndex = 15;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(300, 211);
            label10.Name = "label10";
            label10.Size = new Size(24, 15);
            label10.TabIndex = 16;
            label10.Text = "dni";
            // 
            // btnDo
            // 
            btnDo.Location = new Point(369, 205);
            btnDo.Name = "btnDo";
            btnDo.Size = new Size(40, 23);
            btnDo.TabIndex = 17;
            btnDo.Text = "Do";
            btnDo.UseVisualStyleBackColor = true;
            // 
            // dtPickerDo
            // 
            dtPickerDo.Format = DateTimePickerFormat.Short;
            dtPickerDo.Location = new Point(427, 205);
            dtPickerDo.Name = "dtPickerDo";
            dtPickerDo.ShowUpDown = true;
            dtPickerDo.Size = new Size(108, 23);
            dtPickerDo.TabIndex = 18;
            // 
            // dtPickerDataWys
            // 
            dtPickerDataWys.Format = DateTimePickerFormat.Short;
            dtPickerDataWys.Location = new Point(947, 227);
            dtPickerDataWys.Name = "dtPickerDataWys";
            dtPickerDataWys.ShowUpDown = true;
            dtPickerDataWys.Size = new Size(108, 23);
            dtPickerDataWys.TabIndex = 20;
            // 
            // btnDataWys
            // 
            btnDataWys.Location = new Point(813, 227);
            btnDataWys.Name = "btnDataWys";
            btnDataWys.Size = new Size(117, 23);
            btnDataWys.TabIndex = 19;
            btnDataWys.Text = "Data Wystawienia:";
            btnDataWys.UseVisualStyleBackColor = true;
            // 
            // dtPickerDataSprzed
            // 
            dtPickerDataSprzed.Format = DateTimePickerFormat.Short;
            dtPickerDataSprzed.Location = new Point(947, 279);
            dtPickerDataSprzed.Name = "dtPickerDataSprzed";
            dtPickerDataSprzed.ShowUpDown = true;
            dtPickerDataSprzed.Size = new Size(108, 23);
            dtPickerDataSprzed.TabIndex = 22;
            // 
            // btnDataSprzed
            // 
            btnDataSprzed.Location = new Point(813, 279);
            btnDataSprzed.Name = "btnDataSprzed";
            btnDataSprzed.Size = new Size(117, 23);
            btnDataSprzed.TabIndex = 21;
            btnDataSprzed.Text = "Data Sprzedaży:";
            btnDataSprzed.UseVisualStyleBackColor = true;
            // 
            // dtGridDokument
            // 
            dtGridDokument.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtGridDokument.Dock = DockStyle.Fill;
            dtGridDokument.Location = new Point(0, 0);
            dtGridDokument.Name = "dtGridDokument";
            dtGridDokument.Size = new Size(1203, 252);
            dtGridDokument.TabIndex = 0;
            // 
            // chckBoxArchiwalny
            // 
            chckBoxArchiwalny.AutoSize = true;
            chckBoxArchiwalny.CheckAlign = ContentAlignment.MiddleRight;
            chckBoxArchiwalny.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            chckBoxArchiwalny.Location = new Point(614, 205);
            chckBoxArchiwalny.Name = "chckBoxArchiwalny";
            chckBoxArchiwalny.Size = new Size(115, 25);
            chckBoxArchiwalny.TabIndex = 23;
            chckBoxArchiwalny.Text = "Archiwalny";
            chckBoxArchiwalny.UseVisualStyleBackColor = true;
            // 
            // FakturaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1206, 641);
            Controls.Add(pnlPrzyciski);
            Controls.Add(pnlDataGrid);
            Controls.Add(pnlGoraDane);
            Name = "FakturaForm";
            Text = "FakturaForm";
            pnlGoraDane.ResumeLayout(false);
            pnlGoraDane.PerformLayout();
            pnlDataGrid.ResumeLayout(false);
            grpBoxNaglowek.ResumeLayout(false);
            grpBoxNaglowek.PerformLayout();
            grpBoxWartDok.ResumeLayout(false);
            grpBoxWartDok.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numBoxNrDok).EndInit();
            ((System.ComponentModel.ISupportInitialize)numBoxRok).EndInit();
            ((System.ComponentModel.ISupportInitialize)numBoxDzien).EndInit();
            ((System.ComponentModel.ISupportInitialize)numBoxMiesiac).EndInit();
            ((System.ComponentModel.ISupportInitialize)numBoxIloscDni).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtGridDokument).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlGoraDane;
        private Panel pnlDataGrid;
        private Panel pnlPrzyciski;
        private GroupBox grpBoxWartDok;
        private GroupBox grpBoxNaglowek;
        private ComboBox comboBox2;
        private NumericUpDown numBoxRok;
        private NumericUpDown numBoxNrDok;
        private ComboBox cmbBoxTypDokumentu;
        private Label label1;
        private NumericUpDown numBoxMiesiac;
        private NumericUpDown numBoxDzien;
        private Label label2;
        private Label label9;
        private Label lblCenaBrutto;
        private Label lblCenaNetto;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label7;
        private Label label6;
        private Button btnKontrahent;
        private TextBox txtBoxMiastoKnt;
        private TextBox txtBoxKodPoczKnt;
        private TextBox txtBoxAdresKnt;
        private TextBox txtBoxNipKnt;
        private TextBox txtBoxPrefixNipKnt;
        private TextBox txtBoxNazwaKnt;
        private TextBox txtBoxAkronimKnt;
        private Button btnDo;
        private Label label10;
        private NumericUpDown numBoxIloscDni;
        private ComboBox cmbBoxPlatnosc;
        private RichTextBox richTxtBoxOpis;
        private Label label8;
        private DateTimePicker dtPickerDataSprzed;
        private Button btnDataSprzed;
        private DateTimePicker dtPickerDataWys;
        private Button btnDataWys;
        private DateTimePicker dtPickerDo;
        private CheckBox chckBoxArchiwalny;
        private DataGridView dtGridDokument;
    }
}