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

namespace RentalMobil.Views
{
    public partial class DashboardAdmin : Form
    {
        public DashboardAdmin()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            LoadStatistik();
            LoadTransaksiTerbaru();
            dgvTransaksiTerbaru.EnableHeadersVisualStyles = false;
            dgvTransaksiTerbaru.BackgroundColor = Color.FromArgb(80, 80, 80); // #505050
            dgvTransaksiTerbaru.GridColor = Color.FromArgb(120,120,120);
            dgvTransaksiTerbaru.BorderStyle = BorderStyle.None;

            // Header
            dgvTransaksiTerbaru.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(80, 80, 80);
            dgvTransaksiTerbaru.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvTransaksiTerbaru.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvTransaksiTerbaru.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Trik tambahan agar teks terlihat benar-benar di tengah (secara vertikal)
            dgvTransaksiTerbaru.ColumnHeadersDefaultCellStyle.Padding = new Padding(0, 15, 0, 15); // top padding bisa kamu sesuaikan

            dgvTransaksiTerbaru.ColumnHeadersHeight = 75;// Atur sesuai kebutuhan


            // Baris biasa
            dgvTransaksiTerbaru.DefaultCellStyle.BackColor = Color.FromArgb(50, 50, 50);
            dgvTransaksiTerbaru.DefaultCellStyle.ForeColor = Color.White;
            dgvTransaksiTerbaru.DefaultCellStyle.SelectionBackColor = Color.FromArgb(220,220,220);
            dgvTransaksiTerbaru.DefaultCellStyle.SelectionForeColor = Color.FromArgb(40,40,40);
            dgvTransaksiTerbaru.DefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            dgvTransaksiTerbaru.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Alternating row color
            dgvTransaksiTerbaru.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(60, 60, 60);

            // Lain-lain
            dgvTransaksiTerbaru.RowTemplate.Height = 70;
            dgvTransaksiTerbaru.AllowUserToAddRows = false;
            dgvTransaksiTerbaru.AllowUserToResizeRows = false;
            dgvTransaksiTerbaru.ReadOnly = true;

            dgvTransaksiTerbaru.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTransaksiTerbaru.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;

            dgvTransaksiTerbaru.RowHeadersVisible = false;
            dgvTransaksiTerbaru.AllowUserToResizeColumns = false;
            dgvTransaksiTerbaru.AllowUserToOrderColumns = false;

            BuatRoundedCorners(dgvTransaksiTerbaru);


        }
        private void BuatRoundedCorners(DataGridView dgv)
        {
            int radius = 25; // Ganti dengan radius sesuai keinginanmu

            var path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(dgv.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(dgv.Width - radius, dgv.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, dgv.Height - radius, radius, radius, 90, 90);
            path.CloseAllFigures();

            dgv.Region = new Region(path);
        }



        private void LoadStatistik()
        {
            using (var conn = Database.GetConnection())
            {
                conn.Open();

                // 1. Total Kendaraan Tersedia
                using (var cmd = new NpgsqlCommand("SELECT COUNT(*) FROM kendaraan WHERE status = 'tersedia'", conn))
                {
                    lblTotalKendaraan.Text = cmd.ExecuteScalar().ToString();
                }

                // 2. Total Pelanggan Terdaftar
                using (var cmd = new NpgsqlCommand("SELECT COUNT(*) FROM pelanggan", conn))
                {
                    lblTotalPelanggan.Text = cmd.ExecuteScalar().ToString();
                }

                // 3. Pendapatan Bulan Ini
                using (var cmd = new NpgsqlCommand(
                    "SELECT COALESCE(SUM(total_harga), 0) FROM transaksi " +
                    "WHERE EXTRACT(MONTH FROM tanggal_sewa) = EXTRACT(MONTH FROM CURRENT_DATE) " +
                    "AND EXTRACT(YEAR FROM tanggal_sewa) = EXTRACT(YEAR FROM CURRENT_DATE)", conn))
                {
                    decimal pendapatan = Convert.ToDecimal(cmd.ExecuteScalar());
                    lblPendapatanBulanIni.Text = pendapatan.ToString("C"); // Format currency
                }
            }
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
                    ORDER BY t.tanggal_sewa DESC
                    LIMIT 5";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    var adapter = new NpgsqlDataAdapter(cmd);
                    var dt = new DataTable();
                    adapter.Fill(dt);

                    dgvTransaksiTerbaru.DataSource = dt;

                    // Atur header kolom
                    dgvTransaksiTerbaru.Columns["id_transaksi"].HeaderText = "ID Transaksi";
                    dgvTransaksiTerbaru.Columns["pelanggan"].HeaderText = "Pelanggan";
                    dgvTransaksiTerbaru.Columns["kendaraan"].HeaderText = "Kendaraan";
                    dgvTransaksiTerbaru.Columns["tanggal_sewa"].HeaderText = "Tanggal Sewa";
                    dgvTransaksiTerbaru.Columns["tanggal_kembali"].HeaderText = "Tanggal Kembali";
                    dgvTransaksiTerbaru.Columns["total_harga"].HeaderText = "Total Harga";

                    // Format kolom harga
                    dgvTransaksiTerbaru.Columns["total_harga"].DefaultCellStyle.Format = "C";
                }
            }
        }

        // Opsional: Tambahkan timer untuk auto-refresh
        private void timerRefresh_Tick(object sender, EventArgs e)
        {
            LoadData();
        }

        private void DashboardAdmin_Load(object sender, EventArgs e)
        {

        }

        private void dgvTransaksiTerbaru_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
