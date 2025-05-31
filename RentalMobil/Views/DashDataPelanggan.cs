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

namespace RentalMobil.Views
{
    public partial class DashDataPelanggan : Form
    {
        private PelangganController _pelangganController = new PelangganController();

        public DashDataPelanggan()
        {
            InitializeComponent();
            _pelangganController = new PelangganController();
            LoadData();
        }

        private void DashDataPelanggan_Load(object sender, EventArgs e)
        {

        }


        private void LoadData()
        {
            var pelangganList = _pelangganController.GetAllPelanggan();
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
                    bool success = _pelangganController.DeletePelanggan(id);
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

                Pelanggan pelanggan = _pelangganController.GetPelangganById(id);
                if (pelanggan != null)
                {
                    using (var editForm = new EditDataPelanggan(pelanggan))
                    {
                        if (editForm.ShowDialog() == DialogResult.OK)
                        {
                            bool success = _pelangganController.UpdatePelanggan(editForm.Pelanggan);
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
    }
}
