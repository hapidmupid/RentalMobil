namespace RentalMobil.Views.admin_
{
    partial class DashRiwayat
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashRiwayat));
            dgvRiwayatTransaksi = new DataGridView();
            btnLogOut = new PictureBox();
            btnLihatRiwayat = new PictureBox();
            btnKelolaTransaksi = new PictureBox();
            btnKelolaKendaraan = new PictureBox();
            btnKelolaPelanggan = new PictureBox();
            btnBeranda = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvRiwayatTransaksi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnLogOut).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnLihatRiwayat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnKelolaTransaksi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnKelolaKendaraan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnKelolaPelanggan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnBeranda).BeginInit();
            SuspendLayout();
            // 
            // dgvRiwayatTransaksi
            // 
            dgvRiwayatTransaksi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRiwayatTransaksi.Location = new Point(368, 167);
            dgvRiwayatTransaksi.Name = "dgvRiwayatTransaksi";
            dgvRiwayatTransaksi.RowHeadersWidth = 51;
            dgvRiwayatTransaksi.Size = new Size(1049, 796);
            dgvRiwayatTransaksi.TabIndex = 0;
            // 
            // btnLogOut
            // 
            btnLogOut.BackColor = Color.Transparent;
            btnLogOut.Image = (Image)resources.GetObject("btnLogOut.Image");
            btnLogOut.Location = new Point(82, 916);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(183, 36);
            btnLogOut.SizeMode = PictureBoxSizeMode.Zoom;
            btnLogOut.TabIndex = 20;
            btnLogOut.TabStop = false;
            // 
            // btnLihatRiwayat
            // 
            btnLihatRiwayat.BackColor = Color.Transparent;
            btnLihatRiwayat.Image = (Image)resources.GetObject("btnLihatRiwayat.Image");
            btnLihatRiwayat.Location = new Point(54, 422);
            btnLihatRiwayat.Name = "btnLihatRiwayat";
            btnLihatRiwayat.Size = new Size(265, 79);
            btnLihatRiwayat.SizeMode = PictureBoxSizeMode.Zoom;
            btnLihatRiwayat.TabIndex = 21;
            btnLihatRiwayat.TabStop = false;
            btnLihatRiwayat.Click += btnLihatRiwayat_Click;
            // 
            // btnKelolaTransaksi
            // 
            btnKelolaTransaksi.BackColor = Color.Transparent;
            btnKelolaTransaksi.Image = (Image)resources.GetObject("btnKelolaTransaksi.Image");
            btnKelolaTransaksi.Location = new Point(54, 337);
            btnKelolaTransaksi.Name = "btnKelolaTransaksi";
            btnKelolaTransaksi.Size = new Size(225, 94);
            btnKelolaTransaksi.SizeMode = PictureBoxSizeMode.Zoom;
            btnKelolaTransaksi.TabIndex = 22;
            btnKelolaTransaksi.TabStop = false;
            // 
            // btnKelolaKendaraan
            // 
            btnKelolaKendaraan.BackColor = Color.Transparent;
            btnKelolaKendaraan.Image = (Image)resources.GetObject("btnKelolaKendaraan.Image");
            btnKelolaKendaraan.Location = new Point(54, 268);
            btnKelolaKendaraan.Name = "btnKelolaKendaraan";
            btnKelolaKendaraan.Size = new Size(233, 96);
            btnKelolaKendaraan.SizeMode = PictureBoxSizeMode.Zoom;
            btnKelolaKendaraan.TabIndex = 23;
            btnKelolaKendaraan.TabStop = false;
            btnKelolaKendaraan.Click += btnKelolaKendaraan_Click;
            // 
            // btnKelolaPelanggan
            // 
            btnKelolaPelanggan.BackColor = Color.Transparent;
            btnKelolaPelanggan.Image = (Image)resources.GetObject("btnKelolaPelanggan.Image");
            btnKelolaPelanggan.Location = new Point(54, 195);
            btnKelolaPelanggan.Name = "btnKelolaPelanggan";
            btnKelolaPelanggan.Size = new Size(227, 112);
            btnKelolaPelanggan.SizeMode = PictureBoxSizeMode.Zoom;
            btnKelolaPelanggan.TabIndex = 24;
            btnKelolaPelanggan.TabStop = false;
            btnKelolaPelanggan.Click += btnKelolaPelanggan_Click;
            // 
            // btnBeranda
            // 
            btnBeranda.BackColor = Color.Transparent;
            btnBeranda.Image = (Image)resources.GetObject("btnBeranda.Image");
            btnBeranda.Location = new Point(54, 158);
            btnBeranda.Name = "btnBeranda";
            btnBeranda.Size = new Size(153, 42);
            btnBeranda.SizeMode = PictureBoxSizeMode.Zoom;
            btnBeranda.TabIndex = 19;
            btnBeranda.TabStop = false;
            btnBeranda.Click += btnBeranda_Click;
            // 
            // DashRiwayat
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1442, 1023);
            Controls.Add(btnLogOut);
            Controls.Add(btnLihatRiwayat);
            Controls.Add(btnKelolaTransaksi);
            Controls.Add(btnKelolaKendaraan);
            Controls.Add(btnKelolaPelanggan);
            Controls.Add(btnBeranda);
            Controls.Add(dgvRiwayatTransaksi);
            Name = "DashRiwayat";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DashRiwayat";
            Load += DashRiwayat_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRiwayatTransaksi).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnLogOut).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnLihatRiwayat).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnKelolaTransaksi).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnKelolaKendaraan).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnKelolaPelanggan).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnBeranda).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvRiwayatTransaksi;
        private PictureBox btnLogOut;
        private PictureBox btnLihatRiwayat;
        private PictureBox btnKelolaTransaksi;
        private PictureBox btnKelolaKendaraan;
        private PictureBox btnKelolaPelanggan;
        private PictureBox btnBeranda;
    }
}