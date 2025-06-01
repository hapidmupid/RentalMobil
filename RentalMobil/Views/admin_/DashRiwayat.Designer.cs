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
            ((System.ComponentModel.ISupportInitialize)dgvRiwayatTransaksi).BeginInit();
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
            // DashRiwayat
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1442, 1023);
            Controls.Add(dgvRiwayatTransaksi);
            Name = "DashRiwayat";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DashRiwayat";
            Load += DashRiwayat_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRiwayatTransaksi).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvRiwayatTransaksi;
    }
}