namespace RentalMobil.Views.admin_
{
    partial class EditDataPelanggan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditDataPelanggan));
            btnSimpan = new PictureBox();
            tbNama = new TextBox();
            tbEmail = new TextBox();
            tbAlamat = new TextBox();
            tbNoTelp = new TextBox();
            btnBatal = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)btnSimpan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnBatal).BeginInit();
            SuspendLayout();
            // 
            // btnSimpan
            // 
            btnSimpan.BackColor = Color.Transparent;
            btnSimpan.Image = (Image)resources.GetObject("btnSimpan.Image");
            btnSimpan.Location = new Point(457, 626);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(257, 81);
            btnSimpan.SizeMode = PictureBoxSizeMode.Zoom;
            btnSimpan.TabIndex = 0;
            btnSimpan.TabStop = false;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // tbNama
            // 
            tbNama.BorderStyle = BorderStyle.None;
            tbNama.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbNama.Location = new Point(91, 170);
            tbNama.Name = "tbNama";
            tbNama.Size = new Size(602, 23);
            tbNama.TabIndex = 1;
            // 
            // tbEmail
            // 
            tbEmail.BorderStyle = BorderStyle.None;
            tbEmail.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbEmail.Location = new Point(91, 275);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(602, 23);
            tbEmail.TabIndex = 1;
            // 
            // tbAlamat
            // 
            tbAlamat.BorderStyle = BorderStyle.None;
            tbAlamat.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbAlamat.Location = new Point(91, 382);
            tbAlamat.Name = "tbAlamat";
            tbAlamat.Size = new Size(602, 23);
            tbAlamat.TabIndex = 1;
            // 
            // tbNoTelp
            // 
            tbNoTelp.BorderStyle = BorderStyle.None;
            tbNoTelp.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbNoTelp.Location = new Point(91, 485);
            tbNoTelp.Name = "tbNoTelp";
            tbNoTelp.Size = new Size(602, 23);
            tbNoTelp.TabIndex = 1;
            // 
            // btnBatal
            // 
            btnBatal.BackColor = Color.Transparent;
            btnBatal.Image = (Image)resources.GetObject("btnBatal.Image");
            btnBatal.Location = new Point(71, 626);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(257, 81);
            btnBatal.SizeMode = PictureBoxSizeMode.Zoom;
            btnBatal.TabIndex = 0;
            btnBatal.TabStop = false;
            btnBatal.Click += btnBatal_Click;
            // 
            // EditDataPelanggan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(799, 771);
            Controls.Add(tbNoTelp);
            Controls.Add(tbAlamat);
            Controls.Add(tbEmail);
            Controls.Add(tbNama);
            Controls.Add(btnBatal);
            Controls.Add(btnSimpan);
            Name = "EditDataPelanggan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditDataPelanggan";
            Load += EditDataPelanggan_Load;
            ((System.ComponentModel.ISupportInitialize)btnSimpan).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnBatal).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox btnSimpan;
        private TextBox tbNama;
        private TextBox tbEmail;
        private TextBox tbAlamat;
        private TextBox tbNoTelp;
        private PictureBox btnBatal;
    }
}