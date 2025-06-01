namespace RentalMobil
{
    partial class AuthForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthForm));
            btnLoginAdmin = new PictureBox();
            btnLoginPelanggan = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)btnLoginAdmin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnLoginPelanggan).BeginInit();
            SuspendLayout();
            // 
            // btnLoginAdmin
            // 
            btnLoginAdmin.BackColor = Color.Transparent;
            btnLoginAdmin.Image = (Image)resources.GetObject("btnLoginAdmin.Image");
            btnLoginAdmin.Location = new Point(884, 441);
            btnLoginAdmin.Name = "btnLoginAdmin";
            btnLoginAdmin.Size = new Size(478, 91);
            btnLoginAdmin.SizeMode = PictureBoxSizeMode.Zoom;
            btnLoginAdmin.TabIndex = 0;
            btnLoginAdmin.TabStop = false;
            btnLoginAdmin.Click += btnLoginAdmin_Click_1;
            // 
            // btnLoginPelanggan
            // 
            btnLoginPelanggan.BackColor = Color.Transparent;
            btnLoginPelanggan.Image = (Image)resources.GetObject("btnLoginPelanggan.Image");
            btnLoginPelanggan.Location = new Point(884, 526);
            btnLoginPelanggan.Name = "btnLoginPelanggan";
            btnLoginPelanggan.Size = new Size(478, 91);
            btnLoginPelanggan.SizeMode = PictureBoxSizeMode.Zoom;
            btnLoginPelanggan.TabIndex = 1;
            btnLoginPelanggan.TabStop = false;
            btnLoginPelanggan.Click += btnLoginPelanggan_Click;
            // 
            // AuthForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1442, 1023);
            Controls.Add(btnLoginPelanggan);
            Controls.Add(btnLoginAdmin);
            Name = "AuthForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AuthForm";
            Load += AuthForm_Load;
            ((System.ComponentModel.ISupportInitialize)btnLoginAdmin).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnLoginPelanggan).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox btnLoginAdmin;
        private PictureBox btnLoginPelanggan;
    }
}
