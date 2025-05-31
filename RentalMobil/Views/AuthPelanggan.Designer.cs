namespace RentalMobil.Views
{
    partial class AuthPelanggan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthPelanggan));
            btn_LoginPelanggan = new PictureBox();
            btn_RegisterPelanggan = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)btn_LoginPelanggan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_RegisterPelanggan).BeginInit();
            SuspendLayout();
            // 
            // btn_LoginPelanggan
            // 
            btn_LoginPelanggan.BackColor = Color.Transparent;
            btn_LoginPelanggan.Image = (Image)resources.GetObject("btn_LoginPelanggan.Image");
            btn_LoginPelanggan.Location = new Point(876, 361);
            btn_LoginPelanggan.Name = "btn_LoginPelanggan";
            btn_LoginPelanggan.Size = new Size(404, 80);
            btn_LoginPelanggan.SizeMode = PictureBoxSizeMode.Zoom;
            btn_LoginPelanggan.TabIndex = 0;
            btn_LoginPelanggan.TabStop = false;
            btn_LoginPelanggan.Click += btn_LoginPelanggan_Click;
            // 
            // btn_RegisterPelanggan
            // 
            btn_RegisterPelanggan.BackColor = Color.Transparent;
            btn_RegisterPelanggan.Image = (Image)resources.GetObject("btn_RegisterPelanggan.Image");
            btn_RegisterPelanggan.Location = new Point(876, 438);
            btn_RegisterPelanggan.Name = "btn_RegisterPelanggan";
            btn_RegisterPelanggan.Size = new Size(404, 80);
            btn_RegisterPelanggan.SizeMode = PictureBoxSizeMode.Zoom;
            btn_RegisterPelanggan.TabIndex = 0;
            btn_RegisterPelanggan.TabStop = false;
            btn_RegisterPelanggan.Click += btn_RegisterPelanggan_Click;
            // 
            // AuthPelanggan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1422, 1023);
            Controls.Add(btn_RegisterPelanggan);
            Controls.Add(btn_LoginPelanggan);
            Name = "AuthPelanggan";
            Text = "AuthPelanggan";
            ((System.ComponentModel.ISupportInitialize)btn_LoginPelanggan).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_RegisterPelanggan).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox btn_LoginPelanggan;
        private PictureBox btn_RegisterPelanggan;
    }
}