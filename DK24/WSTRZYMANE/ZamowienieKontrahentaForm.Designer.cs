namespace DK24
{
    partial class ZamowienieKontrahentaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ZamowienieKontrahentaForm));
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            button3 = new Button();
            btnWybierzProdukt = new Button();
            button1 = new Button();
            groupBox1 = new GroupBox();
            comboBox1 = new ComboBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dtGridZamowienie = new DataGridView();
            dtGridWybProdukty = new DataGridView();
            dtGridWybParam = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtGridZamowienie).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtGridWybProdukty).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtGridWybParam).BeginInit();
            SuspendLayout();
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(594, 52);
            label9.Name = "label9";
            label9.Size = new Size(80, 15);
            label9.TabIndex = 23;
            label9.Text = "ZAMÓWIENIE";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(43, 347);
            label8.Name = "label8";
            label8.Size = new Size(124, 15);
            label8.TabIndex = 22;
            label8.Text = "WYBIERZ PARAMETRY";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(43, 81);
            label7.Name = "label7";
            label7.Size = new Size(110, 15);
            label7.TabIndex = 21;
            label7.Text = "WYBIERZ PRODUKT";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(738, 293);
            label6.Name = "label6";
            label6.Size = new Size(45, 15);
            label6.TabIndex = 20;
            label6.Text = "10.00 zł";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(629, 293);
            label5.Name = "label5";
            label5.Size = new Size(98, 15);
            label5.TabIndex = 19;
            label5.Text = "ŁĄCZNA KWOTA:";
            // 
            // button3
            // 
            button3.Location = new Point(821, 280);
            button3.Name = "button3";
            button3.Size = new Size(130, 41);
            button3.TabIndex = 18;
            button3.Text = "Podsumuj zamówienie";
            button3.UseVisualStyleBackColor = true;
            // 
            // btnWybierzProdukt
            // 
            btnWybierzProdukt.Location = new Point(43, 255);
            btnWybierzProdukt.Name = "btnWybierzProdukt";
            btnWybierzProdukt.Size = new Size(75, 23);
            btnWybierzProdukt.TabIndex = 17;
            btnWybierzProdukt.Text = "Wybierz";
            btnWybierzProdukt.UseVisualStyleBackColor = true;
            btnWybierzProdukt.Click += btnWybierzProdukt_Click;
            // 
            // button1
            // 
            button1.Location = new Point(43, 539);
            button1.Name = "button1";
            button1.Size = new Size(100, 42);
            button1.TabIndex = 16;
            button1.Text = "Dodaj do zamówienia";
            button1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(620, 365);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(350, 231);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kontrahent";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(104, 121);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(45, 23);
            comboBox1.TabIndex = 8;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(104, 161);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(174, 23);
            textBox4.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(155, 121);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(123, 23);
            textBox3.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(104, 80);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(174, 23);
            textBox2.TabIndex = 5;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(104, 39);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(174, 23);
            textBox1.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(48, 164);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 3;
            label4.Text = "Email:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 124);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 2;
            label3.Text = "Nr telefonu:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(58, 83);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 1;
            label2.Text = "NIP:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 42);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 0;
            label1.Text = "Nazwa:";
            // 
            // dtGridZamowienie
            // 
            dtGridZamowienie.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtGridZamowienie.Location = new Point(594, 70);
            dtGridZamowienie.Name = "dtGridZamowienie";
            dtGridZamowienie.Size = new Size(394, 201);
            dtGridZamowienie.TabIndex = 14;
            // 
            // dtGridWybProdukty
            // 
            dtGridWybProdukty.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtGridWybProdukty.Location = new Point(43, 99);
            dtGridWybProdukty.MultiSelect = false;
            dtGridWybProdukty.Name = "dtGridWybProdukty";
            dtGridWybProdukty.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtGridWybProdukty.Size = new Size(478, 150);
            dtGridWybProdukty.TabIndex = 13;
            // 
            // dtGridWybParam
            // 
            dtGridWybParam.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtGridWybParam.Location = new Point(43, 365);
            dtGridWybParam.Name = "dtGridWybParam";
            dtGridWybParam.Size = new Size(478, 164);
            dtGridWybParam.TabIndex = 12;
            // 
            // ZamowienieKontrahentaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(1030, 648);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(button3);
            Controls.Add(btnWybierzProdukt);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(dtGridZamowienie);
            Controls.Add(dtGridWybProdukty);
            Controls.Add(dtGridWybParam);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ZamowienieKontrahentaForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ZamowienieKontrahenta";
            Load += ZamowienieKontrahentaForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtGridZamowienie).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtGridWybProdukty).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtGridWybParam).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Button button3;
        private Button btnWybierzProdukt;
        private Button button1;
        private GroupBox groupBox1;
        private ComboBox comboBox1;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dtGridZamowienie;
        private DataGridView dtGridWybProdukty;
        private DataGridView dtGridWybParam;
    }
}