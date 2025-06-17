using RentalMobil.Controller;
using RentalMobil.Models;
using RentalMobil.Views.admin_;
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
    public partial class DashDataPelanggan : Form
    {
        private PelangganController pelangganController = new PelangganController();

        public DashDataPelanggan()
        {
            InitializeComponent();
            pelangganController = new PelangganController();
            LoadData();
        }

        private void DashDataPelanggan_Load(object sender, EventArgs e)
        {

        }


        private void LoadData()
        {
            var pelangganList = pelangganController.GetAllPelanggan();

            // Nonaktifkan auto generate
            dgvPelanggan.AutoGenerateColumns = false;

            // Clear dulu kolomnya
            dgvPelanggan.Columns.Clear();

            // Tambahkan kolom yang diinginkan
            dgvPelanggan.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "ID",
                DataPropertyName = "id_pelanggan",
                Name = "id_pelanggan",
                Width = 50
            });

            dgvPelanggan.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Email",
                DataPropertyName = "email",
                Name = "email"
            });

            dgvPelanggan.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Nama",
                DataPropertyName = "nama",
                Name = "nama"
            });

            dgvPelanggan.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Alamat",
                DataPropertyName = "alamat",
                Name = "alamat"
            });

            dgvPelanggan.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "No. Telepon",
                DataPropertyName = "no_telp",
                Name = "no_telp"
            });

            dgvPelanggan.EnableHeadersVisualStyles = false;
            dgvPelanggan.BackgroundColor = Color.FromArgb(80, 80, 80); // #505050
            dgvPelanggan.GridColor = Color.FromArgb(120, 120, 120);
            dgvPelanggan.BorderStyle = BorderStyle.None;

            // Header
            dgvPelanggan.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(80, 80, 80);
            dgvPelanggan.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvPelanggan.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvPelanggan.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Trik tambahan agar teks terlihat benar-benar di tengah (secara vertikal)
            dgvPelanggan.ColumnHeadersDefaultCellStyle.Padding = new Padding(0, 15, 0, 15); // top padding bisa kamu sesuaikan

            dgvPelanggan.ColumnHeadersHeight = 75;// Atur sesuai kebutuhan


            // Baris biasa
            dgvPelanggan.DefaultCellStyle.BackColor = Color.FromArgb(50, 50, 50);
            dgvPelanggan.DefaultCellStyle.ForeColor = Color.White;
            dgvPelanggan.DefaultCellStyle.SelectionBackColor = Color.FromArgb(220, 220, 220);
            dgvPelanggan.DefaultCellStyle.SelectionForeColor = Color.FromArgb(40, 40, 40);
            dgvPelanggan.DefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            dgvPelanggan.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Alternating row color
            dgvPelanggan.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(60, 60, 60);

            // Lain-lain
            dgvPelanggan.RowTemplate.Height = 70;
            dgvPelanggan.AllowUserToAddRows = false;
            dgvPelanggan.AllowUserToResizeRows = false;
            dgvPelanggan.ReadOnly = true;

            //dgvPelanggan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPelanggan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dgvPelanggan.Columns["email"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvPelanggan.Columns["nama"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvPelanggan.Columns["alamat"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvPelanggan.Columns["no_telp"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


            dgvPelanggan.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;

            //dgvPelanggan.RowHeadersVisible = false;
            dgvPelanggan.AllowUserToResizeColumns = false;
            dgvPelanggan.AllowUserToOrderColumns = false;

            dgvPelanggan.DataSource = pelangganList;
        }


        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (dgvPelanggan.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvPelanggan.SelectedRows[0];
                int id = Convert.ToInt32(selectedRow.Cells["id_pelanggan"].Value);

                DialogResult result = MessageBox.Show(
                    "Apakah Anda yakin ingin menghapus pelanggan ini?",
                    "Konfirmasi Hapus",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    bool success = pelangganController.DeletePelanggan(id);
                    if (success)
                    {
                        MessageBox.Show("Pelanggan berhasil dihapus", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Gagal menghapus pelanggan", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Pilih pelanggan yang akan dihapus", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvPelanggan.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvPelanggan.SelectedRows[0];
                int id = Convert.ToInt32(selectedRow.Cells["id_pelanggan"].Value);

                Pelanggan pelanggan = pelangganController.GetPelangganById(id);
                if (pelanggan != null)
                {
                    using (var editForm = new EditDataPelanggan(pelanggan))
                    {
                        if (editForm.ShowDialog() == DialogResult.OK)
                        {
                            bool success = pelangganController.UpdatePelanggan(editForm.Pelanggan);
                            if (success)
                            {
                                MessageBox.Show("Data pelanggan berhasil diperbarui", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LoadData();
                            }
                            else
                            {
                                MessageBox.Show("Gagal memperbarui data pelanggan", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Pilih pelanggan yang akan diedit", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnBeranda_Click(object sender, EventArgs e)
        {
            this.Hide();
            var dashboardAdmin = new DashboardAdmin();
            dashboardAdmin.Show();
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

        private void btnLihatRiwayat_Click(object sender, EventArgs e)
        {
            this.Hide();
            var riwayatTransaksi = new DashRiwayat();
            riwayatTransaksi.Show();
        }
    }
}
