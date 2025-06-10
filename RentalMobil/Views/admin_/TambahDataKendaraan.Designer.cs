namespace RentalMobil.Views.admin_
{
    partial class TambahDataKendaraan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TambahDataKendaraan));
            btnBatal = new PictureBox();
            btnSimpan = new PictureBox();
            tbHarga = new TextBox();
            tbNoPlat = new TextBox();
            tbTahun = new TextBox();
            tbModel = new TextBox();
            tbMerk = new TextBox();
            tbStatus = new Label();
            ((System.ComponentModel.ISupportInitialize)btnBatal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnSimpan).BeginInit();
            SuspendLayout();
            // 
            // btnBatal
            // 
            btnBatal.BackColor = Color.Transparent;
            btnBatal.Image = (Image)resources.GetObject("btnBatal.Image");
            btnBatal.Location = new Point(72, 817);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(257, 81);
            btnBatal.SizeMode = PictureBoxSizeMode.Zoom;
            btnBatal.TabIndex = 1;
            btnBatal.TabStop = false;
            btnBatal.Click += btnBatal_Click;
            // 
            // btnSimpan
            // 
            btnSimpan.BackColor = Color.Transparent;
            btnSimpan.Image = (Image)resources.GetObject("btnSimpan.Image");
            btnSimpan.Location = new Point(458, 817);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(257, 81);
            btnSimpan.SizeMode = PictureBoxSizeMode.Zoom;
            btnSimpan.TabIndex = 2;
            btnSimpan.TabStop = false;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // tbHarga
            // 
            tbHarga.BorderStyle = BorderStyle.None;
            tbHarga.Font = new Font("Montserrat Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbHarga.Location = new Point(92, 590);
            tbHarga.Name = "tbHarga";
            tbHarga.Size = new Size(602, 25);
            tbHarga.TabIndex = 3;
            // 
            // tbNoPlat
            // 
            tbNoPlat.BorderStyle = BorderStyle.None;
            tbNoPlat.Font = new Font("Montserrat Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbNoPlat.Location = new Point(92, 485);
            tbNoPlat.Name = "tbNoPlat";
            tbNoPlat.Size = new Size(602, 25);
            tbNoPlat.TabIndex = 3;
            // 
            // tbTahun
            // 
            tbTahun.BorderStyle = BorderStyle.None;
            tbTahun.Font = new Font("Montserrat Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbTahun.Location = new Point(92, 378);
            tbTahun.Name = "tbTahun";
            tbTahun.Size = new Size(602, 25);
            tbTahun.TabIndex = 3;
            // 
            // tbModel
            // 
            tbModel.BorderStyle = BorderStyle.None;
            tbModel.Font = new Font("Montserrat Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbModel.Location = new Point(92, 274);
            tbModel.Name = "tbModel";
            tbModel.Size = new Size(602, 25);
            tbModel.TabIndex = 3;
            // 
            // tbMerk
            // 
            tbMerk.BorderStyle = BorderStyle.None;
            tbMerk.Font = new Font("Montserrat Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbMerk.Location = new Point(92, 171);
            tbMerk.Name = "tbMerk";
            tbMerk.Size = new Size(602, 25);
            tbMerk.TabIndex = 3;
            // 
            // tbStatus
            // 
            tbStatus.AutoSize = true;
            tbStatus.BackColor = Color.Transparent;
            tbStatus.Font = new Font("Montserrat Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbStatus.Location = new Point(92, 695);
            tbStatus.Name = "tbStatus";
            tbStatus.Size = new Size(97, 27);
            tbStatus.TabIndex = 4;
            tbStatus.Text = "Tersedia";
            // 
            // TambahDataKendaraan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(794, 994);
            Controls.Add(tbStatus);
            Controls.Add(tbMerk);
            Controls.Add(tbModel);
            Controls.Add(tbTahun);
            Controls.Add(tbNoPlat);
            Controls.Add(tbHarga);
            Controls.Add(btnBatal);
            Controls.Add(btnSimpan);
            Name = "TambahDataKendaraan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TambahDataKendaraan";
            Load += TambahDataKendaraan_Load;
            ((System.ComponentModel.ISupportInitialize)btnBatal).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnSimpan).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox btnBatal;
        private PictureBox btnSimpan;
        private TextBox tbHarga;
        private TextBox tbNoPlat;
        private TextBox tbTahun;
        private TextBox tbModel;
        private TextBox tbMerk;
        private Label tbStatus;
    }
}