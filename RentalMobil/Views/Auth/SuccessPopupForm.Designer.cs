namespace RentalMobil.Views
{
    partial class SuccessPopupForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SuccessPopupForm));
            panel1 = new Panel();
            label1 = new Label();
            label = new Label();
            btnLogin = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnLogin).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label);
            panel1.Controls.Add(btnLogin);
            panel1.Location = new Point(5, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(589, 354);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Montserrat Medium", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(124, 66);
            label1.Name = "label1";
            label1.Size = new Size(320, 25);
            label1.TabIndex = 2;
            label1.Text = "Silahkan untuk melanjutkan login";
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Montserrat Medium", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label.Location = new Point(115, 31);
            label.Name = "label";
            label.Size = new Size(344, 25);
            label.TabIndex = 1;
            label.Text = "Selamat akun anda sudah terdaftar !";
            // 
            // btnLogin
            // 
            btnLogin.Image = (Image)resources.GetObject("btnLogin.Image");
            btnLogin.Location = new Point(15, 235);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(556, 119);
            btnLogin.SizeMode = PictureBoxSizeMode.Zoom;
            btnLogin.TabIndex = 0;
            btnLogin.TabStop = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // SuccessPopupForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(600, 365);
            Controls.Add(panel1);
            Name = "SuccessPopupForm";
            Text = "SuccessPopupForm";
            Load += SuccessPopupForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnLogin).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button;
        private Label label;
        private PictureBox btnLogin;
        private Label label1;
    }
}