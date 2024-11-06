namespace DK24
{
    public partial class WyborKlient_KontrahentZamowienieForm : Form
    {
        public WyborKlient_KontrahentZamowienieForm()
        {
            InitializeComponent();
        }



        private void btnJakoKlient_Click(object sender, EventArgs e)
        {
            ZamowienieKlientForm zamowienieKlientForm = new ZamowienieKlientForm();
            this.Hide();
            zamowienieKlientForm.ShowDialog();

        }

        private void btnJakoKnt_Click(object sender, EventArgs e)
        {
            ZamowienieKontrahentaForm zamowienieKontrahentaForm = new ZamowienieKontrahentaForm();
            this.Hide();
            zamowienieKontrahentaForm.ShowDialog();
        }
    }
}
