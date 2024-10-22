using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnZapisz_Click(object sender, EventArgs e)
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


            if(DzialaniaNaAdresie.PobierzAdresId(AktualnyAdres) == -1)
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

                MessageBox.Show("Podany Adres jest juz przypisany do Kontrahenta!", "Uwaga!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            
            }
            
                


            
            


            

           






        }
    }
}
