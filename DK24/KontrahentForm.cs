using DK24.Klasy;
using System.ServiceModel.Channels;
using System.ServiceModel;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ToolTip = System.Windows.Forms.ToolTip;
using System.Xml;

namespace DK24
{
    public partial class KontrahentForm : Form
    {
        AddressClass DzialaniaNaAdresie = new AddressClass();
        AddressClass.Address AktualnyAdres = new AddressClass.Address();

        GlobalClass GlobalneDzialania = new GlobalClass();

        KontrahentClass DzialanieNaKontrahencie = new KontrahentClass();
        KontrahentClass.Kontrahent AktualnyKontrahent = new KontrahentClass.Kontrahent();


        private KontrahentClass.Kontrahent pobieranyKontrahent;


        public KontrahentForm()
        {
            InitializeComponent();

            GlobalClass.przesuwanieFormsa(panelGorny, this.Handle);



            // Obsługa NIP
            txtBoxNIP.MaxLength = 10;
            txtBoxNIP.KeyPress += new KeyPressEventHandler(GlobalneDzialania.TylkoCyfry);

            // Obsługa REGON
            txtBoxRegon.MaxLength = 9;
            txtBoxRegon.KeyPress += new KeyPressEventHandler(GlobalneDzialania.TylkoCyfry);

            // Obsługa Nr Telefonu
            txtBoxNrTel.MaxLength = 14;
            txtBoxNrTel.KeyPress += new KeyPressEventHandler(GlobalneDzialania.TylkoCyfry);



            // Obsługa Banku
            txtBoxBank.KeyPress += new KeyPressEventHandler(GlobalneDzialania.TylkoLitery);
            txtBoxBank.TextChanged += new EventHandler(GlobalneDzialania.ZmienPierwszaLitereNaWielka);

            // Obsługa Nr Bankowego
            txtBoxNrRachunku.MaxLength = 30;
            txtBoxNrRachunku.KeyPress += new KeyPressEventHandler(GlobalneDzialania.TylkoCyfry);


            // Ulica
            txtBoxUlica.KeyPress += new KeyPressEventHandler(GlobalneDzialania.TylkoLitery);
            txtBoxUlica.TextChanged += new EventHandler(GlobalneDzialania.ZmienPierwszaLitereNaWielka);

            // Nr Domu i Lokalu
            txtBoxNrDomu.KeyPress += new KeyPressEventHandler(GlobalneDzialania.BlokujZnakiSpecjalneIspacje);
            txtBoxNrLokalu.KeyPress += new KeyPressEventHandler(GlobalneDzialania.BlokujZnakiSpecjalneIspacje);


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


            cmbBoxKraj.SelectedIndexChanged += new EventHandler(cmbBoxKraj_SelectedIndexChanged);
            cmbBoxPrefixNrTel.SelectedIndexChanged += new EventHandler(cmbBoxPrefixNrTel_SelectedIndexChanged);

        }


