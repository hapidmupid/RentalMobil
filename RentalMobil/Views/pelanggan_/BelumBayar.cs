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
    public partial class BelumBayar : Form
    {
        private readonly int _idPelanggan;
        private readonly TransaksiController _transaksiController;
        private DataGridView dgRiwayat; // Fix: Change 'object' to 'DataGridView'  

        public BelumBayar(int idPelanggan)
        {
            InitializeComponent();
            _idPelanggan = idPelanggan;
            _transaksiController = new TransaksiController();

            // Initialize DataGridView  
            dgRiwayat = new DataGridView();
            dgRiwayat.AutoGenerateColumns = true;
            dgRiwayat.ReadOnly = true;
            dgRiwayat.AllowUserToAddRows = false;
            dgRiwayat.AllowUserToDeleteRows = false;

            LoadRiwayat();
        }

        private void LoadRiwayat()
        {
            try
            {
                DataTable dataRiwayat = _transaksiController.GetTransaksiBelumBayar(_idPelanggan);
                dgRiwayat.DataSource = dataRiwayat;

                if (dgRiwayat.Columns.Contains("total_harga"))
                {
                    dgRiwayat.Columns["total_harga"].DefaultCellStyle.Format = "C";
                    dgRiwayat.Columns["total_harga"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }

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

                if (dataRiwayat.Rows.Count == 0)
                {
                    MessageBox.Show("Tidak ada transaksi belum lunas.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal memuat data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgBelumBayar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
