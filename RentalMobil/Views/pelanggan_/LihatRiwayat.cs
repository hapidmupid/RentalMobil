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


        private void LoadRiwayat()
        {

            // Styling DataGridView
            dgRiwayat.EnableHeadersVisualStyles = false;
            dgRiwayat.BackgroundColor = Color.FromArgb(80, 80, 80); // #505050
            dgRiwayat.GridColor = Color.FromArgb(120, 120, 120);
            dgRiwayat.BorderStyle = BorderStyle.None;

            // Header
            dgRiwayat.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(80, 80, 80);
            dgRiwayat.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgRiwayat.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgRiwayat.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Trik tambahan agar teks terlihat benar-benar di tengah (secara vertikal)
            dgRiwayat.ColumnHeadersDefaultCellStyle.Padding = new Padding(0, 15, 0, 15); // top padding bisa kamu sesuaikan

            dgRiwayat.ColumnHeadersHeight = 75;// Atur sesuai kebutuhan


            // Baris biasa
            dgRiwayat.DefaultCellStyle.BackColor = Color.FromArgb(50, 50, 50);
            dgRiwayat.DefaultCellStyle.ForeColor = Color.White;
            dgRiwayat.DefaultCellStyle.SelectionBackColor = Color.FromArgb(220, 220, 220);
            dgRiwayat.DefaultCellStyle.SelectionForeColor = Color.FromArgb(40, 40, 40);
            dgRiwayat.DefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            dgRiwayat.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Alternating row color
            dgRiwayat.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(60, 60, 60);

            // Lain-lain
            dgRiwayat.RowTemplate.Height = 70;
            dgRiwayat.AllowUserToAddRows = false;
            dgRiwayat.AllowUserToResizeRows = false;
            dgRiwayat.ReadOnly = true;

            dgRiwayat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgRiwayat.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;

            dgRiwayat.RowHeadersVisible = false;
            dgRiwayat.AllowUserToResizeColumns = false;
            dgRiwayat.AllowUserToOrderColumns = false;




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
            formBelumBayar.Show();
            this.Hide();


        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadRiwayat();

        }

        private void btnBeranda_Click(object sender, EventArgs e)
        {
            var pelanggan = new Pelanggan { id_pelanggan = _idPelanggan };

            DashboardPelanggan dashpelanggan = new DashboardPelanggan(pelanggan);
            dashpelanggan.Show();
            this.Hide();
        }

        private void btnDataDiri_Click(object sender, EventArgs e)
        {
            var pelangganid = new Pelanggan { id_pelanggan = _idPelanggan };

            EditDataDiri dataDiriPelanggan = new EditDataDiri(pelangganid.id_pelanggan);
            dataDiriPelanggan.Show();
            this.Hide();
        }

        private void LihatRiwayat_Load(object sender, EventArgs e)
        {

        }
    }
}
