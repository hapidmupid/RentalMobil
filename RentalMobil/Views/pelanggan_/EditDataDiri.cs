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

namespace RentalMobil.Views.pelanggan_
{
    public partial class EditDataDiri : Form
    {
        private int idPelanggan;
        private Pelanggan pelanggan;
        private PelangganController pelangganController;
        public EditDataDiri(int idPelanggan)
        {
            InitializeComponent();
            this.idPelanggan = idPelanggan;
            pelangganController = new PelangganController();
            LoadDataPelanggan();
        }

        private void LoadDataPelanggan()
        {
            var pelanggan = pelangganController.GetPelangganById(idPelanggan);

            if (pelanggan != null)
            {
                label1.Text = pelanggan.nama;
                label2.Text = pelanggan.alamat;
                label3.Text = pelanggan.no_telp;
                label4.Text = pelanggan.email;
            }
            else
            {
                MessageBox.Show("Data pelanggan tidak ditemukan", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Pastikan objek pelanggan sudah dimuat
            if (pelanggan == null)
            {
                pelanggan = pelangganController.GetPelangganById(idPelanggan);

                // Jika masih null, tampilkan error
                if (pelanggan == null)
                {
                    MessageBox.Show("Gagal memuat data pelanggan", "Error",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            this.Hide();
            var dashboardPelanggan = new DashboardPelanggan(pelanggan); // Pastikan mengirim objek pelanggan
            dashboardPelanggan.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // Buka form edit alamat
            using (var formEdit = new FormEditDataDiri(idPelanggan, label2.Text))
            {
                if (formEdit.ShowDialog() == DialogResult.OK)
                {
                    // Refresh data setelah edit
                    LoadDataPelanggan();
                }
            }
        }
    }
}
