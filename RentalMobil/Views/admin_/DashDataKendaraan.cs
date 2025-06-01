using Npgsql;
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
    public partial class DashDataKendaraan : Form
    {
        private KendaraanController kendaraanController = new KendaraanController();
        public DashDataKendaraan()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            var kendaraanList = kendaraanController.GetAllKendaraan();

            // Konfigurasi DataGridView
            dgvKendaraan.AutoGenerateColumns = false;
            dgvKendaraan.Columns.Clear();

            // Tambahkan kolom
            dgvKendaraan.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "ID",
                DataPropertyName = "id_kendaraan",
                Name = "id_kendaraan",

            });

            dgvKendaraan.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Merk",
                DataPropertyName = "merk",
                Name = "merk"
            });

            dgvKendaraan.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Model",
                DataPropertyName = "model",
                Name = "model"
            });

            dgvKendaraan.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Tahun",
                DataPropertyName = "tahun",
                Name = "tahun"
            });

            dgvKendaraan.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Nomor Plat",
                DataPropertyName = "nomor_plat",
                Name = "nomor_plat"
            });

            dgvKendaraan.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Harga Sewa/Hari",
                DataPropertyName = "harga_sewa_perhari",
                Name = "harga_sewa_perhari"
            });

            dgvKendaraan.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Status",
                DataPropertyName = "status",
                Name = "status"
            });

            // Styling DataGridView
            dgvKendaraan.EnableHeadersVisualStyles = false;
            dgvKendaraan.GridColor = Color.FromArgb(120, 120, 120);
            dgvKendaraan.BorderStyle = BorderStyle.None;
            dgvKendaraan.RowTemplate.Height = 40;
            dgvKendaraan.AllowUserToAddRows = false;
            dgvKendaraan.AllowUserToResizeRows = false;
            dgvKendaraan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKendaraan.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;

            dgvKendaraan.DataSource = kendaraanList;
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            using (var tambahForm = new TambahDataKendaraan())
            {
                if (tambahForm.ShowDialog() == DialogResult.OK)
                {
                    bool success = kendaraanController.AddKendaraan(tambahForm.Kendaraan);
                    if (success)
                    {
                        MessageBox.Show("Kendaraan berhasil ditambahkan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Gagal menambahkan kendaraan", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (dgvKendaraan.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvKendaraan.SelectedRows[0];
                int id = Convert.ToInt32(selectedRow.Cells["id_kendaraan"].Value);

                DialogResult result = MessageBox.Show(
                    "Apakah Anda yakin ingin menghapus kendaraan ini?",
                    "Konfirmasi Hapus",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        bool success = kendaraanController.DeleteKendaraan(id);
                        if (success)
                        {
                            MessageBox.Show("Kendaraan berhasil dihapus", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadData();
                        }
                        else
                        {
                            MessageBox.Show("Gagal menghapus kendaraan", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (PostgresException ex) when (ex.SqlState == "23503")
                    {
                        MessageBox.Show("Data kendaraan ini masih memiliki riwayat transaksi dan tidak bisa dihapus.",
                                        "Gagal Menghapus",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Terjadi kesalahan: " + ex.Message,
                                        "Error",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Pilih kendaraan yang akan dihapus", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvKendaraan.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvKendaraan.SelectedRows[0];
                int id = Convert.ToInt32(selectedRow.Cells["id_kendaraan"].Value);

                Kendaraan kendaraan = kendaraanController.GetKendaraanById(id);
                if (kendaraan != null)
                {
                    using (var editForm = new EditDataKendaraan(kendaraan))
                    {
                        if (editForm.ShowDialog() == DialogResult.OK)
                        {
                            bool success = kendaraanController.UpdateKendaraan(editForm.Kendaraan);
                            if (success)
                            {
                                MessageBox.Show("Data kendaraan berhasil diperbarui", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LoadData();
                            }
                            else
                            {
                                MessageBox.Show("Gagal memperbarui data kendaraan", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Pilih kendaraan yang akan diedit", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
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
    }
}
