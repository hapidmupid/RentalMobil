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
    public partial class TambahDataKendaraan : Form
    {
        public Kendaraan Kendaraan { get; private set; }
        public TambahDataKendaraan()
        {
            InitializeComponent();
        }


        private bool ValidateInput()
        {


            tbStatus.Text = "tersedia"; // Set default status to "tersedia"

            if (string.IsNullOrEmpty(tbMerk.Text) ||
                string.IsNullOrEmpty(tbModel.Text) ||
                string.IsNullOrEmpty(tbTahun.Text) ||
                string.IsNullOrEmpty(tbNoPlat.Text) ||
                string.IsNullOrEmpty(tbHarga.Text))
            //string.IsNullOrEmpty(tbStatus.Text))


            {
                MessageBox.Show("Semua field harus diisi", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!int.TryParse(tbTahun.Text, out _))
            {
                MessageBox.Show("Tahun harus berupa angka", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!decimal.TryParse(tbHarga.Text, out _))
            {
                MessageBox.Show("Harga sewa harus berupa angka", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }


        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                Kendaraan = new Kendaraan
                {
                    merk = tbMerk.Text,
                    model = tbModel.Text,
                    tahun = Convert.ToInt32(tbTahun.Text),
                    nomor_plat = tbNoPlat.Text,
                    harga_sewa_perhari = Convert.ToDecimal(tbHarga.Text),
                    status = "tersedia"
                };

                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void TambahDataKendaraan_Load(object sender, EventArgs e)
        {

        }
    }
}
