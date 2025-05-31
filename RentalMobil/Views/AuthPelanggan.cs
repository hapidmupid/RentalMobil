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
    public partial class AuthPelanggan : Form
    {
        public AuthPelanggan()
        {
            InitializeComponent();
        }

        private void btn_LoginPelanggan_Click(object sender, EventArgs e)
        {
            this.Hide();
            var loginPelanggan = new LoginPelangganForm();
            loginPelanggan.Show();
        }

        private void btn_RegisterPelanggan_Click(object sender, EventArgs e)
        {
            this.Hide();
            var registerPelanggan = new RegisterPelangganForm();
            registerPelanggan.Show();
        }
    }
}
