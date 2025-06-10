//using RentalMobil.Controller;
//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

//namespace RentalMobil.Views.pelanggan_
//{
//    public partial class BelumBayar : Form
//    {
//        private readonly int _idPelanggan;
//        private readonly TransaksiController _transaksiController;
//        private DataGridView dgRiwayat; // Fix: Change 'object' to 'DataGridView'  

//        public BelumBayar(int idPelanggan)
//        {
//            InitializeComponent();
//            _idPelanggan = idPelanggan;
//            _transaksiController = new TransaksiController();

//            // Initialize DataGridView  
//            dgRiwayat = new DataGridView();
//            dgRiwayat.AutoGenerateColumns = true;
//            dgRiwayat.ReadOnly = true;
//            dgRiwayat.AllowUserToAddRows = false;
//            dgRiwayat.AllowUserToDeleteRows = false;

//            LoadRiwayat();
//        }

//        private void LoadRiwayat()
//        {
//            try
//            {
//                DataTable dataRiwayat = _transaksiController.GetTransaksiBelumBayar(_idPelanggan);
//                dgRiwayat.DataSource = dataRiwayat;

//                if (dgRiwayat.Columns.Contains("total_harga"))
//                {
//                    dgRiwayat.Columns["total_harga"].DefaultCellStyle.Format = "C";
//                    dgRiwayat.Columns["total_harga"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
//                }

//                if (dgRiwayat.Columns.Contains("id_transaksi"))
//                    dgRiwayat.Columns["id_transaksi"].HeaderText = "ID Transaksi";
//                if (dgRiwayat.Columns.Contains("kendaraan"))
//                    dgRiwayat.Columns["kendaraan"].HeaderText = "Kendaraan";
//                if (dgRiwayat.Columns.Contains("tanggal_sewa"))
//                    dgRiwayat.Columns["tanggal_sewa"].HeaderText = "Tanggal Sewa";
//                if (dgRiwayat.Columns.Contains("tanggal_kembali"))
//                    dgRiwayat.Columns["tanggal_kembali"].HeaderText = "Tanggal Kembali";
//                if (dgRiwayat.Columns.Contains("status_pembayaran"))
//                    dgRiwayat.Columns["status_pembayaran"].HeaderText = "Status Pembayaran";

