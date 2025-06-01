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

namespace RentalMobil.Views.admin_
{
    public partial class EditDataPelanggan : Form
    {

        public Pelanggan Pelanggan { get; private set; }


        public EditDataPelanggan(Pelanggan pelanggan)
        {
            InitializeComponent();
            Pelanggan = pelanggan;
            LoadData();
        }

        private void LoadData()
        {
            tbNama.Text = Pelanggan.nama;
            tbAlamat.Text = Pelanggan.alamat;
            tbNoTelp.Text = Pelanggan.no_telp;
            tbEmail.Text = Pelanggan.email;
        }
        private void btnSimpan_Click(object sender, EventArgs e)
        {
            Pelanggan.nama = tbNama.Text;
            Pelanggan.alamat = tbAlamat.Text;
            Pelanggan.no_telp = tbNoTelp.Text;
            Pelanggan.email = tbEmail.Text;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void EditDataPelanggan_Load(object sender, EventArgs e)
        {

        }
    }
}
