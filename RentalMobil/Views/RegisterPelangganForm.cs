using RentalMobil.Controller;
using RentalMobil.Models;
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
    public partial class RegisterPelangganForm : Form
    {
        public RegisterPelangganForm()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            var pelanggan = new Pelanggan
            {
                email = textBox1.Text,
                nama = textBox2.Text,
                no_telp = textBox3.Text,
                username = textBox4.Text,
                password = textBox5.Text
            };

            if (AuthController.RegisterPelanggan(pelanggan))
            {
                var popup = new SuccessPopupForm();
                popup.ShowDialog();

                this.Hide();
                new LoginPelangganForm().Show();
            }
            else
            {
                MessageBox.Show("Registrasi gagal! Username atau email mungkin sudah digunakan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RegisterPelangganForm_Load(object sender, EventArgs e)
        {

        }
    }
}
