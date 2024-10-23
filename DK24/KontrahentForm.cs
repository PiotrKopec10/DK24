using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ComboBox = System.Windows.Forms.ComboBox;
using ToolTip = System.Windows.Forms.ToolTip;

namespace DK24
{
    public partial class KontrahentForm : Form
    {
        AddressClass DzialaniaNaAdresie = new AddressClass();
        AddressClass.Address AktualnyAdres = new AddressClass.Address();

        GlobalClass GlobalneDzialania = new GlobalClass();

        KontrahentClass DzialanieNaKontrahencie = new KontrahentClass();
        KontrahentClass.Kontrahent AktualnyKontrahent = new KontrahentClass.Kontrahent();


        public KontrahentForm()
        {
            InitializeComponent();


            // Obsługa NIP
            txtBoxNIP.MaxLength = 10; 
            txtBoxNIP.KeyPress += new KeyPressEventHandler(GlobalneDzialania.TylkoCyfry); 

            // Obsługa REGON
            txtBoxRegon.MaxLength = 9;
            txtBoxRegon.KeyPress += new KeyPressEventHandler(GlobalneDzialania.TylkoCyfry);

            // Obsługa Nr Telefonu
            txtBoxNrTel.MaxLength = 9;  // najdluzszy 14
            txtBoxNrTel.KeyPress += new KeyPressEventHandler(GlobalneDzialania.TylkoCyfry);
            cmbBoxPrefixNrTel.SelectedIndexChanged += new EventHandler(cmbBoxPrefixNrTel_SelectedIndexChanged);
            GlobalneDzialania.cmbBoxAutouzupelnianie(cmbBoxPrefixNrTel);

            // Obsługa Banku
            txtBoxBank.KeyPress += new KeyPressEventHandler(GlobalneDzialania.TylkoLitery);
            txtBoxBank.TextChanged += new EventHandler(GlobalneDzialania.ZmienPierwszaLitereNaWielka);

            // Obsługa Nr Bankowego
            txtBoxNrRachunku.MaxLength = 30;
            txtBoxNrRachunku.KeyPress += new KeyPressEventHandler(GlobalneDzialania.TylkoCyfry);
            GlobalneDzialania.cmbBoxAutouzupelnianie(cmbBoxIBAN);

            // Ulica
            txtBoxUlica.KeyPress += new KeyPressEventHandler(GlobalneDzialania.TylkoLitery);
            txtBoxUlica.TextChanged += new EventHandler(GlobalneDzialania.ZmienPierwszaLitereNaWielka);

            // Nr Domu i Lokalu
            txtBoxNrDomu.KeyPress += new KeyPressEventHandler(GlobalneDzialania.BlokujZnakiSpecjalneIspacje);
            txtBoxNrLokalu.KeyPress += new KeyPressEventHandler(GlobalneDzialania.BlokujZnakiSpecjalneIspacje);

            // Kraj
            cmbBoxKraj.SelectedIndexChanged += new EventHandler(cmbBoxKraj_SelectedIndexChanged);
            GlobalneDzialania.cmbBoxAutouzupelnianie(cmbBoxKraj);

            // Kod pocztowy
            txtBoxKodPocz.KeyPress += new KeyPressEventHandler(txtBoxKodPocz_KeyPress);
            txtBoxKodPocz.TextChanged += new EventHandler(txtBoxKodPocz_TextChanged);

            // Miasto           
            txtBoxMiasto.KeyPress += new KeyPressEventHandler(GlobalneDzialania.TylkoLitery);
            txtBoxMiasto.TextChanged += new EventHandler(GlobalneDzialania.ZmienPierwszaLitereNaWielka);

            // Wojewodztwo
            txtBoxWoj.KeyPress += new KeyPressEventHandler(GlobalneDzialania.TylkoLitery);
            txtBoxWoj.TextChanged += new EventHandler(GlobalneDzialania.ZmienPierwszaLitereNaWielka);

            // Powiat
            txtBoxPowiat.KeyPress += new KeyPressEventHandler(GlobalneDzialania.TylkoLitery);
            txtBoxPowiat.TextChanged += new EventHandler(GlobalneDzialania.ZmienPierwszaLitereNaWielka);

            // Gmina
            txtBoxGmina.KeyPress += new KeyPressEventHandler(GlobalneDzialania.TylkoLitery);
            txtBoxGmina.TextChanged += new EventHandler(GlobalneDzialania.ZmienPierwszaLitereNaWielka);

            GlobalneDzialania.cmbBoxAutouzupelnianie(cmbBoxZnizka);

            cmbBoxKraj.SelectedIndexChanged += new EventHandler(cmbBoxKraj_SelectedIndexChanged);
            cmbBoxPrefixNrTel.SelectedIndexChanged += new EventHandler(cmbBoxPrefixNrTel_SelectedIndexChanged);
        }


