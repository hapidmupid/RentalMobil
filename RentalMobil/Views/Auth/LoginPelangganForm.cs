using RentalMobil.Controller;
using RentalMobil.Views.admin_;
using RentalMobil.Views.pelanggan_;
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
            if (string.IsNullOrWhiteSpace(tbUsername.Text) || string.IsNullOrWhiteSpace(tbPassword.Text))
            {
                MessageBox.Show("Username dan password harus diisi!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string username = tbUsername.Text;
            string password = tbPassword.Text;

            try
            {
                var pelanggan = AuthController.LoginPelanggan(username, password);

                if (pelanggan != null)
                {

                    MessageBox.Show($"Selamat datang, {pelanggan.nama}!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    var dashboardPelanggan = new DashboardPelanggan(pelanggan);
                    dashboardPelanggan.Show();

                }
                else
                {
                    MessageBox.Show("Username atau password salah!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoginPelangganForm_Load(object sender, EventArgs e)
        {

        }
    }
}
