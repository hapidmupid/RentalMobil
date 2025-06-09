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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LihatRiwayat));
            dgRiwayat = new DataGridView();
            pictureBox1 = new PictureBox();
            btnRefresh = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgRiwayat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnRefresh).BeginInit();
            SuspendLayout();
            // 
            // dgRiwayat
            // 
            dgRiwayat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgRiwayat.Location = new Point(367, 165);
            dgRiwayat.Name = "dgRiwayat";
            dgRiwayat.RowHeadersWidth = 51;
            dgRiwayat.Size = new Size(1052, 717);
            dgRiwayat.TabIndex = 0;
            dgRiwayat.CellContentClick += dgRiwayat_CellContentClick;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(397, 918);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(292, 61);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.Transparent;
            btnRefresh.Image = (Image)resources.GetObject("btnRefresh.Image");
            btnRefresh.Location = new Point(1330, 109);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(70, 50);
            btnRefresh.SizeMode = PictureBoxSizeMode.Zoom;
            btnRefresh.TabIndex = 2;
            btnRefresh.TabStop = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // LihatRiwayat
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1442, 1023);
            Controls.Add(btnRefresh);
            Controls.Add(pictureBox1);
            Controls.Add(dgRiwayat);
            Name = "LihatRiwayat";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LihatRiwayat";
            ((System.ComponentModel.ISupportInitialize)dgRiwayat).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnRefresh).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgRiwayat;
        private PictureBox pictureBox1;
        private PictureBox btnRefresh;
    }
}