        //private void btnZapisz_Click(object sender, EventArgs e)
        //{

        //    AktualnyAdres.street = GlobalneDzialania.WyczyscTekst(txtBoxUlica.Text);
        //    AktualnyAdres.house_number = GlobalneDzialania.WyczyscTekst(txtBoxNrDomu.Text);
        //    AktualnyAdres.apartment_number = GlobalneDzialania.WyczyscTekst(txtBoxNrLokalu.Text);
        //    AktualnyAdres.country = cmbBoxKraj.SelectedItem.ToString();
        //    AktualnyAdres.postal_code = txtBoxKodPocz.Text;
        //    AktualnyAdres.city = GlobalneDzialania.WyczyscTekst(txtBoxMiasto.Text);
        //    AktualnyAdres.voivodeship = GlobalneDzialania.WyczyscTekst(txtBoxWoj.Text);
        //    AktualnyAdres.powiat = GlobalneDzialania.WyczyscTekst(txtBoxPowiat.Text);
        //    AktualnyAdres.gmina = GlobalneDzialania.WyczyscTekst(txtBoxGmina.Text);


        //    if (DzialaniaNaAdresie.PobierzAdresId(AktualnyAdres) == -1)
        //    {
        //        DzialaniaNaAdresie.DodajAdres(AktualnyAdres);

        //        AktualnyKontrahent.address_id = DzialaniaNaAdresie.PobierzAdresId(AktualnyAdres);

        //        AktualnyKontrahent.acronym = txtBoxAkronim.Text;
        //        AktualnyKontrahent.name = txtBoxNazwa.Text;
        //        AktualnyKontrahent.nip = GlobalneDzialania.WyczyscTekst(txtBoxNIP.Text);
        //        AktualnyKontrahent.discount_percentage = Convert.ToDecimal(cmbBoxZnizka.SelectedItem);
        //        AktualnyKontrahent.regon = GlobalneDzialania.WyczyscTekst(txtBoxRegon.Text);
        //        AktualnyKontrahent.phone_number = GlobalneDzialania.WyczyscTekst(txtBoxNrTel.Text);
        //        AktualnyKontrahent.phone_prefix = cmbBoxPrefixNrTel.SelectedItem.ToString();
        //        AktualnyKontrahent.email = txtBoxEmail.Text;
        //        AktualnyKontrahent.url = txtBoxUrl.Text;
        //        AktualnyKontrahent.bank_account_number = GlobalneDzialania.WyczyscTekst(txtBoxNrRachunku.Text);
        //        AktualnyKontrahent.bank_name = txtBoxBank.Text;
        //        AktualnyKontrahent.bank_iban_prefix = cmbBoxIBAN.SelectedItem.ToString();
        //        AktualnyKontrahent.is_archived = Convert.ToInt32(chckBoxArchiwalny.Checked);
        //        AktualnyKontrahent.company_description = rchTxtBoxOpis.Text;


        //        DzialanieNaKontrahencie.DodajKontrahenta(AktualnyKontrahent);
        //    }
        //    else
        //    {

        //        MessageBox.Show("Podany Adres jest juz przypisany do Kontrahenta!", "Uwaga!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        //    }

        //}


