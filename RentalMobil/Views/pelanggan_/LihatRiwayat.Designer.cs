namespace RentalMobil.Views.pelanggan_
{
    partial class LihatRiwayat
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
            dgRiwayat = new DataGridView();
            btnBelumBayar = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgRiwayat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnBelumBayar).BeginInit();
            SuspendLayout();
            // 
            // dgRiwayat
            // 
            dgRiwayat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgRiwayat.Location = new Point(229, 29);
            dgRiwayat.Name = "dgRiwayat";
            dgRiwayat.RowHeadersWidth = 51;
            dgRiwayat.Size = new Size(827, 385);
            dgRiwayat.TabIndex = 0;
            dgRiwayat.CellContentClick += dgRiwayat_CellContentClick;
            // 
            // btnBelumBayar
            // 
            btnBelumBayar.Location = new Point(229, 433);
            btnBelumBayar.Name = "btnBelumBayar";
            btnBelumBayar.Size = new Size(125, 62);
            btnBelumBayar.TabIndex = 1;
            btnBelumBayar.TabStop = false;
            // 
            // LihatRiwayat
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1096, 524);
            Controls.Add(btnBelumBayar);
            Controls.Add(dgRiwayat);
            Name = "LihatRiwayat";
            Text = "LihatRiwayat";
            ((System.ComponentModel.ISupportInitialize)dgRiwayat).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnBelumBayar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgRiwayat;
        private PictureBox btnBelumBayar;
    }
}