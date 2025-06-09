using RentalMobil.Controller;
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
    public partial class LihatRiwayat : Form
    {
        private readonly int _idPelanggan;
        private readonly TransaksiController _transaksiController;

        public LihatRiwayat(int idPelanggan)
        {
            InitializeComponent();
            _idPelanggan = idPelanggan;
            _transaksiController = new TransaksiController();

            // Atur DataGridView
            dgRiwayat.AutoGenerateColumns = true;
            dgRiwayat.ReadOnly = true;
            dgRiwayat.AllowUserToAddRows = false;
            dgRiwayat.AllowUserToDeleteRows = false;

            LoadRiwayat();
        }

        public LihatRiwayat()
        {
        }

        private void LoadRiwayat()
        {
            try
            {
                DataTable dataRiwayat = _transaksiController.GetRiwayatByPelanggan(_idPelanggan);
                dgRiwayat.DataSource = dataRiwayat;

                // Format kolom jika diperlukan
                if (dgRiwayat.Columns.Contains("total_harga"))
                {
                    dgRiwayat.Columns["total_harga"].DefaultCellStyle.Format = "C";
                    dgRiwayat.Columns["total_harga"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }

                // Atur header kolom
                if (dgRiwayat.Columns.Contains("id_transaksi"))
                    dgRiwayat.Columns["id_transaksi"].HeaderText = "ID Transaksi";
                if (dgRiwayat.Columns.Contains("kendaraan"))
                    dgRiwayat.Columns["kendaraan"].HeaderText = "Kendaraan";
                if (dgRiwayat.Columns.Contains("tanggal_sewa"))
                    dgRiwayat.Columns["tanggal_sewa"].HeaderText = "Tanggal Sewa";
                if (dgRiwayat.Columns.Contains("tanggal_kembali"))
                    dgRiwayat.Columns["tanggal_kembali"].HeaderText = "Tanggal Kembali";
                if (dgRiwayat.Columns.Contains("status_pembayaran"))
                    dgRiwayat.Columns["status_pembayaran"].HeaderText = "Status Pembayaran";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal memuat riwayat: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void dgRiwayat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            BelumBayar formBelumBayar = new BelumBayar(_idPelanggan);
            formBelumBayar.ShowDialog(); // atau ShowDialog() jika kamu mau bentuk popup modal
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadRiwayat();
            
        }
    }
}
