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
    public partial class DashboardPelanggan : Form
    {
        private readonly KendaraanController kendaraanController;
        public DashboardPelanggan()
        {
            InitializeComponent();
            kendaraanController = new KendaraanController();

            // Pasangkan event click
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;

            LoadData();

        }

        private void LoadData()
        {
            var kendaraanList = kendaraanController.GetAllKendaraan();

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "ID",
                DataPropertyName = "id_kendaraan",
                Name = "id_kendaraan"
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Merk",
                DataPropertyName = "merk",
                Name = "merk"
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Model",
                DataPropertyName = "model",
                Name = "model"
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Tahun",
                DataPropertyName = "tahun",
                Name = "tahun"
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Nomor Plat",
                DataPropertyName = "nomor_plat",
                Name = "nomor_plat"
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Harga Sewa/Hari",
                DataPropertyName = "harga_sewa_perhari",
                Name = "harga_sewa_perhari"
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Status",
                DataPropertyName = "status",
                Name = "status"
            });

            var btnSewa = new DataGridViewButtonColumn
            {
                HeaderText = "Aksi",
                Text = "Sewa",
                Name = "btnSewa",
                UseColumnTextForButtonValue = true
            };
            dataGridView1.Columns.Add(btnSewa);

            dataGridView1.DataSource = kendaraanList;

            // Styling DataGridView
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.FromArgb(120, 120, 120);
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.RowTemplate.Height = 40;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;

            dataGridView1.DataSource = kendaraanList;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dataGridView1.Columns[e.ColumnIndex].Name == "btnSewa" && e.RowIndex >= 0)
            {
                var id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id_kendaraan"].Value);
                MessageBox.Show($"Sewa kendaraan dengan ID: {id}", "Info");
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            AuthForm authForm = new AuthForm();
            this.Hide();
            authForm.Show();
        }
    }
}
