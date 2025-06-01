namespace RentalMobil.Views.pelanggan_
{
    partial class DashboardPelanggan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardPelanggan));
            pictureBox1 = new PictureBox();
            btnLihatRiwayat = new PictureBox();
            btnLogOut = new PictureBox();
            dataGridView1 = new DataGridView();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnLihatRiwayat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnLogOut).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(58, 149);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(272, 71);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // btnLihatRiwayat
            // 
            btnLihatRiwayat.BackColor = Color.Transparent;
            btnLihatRiwayat.Image = (Image)resources.GetObject("btnLihatRiwayat.Image");
            btnLihatRiwayat.Location = new Point(58, 226);
            btnLihatRiwayat.Name = "btnLihatRiwayat";
            btnLihatRiwayat.Size = new Size(187, 40);
            btnLihatRiwayat.SizeMode = PictureBoxSizeMode.Zoom;
            btnLihatRiwayat.TabIndex = 16;
            btnLihatRiwayat.TabStop = false;
            // 
            // btnLogOut
            // 
            btnLogOut.BackColor = Color.Transparent;
            btnLogOut.Image = (Image)resources.GetObject("btnLogOut.Image");
            btnLogOut.Location = new Point(47, 692);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(1460, 1070);
            btnLogOut.SizeMode = PictureBoxSizeMode.Zoom;
            btnLogOut.TabIndex = 17;
            btnLogOut.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(367, 187);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1047, 806);
            dataGridView1.TabIndex = 18;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(80, 922);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(183, 36);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 19;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(53, 285);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(155, 35);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 16;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // DashboardPelanggan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1442, 1023);
            Controls.Add(pictureBox2);
            Controls.Add(dataGridView1);
            Controls.Add(btnLogOut);
            Controls.Add(pictureBox3);
            Controls.Add(btnLihatRiwayat);
            Controls.Add(pictureBox1);
            Name = "DashboardPelanggan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DashboardPelanggan";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnLihatRiwayat).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnLogOut).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox btnLihatRiwayat;
        private PictureBox btnLogOut;
        private DataGridView dataGridView1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}