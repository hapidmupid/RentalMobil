namespace RentalMobil.Views.admin_
{
    partial class DashboardAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardAdmin));
            lblTotalKendaraan = new Label();
            lblTotalPelanggan = new Label();
            lblPendapatanBulanIni = new Label();
            dgvTransaksiTerbaru = new DataGridView();
            pictureBox1 = new PictureBox();
            btnKelolaPelanggan = new PictureBox();
            btnKelolaKendaraan = new PictureBox();
            btnLihatRiwayat = new PictureBox();
            btnLogOut = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvTransaksiTerbaru).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnKelolaPelanggan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnKelolaKendaraan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnLihatRiwayat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnLogOut).BeginInit();
            SuspendLayout();
            // 
            // lblTotalKendaraan
            // 
            lblTotalKendaraan.AutoSize = true;
            lblTotalKendaraan.BackColor = Color.Transparent;
            lblTotalKendaraan.Font = new Font("Microsoft Sans Serif", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalKendaraan.ForeColor = SystemColors.Control;
            lblTotalKendaraan.Location = new Point(560, 146);
            lblTotalKendaraan.Name = "lblTotalKendaraan";
            lblTotalKendaraan.Size = new Size(84, 91);
            lblTotalKendaraan.TabIndex = 0;
            lblTotalKendaraan.Text = "0";
            // 
            // lblTotalPelanggan
            // 
            lblTotalPelanggan.AutoSize = true;
            lblTotalPelanggan.BackColor = Color.Transparent;
            lblTotalPelanggan.Font = new Font("Microsoft Sans Serif", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalPelanggan.ForeColor = SystemColors.ControlLightLight;
            lblTotalPelanggan.Location = new Point(1112, 146);
            lblTotalPelanggan.Name = "lblTotalPelanggan";
            lblTotalPelanggan.Size = new Size(84, 91);
            lblTotalPelanggan.TabIndex = 0;
            lblTotalPelanggan.Text = "0";
            // 
            // lblPendapatanBulanIni
            // 
            lblPendapatanBulanIni.AutoSize = true;
            lblPendapatanBulanIni.BackColor = Color.Transparent;
            lblPendapatanBulanIni.Font = new Font("Microsoft Sans Serif", 19.7999973F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPendapatanBulanIni.ForeColor = SystemColors.ButtonHighlight;
            lblPendapatanBulanIni.Location = new Point(390, 369);
            lblPendapatanBulanIni.Name = "lblPendapatanBulanIni";
            lblPendapatanBulanIni.Size = new Size(346, 38);
            lblPendapatanBulanIni.TabIndex = 0;
            lblPendapatanBulanIni.Text = "Pendapatan Bulan Ini";
            // 
            // dgvTransaksiTerbaru
            // 
            dgvTransaksiTerbaru.BackgroundColor = SystemColors.WindowFrame;
            dgvTransaksiTerbaru.BorderStyle = BorderStyle.None;
            dgvTransaksiTerbaru.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
            dgvTransaksiTerbaru.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvTransaksiTerbaru.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTransaksiTerbaru.Location = new Point(368, 506);
            dgvTransaksiTerbaru.Name = "dgvTransaksiTerbaru";
            dgvTransaksiTerbaru.RowHeadersWidth = 51;
            dgvTransaksiTerbaru.Size = new Size(1049, 495);
            dgvTransaksiTerbaru.TabIndex = 1;
            dgvTransaksiTerbaru.CellContentClick += dgvTransaksiTerbaru_CellContentClick;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(52, 163);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(272, 71);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // btnKelolaPelanggan
            // 
            btnKelolaPelanggan.BackColor = Color.Transparent;
            btnKelolaPelanggan.Image = (Image)resources.GetObject("btnKelolaPelanggan.Image");
            btnKelolaPelanggan.Location = new Point(52, 226);
            btnKelolaPelanggan.Name = "btnKelolaPelanggan";
            btnKelolaPelanggan.Size = new Size(225, 94);
            btnKelolaPelanggan.SizeMode = PictureBoxSizeMode.Zoom;
            btnKelolaPelanggan.TabIndex = 3;
            btnKelolaPelanggan.TabStop = false;
            btnKelolaPelanggan.Click += btnKelolaPelanggan_Click;
            // 
            // btnKelolaKendaraan
            // 
            btnKelolaKendaraan.BackColor = Color.Transparent;
            btnKelolaKendaraan.Image = (Image)resources.GetObject("btnKelolaKendaraan.Image");
            btnKelolaKendaraan.Location = new Point(52, 300);
            btnKelolaKendaraan.Name = "btnKelolaKendaraan";
            btnKelolaKendaraan.Size = new Size(225, 94);
            btnKelolaKendaraan.SizeMode = PictureBoxSizeMode.Zoom;
            btnKelolaKendaraan.TabIndex = 3;
            btnKelolaKendaraan.TabStop = false;
            btnKelolaKendaraan.Click += btnKelolaKendaraan_Click;
            // 
            // btnLihatRiwayat
            // 
            btnLihatRiwayat.BackColor = Color.Transparent;
            btnLihatRiwayat.Image = (Image)resources.GetObject("btnLihatRiwayat.Image");
            btnLihatRiwayat.Location = new Point(52, 400);
            btnLihatRiwayat.Name = "btnLihatRiwayat";
            btnLihatRiwayat.Size = new Size(187, 40);
            btnLihatRiwayat.SizeMode = PictureBoxSizeMode.Zoom;
            btnLihatRiwayat.TabIndex = 3;
            btnLihatRiwayat.TabStop = false;
            btnLihatRiwayat.Click += btnLihatRiwayat_Click;
            // 
            // btnLogOut
            // 
            btnLogOut.BackColor = Color.Transparent;
            btnLogOut.Image = (Image)resources.GetObject("btnLogOut.Image");
            btnLogOut.Location = new Point(52, 924);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(183, 36);
            btnLogOut.SizeMode = PictureBoxSizeMode.Zoom;
            btnLogOut.TabIndex = 3;
            btnLogOut.TabStop = false;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // DashboardAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1442, 1023);
            Controls.Add(btnLogOut);
            Controls.Add(btnLihatRiwayat);
            Controls.Add(btnKelolaKendaraan);
            Controls.Add(btnKelolaPelanggan);
            Controls.Add(pictureBox1);
            Controls.Add(dgvTransaksiTerbaru);
            Controls.Add(lblPendapatanBulanIni);
            Controls.Add(lblTotalPelanggan);
            Controls.Add(lblTotalKendaraan);
            Name = "DashboardAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DashboardAdmin";
            Load += DashboardAdmin_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTransaksiTerbaru).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnKelolaPelanggan).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnKelolaKendaraan).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnLihatRiwayat).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnLogOut).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTotalKendaraan;
        private Label lblTotalPelanggan;
        private Label lblPendapatanBulanIni;
        private DataGridView dgvTransaksiTerbaru;
        private PictureBox pictureBox1;
        private PictureBox btnKelolaPelanggan;
        private PictureBox btnKelolaKendaraan;
        private PictureBox btnLihatRiwayat;
        private PictureBox btnLogOut;
    }
}