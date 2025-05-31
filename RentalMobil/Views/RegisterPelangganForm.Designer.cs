namespace RentalMobil.Views
{
    partial class RegisterPelangganForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterPelangganForm));
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            btnRegister = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)btnRegister).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Montserrat Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(918, 312);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(422, 25);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Montserrat Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(918, 419);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(422, 25);
            textBox2.TabIndex = 0;
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Montserrat Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(918, 523);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(422, 25);
            textBox3.TabIndex = 0;
            // 
            // textBox4
            // 
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Font = new Font("Montserrat Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox4.Location = new Point(918, 629);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(422, 25);
            textBox4.TabIndex = 0;
            // 
            // textBox5
            // 
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Font = new Font("Montserrat Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox5.Location = new Point(918, 732);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(422, 25);
            textBox5.TabIndex = 0;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.Transparent;
            btnRegister.Image = (Image)resources.GetObject("btnRegister.Image");
            btnRegister.Location = new Point(884, 787);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(495, 123);
            btnRegister.SizeMode = PictureBoxSizeMode.Zoom;
            btnRegister.TabIndex = 1;
            btnRegister.TabStop = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // RegisterPelangganForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1422, 1023);
            Controls.Add(btnRegister);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "RegisterPelangganForm";
            Text = "RegisterPelangganForm";
            Load += RegisterPelangganForm_Load;
            ((System.ComponentModel.ISupportInitialize)btnRegister).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private PictureBox btnRegister;
    }
}