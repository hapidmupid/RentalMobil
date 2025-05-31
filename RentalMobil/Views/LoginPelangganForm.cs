using RentalMobil.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentalMobil.Views
{
    public partial class LoginPelangganForm : Form
    {
        public LoginPelangganForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            string username = tbUsername.Text;
            string password = tbPassword.Text;

            var pelanggan = AuthController.LoginPelanggan(username, password);

            if (pelanggan != null)
            {
                MessageBox.Show($"Selamat datang, {pelanggan.nama}!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DashboardAdmin dashboard = new DashboardAdmin();
                dashboard.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username atau password salah!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoginPelangganForm_Load(object sender, EventArgs e)
        {

        }
    }
}
