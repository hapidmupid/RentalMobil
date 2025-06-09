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
    public partial class Pembayaran : Form
    {
        private readonly int _idTransaksi;
        private readonly decimal _totalHarga;
        private readonly string _merkModel;

        // Declare missing fields
        private Label lblIdTransaksi;
        private Label lblMerkModel;
        private Label lblTotalHarga;
        //private ComboBox cbMetodeBayar;
        private Button btnBayar;

        public Pembayaran(int idTransaksi, decimal totalHarga, string merkModel)
        {
            InitializeComponent();
            _idTransaksi = idTransaksi;
            _totalHarga = totalHarga;
            _merkModel = merkModel;

            // Inisialisasi kontrol
            lblIdTransaksi = new Label();
            lblMerkModel = new Label();
            lblTotalHarga = new Label();
            cbMetodeBayar = new ComboBox();
            btnBayar = new Button();

            // Atur properti untuk semua kontrol
            // 1. Label ID Transaksi
            lblIdTransaksi.Location = new Point(20, 20);
            lblIdTransaksi.AutoSize = true;

            // 2. Label Merk Model
            lblMerkModel.Location = new Point(20, 50);
            lblMerkModel.AutoSize = true;

            // 3. Label Total Harga
            lblTotalHarga.Location = new Point(20, 80);
            lblTotalHarga.AutoSize = true;
            lblTotalHarga.Font = new Font(lblTotalHarga.Font, FontStyle.Bold);

            // 4. ComboBox Metode Bayar
            cbMetodeBayar.Location = new Point(20, 110);
            cbMetodeBayar.Size = new Size(200, 25);
            cbMetodeBayar.DropDownStyle = ComboBoxStyle.DropDownList;
            cbMetodeBayar.Items.AddRange(new string[] { "Transfer Bank", "Kartu Kredit", "E-Wallet" });

            // 5. Button Bayar
            btnBayar.Location = new Point(20, 150);
            btnBayar.Size = new Size(100, 30);
            btnBayar.Text = "Bayar";
            btnBayar.Click += button1_Click; // Hubungkan dengan event handler

            // Tambahkan semua kontrol ke form
            this.Controls.Add(lblIdTransaksi);
            this.Controls.Add(lblMerkModel);
            this.Controls.Add(lblTotalHarga);
            this.Controls.Add(cbMetodeBayar);
            this.Controls.Add(btnBayar);

            // Tampilkan data
            lblMerkModel.Text = _merkModel;
            lblTotalHarga.Text = _totalHarga.ToString("C");
            lblIdTransaksi.Text = $"ID Transaksi: {_idTransaksi}";

            // Atur ukuran form
            this.ClientSize = new Size(250, 200);
            this.Text = "Pembayaran";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            if (cbMetodeBayar.SelectedItem == null)
            {
                MessageBox.Show("Pilih metode pembayaran!");
                return;
            }

            string metodeBayar = cbMetodeBayar.SelectedItem.ToString();

            // Simpan ke database
            var pembayaranController = new PembayaranController();
            bool success = pembayaranController.CreatePembayaran(
                _idTransaksi,
                _totalHarga,
                metodeBayar
            );

            if (success)
            {
                MessageBox.Show($"Pembayaran {_totalHarga:C} via {metodeBayar} berhasil!", "Sukses");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
