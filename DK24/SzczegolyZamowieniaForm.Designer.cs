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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            pnlPrzyciski = new Panel();
            btnAnuluj = new Button();
            btnZapisz = new Button();
            panelGorny = new Panel();
            pictureBox1 = new PictureBox();
            pnlGoraDane = new Panel();
            txtBoxAdres = new TextBox();
            chckBoxWysylka = new CheckBox();
            chckBoxOdbior = new CheckBox();
            label13 = new Label();
            label12 = new Label();
            label6 = new Label();
            dtPickSprzed = new DateTimePicker();
            dtPickDataWystaw = new DateTimePicker();
            btnDataSprzed = new Button();
            btnDataWys = new Button();
            richTxtBoxOpis = new RichTextBox();
            cmbBoxPlatnosc = new ComboBox();
            label8 = new Label();
            label7 = new Label();
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
            pnlPrzyciski.Location = new Point(0, 665);
            pnlPrzyciski.Name = "pnlPrzyciski";
            pnlPrzyciski.Size = new Size(1260, 15);
            pnlPrzyciski.TabIndex = 3;
            // 
            // btnAnuluj
            // 
            btnAnuluj.Image = (Image)resources.GetObject("btnAnuluj.Image");
            btnAnuluj.Location = new Point(1191, 311);
            btnAnuluj.Name = "btnAnuluj";
            btnAnuluj.Size = new Size(44, 33);
            btnAnuluj.TabIndex = 6;
            btnAnuluj.UseVisualStyleBackColor = true;
            btnAnuluj.Click += btnAnuluj_Click;
            // 
            // btnZapisz
            // 
            btnZapisz.Image = (Image)resources.GetObject("btnZapisz.Image");
            btnZapisz.Location = new Point(1130, 311);
            btnZapisz.Name = "btnZapisz";
            btnZapisz.Size = new Size(44, 33);
            btnZapisz.TabIndex = 5;
            btnZapisz.UseVisualStyleBackColor = true;
            btnZapisz.Click += btnZapisz_Click;
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
            pnlGoraDane.Controls.Add(btnAnuluj);
            pnlGoraDane.Controls.Add(txtBoxAdres);
            pnlGoraDane.Controls.Add(btnZapisz);
            pnlGoraDane.Controls.Add(chckBoxWysylka);
            pnlGoraDane.Controls.Add(chckBoxOdbior);
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
            pnlGoraDane.Controls.Add(txtBoxNazwaKlienta);
            pnlGoraDane.Controls.Add(grpBoxWartDok);
            pnlGoraDane.Controls.Add(grpBoxNaglowek);
            pnlGoraDane.Location = new Point(0, 50);
            pnlGoraDane.Name = "pnlGoraDane";
            pnlGoraDane.Size = new Size(1260, 360);
            pnlGoraDane.TabIndex = 5;
            // 
            // txtBoxAdres
            // 
            txtBoxAdres.BackColor = SystemColors.Menu;
            txtBoxAdres.Location = new Point(91, 137);
            txtBoxAdres.Name = "txtBoxAdres";
            txtBoxAdres.Size = new Size(295, 23);
            txtBoxAdres.TabIndex = 32;
            // 
            // chckBoxWysylka
            // 
            chckBoxWysylka.AutoSize = true;
            chckBoxWysylka.BackColor = Color.Transparent;
            chckBoxWysylka.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            chckBoxWysylka.ForeColor = Color.White;
            chckBoxWysylka.Location = new Point(538, 137);
            chckBoxWysylka.Name = "chckBoxWysylka";
            chckBoxWysylka.Size = new Size(138, 18);
            chckBoxWysylka.TabIndex = 31;
            chckBoxWysylka.Text = "Wysyłka na adres";
            chckBoxWysylka.UseVisualStyleBackColor = false;
            // 
            // chckBoxOdbior
            // 
            chckBoxOdbior.AutoSize = true;
            chckBoxOdbior.BackColor = Color.Transparent;
            chckBoxOdbior.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            chckBoxOdbior.ForeColor = Color.White;
            chckBoxOdbior.Location = new Point(538, 107);
            chckBoxOdbior.Name = "chckBoxOdbior";
            chckBoxOdbior.Size = new Size(125, 18);
            chckBoxOdbior.TabIndex = 30;
            chckBoxOdbior.Text = "Odbiór osobisty";
            chckBoxOdbior.UseVisualStyleBackColor = false;
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
            // dtPickSprzed
            // 
            dtPickSprzed.Location = new Point(176, 311);
            dtPickSprzed.Name = "dtPickSprzed";
            dtPickSprzed.Size = new Size(232, 23);
            dtPickSprzed.TabIndex = 26;
            // 
            // dtPickDataWystaw
            // 
            dtPickDataWystaw.Location = new Point(176, 259);
            dtPickDataWystaw.Name = "dtPickDataWystaw";
            dtPickDataWystaw.Size = new Size(232, 23);
            dtPickDataWystaw.TabIndex = 25;
            // 
            // btnDataSprzed
            // 
            btnDataSprzed.Location = new Point(38, 311);
            btnDataSprzed.Name = "btnDataSprzed";
            btnDataSprzed.Size = new Size(117, 23);
            btnDataSprzed.TabIndex = 21;
            btnDataSprzed.Text = "Data Sprzedaży:";
            btnDataSprzed.UseVisualStyleBackColor = true;
            // 
            // btnDataWys
            // 
            btnDataWys.Location = new Point(38, 259);
            btnDataWys.Name = "btnDataWys";
            btnDataWys.Size = new Size(117, 23);
            btnDataWys.TabIndex = 19;
            btnDataWys.Text = "Data Wystawienia:";
            btnDataWys.UseVisualStyleBackColor = true;
            // 
            // richTxtBoxOpis
            // 
            richTxtBoxOpis.Location = new Point(967, 195);
            richTxtBoxOpis.Name = "richTxtBoxOpis";
            richTxtBoxOpis.Size = new Size(282, 92);
            richTxtBoxOpis.TabIndex = 13;
            richTxtBoxOpis.Text = "";
            // 
            // cmbBoxPlatnosc
            // 
            cmbBoxPlatnosc.BackColor = SystemColors.Menu;
            cmbBoxPlatnosc.FormattingEnabled = true;
            cmbBoxPlatnosc.Location = new Point(38, 215);
            cmbBoxPlatnosc.Name = "cmbBoxPlatnosc";
            cmbBoxPlatnosc.Size = new Size(189, 23);
            cmbBoxPlatnosc.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label8.ForeColor = Color.White;
            label8.Location = new Point(967, 177);
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
            label7.Location = new Point(38, 198);
            label7.Name = "label7";
            label7.Size = new Size(132, 14);
            label7.TabIndex = 11;
            label7.Text = "Status zamówienia:";
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
            grpBoxWartDok.Location = new Point(993, 5);
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
            panel2.Size = new Size(11, 258);
            panel2.TabIndex = 6;
            // 
            // panel3
            // 
            panel3.BackgroundImage = (Image)resources.GetObject("panel3.BackgroundImage");
            panel3.Location = new Point(1243, 410);
            panel3.Name = "panel3";
            panel3.Size = new Size(17, 255);
            panel3.TabIndex = 7;
            // 
            // pnlDtGridZamowienia
            // 
            pnlDtGridZamowienia.BackColor = Color.White;
            pnlDtGridZamowienia.Controls.Add(dtGridViewZamowienia);
            pnlDtGridZamowienia.ImeMode = ImeMode.NoControl;
            pnlDtGridZamowienia.Location = new Point(11, 410);
            pnlDtGridZamowienia.Margin = new Padding(3, 2, 3, 2);
            pnlDtGridZamowienia.Name = "pnlDtGridZamowienia";
            pnlDtGridZamowienia.Size = new Size(1238, 255);
            pnlDtGridZamowienia.TabIndex = 8;
            // 
            // dtGridViewZamowienia
            // 
            dtGridViewZamowienia.AllowUserToAddRows = false;
            dtGridViewZamowienia.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.LightGray;
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.NullValue = "Brak Danych";
            dtGridViewZamowienia.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dtGridViewZamowienia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtGridViewZamowienia.BackgroundColor = SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dtGridViewZamowienia.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dtGridViewZamowienia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.NullValue = "Brak Danych";
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dtGridViewZamowienia.DefaultCellStyle = dataGridViewCellStyle3;
            dtGridViewZamowienia.Dock = DockStyle.Fill;
            dtGridViewZamowienia.EnableHeadersVisualStyles = false;
            dtGridViewZamowienia.GridColor = Color.Gray;
            dtGridViewZamowienia.Location = new Point(0, 0);
            dtGridViewZamowienia.Margin = new Padding(3, 2, 3, 2);
            dtGridViewZamowienia.Name = "dtGridViewZamowienia";
            dtGridViewZamowienia.ReadOnly = true;
            dtGridViewZamowienia.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.ControlDark;
            dataGridViewCellStyle4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dtGridViewZamowienia.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dtGridViewZamowienia.RowHeadersVisible = false;
            dtGridViewZamowienia.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dtGridViewZamowienia.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtGridViewZamowienia.Size = new Size(1238, 255);
            dtGridViewZamowienia.TabIndex = 1;
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
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SzczegolyZamowieniaForm";
            Load += SzczegolyZamowieniaForm_Load;
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
        private CheckBox chckBoxWysylka;
        private CheckBox chckBoxOdbior;
        private Label label13;
        private TextBox txtBoxAdres;
    }
}