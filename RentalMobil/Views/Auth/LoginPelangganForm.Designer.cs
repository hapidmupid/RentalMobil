namespace RentalMobil.Views
{
    partial class LoginPelangganForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPelangganForm));
            tbPassword = new TextBox();
            tbUsername = new TextBox();
            btnLogin = new PictureBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)btnLogin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tbPassword
            // 
            tbPassword.BorderStyle = BorderStyle.None;
            tbPassword.Font = new Font("Montserrat Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbPassword.Location = new Point(918, 417);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(415, 25);
            tbPassword.TabIndex = 0;
            // 
            // tbUsername
            // 
            tbUsername.BorderStyle = BorderStyle.None;
            tbUsername.Font = new Font("Montserrat Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbUsername.Location = new Point(918, 312);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(415, 25);
            tbUsername.TabIndex = 0;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Transparent;
            btnLogin.Image = (Image)resources.GetObject("btnLogin.Image");
            btnLogin.Location = new Point(886, 465);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(502, 120);
            btnLogin.SizeMode = PictureBoxSizeMode.Zoom;
            btnLogin.TabIndex = 1;
            btnLogin.TabStop = false;
            btnLogin.Click += btnLogin_Click_1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(902, 34);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(38, 34);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // LoginPelangganForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1442, 1023);
            Controls.Add(pictureBox1);
            Controls.Add(btnLogin);
            Controls.Add(tbUsername);
            Controls.Add(tbPassword);
            Name = "LoginPelangganForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginPelangganForm";
            Load += LoginPelangganForm_Load;
            ((System.ComponentModel.ISupportInitialize)btnLogin).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbPassword;
        private TextBox tbUsername;
        private PictureBox btnLogin;
        private PictureBox pictureBox1;
    }
}