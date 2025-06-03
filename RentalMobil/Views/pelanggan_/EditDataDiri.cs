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

        public Pelanggan Pelanggan { get; private set; }
        private PelangganController PelangganController = new PelangganController();
        public EditDataDiri(Pelanggan pelanggan)
        {
            InitializeComponent();
            Pelanggan = pelanggan;
            LoadData();
        }


        private void LoadData()
        {
            try
            {
                var pelanggan = PelangganController.GetPelangganById(Pelanggan.id_pelanggan);

                if (pelanggan != null)
                {
                    label1.Text = pelanggan.nama;
                    label2.Text = pelanggan.alamat;
                    label3.Text = pelanggan.no_telp;
                    label4.Text = pelanggan.email;
                }
                else
                {
                    MessageBox.Show("Data pelanggan tidak ditemukan", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal memuat data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



    }
}
