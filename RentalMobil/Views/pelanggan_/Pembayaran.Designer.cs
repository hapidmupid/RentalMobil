namespace RentalMobil.Views.pelanggan_
{
    partial class Pembayaran
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pembayaran));
            lblIdTransaksi = new Label();
            lblMerkModel = new Label();
            lblTotalHarga = new Label();
            cbMetodeBayar = new ComboBox();
            btnBayar = new PictureBox();
            btnBayarNanti = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)btnBayar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnBayarNanti).BeginInit();
            SuspendLayout();
            // 
            // lblIdTransaksi
            // 
            lblIdTransaksi.AutoSize = true;
            lblIdTransaksi.BackColor = Color.Transparent;
            lblIdTransaksi.Font = new Font("Montserrat Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIdTransaksi.Location = new Point(99, 174);
            lblIdTransaksi.Name = "lblIdTransaksi";
            lblIdTransaksi.Size = new Size(135, 27);
            lblIdTransaksi.TabIndex = 0;
            lblIdTransaksi.Text = "ID Transaksi";
            // 
            // lblMerkModel
            // 
            lblMerkModel.AutoSize = true;
            lblMerkModel.BackColor = Color.Transparent;
            lblMerkModel.Font = new Font("Montserrat Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMerkModel.Location = new Point(99, 279);
            lblMerkModel.Name = "lblMerkModel";
            lblMerkModel.Size = new Size(132, 27);
            lblMerkModel.TabIndex = 0;
            lblMerkModel.Text = "Merk Model";
            // 
            // lblTotalHarga
            // 
            lblTotalHarga.AutoSize = true;
            lblTotalHarga.BackColor = Color.Transparent;
            lblTotalHarga.Font = new Font("Montserrat Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalHarga.Location = new Point(99, 381);
            lblTotalHarga.Name = "lblTotalHarga";
            lblTotalHarga.Size = new Size(129, 27);
            lblTotalHarga.TabIndex = 0;
            lblTotalHarga.Text = "Total Harga";
            // 
            // cbMetodeBayar
            // 
            cbMetodeBayar.FlatStyle = FlatStyle.Popup;
            cbMetodeBayar.Font = new Font("Montserrat Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbMetodeBayar.FormattingEnabled = true;
            cbMetodeBayar.Location = new Point(99, 484);
            cbMetodeBayar.Name = "cbMetodeBayar";
            cbMetodeBayar.Size = new Size(592, 35);
            cbMetodeBayar.TabIndex = 1;
            // 
            // btnBayar
            // 
            btnBayar.BackColor = Color.Transparent;
            btnBayar.Image = (Image)resources.GetObject("btnBayar.Image");
            btnBayar.Location = new Point(503, 599);
            btnBayar.Name = "btnBayar";
            btnBayar.Size = new Size(211, 73);
            btnBayar.SizeMode = PictureBoxSizeMode.Zoom;
            btnBayar.TabIndex = 2;
            btnBayar.TabStop = false;
            btnBayar.Click += btnBayar_Click;
            // 
            // btnBayarNanti
            // 
            btnBayarNanti.BackColor = Color.Transparent;
            btnBayarNanti.Image = (Image)resources.GetObject("btnBayarNanti.Image");
            btnBayarNanti.Location = new Point(74, 599);
            btnBayarNanti.Name = "btnBayarNanti";
            btnBayarNanti.Size = new Size(256, 73);
            btnBayarNanti.SizeMode = PictureBoxSizeMode.Zoom;
            btnBayarNanti.TabIndex = 2;
            btnBayarNanti.TabStop = false;
            btnBayarNanti.Click += btnBayarNanti_Click;
            // 
            // Pembayaran
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(796, 752);
            Controls.Add(btnBayarNanti);
            Controls.Add(btnBayar);
            Controls.Add(cbMetodeBayar);
            Controls.Add(lblTotalHarga);
            Controls.Add(lblMerkModel);
            Controls.Add(lblIdTransaksi);
            Name = "Pembayaran";
            Text = "Pembayaran";
            Load += Pembayaran_Load;
            ((System.ComponentModel.ISupportInitialize)btnBayar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnBayarNanti).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox cbMetodeBayar;
        private Label lblIdTransaksi;
        private Label lblMerkModel;
        private Label lblTotalHarga;

        private PictureBox btnBayar;
        private PictureBox btnBayarNanti;

    }
}