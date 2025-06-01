using RentalMobil.Controller;
using RentalMobil.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
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
            if (string.IsNullOrWhiteSpace(textBox5.Text))
            {
                MessageBox.Show("Email harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Focus();
                return;
            }
            try
            {
                var emailCheck = new MailAddress(textBox5.Text);
            }
            catch
            {
                MessageBox.Show("Format email tidak valid!", "Format Salah", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Nama harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox2.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("No. Telepon harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox3.Focus();
                return;
            }
            if (!textBox3.Text.All(char.IsDigit))
            {
                MessageBox.Show("No. Telepon hanya boleh berisi angka!", "Format Salah", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox3.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(textBox4.Text))
            {
                MessageBox.Show("Username harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox4.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Password harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Focus();
                return;
            }

            var pelanggan = new Pelanggan
            {
                email = textBox5.Text,
                nama = textBox2.Text,
                no_telp = textBox3.Text,
                username = textBox4.Text,
                password = textBox1.Text
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
