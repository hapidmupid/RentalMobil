using RentalMobil.Views;

namespace RentalMobil
{
    public partial class AuthForm : Form
    {
        public AuthForm()
        {
            InitializeComponent();
        }

        private void AuthForm_Load(object sender, EventArgs e)
        {

        }


        private void btnLoginAdmin_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            var loginAdmin = new LoginAdminForm();
            loginAdmin.Show();
        }

        private void btnLoginPelanggan_Click(object sender, EventArgs e)
        {
            this.Hide();
            var authPelanggan = new AuthPelanggan();
            authPelanggan.Show();
        }
    }
}
