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
    public partial class SuccessPopupForm : Form
    {
        public SuccessPopupForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.None;
            this.BackColor = Color.LimeGreen;
            this.Size = new Size(400, 300);

            SetupControls();
        }

        private void SetupControls()
        {
            // Panel untuk container
            var panel = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.White,
                Padding = new Padding(20)
            };

            // Gambar centang/success
            var pictureBox = new PictureBox
            { // Ganti dengan path gambar Anda
                SizeMode = PictureBoxSizeMode.Zoom,
                Size = new Size(100, 100),
                Top = 20,
                Left = (panel.Width - 100) / 2
            };

            // Label pesan
            var label = new Label
            {
                Text = "Registrasi Berhasil!",
                Font = new Font("Segoe UI", 14, FontStyle.Bold),
                ForeColor = Color.DarkGreen,
                AutoSize = false,
                TextAlign = ContentAlignment.MiddleCenter,
                Size = new Size(panel.Width - 40, 50),
                Top = pictureBox.Bottom + 20,
                Left = 20
            };

            // Button lanjut
            var button = new Button
            {
                Text = "Lanjut ke Login",
                BackColor = Color.LimeGreen,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                Size = new Size(150, 40),
                Top = label.Bottom + 30,
                Left = (panel.Width - 150) / 2
            };
            button.FlatAppearance.BorderSize = 0;
            button.Click += (s, e) => this.Close();

            // Tambahkan kontrol ke panel
            panel.Controls.Add(pictureBox);
            panel.Controls.Add(label);
            panel.Controls.Add(button);

            // Tambahkan panel ke form
            this.Controls.Add(panel);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
            LoginPelangganForm dashboard = new LoginPelangganForm();
            dashboard.Show();
            this.Hide();
        }
    }
}
