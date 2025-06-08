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

    public partial class FormEditDataDiri : Form
    {
        private int idPelanggan;
        private PelangganController pelangganController;
        public FormEditDataDiri(int idPelanggan, string alamatSekarang)
        {
            InitializeComponent();
            this.idPelanggan = idPelanggan;
            pelangganController = new PelangganController();
            tbalamat.Text = alamatSekarang;
        }

        private void FormEditDataDiri_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbalamat.Text))
            {
                MessageBox.Show("Alamat tidak boleh kosong!", "Peringatan",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                bool success = pelangganController.UpdateAlamat(idPelanggan, tbalamat.Text.Trim());

                if (success)
                {
                    MessageBox.Show("Alamat berhasil diperbarui!", "Sukses",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Gagal memperbarui alamat!", "Error",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
