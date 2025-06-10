namespace RentalMobil.Views
{
    partial class LoginAdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginAdminForm));
            btnSignIn = new PictureBox();
            tbPassword = new TextBox();
            tbUsername = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)btnSignIn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnSignIn
            // 
            btnSignIn.BackColor = Color.Transparent;
            btnSignIn.Image = (Image)resources.GetObject("btnSignIn.Image");
            btnSignIn.Location = new Point(884, 481);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(497, 101);
            btnSignIn.SizeMode = PictureBoxSizeMode.StretchImage;
            btnSignIn.TabIndex = 0;
            btnSignIn.TabStop = false;
            btnSignIn.Click += btnSignIn_Click;
            // 
            // tbPassword
            // 
            tbPassword.BorderStyle = BorderStyle.None;
            tbPassword.Font = new Font("Montserrat Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbPassword.Location = new Point(916, 416);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(437, 25);
            tbPassword.TabIndex = 1;
            // 
            // tbUsername
            // 
            tbUsername.BorderStyle = BorderStyle.None;
            tbUsername.Font = new Font("Montserrat Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbUsername.Location = new Point(916, 311);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(437, 25);
            tbUsername.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(905, 44);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(38, 34);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // LoginAdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1442, 1023);
            Controls.Add(pictureBox1);
            Controls.Add(tbUsername);
            Controls.Add(tbPassword);
            Controls.Add(btnSignIn);
            Name = "LoginAdminForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginAdminForm";
            ((System.ComponentModel.ISupportInitialize)btnSignIn).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox btnSignIn;
        private TextBox tbPassword;
        private TextBox tbUsername;
        private PictureBox pictureBox1;
    }
}