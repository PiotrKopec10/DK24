﻿namespace DK24
{
    partial class SzczegolyZamowieniaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SzczegolyZamowieniaForm));
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle16 = new DataGridViewCellStyle();
            pnlPrzyciski = new Panel();
            btnAnuluj = new Button();
            btnZapisz = new Button();
            btnUsun = new Button();
            btnDodaj = new Button();
            label11 = new Label();
            textBox1 = new TextBox();
            btnTowarUslugi = new Button();
            panelGorny = new Panel();
            pictureBox1 = new PictureBox();
            pnlGoraDane = new Panel();
            dtPickSprzed = new DateTimePicker();
            dtPickDataWystaw = new DateTimePicker();
            btnDataSprzed = new Button();
            btnDataWys = new Button();
            cmbBoxPlatnosc = new ComboBox();
            richTxtBoxOpis = new RichTextBox();
            label8 = new Label();
            label7 = new Label();
            this.txtBoxAdresKlienta = new TextBox();
            txtBoxNazwaKlienta = new TextBox();
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
            panel2 = new Panel();
            panel3 = new Panel();
            pnlDtGridZamowienia = new Panel();
            dtGridViewZamowienia = new DataGridView();
            label6 = new Label();
            label12 = new Label();
            label13 = new Label();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            pnlPrzyciski.SuspendLayout();
            panelGorny.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlGoraDane.SuspendLayout();
            grpBoxWartDok.SuspendLayout();
            grpBoxNaglowek.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numBoxMiesiac).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numBoxDzien).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numBoxRok).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numBoxNrDok).BeginInit();
            pnlDtGridZamowienia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtGridViewZamowienia).BeginInit();
            SuspendLayout();
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
            pnlPrzyciski.Location = new Point(0, 615);
            pnlPrzyciski.Name = "pnlPrzyciski";
            pnlPrzyciski.Size = new Size(1260, 65);
            pnlPrzyciski.TabIndex = 3;
            // 
            // btnAnuluj
            // 
            btnAnuluj.Image = (Image)resources.GetObject("btnAnuluj.Image");
            btnAnuluj.Location = new Point(1191, 15);
            btnAnuluj.Name = "btnAnuluj";
            btnAnuluj.Size = new Size(44, 33);
            btnAnuluj.TabIndex = 6;
            btnAnuluj.UseVisualStyleBackColor = true;
            // 
            // btnZapisz
            // 
            btnZapisz.Image = (Image)resources.GetObject("btnZapisz.Image");
            btnZapisz.Location = new Point(1134, 15);
            btnZapisz.Name = "btnZapisz";
            btnZapisz.Size = new Size(44, 33);
            btnZapisz.TabIndex = 5;
            btnZapisz.UseVisualStyleBackColor = true;
            // 
            // btnUsun
            // 
            btnUsun.Image = (Image)resources.GetObject("btnUsun.Image");
            btnUsun.Location = new Point(813, 15);
            btnUsun.Name = "btnUsun";
            btnUsun.Size = new Size(44, 33);
            btnUsun.TabIndex = 4;
            btnUsun.UseVisualStyleBackColor = true;
            // 
            // btnDodaj
            // 
            btnDodaj.Image = (Image)resources.GetObject("btnDodaj.Image");
            btnDodaj.Location = new Point(749, 15);
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
            label11.Location = new Point(447, 27);
            label11.Name = "label11";
            label11.Size = new Size(274, 15);
            label11.TabIndex = 2;
            label11.Text = "Wpisz kod Towaru/Usługi aby go dodać i kliknij [+]";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(152, 24);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(260, 23);
            textBox1.TabIndex = 1;
            // 
            // btnTowarUslugi
            // 
            btnTowarUslugi.Location = new Point(14, 23);
            btnTowarUslugi.Name = "btnTowarUslugi";
            btnTowarUslugi.Size = new Size(91, 23);
            btnTowarUslugi.TabIndex = 0;
            btnTowarUslugi.Text = "Towar/Usługi";
            btnTowarUslugi.UseVisualStyleBackColor = true;
            // 
            // panelGorny
            // 
            panelGorny.BackgroundImage = (Image)resources.GetObject("panelGorny.BackgroundImage");
            panelGorny.Controls.Add(pictureBox1);
            panelGorny.Location = new Point(0, 0);
            panelGorny.Name = "panelGorny";
            panelGorny.Size = new Size(1260, 50);
            panelGorny.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Enabled = false;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(10, -14);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(132, 82);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // pnlGoraDane
            // 
            pnlGoraDane.BackgroundImage = (Image)resources.GetObject("pnlGoraDane.BackgroundImage");
            pnlGoraDane.Controls.Add(checkBox2);
            pnlGoraDane.Controls.Add(checkBox1);
            pnlGoraDane.Controls.Add(label13);
            pnlGoraDane.Controls.Add(label12);
            pnlGoraDane.Controls.Add(label6);
            pnlGoraDane.Controls.Add(dtPickSprzed);
            pnlGoraDane.Controls.Add(dtPickDataWystaw);
            pnlGoraDane.Controls.Add(btnDataSprzed);
            pnlGoraDane.Controls.Add(btnDataWys);
            pnlGoraDane.Controls.Add(richTxtBoxOpis);
            pnlGoraDane.Controls.Add(cmbBoxPlatnosc);
            pnlGoraDane.Controls.Add(label8);
            pnlGoraDane.Controls.Add(label7);
            pnlGoraDane.Controls.Add(this.txtBoxAdresKlienta);
            pnlGoraDane.Controls.Add(txtBoxNazwaKlienta);
            pnlGoraDane.Controls.Add(grpBoxWartDok);
            pnlGoraDane.Controls.Add(grpBoxNaglowek);
            pnlGoraDane.Location = new Point(0, 50);
            pnlGoraDane.Name = "pnlGoraDane";
            pnlGoraDane.Size = new Size(1260, 360);
            pnlGoraDane.TabIndex = 5;
            // 
            // dtPickSprzed
            // 
            dtPickSprzed.Location = new Point(440, 307);
            dtPickSprzed.Name = "dtPickSprzed";
            dtPickSprzed.Size = new Size(232, 23);
            dtPickSprzed.TabIndex = 26;
            // 
            // dtPickDataWystaw
            // 
            dtPickDataWystaw.Location = new Point(440, 255);
            dtPickDataWystaw.Name = "dtPickDataWystaw";
            dtPickDataWystaw.Size = new Size(232, 23);
            dtPickDataWystaw.TabIndex = 25;
            // 
            // btnDataSprzed
            // 
            btnDataSprzed.Location = new Point(302, 307);
            btnDataSprzed.Name = "btnDataSprzed";
            btnDataSprzed.Size = new Size(117, 23);
            btnDataSprzed.TabIndex = 21;
            btnDataSprzed.Text = "Data Sprzedaży:";
            btnDataSprzed.UseVisualStyleBackColor = true;
            // 
            // btnDataWys
            // 
            btnDataWys.Location = new Point(302, 255);
            btnDataWys.Name = "btnDataWys";
            btnDataWys.Size = new Size(117, 23);
            btnDataWys.TabIndex = 19;
            btnDataWys.Text = "Data Wystawienia:";
            btnDataWys.UseVisualStyleBackColor = true;
            // 
            // cmbBoxPlatnosc
            // 
            cmbBoxPlatnosc.BackColor = SystemColors.Menu;
            cmbBoxPlatnosc.FormattingEnabled = true;
            cmbBoxPlatnosc.Location = new Point(302, 211);
            cmbBoxPlatnosc.Name = "cmbBoxPlatnosc";
            cmbBoxPlatnosc.Size = new Size(189, 23);
            cmbBoxPlatnosc.TabIndex = 14;
            // 
            // richTxtBoxOpis
            // 
            richTxtBoxOpis.Location = new Point(766, 33);
            richTxtBoxOpis.Name = "richTxtBoxOpis";
            richTxtBoxOpis.Size = new Size(482, 314);
            richTxtBoxOpis.TabIndex = 13;
            richTxtBoxOpis.Text = "";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label8.ForeColor = Color.White;
            label8.Location = new Point(766, 11);
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
            label7.Location = new Point(302, 194);
            label7.Name = "label7";
            label7.Size = new Size(132, 14);
            label7.TabIndex = 11;
            label7.Text = "Status zamówienia:";
            // 
            // txtBoxAdresKlienta
            // 
            this.txtBoxAdresKlienta.BackColor = SystemColors.Menu;
            this.txtBoxAdresKlienta.Location = new Point(91, 142);
            this.txtBoxAdresKlienta.Name = "txtBoxAdresKlienta";
            this.txtBoxAdresKlienta.Size = new Size(295, 23);
            this.txtBoxAdresKlienta.TabIndex = 3;
            // 
            // txtBoxNazwaKlienta
            // 
            txtBoxNazwaKlienta.BackColor = SystemColors.Menu;
            txtBoxNazwaKlienta.Location = new Point(91, 102);
            txtBoxNazwaKlienta.Name = "txtBoxNazwaKlienta";
            txtBoxNazwaKlienta.Size = new Size(295, 23);
            txtBoxNazwaKlienta.TabIndex = 2;
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
            grpBoxWartDok.Location = new Point(38, 183);
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
            // panel2
            // 
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.Location = new Point(0, 410);
            panel2.Name = "panel2";
            panel2.Size = new Size(10, 205);
            panel2.TabIndex = 6;
            // 
            // panel3
            // 
            panel3.BackgroundImage = (Image)resources.GetObject("panel3.BackgroundImage");
            panel3.Location = new Point(1250, 410);
            panel3.Name = "panel3";
            panel3.Size = new Size(10, 205);
            panel3.TabIndex = 7;
            // 
            // pnlDtGridZamowienia
            // 
            pnlDtGridZamowienia.BackColor = Color.White;
            pnlDtGridZamowienia.Controls.Add(dtGridViewZamowienia);
            pnlDtGridZamowienia.ImeMode = ImeMode.NoControl;
            pnlDtGridZamowienia.Location = new Point(11, 411);
            pnlDtGridZamowienia.Margin = new Padding(3, 2, 3, 2);
            pnlDtGridZamowienia.Name = "pnlDtGridZamowienia";
            pnlDtGridZamowienia.Size = new Size(1238, 203);
            pnlDtGridZamowienia.TabIndex = 8;
            // 
            // dtGridViewZamowienia
            // 
            dtGridViewZamowienia.AllowUserToAddRows = false;
            dtGridViewZamowienia.AllowUserToDeleteRows = false;
            dataGridViewCellStyle13.BackColor = Color.LightGray;
            dataGridViewCellStyle13.ForeColor = Color.Black;
            dataGridViewCellStyle13.NullValue = "Brak Danych";
            dtGridViewZamowienia.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            dtGridViewZamowienia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtGridViewZamowienia.BackgroundColor = SystemColors.ControlDarkDark;
            dataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle14.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            dataGridViewCellStyle14.ForeColor = Color.White;
            dataGridViewCellStyle14.SelectionBackColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle14.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = DataGridViewTriState.True;
            dtGridViewZamowienia.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            dtGridViewZamowienia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle15.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = SystemColors.Control;
            dataGridViewCellStyle15.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            dataGridViewCellStyle15.ForeColor = Color.Black;
            dataGridViewCellStyle15.NullValue = "Brak Danych";
            dataGridViewCellStyle15.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = DataGridViewTriState.False;
            dtGridViewZamowienia.DefaultCellStyle = dataGridViewCellStyle15;
            dtGridViewZamowienia.Dock = DockStyle.Fill;
            dtGridViewZamowienia.EnableHeadersVisualStyles = false;
            dtGridViewZamowienia.GridColor = Color.Gray;
            dtGridViewZamowienia.Location = new Point(0, 0);
            dtGridViewZamowienia.Margin = new Padding(3, 2, 3, 2);
            dtGridViewZamowienia.Name = "dtGridViewZamowienia";
            dtGridViewZamowienia.ReadOnly = true;
            dtGridViewZamowienia.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle16.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = SystemColors.ControlDark;
            dataGridViewCellStyle16.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            dataGridViewCellStyle16.ForeColor = Color.White;
            dataGridViewCellStyle16.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = DataGridViewTriState.True;
            dtGridViewZamowienia.RowHeadersDefaultCellStyle = dataGridViewCellStyle16;
            dtGridViewZamowienia.RowHeadersVisible = false;
            dtGridViewZamowienia.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dtGridViewZamowienia.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtGridViewZamowienia.Size = new Size(1238, 203);
            dtGridViewZamowienia.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label6.ForeColor = Color.White;
            label6.Location = new Point(38, 105);
            label6.Name = "label6";
            label6.Size = new Size(47, 14);
            label6.TabIndex = 27;
            label6.Text = "Klient:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label12.ForeColor = Color.White;
            label12.Location = new Point(38, 145);
            label12.Name = "label12";
            label12.Size = new Size(48, 14);
            label12.TabIndex = 28;
            label12.Text = "Adres:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label13.ForeColor = Color.White;
            label13.Location = new Point(414, 105);
            label13.Name = "label13";
            label13.Size = new Size(118, 14);
            label13.TabIndex = 29;
            label13.Text = "Metoda Dostawy:";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackColor = Color.Transparent;
            checkBox1.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            checkBox1.ForeColor = Color.White;
            checkBox1.Location = new Point(538, 107);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(125, 18);
            checkBox1.TabIndex = 30;
            checkBox1.Text = "Odbiór osobisty";
            checkBox1.UseVisualStyleBackColor = false;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.BackColor = Color.Transparent;
            checkBox2.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            checkBox2.ForeColor = Color.White;
            checkBox2.Location = new Point(538, 137);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(138, 18);
            checkBox2.TabIndex = 31;
            checkBox2.Text = "Wysyłka na adres";
            checkBox2.UseVisualStyleBackColor = false;
            // 
            // SzczegolyZamowieniaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1260, 680);
            Controls.Add(pnlDtGridZamowienia);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panelGorny);
            Controls.Add(pnlPrzyciski);
            Controls.Add(pnlGoraDane);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SzczegolyZamowieniaForm";
            Text = "SzczegolyZamowieniaForm";
            Load += SzczegolyZamowieniaForm_Load;
            pnlPrzyciski.ResumeLayout(false);
            pnlPrzyciski.PerformLayout();
            panelGorny.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlGoraDane.ResumeLayout(false);
            pnlGoraDane.PerformLayout();
            grpBoxWartDok.ResumeLayout(false);
            grpBoxWartDok.PerformLayout();
            grpBoxNaglowek.ResumeLayout(false);
            grpBoxNaglowek.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numBoxMiesiac).EndInit();
            ((System.ComponentModel.ISupportInitialize)numBoxDzien).EndInit();
            ((System.ComponentModel.ISupportInitialize)numBoxRok).EndInit();
            ((System.ComponentModel.ISupportInitialize)numBoxNrDok).EndInit();
            pnlDtGridZamowienia.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtGridViewZamowienia).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlPrzyciski;
        private Button btnAnuluj;
        private Button btnZapisz;
        private Button btnUsun;
        private Button btnDodaj;
        private Label label11;
        private TextBox textBox1;
        private Button btnTowarUslugi;
        private Panel panelGorny;
        private PictureBox pictureBox1;
        private Panel pnlGoraDane;
        private DateTimePicker dtPickSprzed;
        private DateTimePicker dtPickDataWystaw;
        private Button btnDataSprzed;
        private Button btnDataWys;
        private ComboBox cmbBoxPlatnosc;
        private RichTextBox richTxtBoxOpis;
        private Label label8;
        private Label label7;
        private Button btnKontrahent;
        private TextBox txtBoxMiastoKnt;
        private TextBox txtBoxKodPoczKnt;
        private TextBox txtBoxAdresKnt;
        private TextBox txtBoxNipKnt;
        private TextBox txtBoxPrefixNipKnt;
        private TextBox txtBoxNazwaKnt;
        private TextBox txtBoxNazwaKlienta;
        private GroupBox grpBoxWartDok;
        private Label label9;
        private Label lblCenaBrutto;
        private Label lblCenaNetto;
        private Label label5;
        private GroupBox grpBoxNaglowek;
        private Label label4;
        private Label label3;
        private Label label2;
        private NumericUpDown numBoxMiesiac;
        private NumericUpDown numBoxDzien;
        private NumericUpDown numBoxRok;
        private NumericUpDown numBoxNrDok;
        private ComboBox cmbBoxTypDokumentu;
        private Label label1;
        private Panel panel2;
        private Panel panel3;
        private Panel pnlDtGridZamowienia;
        private DataGridView dtGridViewZamowienia;
        private Label label6;
        private Label label12;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private Label label13;
    }
}