        private void btnZapisz_Click(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.IsBalloon = true;
            toolTip.InitialDelay = 0;
            toolTip.ShowAlways = true;


            bool isValid = true;
            List<string> pustePola = new List<string>();


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

            if (string.IsNullOrWhiteSpace(txtBoxNIP.Text) || txtBoxNIP.Text.Length != 10)
            {
                txtBoxNIP.BackColor = Color.Pink;
                toolTip.SetToolTip(txtBoxNIP, "Pole NIP musi być wypełnione i mieć równo 10 znaków!");
                toolTip.Show("Nieprawidłowy Nr NIP", txtBoxNIP, 3000);
                pustePola.Add("NIP");
                isValid = false;
            }
            else
            {
                txtBoxNIP.BackColor = SystemColors.Window;
            }

            if (txtBoxRegon.Text.Length > 0 && txtBoxRegon.Text.Length < 9)
            {
                txtBoxRegon.BackColor = Color.Pink;
                toolTip.SetToolTip(txtBoxRegon, "Regon musi mieć co najmniej 9 znaków!");
                toolTip.Show("Nieprawidłowy Nr Regon", txtBoxRegon, 3000);
                isValid = false;
            }
            else
            {
                txtBoxRegon.BackColor = SystemColors.Window;
            }


            if (string.IsNullOrWhiteSpace(txtBoxNrTel.Text) || txtBoxNrTel.Text.Length < 9)
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

            if (string.IsNullOrWhiteSpace(txtBoxEmail.Text) || !txtBoxEmail.Text.Contains("@"))
            {
                txtBoxEmail.BackColor = Color.Pink;
                toolTip.SetToolTip(txtBoxEmail, "Pole Email nie może być puste!");
                toolTip.Show("Nieprawidłowy Adres E-mail", txtBoxEmail, 3000);
                pustePola.Add("Email");
                isValid = false;
            }
            else
            {
                txtBoxEmail.BackColor = SystemColors.Window;
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

            if (string.IsNullOrWhiteSpace(txtBoxKodPocz.Text) || txtBoxKodPocz.Text.Length != 6)
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

                    if (pustePole == "Nazwa")
                    {
                        pustePoleControl = txtBoxNazwa;
                    }
                    else if (pustePole == "NIP")
                    {
                        pustePoleControl = txtBoxNIP;
                    }
                    else if (pustePole == "Numer Telefonu")
                    {
                        pustePoleControl = txtBoxNrTel;
                    }
                    else if (pustePole == "Email")
                    {
                        pustePoleControl = txtBoxEmail;
                    }
                    else if (pustePole == "Bank")
                    {
                        pustePoleControl = txtBoxBank;
                    }
                    else if (pustePole == "Nr Rachunku")
                    {
                        pustePoleControl = txtBoxNrRachunku;
                    }
                    else if (pustePole == "Ulica")
                    {
                        pustePoleControl = txtBoxUlica;
                    }
                    else if (pustePole == "Nr Domu")
                    {
                        pustePoleControl = txtBoxNrDomu;
                    }
                    else if (pustePole == "Kod Pocztowy")
                    {
                        pustePoleControl = txtBoxKodPocz;
                    }
                    else if (pustePole == "Miasto")
                    {
                        pustePoleControl = txtBoxMiasto;
                    }
                    else if (pustePole == "Numer Kierunkowy")
                    {
                        pustePoleControl = cmbBoxPrefixNrTel;
                    }
                    else if (pustePole == "Zniżka")
                    {
                        pustePoleControl = cmbBoxZnizka;
                    }
                    else if (pustePole == "IBAN")
                    {
                        pustePoleControl = cmbBoxIBAN;
                    }
                    else if (pustePole == "Kraj")
                    {
                        pustePoleControl = cmbBoxKraj;
                    }

                    MessageBox.Show($"Pole {pustePole} nie może być puste!", "Błąd walidacji", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    if (pustePoleControl != null)
                    {
                        toolTip.Show($"Uzupełnij pole {pustePole}!", pustePoleControl, 20, 21, 4000);
                    }
                }
                return;
            }




            if (GlobalClass.StanFormyKontrahenta.StanFormy == 3)
            {


                AktualnyAdres.street = GlobalneDzialania.WyczyscTekst(txtBoxUlica.Text);
                AktualnyAdres.house_number = GlobalneDzialania.WyczyscTekst(txtBoxNrDomu.Text);
                AktualnyAdres.apartment_number = GlobalneDzialania.WyczyscTekst(txtBoxNrLokalu.Text);
                AktualnyAdres.country = cmbBoxKraj.SelectedItem.ToString();
                AktualnyAdres.postal_code = txtBoxKodPocz.Text;
                AktualnyAdres.city = GlobalneDzialania.WyczyscTekst(txtBoxMiasto.Text);
                AktualnyAdres.voivodeship = GlobalneDzialania.WyczyscTekst(txtBoxWoj.Text);
                AktualnyAdres.powiat = GlobalneDzialania.WyczyscTekst(txtBoxPowiat.Text);
                AktualnyAdres.gmina = GlobalneDzialania.WyczyscTekst(txtBoxGmina.Text);



                if (DzialaniaNaAdresie.PobierzIdAdresu(AktualnyAdres) == -1)
                {
                    DzialaniaNaAdresie.DodajAdres(AktualnyAdres);

                    AktualnyKontrahent.address_id = DzialaniaNaAdresie.PobierzIdAdresu(AktualnyAdres);
                    AktualnyKontrahent.acronym = txtBoxAkronim.Text;
                    AktualnyKontrahent.name = txtBoxNazwa.Text;
                    AktualnyKontrahent.nip = GlobalneDzialania.WyczyscTekst(txtBoxNIP.Text);
                    AktualnyKontrahent.discount_percentage = Convert.ToInt32(cmbBoxZnizka.SelectedItem);
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





                    if(DzialanieNaKontrahencie.PobierzIdUseraPoEmail(AktualnyKontrahent.email) != -1 )
                    {
                        AktualnyKontrahent.user_id = DzialanieNaKontrahencie.PobierzIdUseraPoEmail(AktualnyKontrahent.email);

                        if (DzialanieNaKontrahencie.CzyUserJestPrzypisanyDoKontrahenta(AktualnyKontrahent.user_id) == false) 
                        {
                            DzialanieNaKontrahencie.DodajKontrahenta(AktualnyKontrahent);
                        }
                        else
                        {
                            MessageBox.Show("Podany Adres email jest przypisany do danego konta!", "Uwaga!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                        


                       
                    }
                    else
                    {
                        MessageBox.Show("Nieznaleziono maila przypisanego do danego Kontrahenta!", "Uwaga!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }


                   



                }
                else
                {
                    MessageBox.Show("Podany Adres jest już przypisany do Kontrahenta!", "Uwaga!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                ListaKontrahentowForm listaKontrahentowForm = new ListaKontrahentowForm();
                this.Close();
                listaKontrahentowForm.ShowDialog();


            }
            else if (GlobalClass.StanFormyKontrahenta.StanFormy == 2)
            {


                


                AktualnyKontrahent = DzialanieNaKontrahencie.PobierzKontrahentaWgId(GlobalClass.KontrahentSesja.AktualnyKontrahent.company_details_id);



                AktualnyAdres.street = GlobalneDzialania.WyczyscTekst(txtBoxUlica.Text);
                AktualnyAdres.house_number = GlobalneDzialania.WyczyscTekst(txtBoxNrDomu.Text);
                AktualnyAdres.apartment_number = GlobalneDzialania.WyczyscTekst(txtBoxNrLokalu.Text);
                AktualnyAdres.country = cmbBoxKraj.SelectedItem.ToString();
                AktualnyAdres.postal_code = txtBoxKodPocz.Text;
                AktualnyAdres.city = GlobalneDzialania.WyczyscTekst(txtBoxMiasto.Text);
                AktualnyAdres.voivodeship = GlobalneDzialania.WyczyscTekst(txtBoxWoj.Text);
                AktualnyAdres.powiat = GlobalneDzialania.WyczyscTekst(txtBoxPowiat.Text);
                AktualnyAdres.gmina = GlobalneDzialania.WyczyscTekst(txtBoxGmina.Text);


                DzialaniaNaAdresie.EdytujAdres(AktualnyAdres);





                AktualnyKontrahent.address_id = DzialaniaNaAdresie.PobierzIdAdresu(AktualnyAdres);
                AktualnyKontrahent.acronym = txtBoxAkronim.Text;
                AktualnyKontrahent.name = txtBoxNazwa.Text;
                AktualnyKontrahent.nip = GlobalneDzialania.WyczyscTekst(txtBoxNIP.Text);
                AktualnyKontrahent.discount_percentage = Convert.ToInt32(cmbBoxZnizka.SelectedItem);
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



                //if (DzialanieNaKontrahencie.PobierzIdUseraPoEmail(AktualnyKontrahent.email) != -1)
                //{
                //    AktualnyKontrahent.user_id = DzialanieNaKontrahencie.PobierzIdUseraPoEmail(AktualnyKontrahent.email);
                    
                //}
                //else
                //{
                //    MessageBox.Show("Nieznaleziono maila przypisanego do danego Kontrahenta!", "Uwaga!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //}




                DzialanieNaKontrahencie.EdytujKontrahenta(AktualnyKontrahent);


                ListaKontrahentowForm listaKontrahentowForm = new ListaKontrahentowForm();
                this.Close();
                listaKontrahentowForm.ShowDialog();




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

        }

        private void cmbBoxPrefixNrTel_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        private void KontrahentForm_Click(object sender, EventArgs e)
        {

        }

        private void txtBoxAkronim_Enter(object sender, EventArgs e)
        {
            txtBoxAkronim.BackColor = SystemColors.Window;
        }

        private void txtBoxNazwa_Enter(object sender, EventArgs e)
        {
            txtBoxNazwa.BackColor = SystemColors.Window;
        }

        private void txtBoxNIP_Enter(object sender, EventArgs e)
        {
            txtBoxNIP.BackColor = SystemColors.Window;
        }

        private void txtBoxRegon_Enter(object sender, EventArgs e)
        {
            txtBoxRegon.BackColor = SystemColors.Window;
        }

        private void cmbBoxPrefixNrTel_Enter(object sender, EventArgs e)
        {
            cmbBoxPrefixNrTel.BackColor = SystemColors.Window;
        }

        private void txtBoxNrTel_Enter(object sender, EventArgs e)
        {
            txtBoxNrTel.BackColor = SystemColors.Window;
        }

        private void txtBoxEmail_Enter(object sender, EventArgs e)
        {
            txtBoxEmail.BackColor = SystemColors.Window;
        }

        private void txtBoxUrl_Enter(object sender, EventArgs e)
        {
            txtBoxUrl.BackColor = SystemColors.Window;
        }

        private void txtBoxBank_Enter(object sender, EventArgs e)
        {
            txtBoxBank.BackColor = SystemColors.Window;
        }

        private void cmbBoxIBAN_Enter(object sender, EventArgs e)
        {
            cmbBoxIBAN.BackColor = SystemColors.Window;
        }

        private void txtBoxNrRachunku_Enter(object sender, EventArgs e)
        {
            txtBoxNrRachunku.BackColor = SystemColors.Window;
        }

        private void cmbBoxZnizka_Enter(object sender, EventArgs e)
        {
            cmbBoxZnizka.BackColor = SystemColors.Window;
        }

        private void txtBoxUlica_Enter(object sender, EventArgs e)
        {
            txtBoxUlica.BackColor = SystemColors.Window;
        }

        private void txtBoxNrDomu_Enter(object sender, EventArgs e)
        {
            txtBoxNrDomu.BackColor = SystemColors.Window;
        }

        private void txtBoxNrLokalu_Enter(object sender, EventArgs e)
        {
            txtBoxNrLokalu.BackColor = SystemColors.Window;
        }

        private void cmbBoxKraj_Enter(object sender, EventArgs e)
        {
            cmbBoxKraj.BackColor = SystemColors.Window;
        }

        private void txtBoxKodPocz_Enter(object sender, EventArgs e)
        {
            txtBoxKodPocz.BackColor = SystemColors.Window;
        }

        private void txtBoxMiasto_Enter(object sender, EventArgs e)
        {
            txtBoxMiasto.BackColor = SystemColors.Window;
        }

        private void KontrahentForm_Load(object sender, EventArgs e)
        {

            if (GlobalClass.StanFormyKontrahenta.StanFormy == 1)
            {
                lblNaglowek.Text = "PODGLĄD KONTRAHNETA";
                btnZapisz.Visible = false;
                btnPobierzPoNip.Visible = false;
                AktualnyKontrahent = DzialanieNaKontrahencie.PobierzKontrahentaWgId(GlobalClass.KontrahentSesja.AktualnyKontrahent.company_details_id);
                AktualnyAdres.address_id = AktualnyKontrahent.address_id;
                AktualnyAdres = DzialaniaNaAdresie.PobierzAdresWgId(AktualnyAdres.address_id);
                WstawPolaDoEdycji();

                txtBoxAkronim.Enabled = false;
                txtBoxNazwa.Enabled = false;
                txtBoxNIP.Enabled = false;
                txtBoxRegon.Enabled = false;
                cmbBoxPrefixNrTel.Enabled = false;
                txtBoxNrTel.Enabled = false;
                txtBoxEmail.Enabled = false;
                txtBoxUrl.Enabled = false;
                txtBoxBank.Enabled = false;
                cmbBoxIBAN.Enabled = false;
                txtBoxNrRachunku.Enabled = false;
                cmbBoxZnizka.Enabled = false;
                chckBoxArchiwalny.Enabled = false;
                rchTxtBoxOpis.Enabled = false;
                txtBoxUlica.Enabled = false;
                txtBoxNrDomu.Enabled = false;
                txtBoxNrLokalu.Enabled = false;
                cmbBoxKraj.Enabled = false;
                txtBoxKodPocz.Enabled = false;
                txtBoxMiasto.Enabled = false;
                txtBoxWoj.Enabled = false;
                txtBoxPowiat.Enabled = false;
                txtBoxGmina.Enabled = false;
               

            }
            else if (GlobalClass.StanFormyKontrahenta.StanFormy == 2)
            {
                lblNaglowek.Text = "EDYTUJ KONTRAHENTA";
                txtBoxEmail.Enabled = false;
                btnZapisz.Visible = true;
                btnPobierzPoNip.Visible = true;
                AktualnyKontrahent = DzialanieNaKontrahencie.PobierzKontrahentaWgId(GlobalClass.KontrahentSesja.AktualnyKontrahent.company_details_id);
                AktualnyAdres.address_id = AktualnyKontrahent.address_id;
                AktualnyAdres = DzialaniaNaAdresie.PobierzAdresWgId(AktualnyAdres.address_id);
                WstawPolaDoEdycji();






            }
            else if (GlobalClass.StanFormyKontrahenta.StanFormy == 3)
            {
                txtBoxEmail.Enabled = true;
                btnZapisz.Visible = true;
                btnPobierzPoNip.Visible = true;

            }





        }



        void WstawPolaDoEdycji()
        {


            txtBoxAkronim.Text = AktualnyKontrahent.acronym;
            txtBoxNazwa.Text = AktualnyKontrahent.name;
            txtBoxNIP.Text = AktualnyKontrahent.nip;
            txtBoxRegon.Text = AktualnyKontrahent.regon;
            txtBoxNrTel.Text = AktualnyKontrahent.phone_number;
            txtBoxEmail.Text = AktualnyKontrahent.email;
            txtBoxUrl.Text = AktualnyKontrahent.url;
            txtBoxBank.Text = AktualnyKontrahent.bank_name;
            txtBoxNrRachunku.Text = AktualnyKontrahent.bank_account_number;

            cmbBoxZnizka.Text = AktualnyKontrahent.discount_percentage.ToString();
            cmbBoxPrefixNrTel.Text = AktualnyKontrahent.phone_prefix;

            cmbBoxIBAN.Text = AktualnyKontrahent.bank_iban_prefix;


            rchTxtBoxOpis.Text = AktualnyKontrahent.company_description;




            if (AktualnyKontrahent.is_archived == 1)
            {
                chckBoxArchiwalny.Checked = true;
            }




            txtBoxUlica.Text = AktualnyAdres.street;
            txtBoxNrDomu.Text = AktualnyAdres.house_number;
            txtBoxNrLokalu.Text = AktualnyAdres.apartment_number;
            txtBoxKodPocz.Text = AktualnyAdres.postal_code;
            txtBoxMiasto.Text = AktualnyAdres.city;
            txtBoxWoj.Text = AktualnyAdres.voivodeship;
            txtBoxPowiat.Text = AktualnyAdres.powiat;
            txtBoxGmina.Text = AktualnyAdres.gmina;

            cmbBoxKraj.Text = AktualnyAdres.country;




        }

        private void btnPobierzPoNip_Click(object sender, EventArgs e)
        {

            if (txtBoxNIP.Text.Length != 10)
            {
                MessageBox.Show("NIP musi mieć dokładnie 10 cyfr!", "Pole NIP musi być wypełnione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBoxNIP.Focus();
                return;
            }


            DialogResult result = MessageBox.Show("Czy na pewno chcesz szukać po NIP-ie kontrahenta?","Potwierdzenie",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {            
                SzukajPoNIP(txtBoxNIP.Text);
            }




        }


        public async void SzukajPoNIP(string nip)
        {
            try
            {
                var binding = new WSHttpBinding();
                binding.MessageEncoding = WSMessageEncoding.Mtom;
                binding.Security.Mode = SecurityMode.Transport;

                var endpointAddress = new EndpointAddress("https://wyszukiwarkaregontest.stat.gov.pl/wsBIR/UslugaBIRzewnPubl.svc");
                var client = new GUSAPI.UslugaBIRzewnPublClient(binding, endpointAddress);

                // Logowanie i pobranie SID (sesji)
                var loginResponse = await client.ZalogujAsync("abcde12345abcde12345");
                string sid = loginResponse.ZalogujResult;

                // Dodanie SID do nagłówków
                using (var scope = new OperationContextScope(client.InnerChannel))
                {
                    var httpRequestProperty = new HttpRequestMessageProperty();
                    httpRequestProperty.Headers["sid"] = sid;
                    OperationContext.Current.OutgoingMessageProperties[HttpRequestMessageProperty.Name] = httpRequestProperty;

                    // Przygotowanie parametrów wyszukiwania po NIP
                    var parametry = new GUSAPI.ParametryWyszukiwania { Nip = nip };

                    // Wykonanie zapytania
                    var wynikResponse = await client.DaneSzukajPodmiotyAsync(parametry);
                    string wynik = wynikResponse.DaneSzukajPodmiotyResult;

                    // Przetwarzanie wyniku XML
                    WypelnijDaneZXml(wynik);
                }

                // Wylogowanie
                using (var scope = new OperationContextScope(client.InnerChannel))
                {
                    var httpRequestProperty = new HttpRequestMessageProperty();
                    httpRequestProperty.Headers["sid"] = sid;
                    OperationContext.Current.OutgoingMessageProperties[HttpRequestMessageProperty.Name] = httpRequestProperty;

                    await client.WylogujAsync(sid);
                }

                client.Close();
            }
            catch (Exception ex)
            {
               // txtBoxNipKnt.Text = $"Błąd: {ex.Message}";
            }
        }


        public void WypelnijDaneZXml(string xmlContent)
        {
            
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xmlContent);


            XmlNode daneNode = doc.SelectSingleNode("/root/dane");

            

            if (daneNode != null)
            {
                
                string czyBlad = daneNode.SelectSingleNode("ErrorCode")?.InnerText ??"";

                if (czyBlad == "4") 
                {
                   

                    txtBoxRegon.Text = "";
                    txtBoxNazwa.Text = "";
                    txtBoxWoj.Text = "";
                    txtBoxPowiat.Text = "";
                    txtBoxGmina.Text = "";
                    txtBoxMiasto.Text = "";
                    txtBoxKodPocz.Text = "";
                    txtBoxUlica.Text = "";
                    txtBoxNrDomu.Text = "";
                    txtBoxNrLokalu.Text = "";

                    MessageBox.Show("Błąd nie znaleziono w bazie!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {

                    txtBoxRegon.Text = daneNode.SelectSingleNode("Regon")?.InnerText ?? "";
                    txtBoxNIP.Text = daneNode.SelectSingleNode("Nip")?.InnerText ?? "";
                    txtBoxNazwa.Text = daneNode.SelectSingleNode("Nazwa")?.InnerText ?? "";
                    txtBoxWoj.Text = daneNode.SelectSingleNode("Wojewodztwo")?.InnerText ?? "";
                    txtBoxPowiat.Text = daneNode.SelectSingleNode("Powiat")?.InnerText ?? "";
                    txtBoxGmina.Text = daneNode.SelectSingleNode("Gmina")?.InnerText ?? "";
                    txtBoxMiasto.Text = daneNode.SelectSingleNode("Miejscowosc")?.InnerText ?? "";
                    txtBoxKodPocz.Text = daneNode.SelectSingleNode("KodPocztowy")?.InnerText ?? "";
                    txtBoxUlica.Text = daneNode.SelectSingleNode("Ulica")?.InnerText ?? "";
                    txtBoxNrDomu.Text = daneNode.SelectSingleNode("NrNieruchomosci")?.InnerText ?? "";
                    txtBoxNrLokalu.Text = daneNode.SelectSingleNode("NrLokalu")?.InnerText ?? "";

                }


                


            }
            
        }

    }
}
