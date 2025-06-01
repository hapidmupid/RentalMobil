using RentalMobil.Controller;
using RentalMobil.Models;
using RentalMobil.Views.admin_;
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
    public partial class LoginAdminForm : Form
    {
        public LoginAdminForm()
        {
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text.Trim();
            string password = tbPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Username dan password tidak boleh kosong!");
                return;
            }

            Admin admin = AuthController.LoginAdmin(username, password);

            if (admin != null)
            {
                MessageBox.Show($"Selamat datang, {admin.nama}!");
                this.Hide();
                var dashboardAdmin = new DashboardAdmin();
                dashboardAdmin.Show();
                
            }
            else
            {
                MessageBox.Show("Username atau password salah!");
            }

            //this.Hide();
            //var dashboardAdmin = new DashboardAdmin();
            //dashboardAdmin.Show();
        }
    }
}
