using Npgsql;
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
    public partial class DashRiwayat : Form
    {
        public DashRiwayat()
        {
            InitializeComponent();
            LoadData();
        }


        private void LoadData()
        {
            LoadTransaksiTerbaru();
            dgvRiwayatTransaksi.EnableHeadersVisualStyles = false;
            dgvRiwayatTransaksi.BackgroundColor = Color.FromArgb(80, 80, 80); // #505050
            dgvRiwayatTransaksi.GridColor = Color.FromArgb(120, 120, 120);
            dgvRiwayatTransaksi.BorderStyle = BorderStyle.None;

            // Header
            dgvRiwayatTransaksi.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(80, 80, 80);
            dgvRiwayatTransaksi.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvRiwayatTransaksi.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvRiwayatTransaksi.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Trik tambahan agar teks terlihat benar-benar di tengah (secara vertikal)
            dgvRiwayatTransaksi.ColumnHeadersDefaultCellStyle.Padding = new Padding(0, 15, 0, 15); // top padding bisa kamu sesuaikan

            dgvRiwayatTransaksi.ColumnHeadersHeight = 75;// Atur sesuai kebutuhan


            // Baris biasa
            dgvRiwayatTransaksi.DefaultCellStyle.BackColor = Color.FromArgb(50, 50, 50);
            dgvRiwayatTransaksi.DefaultCellStyle.ForeColor = Color.White;
            dgvRiwayatTransaksi.DefaultCellStyle.SelectionBackColor = Color.FromArgb(220, 220, 220);
            dgvRiwayatTransaksi.DefaultCellStyle.SelectionForeColor = Color.FromArgb(40, 40, 40);
            dgvRiwayatTransaksi.DefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            dgvRiwayatTransaksi.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Alternating row color
            dgvRiwayatTransaksi.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(60, 60, 60);

            // Lain-lain
            dgvRiwayatTransaksi.RowTemplate.Height = 70;
            dgvRiwayatTransaksi.AllowUserToAddRows = false;
            dgvRiwayatTransaksi.AllowUserToResizeRows = false;
            dgvRiwayatTransaksi.ReadOnly = true;

            dgvRiwayatTransaksi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRiwayatTransaksi.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;

            dgvRiwayatTransaksi.RowHeadersVisible = false;
            dgvRiwayatTransaksi.AllowUserToResizeColumns = false;
            dgvRiwayatTransaksi.AllowUserToOrderColumns = false;


        }

        private void LoadTransaksiTerbaru()
        {
            using (var conn = Database.GetConnection())
            {
                conn.Open();

                string query = @"
                    SELECT 
                        t.id_transaksi,
                        p.nama AS pelanggan,
                        k.model AS kendaraan,
                        t.tanggal_sewa,
                        t.tanggal_kembali,
                        t.total_harga
                    FROM transaksi t
                    JOIN pelanggan p ON t.id_pelanggan = p.id_pelanggan
                    JOIN kendaraan k ON t.id_kendaraan = k.id_kendaraan
                    ORDER BY t.tanggal_sewa DESC";


                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    var adapter = new NpgsqlDataAdapter(cmd);
                    var dt = new DataTable();
                    adapter.Fill(dt);

                    dgvRiwayatTransaksi.DataSource = dt;

                    // Atur header kolom
                    dgvRiwayatTransaksi.Columns["id_transaksi"].HeaderText = "ID Transaksi";
                    dgvRiwayatTransaksi.Columns["pelanggan"].HeaderText = "Pelanggan";
                    dgvRiwayatTransaksi.Columns["kendaraan"].HeaderText = "Kendaraan";
                    dgvRiwayatTransaksi.Columns["tanggal_sewa"].HeaderText = "Tanggal Sewa";
                    dgvRiwayatTransaksi.Columns["tanggal_kembali"].HeaderText = "Tanggal Kembali";
                    dgvRiwayatTransaksi.Columns["total_harga"].HeaderText = "Total Harga";

                    // Format kolom harga
                    dgvRiwayatTransaksi.Columns["total_harga"].DefaultCellStyle.Format = "C";
                }
            }
        }



        private void DashRiwayat_Load(object sender, EventArgs e)
        {

        }

        private void btnLihatRiwayat_Click(object sender, EventArgs e)
        {

        }

        private void btnBeranda_Click(object sender, EventArgs e)
        {
            this.Hide();
            var dashboardAdmin = new DashboardAdmin();
            dashboardAdmin.Show();
        }

        private void btnKelolaPelanggan_Click(object sender, EventArgs e)
        {
            this.Hide();
            var kelolaPelanggan = new DashDataPelanggan();
            kelolaPelanggan.Show();
        }

        private void btnKelolaKendaraan_Click(object sender, EventArgs e)
        {
            this.Hide();
            var kelolaKendaraan = new DashDataKendaraan();
            kelolaKendaraan.Show();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            var authForm = new AuthForm();
            authForm.Show();
        }
    }
}
