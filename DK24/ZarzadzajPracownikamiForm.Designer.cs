namespace DK24
{
    partial class ZarzadzajPracownikamiForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ZarzadzajPracownikamiForm));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            pnlPrzyciski = new Panel();
            radioButtonPracownicy = new RadioButton();
            radioButtonAdmin = new RadioButton();
            radioButtonWszyscy = new RadioButton();
            label1 = new Label();
            btnCofnij = new Button();
            btnUsun = new Button();
            btnEdytuj = new Button();
            panelZalogowania = new Panel();
            linkLabel1 = new LinkLabel();
            pictureBox1 = new PictureBox();
            lblZalogowanoJako = new Label();
            panel4 = new Panel();
            panel2 = new Panel();
            menuStrip = new MenuStrip();
            zamówieniaToolStripMenuItem = new ToolStripMenuItem();
            fakturyToolStripMenuItem = new ToolStripMenuItem();
            kontrahenciToolStripMenuItem = new ToolStripMenuItem();
            wysyłkiToolStripMenuItem = new ToolStripMenuItem();
            towaryToolStripMenuItem = new ToolStripMenuItem();
            ądzajPracownikamiToolStripMenuItem = new ToolStripMenuItem();
            pnlZarzadzaniaPracownikami = new Panel();
            label12 = new Label();
            btnAktywacja = new Button();
            btnResetujHaslo = new Button();
            btnZapisz = new Button();
            dtPickerUtworzono = new DateTimePicker();
            dtPickerModyfikacja = new DateTimePicker();
            cmbBoxRola = new ComboBox();
            cmbBoxNrTelPrefix = new ComboBox();
            txtBoxHaslo = new TextBox();
            txtBoxLogin = new TextBox();
            txtBoxNrTel = new TextBox();
            txtBoxEmail = new TextBox();
            txtBoxNazwisko = new TextBox();
            txtBoxImie = new TextBox();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            dtGridLstPracownikow = new DataGridView();
            panel1 = new Panel();
            dataScrollBar = new HScrollBar();
            pnlPrzyciski.SuspendLayout();
            panelZalogowania.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menuStrip.SuspendLayout();
            pnlZarzadzaniaPracownikami.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtGridLstPracownikow).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlPrzyciski
            // 
            pnlPrzyciski.BackgroundImage = (Image)resources.GetObject("pnlPrzyciski.BackgroundImage");
            pnlPrzyciski.Controls.Add(radioButtonPracownicy);
            pnlPrzyciski.Controls.Add(radioButtonAdmin);
            pnlPrzyciski.Controls.Add(radioButtonWszyscy);
            pnlPrzyciski.Controls.Add(label1);
            pnlPrzyciski.Controls.Add(btnCofnij);
            pnlPrzyciski.Controls.Add(btnUsun);
            pnlPrzyciski.Controls.Add(btnEdytuj);
            pnlPrzyciski.Location = new Point(0, 615);
            pnlPrzyciski.Name = "pnlPrzyciski";
            pnlPrzyciski.Size = new Size(1260, 65);
            pnlPrzyciski.TabIndex = 2;
            // 
            // radioButtonPracownicy
            // 
            radioButtonPracownicy.AutoSize = true;
            radioButtonPracownicy.BackColor = Color.Transparent;
            radioButtonPracownicy.ForeColor = Color.White;
            radioButtonPracownicy.Location = new Point(227, 23);
            radioButtonPracownicy.Name = "radioButtonPracownicy";
            radioButtonPracownicy.Size = new Size(102, 19);
            radioButtonPracownicy.TabIndex = 22;
            radioButtonPracownicy.Text = "PRACOWNICY";
            radioButtonPracownicy.UseVisualStyleBackColor = false;
            // 
            // radioButtonAdmin
            // 
            radioButtonAdmin.AutoSize = true;
            radioButtonAdmin.BackColor = Color.Transparent;
            radioButtonAdmin.ForeColor = Color.White;
            radioButtonAdmin.Location = new Point(347, 23);
            radioButtonAdmin.Name = "radioButtonAdmin";
            radioButtonAdmin.Size = new Size(128, 19);
            radioButtonAdmin.TabIndex = 21;
            radioButtonAdmin.Text = "ADMINISTRATORZY";
            radioButtonAdmin.UseVisualStyleBackColor = false;
            // 
            // radioButtonWszyscy
            // 
            radioButtonWszyscy.AutoSize = true;
            radioButtonWszyscy.BackColor = Color.Transparent;
            radioButtonWszyscy.Checked = true;
            radioButtonWszyscy.ForeColor = Color.White;
            radioButtonWszyscy.Location = new Point(129, 23);
            radioButtonWszyscy.Name = "radioButtonWszyscy";
            radioButtonWszyscy.Size = new Size(77, 19);
            radioButtonWszyscy.TabIndex = 19;
            radioButtonWszyscy.TabStop = true;
            radioButtonWszyscy.Text = "WSZYSCY";
            radioButtonWszyscy.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.ForeColor = Color.FromArgb(255, 128, 0);
            label1.Location = new Point(23, 22);
            label1.Name = "label1";
            label1.Size = new Size(90, 18);
            label1.TabIndex = 18;
            label1.Text = "Sortuj po:";
            // 
            // btnCofnij
            // 
            btnCofnij.Image = (Image)resources.GetObject("btnCofnij.Image");
            btnCofnij.Location = new Point(1190, 16);
            btnCofnij.Name = "btnCofnij";
            btnCofnij.Size = new Size(44, 33);
            btnCofnij.TabIndex = 14;
            btnCofnij.UseVisualStyleBackColor = true;
            btnCofnij.Click += btnCofnij_Click;
            // 
            // btnUsun
            // 
            btnUsun.Image = (Image)resources.GetObject("btnUsun.Image");
            btnUsun.Location = new Point(1130, 16);
            btnUsun.Name = "btnUsun";
            btnUsun.Size = new Size(44, 33);
            btnUsun.TabIndex = 13;
            btnUsun.UseVisualStyleBackColor = true;
            btnUsun.Click += btnUsun_Click;
            // 
            // btnEdytuj
            // 
            btnEdytuj.Image = (Image)resources.GetObject("btnEdytuj.Image");
            btnEdytuj.Location = new Point(1067, 16);
            btnEdytuj.Name = "btnEdytuj";
            btnEdytuj.Size = new Size(44, 33);
            btnEdytuj.TabIndex = 12;
            btnEdytuj.UseVisualStyleBackColor = true;
            btnEdytuj.Click += btnEdytuj_Click;
            // 
            // panelZalogowania
            // 
            panelZalogowania.BackgroundImage = (Image)resources.GetObject("panelZalogowania.BackgroundImage");
            panelZalogowania.Controls.Add(linkLabel1);
            panelZalogowania.Controls.Add(pictureBox1);
            panelZalogowania.Controls.Add(lblZalogowanoJako);
            panelZalogowania.Location = new Point(1000, 0);
            panelZalogowania.Name = "panelZalogowania";
            panelZalogowania.Size = new Size(260, 80);
            panelZalogowania.TabIndex = 10;
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.Silver;
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.Transparent;
            linkLabel1.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            linkLabel1.LinkColor = Color.FromArgb(255, 192, 128);
            linkLabel1.Location = new Point(89, 61);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(73, 13);
            linkLabel1.TabIndex = 2;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Wyloguj się";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(111, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(35, 35);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // lblZalogowanoJako
            // 
            lblZalogowanoJako.AutoSize = true;
            lblZalogowanoJako.BackColor = Color.Transparent;
            lblZalogowanoJako.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lblZalogowanoJako.ForeColor = Color.FromArgb(255, 128, 0);
            lblZalogowanoJako.Location = new Point(0, 43);
            lblZalogowanoJako.Name = "lblZalogowanoJako";
            lblZalogowanoJako.Size = new Size(110, 13);
            lblZalogowanoJako.TabIndex = 14;
            lblZalogowanoJako.Text = "Zalogowano jako:";
            // 
            // panel4
            // 
            panel4.BackgroundImage = (Image)resources.GetObject("panel4.BackgroundImage");
            panel4.Location = new Point(1250, 80);
            panel4.Name = "panel4";
            panel4.Size = new Size(10, 535);
            panel4.TabIndex = 12;
            // 
            // panel2
            // 
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.Location = new Point(0, 80);
            panel2.Name = "panel2";
            panel2.Size = new Size(10, 535);
            panel2.TabIndex = 11;
            // 
            // menuStrip
            // 
            menuStrip.AutoSize = false;
            menuStrip.BackgroundImage = (Image)resources.GetObject("menuStrip.BackgroundImage");
            menuStrip.BackgroundImageLayout = ImageLayout.None;
            menuStrip.Dock = DockStyle.None;
            menuStrip.ImageScalingSize = new Size(20, 20);
            menuStrip.Items.AddRange(new ToolStripItem[] { zamówieniaToolStripMenuItem, fakturyToolStripMenuItem, kontrahenciToolStripMenuItem, wysyłkiToolStripMenuItem, towaryToolStripMenuItem, ądzajPracownikamiToolStripMenuItem });
            menuStrip.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow;
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Padding = new Padding(250, 35, 0, 5);
            menuStrip.RenderMode = ToolStripRenderMode.Professional;
            menuStrip.Size = new Size(1000, 80);
            menuStrip.Stretch = false;
            menuStrip.TabIndex = 9;
            menuStrip.Text = "menuStrip1";
            // 
            // zamówieniaToolStripMenuItem
            // 
            zamówieniaToolStripMenuItem.BackColor = Color.Transparent;
            zamówieniaToolStripMenuItem.ForeColor = Color.Silver;
            zamówieniaToolStripMenuItem.Image = (Image)resources.GetObject("zamówieniaToolStripMenuItem.Image");
            zamówieniaToolStripMenuItem.ImageAlign = ContentAlignment.TopCenter;
            zamówieniaToolStripMenuItem.Name = "zamówieniaToolStripMenuItem";
            zamówieniaToolStripMenuItem.Size = new Size(84, 40);
            zamówieniaToolStripMenuItem.Text = "Zamówienia";
            zamówieniaToolStripMenuItem.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // fakturyToolStripMenuItem
            // 
            fakturyToolStripMenuItem.BackColor = Color.Transparent;
            fakturyToolStripMenuItem.ForeColor = Color.Silver;
            fakturyToolStripMenuItem.Image = (Image)resources.GetObject("fakturyToolStripMenuItem.Image");
            fakturyToolStripMenuItem.Name = "fakturyToolStripMenuItem";
            fakturyToolStripMenuItem.Size = new Size(58, 40);
            fakturyToolStripMenuItem.Text = "Faktury";
            fakturyToolStripMenuItem.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // kontrahenciToolStripMenuItem
            // 
            kontrahenciToolStripMenuItem.BackColor = Color.Transparent;
            kontrahenciToolStripMenuItem.Enabled = false;
            kontrahenciToolStripMenuItem.ForeColor = Color.Silver;
            kontrahenciToolStripMenuItem.Image = (Image)resources.GetObject("kontrahenciToolStripMenuItem.Image");
            kontrahenciToolStripMenuItem.Name = "kontrahenciToolStripMenuItem";
            kontrahenciToolStripMenuItem.Size = new Size(83, 40);
            kontrahenciToolStripMenuItem.Text = "Kontrahenci";
            kontrahenciToolStripMenuItem.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // wysyłkiToolStripMenuItem
            // 
            wysyłkiToolStripMenuItem.BackColor = Color.Transparent;
            wysyłkiToolStripMenuItem.ForeColor = Color.Silver;
            wysyłkiToolStripMenuItem.Image = (Image)resources.GetObject("wysyłkiToolStripMenuItem.Image");
            wysyłkiToolStripMenuItem.Name = "wysyłkiToolStripMenuItem";
            wysyłkiToolStripMenuItem.Size = new Size(59, 40);
            wysyłkiToolStripMenuItem.Text = "Wysyłki";
            wysyłkiToolStripMenuItem.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // towaryToolStripMenuItem
            // 
            towaryToolStripMenuItem.BackColor = Color.Transparent;
            towaryToolStripMenuItem.ForeColor = Color.Silver;
            towaryToolStripMenuItem.Image = (Image)resources.GetObject("towaryToolStripMenuItem.Image");
            towaryToolStripMenuItem.Name = "towaryToolStripMenuItem";
            towaryToolStripMenuItem.Size = new Size(98, 40);
            towaryToolStripMenuItem.Text = "Towary i Usługi";
            towaryToolStripMenuItem.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // ądzajPracownikamiToolStripMenuItem
            // 
            ądzajPracownikamiToolStripMenuItem.ForeColor = Color.Silver;
            ądzajPracownikamiToolStripMenuItem.Image = (Image)resources.GetObject("ądzajPracownikamiToolStripMenuItem.Image");
            ądzajPracownikamiToolStripMenuItem.Name = "ądzajPracownikamiToolStripMenuItem";
            ądzajPracownikamiToolStripMenuItem.Size = new Size(146, 40);
            ądzajPracownikamiToolStripMenuItem.Text = "Zarządzaj Pracownikami";
            ądzajPracownikamiToolStripMenuItem.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // pnlZarzadzaniaPracownikami
            // 
            pnlZarzadzaniaPracownikami.BackColor = SystemColors.ControlDark;
            pnlZarzadzaniaPracownikami.Controls.Add(label12);
            pnlZarzadzaniaPracownikami.Controls.Add(btnAktywacja);
            pnlZarzadzaniaPracownikami.Controls.Add(btnResetujHaslo);
            pnlZarzadzaniaPracownikami.Controls.Add(btnZapisz);
            pnlZarzadzaniaPracownikami.Controls.Add(dtPickerUtworzono);
            pnlZarzadzaniaPracownikami.Controls.Add(dtPickerModyfikacja);
            pnlZarzadzaniaPracownikami.Controls.Add(cmbBoxRola);
            pnlZarzadzaniaPracownikami.Controls.Add(cmbBoxNrTelPrefix);
            pnlZarzadzaniaPracownikami.Controls.Add(txtBoxHaslo);
            pnlZarzadzaniaPracownikami.Controls.Add(txtBoxLogin);
            pnlZarzadzaniaPracownikami.Controls.Add(txtBoxNrTel);
            pnlZarzadzaniaPracownikami.Controls.Add(txtBoxEmail);
            pnlZarzadzaniaPracownikami.Controls.Add(txtBoxNazwisko);
            pnlZarzadzaniaPracownikami.Controls.Add(txtBoxImie);
            pnlZarzadzaniaPracownikami.Controls.Add(label11);
            pnlZarzadzaniaPracownikami.Controls.Add(label10);
            pnlZarzadzaniaPracownikami.Controls.Add(label9);
            pnlZarzadzaniaPracownikami.Controls.Add(label8);
            pnlZarzadzaniaPracownikami.Controls.Add(label7);
            pnlZarzadzaniaPracownikami.Controls.Add(label6);
            pnlZarzadzaniaPracownikami.Controls.Add(label5);
            pnlZarzadzaniaPracownikami.Controls.Add(label4);
            pnlZarzadzaniaPracownikami.Controls.Add(label3);
            pnlZarzadzaniaPracownikami.ImeMode = ImeMode.NoControl;
            pnlZarzadzaniaPracownikami.Location = new Point(685, 81);
            pnlZarzadzaniaPracownikami.Margin = new Padding(3, 2, 3, 2);
            pnlZarzadzaniaPracownikami.Name = "pnlZarzadzaniaPracownikami";
            pnlZarzadzaniaPracownikami.Size = new Size(563, 533);
            pnlZarzadzaniaPracownikami.TabIndex = 13;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Gill Sans MT", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label12.ForeColor = SystemColors.ControlDarkDark;
            label12.Location = new Point(214, 32);
            label12.Name = "label12";
            label12.Size = new Size(196, 23);
            label12.TabIndex = 23;
            label12.Text = "Zarządzaj Pracownikami";
            // 
            // btnAktywacja
            // 
            btnAktywacja.Location = new Point(214, 434);
            btnAktywacja.Name = "btnAktywacja";
            btnAktywacja.Size = new Size(146, 51);
            btnAktywacja.TabIndex = 22;
            btnAktywacja.Text = "Aktywuj / Dezaktywuj\r\nPracownika\r\n";
            btnAktywacja.UseVisualStyleBackColor = true;
            // 
            // btnResetujHaslo
            // 
            btnResetujHaslo.Location = new Point(402, 198);
            btnResetujHaslo.Name = "btnResetujHaslo";
            btnResetujHaslo.Size = new Size(107, 23);
            btnResetujHaslo.TabIndex = 21;
            btnResetujHaslo.Text = "Resetuj hasło";
            btnResetujHaslo.UseVisualStyleBackColor = true;
            btnResetujHaslo.Click += btnResetujHaslo_Click;
            // 
            // btnZapisz
            // 
            btnZapisz.Location = new Point(446, 269);
            btnZapisz.Name = "btnZapisz";
            btnZapisz.Size = new Size(95, 37);
            btnZapisz.TabIndex = 20;
            btnZapisz.Text = "Zapisz dane";
            btnZapisz.UseVisualStyleBackColor = true;
            btnZapisz.Click += btnZapisz_Click;
            // 
            // dtPickerUtworzono
            // 
            dtPickerUtworzono.Enabled = false;
            dtPickerUtworzono.Location = new Point(26, 374);
            dtPickerUtworzono.Name = "dtPickerUtworzono";
            dtPickerUtworzono.Size = new Size(221, 23);
            dtPickerUtworzono.TabIndex = 19;
            // 
            // dtPickerModyfikacja
            // 
            dtPickerModyfikacja.Enabled = false;
            dtPickerModyfikacja.Location = new Point(320, 374);
            dtPickerModyfikacja.Name = "dtPickerModyfikacja";
            dtPickerModyfikacja.Size = new Size(221, 23);
            dtPickerModyfikacja.TabIndex = 18;
            // 
            // cmbBoxRola
            // 
            cmbBoxRola.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBoxRola.FormattingEnabled = true;
            cmbBoxRola.Location = new Point(366, 86);
            cmbBoxRola.Name = "cmbBoxRola";
            cmbBoxRola.Size = new Size(175, 23);
            cmbBoxRola.TabIndex = 16;
            // 
            // cmbBoxNrTelPrefix
            // 
            cmbBoxNrTelPrefix.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBoxNrTelPrefix.FormattingEnabled = true;
            cmbBoxNrTelPrefix.Items.AddRange(new object[] { "+48", "+44", "+42" });
            cmbBoxNrTelPrefix.Location = new Point(100, 199);
            cmbBoxNrTelPrefix.Name = "cmbBoxNrTelPrefix";
            cmbBoxNrTelPrefix.Size = new Size(42, 23);
            cmbBoxNrTelPrefix.TabIndex = 15;
            // 
            // txtBoxHaslo
            // 
            txtBoxHaslo.Location = new Point(366, 162);
            txtBoxHaslo.Name = "txtBoxHaslo";
            txtBoxHaslo.Size = new Size(175, 23);
            txtBoxHaslo.TabIndex = 14;
            // 
            // txtBoxLogin
            // 
            txtBoxLogin.Location = new Point(366, 124);
            txtBoxLogin.Name = "txtBoxLogin";
            txtBoxLogin.Size = new Size(175, 23);
            txtBoxLogin.TabIndex = 13;
            // 
            // txtBoxNrTel
            // 
            txtBoxNrTel.Location = new Point(145, 199);
            txtBoxNrTel.MaxLength = 12;
            txtBoxNrTel.Name = "txtBoxNrTel";
            txtBoxNrTel.Size = new Size(132, 23);
            txtBoxNrTel.TabIndex = 12;
            txtBoxNrTel.KeyPress += txtBoxNrTel_KeyPress;
            // 
            // txtBoxEmail
            // 
            txtBoxEmail.Location = new Point(67, 162);
            txtBoxEmail.Name = "txtBoxEmail";
            txtBoxEmail.Size = new Size(210, 23);
            txtBoxEmail.TabIndex = 11;
            // 
            // txtBoxNazwisko
            // 
            txtBoxNazwisko.Location = new Point(92, 124);
            txtBoxNazwisko.Name = "txtBoxNazwisko";
            txtBoxNazwisko.Size = new Size(185, 23);
            txtBoxNazwisko.TabIndex = 10;
            // 
            // txtBoxImie
            // 
            txtBoxImie.Location = new Point(67, 86);
            txtBoxImie.Name = "txtBoxImie";
            txtBoxImie.Size = new Size(210, 23);
            txtBoxImie.TabIndex = 9;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(320, 353);
            label11.Name = "label11";
            label11.Size = new Size(99, 15);
            label11.TabIndex = 8;
            label11.Text = "Data modyfikacji:\r\n";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(26, 353);
            label10.Name = "label10";
            label10.Size = new Size(95, 15);
            label10.TabIndex = 7;
            label10.Text = "Data utworzenia:\r\n";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(320, 165);
            label9.Name = "label9";
            label9.Size = new Size(40, 15);
            label9.TabIndex = 6;
            label9.Text = "Hasło:\r\n";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(320, 127);
            label8.Name = "label8";
            label8.Size = new Size(40, 15);
            label8.TabIndex = 5;
            label8.Text = "Login:\r\n";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(320, 89);
            label7.Name = "label7";
            label7.Size = new Size(33, 15);
            label7.TabIndex = 4;
            label7.Text = "Rola:\r\n";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(26, 165);
            label6.Name = "label6";
            label6.Size = new Size(39, 15);
            label6.TabIndex = 3;
            label6.Text = "Email:\r\n";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 202);
            label5.Name = "label5";
            label5.Size = new Size(71, 15);
            label5.TabIndex = 2;
            label5.Text = "Nr Telefonu:\r\n";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 127);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 1;
            label4.Text = "Nazwisko:\r\n";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 89);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 0;
            label3.Text = "Imie:\r\n";
            // 
            // dtGridLstPracownikow
            // 
            dtGridLstPracownikow.AccessibleRole = AccessibleRole.Caret;
            dtGridLstPracownikow.AllowUserToAddRows = false;
            dtGridLstPracownikow.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.LightGray;
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.NullValue = "Brak Danych";
            dtGridLstPracownikow.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dtGridLstPracownikow.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtGridLstPracownikow.BackgroundColor = SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dtGridLstPracownikow.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dtGridLstPracownikow.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.NullValue = "Brak Danych";
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dtGridLstPracownikow.DefaultCellStyle = dataGridViewCellStyle3;
            dtGridLstPracownikow.GridColor = Color.Gray;
            dtGridLstPracownikow.Location = new Point(0, 1);
            dtGridLstPracownikow.Margin = new Padding(3, 2, 3, 2);
            dtGridLstPracownikow.Name = "dtGridLstPracownikow";
            dtGridLstPracownikow.ReadOnly = true;
            dtGridLstPracownikow.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.ControlDark;
            dataGridViewCellStyle4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dtGridLstPracownikow.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dtGridLstPracownikow.RowHeadersVisible = false;
            dtGridLstPracownikow.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dtGridLstPracownikow.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtGridLstPracownikow.ShowCellErrors = false;
            dtGridLstPracownikow.ShowCellToolTips = false;
            dtGridLstPracownikow.ShowEditingIcon = false;
            dtGridLstPracownikow.ShowRowErrors = false;
            dtGridLstPracownikow.Size = new Size(1084, 515);
            dtGridLstPracownikow.TabIndex = 0;
            dtGridLstPracownikow.SizeChanged += dtGridLstPracownikow_SizeChanged;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(dtGridLstPracownikow);
            panel1.Controls.Add(dataScrollBar);
            panel1.Location = new Point(11, 81);
            panel1.Name = "panel1";
            panel1.Size = new Size(673, 533);
            panel1.TabIndex = 24;
            // 
            // dataScrollBar
            // 
            dataScrollBar.Location = new Point(0, 519);
            dataScrollBar.Name = "dataScrollBar";
            dataScrollBar.Size = new Size(671, 14);
            dataScrollBar.TabIndex = 1;
            dataScrollBar.Visible = false;
            dataScrollBar.Scroll += dataScrollBar_Scroll;
            // 
            // ZarzadzajPracownikamiForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(1260, 680);
            Controls.Add(panel1);
            Controls.Add(pnlZarzadzaniaPracownikami);
            Controls.Add(panelZalogowania);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(menuStrip);
            Controls.Add(pnlPrzyciski);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ZarzadzajPracownikamiForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ZarzadzajPracownikami";
            Load += ZarzadzajPracownikami_Load;
            pnlPrzyciski.ResumeLayout(false);
            pnlPrzyciski.PerformLayout();
            panelZalogowania.ResumeLayout(false);
            panelZalogowania.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            pnlZarzadzaniaPracownikami.ResumeLayout(false);
            pnlZarzadzaniaPracownikami.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtGridLstPracownikow).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlPrzyciski;
        private Button btnCofnij;
        private Button btnUsun;
        private Button btnEdytuj;
        private Panel panelZalogowania;
        private LinkLabel linkLabel1;
        private PictureBox pictureBox1;
        private Label lblZalogowanoJako;
        private Panel panel4;
        private Panel panel2;
        private MenuStrip menuStrip;
        private ToolStripMenuItem zamówieniaToolStripMenuItem;
        private ToolStripMenuItem fakturyToolStripMenuItem;
        private ToolStripMenuItem kontrahenciToolStripMenuItem;
        private ToolStripMenuItem wysyłkiToolStripMenuItem;
        private ToolStripMenuItem towaryToolStripMenuItem;
        private ToolStripMenuItem ądzajPracownikamiToolStripMenuItem;
        private Panel pnlZarzadzaniaPracownikami;
        private Label label3;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private DateTimePicker dtPickerUtworzono;
        private DateTimePicker dtPickerModyfikacja;
        private ComboBox cmbBoxRola;
        private ComboBox cmbBoxNrTelPrefix;
        private TextBox txtBoxHaslo;
        private TextBox txtBoxLogin;
        private TextBox txtBoxNrTel;
        private TextBox txtBoxEmail;
        private TextBox txtBoxNazwisko;
        private TextBox txtBoxImie;
        private Button btnAktywacja;
        private Button btnResetujHaslo;
        private Button btnZapisz;
        private Label label12;
        private Panel panel1;
        private DataGridView dtGridLstPracownikow;
        private HScrollBar dataScrollBar;
        private RadioButton radioButtonAdmin;
        private RadioButton radioButtonUslugi;
        private RadioButton radioButtonWszyscy;
        private Label label1;
        private RadioButton radioButtonPracownicy;
    }
}