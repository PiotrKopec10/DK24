using DK24.Klasy;
using MySql.Data.MySqlClient;
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
    public partial class SzczegolyZamowieniaForm : Form
    {
        ZamowieniaClass.Orders Zamowienia = new ZamowieniaClass.Orders();
        ZamowieniaClass DzialanieNaZamowieniu = new ZamowieniaClass()
;
        public SzczegolyZamowieniaForm()
        {
            InitializeComponent();

            GlobalClass.przesuwanieFormsa(panelGorny, this.Handle);
        }

        private void SzczegolyZamowieniaForm_Load(object sender, EventArgs e)
        {
            WypelnijSzczegolyZamowienia();
            DzialanieNaZamowieniu.WyswietlSzczegolyZamowienia(GlobalClass.ZamowienieSesja.AktualneZamowienie.order_id,dtGridViewZamowienia);
        }

        private void WypelnijSzczegolyZamowienia()
        {
            string query = @"SELECT 
                            o.order_id,
                            o.total_price,
                            o.status,
                            o.created_at,
                            COALESCE(cd.name, CONCAT(u.first_name, ' ', u.last_name)) AS customer_name,
                            COALESCE(cd.email, u.email) AS email,
                            COALESCE(cd.phone_number, u.phone_number) AS phone_number,
                            CONCAT(a.street, ' ', a.house_number, 
                                   IF(a.apartment_number IS NOT NULL AND a.apartment_number != '', CONCAT('/', a.apartment_number), ''), 
                                   ', ', a.city, ', ', a.country) AS full_address
                        FROM 
                            orders o
                        INNER JOIN 
                            users u ON o.user_id = u.user_id
                        LEFT JOIN 
                            company_details cd ON u.user_id = cd.user_id
                        INNER JOIN 
                            addresses a ON o.delivery_address_id = a.address_id
                        WHERE 
                            o.order_id = @OrderId";


            using (MySqlConnection conn = new MySqlConnection(GlobalClass.GlobalnaZmienna.DBPolaczenie))
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@OrderId", GlobalClass.ZamowienieSesja.AktualneZamowienie.order_id);

                conn.Open();
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        lblCenaNetto.Text = !reader.IsDBNull(reader.GetOrdinal("total_price")) ? reader["total_price"].ToString() : "0.00";
                        txtBoxNazwaKlienta.Text = !reader.IsDBNull(reader.GetOrdinal("customer_name")) ? reader["customer_name"].ToString() : string.Empty;
                        //txtf.Text = !reader.IsDBNull(reader.GetOrdinal("email")) ? reader["email"].ToString() : string.Empty;

                        dtPickDataWystaw.Value = !reader.IsDBNull(reader.GetOrdinal("created_at")) ? Convert.ToDateTime(reader["created_at"]) : DateTime.Now;
                        // txtBoxAdresKnt.Text = !reader.IsDBNull(reader.GetOrdinal("full_address")) ? reader["full_address"].ToString() : string.Empty;
                    }
                    else
                    {
                        MessageBox.Show("Nie znaleziono zamówienia o podanym ID.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }

        private void btnAnuluj_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            this.Hide();
            mainForm.ShowDialog();
        }

        private void btnZapisz_Click(object sender, EventArgs e)
        {

        }
    }
}
