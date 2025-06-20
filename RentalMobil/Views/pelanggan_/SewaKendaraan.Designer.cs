namespace RentalMobil.Views.pelanggan_
{
    partial class SewaKendaraan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SewaKendaraan));
            btnSewa = new PictureBox();
            btnBatal = new PictureBox();
            lblMerkModel = new Label();
            lblTahun = new Label();
            lblNoPlat = new Label();
            lblHargaPerHari = new Label();
            lblTotal = new Label();
            dtpTanggalMulai = new DateTimePicker();
            dtpTanggalSelesai = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)btnSewa).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnBatal).BeginInit();
            SuspendLayout();
            // 
            // btnSewa
            // 
            btnSewa.BackColor = Color.Transparent;
            btnSewa.Image = (Image)resources.GetObject("btnSewa.Image");
            btnSewa.Location = new Point(494, 850);
            btnSewa.Name = "btnSewa";
            btnSewa.Size = new Size(216, 50);
            btnSewa.SizeMode = PictureBoxSizeMode.Zoom;
            btnSewa.TabIndex = 0;
            btnSewa.TabStop = false;
            btnSewa.Click += btnSewa_Click;
            // 
            // btnBatal
            // 
            btnBatal.BackColor = Color.Transparent;
            btnBatal.Image = (Image)resources.GetObject("btnBatal.Image");
            btnBatal.Location = new Point(95, 850);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(216, 50);
            btnBatal.SizeMode = PictureBoxSizeMode.Zoom;
            btnBatal.TabIndex = 1;
            btnBatal.TabStop = false;
            // 
            // lblMerkModel
            // 
            lblMerkModel.AutoSize = true;
            lblMerkModel.BackColor = Color.Transparent;
            lblMerkModel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMerkModel.Location = new Point(95, 170);
            lblMerkModel.Name = "lblMerkModel";
            lblMerkModel.Size = new Size(123, 25);
            lblMerkModel.TabIndex = 2;
            lblMerkModel.Text = "merk model";
            // 
            // lblTahun
            // 
            lblTahun.AutoSize = true;
            lblTahun.BackColor = Color.Transparent;
            lblTahun.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTahun.Location = new Point(95, 275);
            lblTahun.Name = "lblTahun";
            lblTahun.Size = new Size(66, 25);
            lblTahun.TabIndex = 3;
            lblTahun.Text = "tahun";
            // 
            // lblNoPlat
            // 
            lblNoPlat.AutoSize = true;
            lblNoPlat.BackColor = Color.Transparent;
            lblNoPlat.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNoPlat.Location = new Point(95, 382);
            lblNoPlat.Name = "lblNoPlat";
            lblNoPlat.Size = new Size(82, 25);
            lblNoPlat.TabIndex = 4;
            lblNoPlat.Text = "No.Plat";
            // 
            // lblHargaPerHari
            // 
            lblHargaPerHari.AutoSize = true;
            lblHargaPerHari.BackColor = Color.Transparent;
            lblHargaPerHari.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHargaPerHari.Location = new Point(95, 485);
            lblHargaPerHari.Name = "lblHargaPerHari";
            lblHargaPerHari.Size = new Size(128, 25);
            lblHargaPerHari.TabIndex = 5;
            lblHargaPerHari.Text = "Harga / Hari";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.BackColor = Color.Transparent;
            lblTotal.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(462, 485);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(61, 25);
            lblTotal.TabIndex = 6;
            lblTotal.Text = "Total";
            // 
            // dtpTanggalMulai
            // 
            dtpTanggalMulai.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpTanggalMulai.Location = new Point(95, 589);
            dtpTanggalMulai.Name = "dtpTanggalMulai";
            dtpTanggalMulai.Size = new Size(354, 34);
            dtpTanggalMulai.TabIndex = 7;
            // 
            // dtpTanggalSelesai
            // 
            dtpTanggalSelesai.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpTanggalSelesai.Location = new Point(95, 692);
            dtpTanggalSelesai.Name = "dtpTanggalSelesai";
            dtpTanggalSelesai.Size = new Size(354, 34);
            dtpTanggalSelesai.TabIndex = 8;
            // 
            // SewaKendaraan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(798, 993);
            Controls.Add(dtpTanggalSelesai);
            Controls.Add(dtpTanggalMulai);
            Controls.Add(lblTotal);
            Controls.Add(lblHargaPerHari);
            Controls.Add(lblNoPlat);
            Controls.Add(lblTahun);
            Controls.Add(lblMerkModel);
            Controls.Add(btnBatal);
            Controls.Add(btnSewa);
            Name = "SewaKendaraan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SewaKendaraan";
            ((System.ComponentModel.ISupportInitialize)btnSewa).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnBatal).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox btnSewa;
        private PictureBox btnBatal;
        private Label lblMerkModel;
        private Label lblTahun;
        private Label lblNoPlat;
        private Label lblHargaPerHari;
        private Label lblTotal;
        private DateTimePicker dtpTanggalMulai;
        private DateTimePicker dtpTanggalSelesai;
    }
}