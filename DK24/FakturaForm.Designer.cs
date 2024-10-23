﻿namespace DK24
{
    partial class DokumentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DokumentForm));
            pnlGoraDane = new Panel();
            chckBoxCzyFaktura = new CheckBox();
            chckBoxArchiwalny = new CheckBox();
            btnDataSprzed = new Button();
            btnDataWys = new Button();
            dtPickerDo = new DateTimePicker();
            btnDo = new Button();
            label10 = new Label();
            numBoxIloscDni = new NumericUpDown();
            cmbBoxPlatnosc = new ComboBox();
            richTxtBoxOpis = new RichTextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            btnKontrahent = new Button();
            txtBoxMiastoKnt = new TextBox();
            txtBoxKodPoczKnt = new TextBox();
            txtBoxAdresKnt = new TextBox();
            txtBoxNipKnt = new TextBox();
            txtBoxPrefixNipKnt = new TextBox();
            txtBoxNazwaKnt = new TextBox();
            txtBoxAkronimKnt = new TextBox();
            grpBoxWartDok = new GroupBox();
            label9 = new Label();
            lblCenaBrutto = new Label();
            lblCenaNetto = new Label();
            label5 = new Label();
            grpBoxNaglowek = new GroupBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            numBoxMiesiac = new NumericUpDown();
            numBoxDzien = new NumericUpDown();
            numBoxRok = new NumericUpDown();
            numBoxNrDok = new NumericUpDown();
            cmbBoxTypDokumentu = new ComboBox();
            label1 = new Label();
            pnlDataGrid = new Panel();
            dtGridDokument = new DataGridView();
            pnlPrzyciski = new Panel();
            btnAnuluj = new Button();
            btnZapisz = new Button();
            btnUsun = new Button();
            btnDodaj = new Button();
            label11 = new Label();
            textBox1 = new TextBox();
            btnTowarUslugi = new Button();
            dtPickDataWystaw = new DateTimePicker();
            dtPickSprzed = new DateTimePicker();
            pnlGoraDane.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numBoxIloscDni).BeginInit();
            grpBoxWartDok.SuspendLayout();
            grpBoxNaglowek.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numBoxMiesiac).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numBoxDzien).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numBoxRok).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numBoxNrDok).BeginInit();
            pnlDataGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtGridDokument).BeginInit();
            pnlPrzyciski.SuspendLayout();
            SuspendLayout();
            // 
            // pnlGoraDane
            // 
            pnlGoraDane.BackgroundImage = (Image)resources.GetObject("pnlGoraDane.BackgroundImage");
            pnlGoraDane.Controls.Add(dtPickSprzed);
            pnlGoraDane.Controls.Add(dtPickDataWystaw);
            pnlGoraDane.Controls.Add(chckBoxCzyFaktura);
            pnlGoraDane.Controls.Add(chckBoxArchiwalny);
            pnlGoraDane.Controls.Add(btnDataSprzed);
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
            pnlGoraDane.Location = new Point(0, 0);
            pnlGoraDane.Name = "pnlGoraDane";
            pnlGoraDane.Size = new Size(1244, 345);
            pnlGoraDane.TabIndex = 0;
            // 
            // chckBoxCzyFaktura
            // 
            chckBoxCzyFaktura.AutoSize = true;
            chckBoxCzyFaktura.BackColor = Color.Transparent;
            chckBoxCzyFaktura.CheckAlign = ContentAlignment.MiddleRight;
            chckBoxCzyFaktura.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            chckBoxCzyFaktura.ForeColor = Color.FromArgb(255, 128, 0);
            chckBoxCzyFaktura.Location = new Point(804, 80);
            chckBoxCzyFaktura.Name = "chckBoxCzyFaktura";
            chckBoxCzyFaktura.Size = new Size(95, 22);
            chckBoxCzyFaktura.TabIndex = 24;
            chckBoxCzyFaktura.Text = "Faktura";
            chckBoxCzyFaktura.UseVisualStyleBackColor = false;
            // 
            // chckBoxArchiwalny
            // 
            chckBoxArchiwalny.AutoSize = true;
            chckBoxArchiwalny.BackColor = Color.Transparent;
            chckBoxArchiwalny.CheckAlign = ContentAlignment.MiddleRight;
            chckBoxArchiwalny.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            chckBoxArchiwalny.ForeColor = Color.FromArgb(255, 128, 0);
            chckBoxArchiwalny.Location = new Point(776, 137);
            chckBoxArchiwalny.Name = "chckBoxArchiwalny";
            chckBoxArchiwalny.Size = new Size(123, 22);
            chckBoxArchiwalny.TabIndex = 23;
            chckBoxArchiwalny.Text = "Archiwalny";
            chckBoxArchiwalny.UseVisualStyleBackColor = false;
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
            // btnDataWys
            // 
            btnDataWys.Location = new Point(813, 227);
            btnDataWys.Name = "btnDataWys";
            btnDataWys.Size = new Size(117, 23);
            btnDataWys.TabIndex = 19;
            btnDataWys.Text = "Data Wystawienia:";
            btnDataWys.UseVisualStyleBackColor = true;
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
            // btnDo
            // 
            btnDo.Location = new Point(369, 205);
            btnDo.Name = "btnDo";
            btnDo.Size = new Size(40, 23);
            btnDo.TabIndex = 17;
            btnDo.Text = "Do";
            btnDo.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label10.ForeColor = Color.Transparent;
            label10.Location = new Point(299, 213);
            label10.Name = "label10";
            label10.Size = new Size(26, 14);
            label10.TabIndex = 16;
            label10.Text = "dni";
            // 
            // numBoxIloscDni
            // 
            numBoxIloscDni.Location = new Point(249, 208);
            numBoxIloscDni.Name = "numBoxIloscDni";
            numBoxIloscDni.Size = new Size(45, 23);
            numBoxIloscDni.TabIndex = 15;
            // 
            // cmbBoxPlatnosc
            // 
            cmbBoxPlatnosc.BackColor = SystemColors.Menu;
            cmbBoxPlatnosc.FormattingEnabled = true;
            cmbBoxPlatnosc.Location = new Point(111, 208);
            cmbBoxPlatnosc.Name = "cmbBoxPlatnosc";
            cmbBoxPlatnosc.Size = new Size(121, 23);
            cmbBoxPlatnosc.TabIndex = 14;
            // 
            // richTxtBoxOpis
            // 
            richTxtBoxOpis.Location = new Point(78, 237);
            richTxtBoxOpis.Name = "richTxtBoxOpis";
            richTxtBoxOpis.Size = new Size(659, 94);
            richTxtBoxOpis.TabIndex = 13;
            richTxtBoxOpis.Text = "";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label8.ForeColor = Color.White;
            label8.Location = new Point(38, 239);
            label8.Name = "label8";
            label8.Size = new Size(40, 14);
            label8.TabIndex = 12;
            label8.Text = "Opis:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label7.ForeColor = Color.White;
            label7.Location = new Point(43, 212);
            label7.Name = "label7";
            label7.Size = new Size(65, 14);
            label7.TabIndex = 11;
            label7.Text = "Płatność:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label6.ForeColor = Color.White;
            label6.Location = new Point(70, 145);
            label6.Name = "label6";
            label6.Size = new Size(34, 14);
            label6.TabIndex = 10;
            label6.Text = "NIP:";
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
            // txtBoxMiastoKnt
            // 
            txtBoxMiastoKnt.BackColor = SystemColors.Menu;
            txtBoxMiastoKnt.Location = new Point(190, 170);
            txtBoxMiastoKnt.Name = "txtBoxMiastoKnt";
            txtBoxMiastoKnt.Size = new Size(216, 23);
            txtBoxMiastoKnt.TabIndex = 8;
            // 
            // txtBoxKodPoczKnt
            // 
            txtBoxKodPoczKnt.BackColor = SystemColors.Menu;
            txtBoxKodPoczKnt.Location = new Point(111, 170);
            txtBoxKodPoczKnt.Name = "txtBoxKodPoczKnt";
            txtBoxKodPoczKnt.Size = new Size(73, 23);
            txtBoxKodPoczKnt.TabIndex = 7;
            // 
            // txtBoxAdresKnt
            // 
            txtBoxAdresKnt.BackColor = SystemColors.Menu;
            txtBoxAdresKnt.Location = new Point(440, 141);
            txtBoxAdresKnt.Name = "txtBoxAdresKnt";
            txtBoxAdresKnt.Size = new Size(266, 23);
            txtBoxAdresKnt.TabIndex = 6;
            // 
            // txtBoxNipKnt
            // 
            txtBoxNipKnt.BackColor = SystemColors.Menu;
            txtBoxNipKnt.Location = new Point(152, 141);
            txtBoxNipKnt.Name = "txtBoxNipKnt";
            txtBoxNipKnt.Size = new Size(254, 23);
            txtBoxNipKnt.TabIndex = 5;
            // 
            // txtBoxPrefixNipKnt
            // 
            txtBoxPrefixNipKnt.BackColor = SystemColors.Menu;
            txtBoxPrefixNipKnt.Location = new Point(111, 141);
            txtBoxPrefixNipKnt.Name = "txtBoxPrefixNipKnt";
            txtBoxPrefixNipKnt.Size = new Size(35, 23);
            txtBoxPrefixNipKnt.TabIndex = 4;
            // 
            // txtBoxNazwaKnt
            // 
            txtBoxNazwaKnt.BackColor = SystemColors.Menu;
            txtBoxNazwaKnt.Location = new Point(440, 102);
            txtBoxNazwaKnt.Name = "txtBoxNazwaKnt";
            txtBoxNazwaKnt.Size = new Size(266, 23);
            txtBoxNazwaKnt.TabIndex = 3;
            // 
            // txtBoxAkronimKnt
            // 
            txtBoxAkronimKnt.BackColor = SystemColors.Menu;
            txtBoxAkronimKnt.Location = new Point(111, 102);
            txtBoxAkronimKnt.Name = "txtBoxAkronimKnt";
            txtBoxAkronimKnt.Size = new Size(295, 23);
            txtBoxAkronimKnt.TabIndex = 2;
            // 
            // grpBoxWartDok
            // 
            grpBoxWartDok.BackColor = Color.Transparent;
            grpBoxWartDok.Controls.Add(label9);
            grpBoxWartDok.Controls.Add(lblCenaBrutto);
            grpBoxWartDok.Controls.Add(lblCenaNetto);
            grpBoxWartDok.Controls.Add(label5);
            grpBoxWartDok.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            grpBoxWartDok.ForeColor = Color.FromArgb(255, 128, 0);
            grpBoxWartDok.Location = new Point(951, 10);
            grpBoxWartDok.Name = "grpBoxWartDok";
            grpBoxWartDok.Size = new Size(242, 164);
            grpBoxWartDok.TabIndex = 1;
            grpBoxWartDok.TabStop = false;
            grpBoxWartDok.Text = "Wartość Dokumentu:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 238);
            label9.Location = new Point(23, 114);
            label9.Name = "label9";
            label9.Size = new Size(60, 21);
            label9.TabIndex = 4;
            label9.Text = "Brutto:";
            // 
            // lblCenaBrutto
            // 
            lblCenaBrutto.AutoSize = true;
            lblCenaBrutto.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblCenaBrutto.Location = new Point(120, 115);
            lblCenaBrutto.Name = "lblCenaBrutto";
            lblCenaBrutto.Size = new Size(37, 20);
            lblCenaBrutto.TabIndex = 3;
            lblCenaBrutto.Text = "0,00";
            // 
            // lblCenaNetto
            // 
            lblCenaNetto.AutoSize = true;
            lblCenaNetto.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblCenaNetto.Location = new Point(120, 45);
            lblCenaNetto.Name = "lblCenaNetto";
            lblCenaNetto.Size = new Size(37, 20);
            lblCenaNetto.TabIndex = 2;
            lblCenaNetto.Text = "0,00";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 238);
            label5.Location = new Point(23, 46);
            label5.Name = "label5";
            label5.Size = new Size(55, 21);
            label5.TabIndex = 0;
            label5.Text = "Netto:";
            // 
            // grpBoxNaglowek
            // 
            grpBoxNaglowek.BackColor = Color.Transparent;
            grpBoxNaglowek.Controls.Add(label4);
            grpBoxNaglowek.Controls.Add(label3);
            grpBoxNaglowek.Controls.Add(label2);
            grpBoxNaglowek.Controls.Add(numBoxMiesiac);
            grpBoxNaglowek.Controls.Add(numBoxDzien);
            grpBoxNaglowek.Controls.Add(numBoxRok);
            grpBoxNaglowek.Controls.Add(numBoxNrDok);
            grpBoxNaglowek.Controls.Add(cmbBoxTypDokumentu);
            grpBoxNaglowek.Controls.Add(label1);
            grpBoxNaglowek.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            grpBoxNaglowek.ForeColor = Color.FromArgb(255, 128, 0);
            grpBoxNaglowek.Location = new Point(11, 5);
            grpBoxNaglowek.Name = "grpBoxNaglowek";
            grpBoxNaglowek.Size = new Size(726, 83);
            grpBoxNaglowek.TabIndex = 0;
            grpBoxNaglowek.TabStop = false;
            grpBoxNaglowek.Text = "Nagłówek";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label4.ForeColor = Color.White;
            label4.Location = new Point(484, 28);
            label4.Name = "label4";
            label4.Size = new Size(20, 25);
            label4.TabIndex = 8;
            label4.Text = "/";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label3.ForeColor = Color.White;
            label3.Location = new Point(403, 28);
            label3.Name = "label3";
            label3.Size = new Size(20, 25);
            label3.TabIndex = 7;
            label3.Text = "/";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(260, 36);
            label2.Name = "label2";
            label2.Size = new Size(86, 14);
            label2.TabIndex = 6;
            label2.Text = "Seria(D/M/R)";
            // 
            // numBoxMiesiac
            // 
            numBoxMiesiac.Location = new Point(425, 32);
            numBoxMiesiac.Name = "numBoxMiesiac";
            numBoxMiesiac.Size = new Size(56, 22);
            numBoxMiesiac.TabIndex = 5;
            // 
            // numBoxDzien
            // 
            numBoxDzien.Location = new Point(352, 32);
            numBoxDzien.Name = "numBoxDzien";
            numBoxDzien.Size = new Size(48, 22);
            numBoxDzien.TabIndex = 4;
            // 
            // numBoxRok
            // 
            numBoxRok.Location = new Point(504, 32);
            numBoxRok.Name = "numBoxRok";
            numBoxRok.Size = new Size(82, 22);
            numBoxRok.TabIndex = 3;
            // 
            // numBoxNrDok
            // 
            numBoxNrDok.Location = new Point(152, 32);
            numBoxNrDok.Name = "numBoxNrDok";
            numBoxNrDok.Size = new Size(53, 22);
            numBoxNrDok.TabIndex = 2;
            // 
            // cmbBoxTypDokumentu
            // 
            cmbBoxTypDokumentu.FormattingEnabled = true;
            cmbBoxTypDokumentu.Location = new Point(66, 32);
            cmbBoxTypDokumentu.Name = "cmbBoxTypDokumentu";
            cmbBoxTypDokumentu.Size = new Size(68, 22);
            cmbBoxTypDokumentu.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(13, 35);
            label1.Name = "label1";
            label1.Size = new Size(53, 14);
            label1.TabIndex = 0;
            label1.Text = "Numer:";
            // 
            // pnlDataGrid
            // 
            pnlDataGrid.Controls.Add(dtGridDokument);
            pnlDataGrid.Location = new Point(0, 345);
            pnlDataGrid.Name = "pnlDataGrid";
            pnlDataGrid.Size = new Size(1244, 234);
            pnlDataGrid.TabIndex = 1;
            // 
            // dtGridDokument
            // 
            dtGridDokument.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtGridDokument.Dock = DockStyle.Fill;
            dtGridDokument.Location = new Point(0, 0);
            dtGridDokument.Name = "dtGridDokument";
            dtGridDokument.Size = new Size(1244, 234);
            dtGridDokument.TabIndex = 0;
            // 
            // pnlPrzyciski
            // 
            pnlPrzyciski.BackgroundImage = (Image)resources.GetObject("pnlPrzyciski.BackgroundImage");
            pnlPrzyciski.Controls.Add(btnAnuluj);
            pnlPrzyciski.Controls.Add(btnZapisz);
            pnlPrzyciski.Controls.Add(btnUsun);
            pnlPrzyciski.Controls.Add(btnDodaj);
            pnlPrzyciski.Controls.Add(label11);
            pnlPrzyciski.Controls.Add(textBox1);
            pnlPrzyciski.Controls.Add(btnTowarUslugi);
            pnlPrzyciski.Location = new Point(1, 579);
            pnlPrzyciski.Name = "pnlPrzyciski";
            pnlPrzyciski.Size = new Size(1244, 62);
            pnlPrzyciski.TabIndex = 2;
            // 
            // btnAnuluj
            // 
            btnAnuluj.Image = (Image)resources.GetObject("btnAnuluj.Image");
            btnAnuluj.Location = new Point(1128, 14);
            btnAnuluj.Name = "btnAnuluj";
            btnAnuluj.Size = new Size(44, 33);
            btnAnuluj.TabIndex = 6;
            btnAnuluj.UseVisualStyleBackColor = true;
            btnAnuluj.Click += btnAnuluj_Click;
            // 
            // btnZapisz
            // 
            btnZapisz.Image = (Image)resources.GetObject("btnZapisz.Image");
            btnZapisz.Location = new Point(1071, 14);
            btnZapisz.Name = "btnZapisz";
            btnZapisz.Size = new Size(44, 33);
            btnZapisz.TabIndex = 5;
            btnZapisz.UseVisualStyleBackColor = true;
            // 
            // btnUsun
            // 
            btnUsun.Image = (Image)resources.GetObject("btnUsun.Image");
            btnUsun.Location = new Point(813, 14);
            btnUsun.Name = "btnUsun";
            btnUsun.Size = new Size(44, 33);
            btnUsun.TabIndex = 4;
            btnUsun.UseVisualStyleBackColor = true;
            // 
            // btnDodaj
            // 
            btnDodaj.Image = (Image)resources.GetObject("btnDodaj.Image");
            btnDodaj.Location = new Point(749, 14);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(40, 33);
            btnDodaj.TabIndex = 3;
            btnDodaj.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label11.ForeColor = Color.Silver;
            label11.Location = new Point(447, 23);
            label11.Name = "label11";
            label11.Size = new Size(274, 15);
            label11.TabIndex = 2;
            label11.Text = "Wpisz kod Towaru/Usługi aby go dodać i kliknij [+]";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(152, 20);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(260, 23);
            textBox1.TabIndex = 1;
            // 
            // btnTowarUslugi
            // 
            btnTowarUslugi.Location = new Point(14, 19);
            btnTowarUslugi.Name = "btnTowarUslugi";
            btnTowarUslugi.Size = new Size(91, 23);
            btnTowarUslugi.TabIndex = 0;
            btnTowarUslugi.Text = "Towar/Usługi";
            btnTowarUslugi.UseVisualStyleBackColor = true;
            // 
            // dtPickDataWystaw
            // 
            dtPickDataWystaw.Location = new Point(951, 227);
            dtPickDataWystaw.Name = "dtPickDataWystaw";
            dtPickDataWystaw.Size = new Size(232, 23);
            dtPickDataWystaw.TabIndex = 25;
            // 
            // dtPickSprzed
            // 
            dtPickSprzed.Location = new Point(951, 279);
            dtPickSprzed.Name = "dtPickSprzed";
            dtPickSprzed.Size = new Size(232, 23);
            dtPickSprzed.TabIndex = 26;
            // 
            // DokumentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1244, 641);
            Controls.Add(pnlPrzyciski);
            Controls.Add(pnlDataGrid);
            Controls.Add(pnlGoraDane);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(1260, 680);
            MinimumSize = new Size(1260, 680);
            Name = "DokumentForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Dokument";
            pnlGoraDane.ResumeLayout(false);
            pnlGoraDane.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numBoxIloscDni).EndInit();
            grpBoxWartDok.ResumeLayout(false);
            grpBoxWartDok.PerformLayout();
            grpBoxNaglowek.ResumeLayout(false);
            grpBoxNaglowek.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numBoxMiesiac).EndInit();
            ((System.ComponentModel.ISupportInitialize)numBoxDzien).EndInit();
            ((System.ComponentModel.ISupportInitialize)numBoxRok).EndInit();
            ((System.ComponentModel.ISupportInitialize)numBoxNrDok).EndInit();
            pnlDataGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtGridDokument).EndInit();
            pnlPrzyciski.ResumeLayout(false);
            pnlPrzyciski.PerformLayout();
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
        private Button btnUsun;
        private Button btnDodaj;
        private Label label11;
        private TextBox textBox1;
        private Button btnTowarUslugi;
        private Button btnAnuluj;
        private Button btnZapisz;
        private CheckBox chckBoxCzyFaktura;
        private DateTimePicker dtPickDataWystaw;
        private DateTimePicker dtPickSprzed;
    }
}