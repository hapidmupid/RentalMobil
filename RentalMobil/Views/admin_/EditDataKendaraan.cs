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

namespace RentalMobil.Views.admin_
{
    public partial class EditDataKendaraan : Form
    {
        public Kendaraan Kendaraan { get; private set; }
        public EditDataKendaraan(Kendaraan kendaraan)
        {
            InitializeComponent();
            Kendaraan = kendaraan;
            LoadData();
      
        }


        private void LoadData()
        {
            tbMerk.Text = Kendaraan.merk;
            tbModel.Text = Kendaraan.model;
            tbTahun.Text = Kendaraan.tahun.ToString();
            tbNoPlat.Text = Kendaraan.nomor_plat;
            tbHarga.Text = Kendaraan.harga_sewa_perhari.ToString();
            tbStatus.Text = Kendaraan.status;

        }




        private void btnSimpan_Click(object sender, EventArgs e)
        {
            Kendaraan.merk = tbMerk.Text;
            Kendaraan.model = tbModel.Text;
            Kendaraan.tahun = int.Parse(tbTahun.Text);
            Kendaraan.nomor_plat = tbNoPlat.Text;
            Kendaraan.harga_sewa_perhari = decimal.Parse(tbHarga.Text);
            Kendaraan.status = tbStatus.Text;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}