//                if (dataRiwayat.Rows.Count == 0)
//                {
//                    MessageBox.Show("Tidak ada transaksi belum lunas.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
//                }
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show($"Gagal memuat data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
//            }
//        }

//        private void dgBelumBayar_CellContentClick(object sender, DataGridViewCellEventArgs e)
//        {

//        }
//    }
//}





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
    public partial class BelumBayar : Form
    {
        private readonly int _idPelanggan;
        private readonly TransaksiController _transaksiController;

        public BelumBayar(int idPelanggan)
        {
            InitializeComponent();
            _idPelanggan = idPelanggan;
            _transaksiController = new TransaksiController();
            // Atur DataGridView
            dgBelumBayar.AutoGenerateColumns = true;
            dgBelumBayar.ReadOnly = true;
            dgBelumBayar.AllowUserToAddRows = false;
            dgBelumBayar.AllowUserToDeleteRows = false;

            // Tambahkan kolom tombol Bayar
            DataGridViewButtonColumn btnBayar = new DataGridViewButtonColumn();
            btnBayar.Name = "Bayar";
            btnBayar.Text = "Bayar";
            btnBayar.UseColumnTextForButtonValue = true;
            dgBelumBayar.Columns.Add(btnBayar);

            LoadRiwayat();
        }

        private void LoadRiwayat()
        {

            // Styling DataGridView
            dgBelumBayar.EnableHeadersVisualStyles = false;
            dgBelumBayar.BackgroundColor = Color.FromArgb(80, 80, 80); // #505050
            dgBelumBayar.GridColor = Color.FromArgb(120, 120, 120);
            dgBelumBayar.BorderStyle = BorderStyle.None;

            // Header
            dgBelumBayar.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(80, 80, 80);
            dgBelumBayar.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgBelumBayar.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgBelumBayar.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Trik tambahan agar teks terlihat benar-benar di tengah (secara vertikal)
            dgBelumBayar.ColumnHeadersDefaultCellStyle.Padding = new Padding(0, 15, 0, 15); // top padding bisa kamu sesuaikan

            dgBelumBayar.ColumnHeadersHeight = 75;// Atur sesuai kebutuhan


            // Baris biasa
            dgBelumBayar.DefaultCellStyle.BackColor = Color.FromArgb(50, 50, 50);
            dgBelumBayar.DefaultCellStyle.ForeColor = Color.White;
            dgBelumBayar.DefaultCellStyle.SelectionBackColor = Color.FromArgb(220, 220, 220);
            dgBelumBayar.DefaultCellStyle.SelectionForeColor = Color.FromArgb(40, 40, 40);
            dgBelumBayar.DefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            dgBelumBayar.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Alternating row color
            dgBelumBayar.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(60, 60, 60);

            // Lain-lain
            dgBelumBayar.RowTemplate.Height = 70;
            dgBelumBayar.AllowUserToAddRows = false;
            dgBelumBayar.AllowUserToResizeRows = false;
            dgBelumBayar.ReadOnly = true;

            dgBelumBayar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgBelumBayar.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;

            dgBelumBayar.RowHeadersVisible = false;
            dgBelumBayar.AllowUserToResizeColumns = false;
            dgBelumBayar.AllowUserToOrderColumns = false;


            try
            {
                DataTable dataRiwayat = _transaksiController.GetTransaksiBelumBayar(_idPelanggan);
                dgBelumBayar.DataSource = dataRiwayat;

                if (dgBelumBayar.Columns.Contains("total_harga"))
                {
                    dgBelumBayar.Columns["total_harga"].DefaultCellStyle.Format = "C";
                    dgBelumBayar.Columns["total_harga"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }

                if (dgBelumBayar.Columns.Contains("id_transaksi"))
                    dgBelumBayar.Columns["id_transaksi"].HeaderText = "ID Transaksi";
                if (dgBelumBayar.Columns.Contains("kendaraan"))
                    dgBelumBayar.Columns["kendaraan"].HeaderText = "Kendaraan";
                if (dgBelumBayar.Columns.Contains("tanggal_sewa"))
                    dgBelumBayar.Columns["tanggal_sewa"].HeaderText = "Tanggal Sewa";
                if (dgBelumBayar.Columns.Contains("tanggal_kembali"))
                    dgBelumBayar.Columns["tanggal_kembali"].HeaderText = "Tanggal Kembali";
                if (dgBelumBayar.Columns.Contains("status_pembayaran"))
                    dgBelumBayar.Columns["status_pembayaran"].HeaderText = "Status Pembayaran";

                if (dataRiwayat.Rows.Count == 0)
                {
                    MessageBox.Show("Tidak ada transaksi belum lunas.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal memuat data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgBelumBayar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgBelumBayar.Columns["Bayar"].Index && e.RowIndex >= 0)
            {
                int idTransaksi = Convert.ToInt32(dgBelumBayar.Rows[e.RowIndex].Cells["id_transaksi"].Value);
                decimal totalHarga = Convert.ToDecimal(dgBelumBayar.Rows[e.RowIndex].Cells["total_harga"].Value);


                string merkModel = dgBelumBayar.Rows[e.RowIndex].Cells["kendaraan"].Value.ToString();

                // Simplify 'new' expression as per IDE0090
                var formPembayaran = new Pembayaran(idTransaksi, totalHarga, merkModel);

                if (formPembayaran.ShowDialog() == DialogResult.OK)
                {
                    LoadRiwayat();
                }

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var formRiwayat = new LihatRiwayat(_idPelanggan);
            formRiwayat.Show();
            this.Hide();
        }
    }
}