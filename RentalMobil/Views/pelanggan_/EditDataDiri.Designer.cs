namespace RentalMobil.Views.pelanggan_
{
    partial class EditDataDiri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditDataDiri));
            pictureBox3 = new PictureBox();
            btnLihatRiwayat = new PictureBox();
            pictureBox1 = new PictureBox();
            btnEdit = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnLihatRiwayat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnEdit).BeginInit();
            SuspendLayout();
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(46, 273);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(282, 74);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 19;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // btnLihatRiwayat
            // 
            btnLihatRiwayat.BackColor = Color.Transparent;
            btnLihatRiwayat.Image = (Image)resources.GetObject("btnLihatRiwayat.Image");
            btnLihatRiwayat.Location = new Point(62, 227);
            btnLihatRiwayat.Name = "btnLihatRiwayat";
            btnLihatRiwayat.Size = new Size(187, 40);
            btnLihatRiwayat.SizeMode = PictureBoxSizeMode.Zoom;
            btnLihatRiwayat.TabIndex = 18;
            btnLihatRiwayat.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(46, 166);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(191, 41);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.Transparent;
            btnEdit.Image = (Image)resources.GetObject("btnEdit.Image");
            btnEdit.Location = new Point(409, 632);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(217, 59);
            btnEdit.SizeMode = PictureBoxSizeMode.Zoom;
            btnEdit.TabIndex = 20;
            btnEdit.TabStop = false;
            // 
            // EditDataDiri
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1442, 1023);
            Controls.Add(btnEdit);
            Controls.Add(pictureBox3);
            Controls.Add(btnLihatRiwayat);
            Controls.Add(pictureBox1);
            Name = "EditDataDiri";
            Text = "EditDataDiri";
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnLihatRiwayat).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnEdit).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox3;
        private PictureBox btnLihatRiwayat;
        private PictureBox pictureBox1;
        private PictureBox btnEdit;
    }
}