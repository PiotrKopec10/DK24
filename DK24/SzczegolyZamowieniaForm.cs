using DK24.Klasy;
using MySql.Data.MySqlClient;

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
            DzialanieNaZamowieniu.WyswietlSzczegolyZamowienia(GlobalClass.ZamowienieSesja.AktualneZamowienie.order_id, dtGridViewZamowienia);
        }

        private void WypelnijSzczegolyZamowienia()
        {
            string query = @"
        SELECT 
            o.order_id,
            o.total_price,
            o.status,
            o.created_at,
            o.shipping_method,
            COALESCE(cd.name, CONCAT(u.first_name, ' ', u.last_name)) AS customer_name,
            COALESCE(cd.email, u.email) AS email,
            COALESCE(cd.phone_number, u.phone_number) AS phone_number,
            CASE 
                WHEN o.delivery_address_id IS NULL THEN 'Odbiór osobisty'
                ELSE CONCAT(a.street, ' ', a.house_number, 
                            IF(a.apartment_number IS NOT NULL AND a.apartment_number != '', 
                               CONCAT('/', a.apartment_number), ''), 
                            ', ', a.city, ', ', a.country)
            END AS full_address
        FROM 
            orders o
        INNER JOIN 
            users u ON o.user_id = u.user_id
        LEFT JOIN 
            company_details cd ON u.user_id = cd.user_id
        LEFT JOIN 
            addresses a ON o.delivery_address_id = a.address_id
        WHERE 
            o.order_id = @OrderId";

            using (MySqlConnection conn = new MySqlConnection(GlobalClass.GlobalnaZmienna.DBPolaczenie))
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@OrderId", GlobalClass.ZamowienieSesja.AktualneZamowienie.order_id);

                try
                {
                    conn.Open();

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows && reader.Read())
                        {
                            lblCenaNetto.Text = reader.IsDBNull(reader.GetOrdinal("total_price"))
                                                ? "0.00"
                                                : reader["total_price"].ToString();

                            txtBoxNazwaKlienta.Text = reader.IsDBNull(reader.GetOrdinal("customer_name"))
                                                      ? "Nieznany klient"
                                                      : reader["customer_name"].ToString();

                            txtBoxAdres.Text = reader.IsDBNull(reader.GetOrdinal("full_address"))
                                               ? "Odbiór osobisty"
                                               : reader["full_address"].ToString();

                            dtPickDataWystaw.Value = reader.IsDBNull(reader.GetOrdinal("created_at"))
                                                     ? DateTime.Now
                                                     : Convert.ToDateTime(reader["created_at"]);

                           
                            string shippingMethod = reader.IsDBNull(reader.GetOrdinal("shipping_method"))
                                                    ? "self_pickup"
                                                    : reader["shipping_method"].ToString();

                            if (shippingMethod == "self_pickup")
                            {
                                chckBoxOdbior.Checked = true;
                                chckBoxWysylka.Checked = false;
                                btnWygenerujEtykiete.Visible = false;
                            }
                            if(shippingMethod == "dhl")
                            {
                                chckBoxOdbior.Checked = false;
                                chckBoxWysylka.Checked = true;
                                btnWygenerujEtykiete.Visible = true;
                            }

                            string status = reader.IsDBNull(reader.GetOrdinal("status"))
                                    ? "newOrder"
                                    : reader["status"].ToString();
                            cmbBoxStatusZamowienia.SelectedItem = status;

                        }
                        else
                        {
                            MessageBox.Show("Nie znaleziono zamówienia o podanym ID.",
                                            "Błąd",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Wystąpił błąd podczas pobierania szczegółów zamówienia: " + ex.Message,
                                    "Błąd",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
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
