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
            pnlPrzyciski = new Panel();
            dtGridLstKnt = new DataGridView();
            label1 = new Label();
            txtBoxWyszukaj = new TextBox();
            label2 = new Label();
            chckBoxAkronim = new CheckBox();
            chckBoxNazwa = new CheckBox();
            btnCofnij = new Button();
            btnUsun = new Button();
            btnEdytuj = new Button();
            btnDodaj = new Button();
            btnZaznacz = new Button();
            pnlDataGrid.SuspendLayout();
            pnlPrzyciski.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtGridLstKnt).BeginInit();
            SuspendLayout();
            // 
            // pnlDataGrid
            // 
            pnlDataGrid.Controls.Add(dtGridLstKnt);
            pnlDataGrid.Location = new Point(0, 0);
            pnlDataGrid.Name = "pnlDataGrid";
            pnlDataGrid.Size = new Size(1244, 573);
            pnlDataGrid.TabIndex = 0;
            // 
            // pnlPrzyciski
            // 
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
            // dtGridLstKnt
            // 
            dtGridLstKnt.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtGridLstKnt.Dock = DockStyle.Fill;
            dtGridLstKnt.Location = new Point(0, 0);
            dtGridLstKnt.Name = "dtGridLstKnt";
            dtGridLstKnt.Size = new Size(1244, 573);
            dtGridLstKnt.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.Location = new Point(23, 15);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 0;
            label1.Text = "Wyszukaj:";
            // 
            // txtBoxWyszukaj
            // 
            txtBoxWyszukaj.Location = new Point(102, 15);
            txtBoxWyszukaj.Name = "txtBoxWyszukaj";
            txtBoxWyszukaj.Size = new Size(252, 23);
            txtBoxWyszukaj.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(373, 20);
            label2.Name = "label2";
            label2.Size = new Size(121, 15);
            label2.TabIndex = 2;
            label2.Text = "(używaj checkboxów)";
            // 
            // chckBoxAkronim
            // 
            chckBoxAkronim.AutoSize = true;
            chckBoxAkronim.CheckAlign = ContentAlignment.MiddleRight;
            chckBoxAkronim.Location = new Point(512, 19);
            chckBoxAkronim.Name = "chckBoxAkronim";
            chckBoxAkronim.Size = new Size(75, 19);
            chckBoxAkronim.TabIndex = 3;
            chckBoxAkronim.Text = "Akronim:";
            chckBoxAkronim.UseVisualStyleBackColor = true;
            // 
            // chckBoxNazwa
            // 
            chckBoxNazwa.AutoSize = true;
            chckBoxNazwa.CheckAlign = ContentAlignment.MiddleRight;
            chckBoxNazwa.Location = new Point(618, 20);
            chckBoxNazwa.Name = "chckBoxNazwa";
            chckBoxNazwa.Size = new Size(64, 19);
            chckBoxNazwa.TabIndex = 4;
            chckBoxNazwa.Text = "Nazwa:";
            chckBoxNazwa.UseVisualStyleBackColor = true;
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
            // btnZaznacz
            // 
            btnZaznacz.Image = (Image)resources.GetObject("btnZaznacz.Image");
            btnZaznacz.Location = new Point(939, 9);
            btnZaznacz.Name = "btnZaznacz";
            btnZaznacz.Size = new Size(44, 33);
            btnZaznacz.TabIndex = 15;
            btnZaznacz.UseVisualStyleBackColor = true;
            // 
            // ListaKontrahentowForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1244, 624);
            Controls.Add(pnlPrzyciski);
            Controls.Add(pnlDataGrid);
            Name = "ListaKontrahentowForm";
            Text = "Lista Kontrahentów";
            pnlDataGrid.ResumeLayout(false);
            pnlPrzyciski.ResumeLayout(false);
            pnlPrzyciski.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtGridLstKnt).EndInit();
            ResumeLayout(false);
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
    }
}