        private void btnZapisz_Click(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.IsBalloon = true;
            toolTip.InitialDelay = 0;
            toolTip.ShowAlways = true;


            bool isValid = true;
            List<string> pustePola = new List<string>();

            if (string.IsNullOrWhiteSpace(txtBoxAkronim.Text))
            {
                txtBoxAkronim.BackColor = Color.Pink;
                toolTip.SetToolTip(txtBoxAkronim, "Pole Akronim nie może być puste!");
                pustePola.Add("Akronim");
                isValid = false;
            }
            else
            {
                txtBoxAkronim.BackColor = SystemColors.Window;
            }

            if (string.IsNullOrWhiteSpace(txtBoxNazwa.Text))
            {
                txtBoxNazwa.BackColor = Color.Pink;
                toolTip.SetToolTip(txtBoxNazwa, "Pole Nazwa nie może być puste!");
                pustePola.Add("Nazwa");
                isValid = false;
            }
            else
            {
                txtBoxNazwa.BackColor = SystemColors.Window;
            }

            if (string.IsNullOrWhiteSpace(txtBoxNIP.Text) && string.IsNullOrWhiteSpace(txtBoxRegon.Text))
            {
                txtBoxNIP.BackColor = Color.Pink;
                txtBoxRegon.BackColor = Color.Pink;
                toolTip.SetToolTip(txtBoxNIP, "Pole NIP lub Regon musi być wypełnione!");
                toolTip.SetToolTip(txtBoxRegon, "Pole Regon lub NIP musi być wypełnione!");
                pustePola.Add("NIP lub Regon");
                isValid = false;
            }
            else
            {
                txtBoxNIP.BackColor= SystemColors.Window;
                txtBoxRegon.BackColor= SystemColors.Window;
            }

            if (string.IsNullOrWhiteSpace(txtBoxNrTel.Text))
            {
                txtBoxNrTel.BackColor = Color.Pink;
                toolTip.SetToolTip(txtBoxNrTel, "Pole Numer Telefonu nie może być puste!");
                pustePola.Add("Numer Telefonu");
                isValid = false;
            }
            else
            {
                txtBoxNrTel.BackColor = SystemColors.Window;
            }

            if (string.IsNullOrWhiteSpace(txtBoxEmail.Text))
            {
                txtBoxEmail.BackColor = Color.Pink;
                toolTip.SetToolTip(txtBoxEmail, "Pole Email nie może być puste!");
                pustePola.Add("Email");
                isValid = false;
            }
            else
            {
                txtBoxEmail.BackColor = SystemColors.Window;
            }

            if (string.IsNullOrWhiteSpace(txtBoxUrl.Text))
            {
                txtBoxUrl.BackColor = Color.Pink;
                toolTip.SetToolTip(txtBoxUrl, "Pole URL nie może być puste!");
                pustePola.Add("URL");
                isValid = false;
            }
            else
            {
                txtBoxUrl.BackColor = SystemColors.Window;
            }

            if (string.IsNullOrWhiteSpace(txtBoxBank.Text))
            {
                txtBoxBank.BackColor = Color.Pink;
                toolTip.SetToolTip(txtBoxBank, "Pole Bank nie może być puste!");
                pustePola.Add("Bank");
                isValid = false;
            }
            else
            {
                txtBoxBank.BackColor = SystemColors.Window;
            }

            if (string.IsNullOrWhiteSpace(txtBoxNrRachunku.Text))
            {
                txtBoxNrRachunku.BackColor = Color.Pink;
                toolTip.SetToolTip(txtBoxNrRachunku, "Pole Nr Rachunku nie może być puste!");
                pustePola.Add("Nr Rachunku");
                isValid = false;
            }
            else
            {
                txtBoxNrRachunku.BackColor = SystemColors.Window;
            }

            if (string.IsNullOrWhiteSpace(txtBoxUlica.Text))
            {
                txtBoxUlica.BackColor = Color.Pink;
                toolTip.SetToolTip(txtBoxUlica, "Pole Ulica nie może być puste!");
                pustePola.Add("Ulica");
                isValid = false;
            }
            else
            {
                txtBoxUlica.BackColor = SystemColors.Window;
            }

            if (string.IsNullOrWhiteSpace(txtBoxNrDomu.Text))
            {
                txtBoxNrDomu.BackColor = Color.Pink;
                toolTip.SetToolTip(txtBoxNrDomu, "Pole Nr Domu nie może być puste!");
                pustePola.Add("Nr Domu");
                isValid = false;
            }
            else
            {
                txtBoxNrDomu.BackColor = SystemColors.Window;
            }

            if (string.IsNullOrWhiteSpace(txtBoxKodPocz.Text))
            {
                txtBoxKodPocz.BackColor = Color.Pink;
                toolTip.SetToolTip(txtBoxKodPocz, "Pole Kod Pocztowy nie może być puste!");
                pustePola.Add("Kod Pocztowy");
                isValid = false;
            }
            else
            {
                txtBoxKodPocz.BackColor = SystemColors.Window;
            }

            if (string.IsNullOrWhiteSpace(txtBoxMiasto.Text))
            {
                txtBoxMiasto.BackColor = Color.Pink;
                toolTip.SetToolTip(txtBoxMiasto, "Pole Miasto nie może być puste!");
                pustePola.Add("Miasto");
                isValid = false;
            }
            else
            {
                txtBoxMiasto.BackColor = SystemColors.Window;
            }


            if (string.IsNullOrWhiteSpace(cmbBoxPrefixNrTel.Text))
            {
                cmbBoxPrefixNrTel.BackColor = Color.Pink;
                toolTip.SetToolTip(cmbBoxPrefixNrTel, "Pole Numer Kierunkowy nie może być puste!");
                pustePola.Add("Numer Kierunkowy");
                isValid = false;
            }
            else
            {
                cmbBoxPrefixNrTel.BackColor = SystemColors.Window;
            }

            if (string.IsNullOrWhiteSpace(cmbBoxZnizka.Text))
            {
                cmbBoxZnizka.BackColor = Color.Pink;
                toolTip.SetToolTip(cmbBoxZnizka, "Pole Zniżka nie może być puste!");
                pustePola.Add("Zniżka");
                isValid = false;
            }
            else
            {
                cmbBoxZnizka.BackColor = SystemColors.Window;
            }

            if (string.IsNullOrWhiteSpace(cmbBoxIBAN.Text))
            {
                cmbBoxIBAN.BackColor = Color.Pink;
                toolTip.SetToolTip(cmbBoxIBAN, "Pole Nr Rachunku nie może być puste!");
                pustePola.Add("IBAN");
                isValid = false;
            }
            else
            {
                cmbBoxIBAN.BackColor = SystemColors.Window;
            }

            if (string.IsNullOrWhiteSpace(cmbBoxKraj.Text))
            {
                cmbBoxKraj.BackColor = Color.Pink;
                toolTip.SetToolTip(cmbBoxKraj, "Pole Kraj nie może być puste!");
                pustePola.Add("Kraj");
                isValid = false;
            }
            else
            {
                cmbBoxKraj.BackColor = SystemColors.Window;
            }

            if (!isValid)
            {

                if (pustePola.Count > 1)
                {
                    if (!GlobalneDzialania.WalidujEmail(txtBoxEmail, toolTip))
                    {
                        MessageBox.Show("Te pola nie mogą być puste: " + string.Join(", ", pustePola) + "!", "Błąd walidacji", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        pustePola.Add("Email");
                    }
                    else
                    {
                        MessageBox.Show("Te pola nie mogą być puste: " + string.Join(", ", pustePola) + "!", "Błąd walidacji", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else if (pustePola.Count == 1)
                {

                    string pustePole = pustePola[0];
                    Control pustePoleControl = null;

                    if (pustePole == "Akronim") pustePoleControl = txtBoxAkronim;
                    else if (pustePole == "Nazwa") pustePoleControl = txtBoxNazwa;
                    else if (pustePole == "NIP") pustePoleControl = txtBoxNIP;
                    else if (pustePole == "Regon") pustePoleControl = txtBoxRegon;
                    else if (pustePole == "Numer Telefonu") pustePoleControl = txtBoxNrTel;
                    else if (pustePole == "Email") pustePoleControl = txtBoxEmail;
                    else if (pustePole == "URL") pustePoleControl = txtBoxUrl;
                    else if (pustePole == "Bank") pustePoleControl = txtBoxBank;
                    else if (pustePole == "Nr Rachunku") pustePoleControl = txtBoxNrRachunku;
                    else if (pustePole == "Ulica") pustePoleControl = txtBoxUlica;
                    else if (pustePole == "Nr Domu") pustePoleControl = txtBoxNrDomu;
                    else if (pustePole == "Kod Pocztowy") pustePoleControl = txtBoxKodPocz;
                    else if (pustePole == "Miasto") pustePoleControl = txtBoxMiasto;
                    else if (pustePole == "Numer Kierunkowy") pustePoleControl = cmbBoxPrefixNrTel;
                    else if (pustePole == "Zniżka") pustePoleControl = cmbBoxZnizka;
                    else if (pustePole == "IBAN") pustePoleControl = cmbBoxIBAN;
                    else if (pustePole == "Kraj") pustePoleControl = cmbBoxKraj;


                    MessageBox.Show($"Pole {pustePole} nie może być puste!", "Błąd walidacji", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    if (pustePoleControl != null)
                    {
                        toolTip.Show($"Uzupełnij pole {pustePole}!", pustePoleControl, 20, 21, 4000);
                    }
                }
                return;
            }


            AktualnyAdres.street = GlobalneDzialania.WyczyscTekst(txtBoxUlica.Text);
            AktualnyAdres.house_number = GlobalneDzialania.WyczyscTekst(txtBoxNrDomu.Text);
            AktualnyAdres.apartment_number = GlobalneDzialania.WyczyscTekst(txtBoxNrLokalu.Text);
            AktualnyAdres.country = cmbBoxKraj.SelectedItem.ToString();
            AktualnyAdres.postal_code = txtBoxKodPocz.Text;
            AktualnyAdres.city = GlobalneDzialania.WyczyscTekst(txtBoxMiasto.Text);
            AktualnyAdres.voivodeship = GlobalneDzialania.WyczyscTekst(txtBoxWoj.Text);
            AktualnyAdres.powiat = GlobalneDzialania.WyczyscTekst(txtBoxPowiat.Text);
            AktualnyAdres.gmina = GlobalneDzialania.WyczyscTekst(txtBoxGmina.Text);

            if (DzialaniaNaAdresie.PobierzAdresId(AktualnyAdres) == -1)
            {
                DzialaniaNaAdresie.DodajAdres(AktualnyAdres);

                AktualnyKontrahent.address_id = DzialaniaNaAdresie.PobierzAdresId(AktualnyAdres);
                AktualnyKontrahent.acronym = txtBoxAkronim.Text;
                AktualnyKontrahent.name = txtBoxNazwa.Text;
                AktualnyKontrahent.nip = GlobalneDzialania.WyczyscTekst(txtBoxNIP.Text);
                AktualnyKontrahent.discount_percentage = Convert.ToDecimal(cmbBoxZnizka.SelectedItem);
                AktualnyKontrahent.regon = GlobalneDzialania.WyczyscTekst(txtBoxRegon.Text);
                AktualnyKontrahent.phone_number = GlobalneDzialania.WyczyscTekst(txtBoxNrTel.Text);
                AktualnyKontrahent.phone_prefix = cmbBoxPrefixNrTel.SelectedItem.ToString();
                AktualnyKontrahent.email = txtBoxEmail.Text;
                AktualnyKontrahent.url = txtBoxUrl.Text;
                AktualnyKontrahent.bank_account_number = GlobalneDzialania.WyczyscTekst(txtBoxNrRachunku.Text);
                AktualnyKontrahent.bank_name = txtBoxBank.Text;
                AktualnyKontrahent.bank_iban_prefix = cmbBoxIBAN.SelectedItem.ToString();
                AktualnyKontrahent.is_archived = Convert.ToInt32(chckBoxArchiwalny.Checked);
                AktualnyKontrahent.company_description = rchTxtBoxOpis.Text;

                DzialanieNaKontrahencie.DodajKontrahenta(AktualnyKontrahent);
            }
            else
            {
                MessageBox.Show("Podany Adres jest już przypisany do Kontrahenta!", "Uwaga!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        private void btnAnuluj_Click(object sender, EventArgs e)
        {
            ListaKontrahentowForm listaKontrahentowForm = new ListaKontrahentowForm();
            this.Hide();
            listaKontrahentowForm.ShowDialog();
        }

        private void cmbBoxKraj_SelectedIndexChanged(object sender, EventArgs e)
        {
            GlobalneDzialania.PowiązKrajINumer(cmbBoxKraj, cmbBoxPrefixNrTel);
        }

        private void cmbBoxPrefixNrTel_SelectedIndexChanged(object sender, EventArgs e)
        {
            GlobalneDzialania.PowiązKrajINumer(cmbBoxKraj, cmbBoxPrefixNrTel);
        }

        private void txtBoxKodPocz_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtBoxKodPocz_TextChanged(object sender, EventArgs e)
        {
            string currentText = txtBoxKodPocz.Text.Replace("-", "");
            if (currentText.Length > 2)
            {
                currentText = currentText.Insert(2, "-");
            }

            if (currentText.Length > 6)
            {
                currentText = currentText.Substring(0, 6);
            }

            txtBoxKodPocz.Text = currentText;

            txtBoxKodPocz.SelectionStart = txtBoxKodPocz.Text.Length;
        }
    }
}
