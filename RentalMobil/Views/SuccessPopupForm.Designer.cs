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
            button = new Button();
            label = new Label();
            pictureBox = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button);
            panel1.Controls.Add(label);
            panel1.Controls.Add(pictureBox);
            panel1.Location = new Point(5, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(589, 354);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // button
            // 
            button.Location = new Point(146, 216);
            button.Name = "button";
            button.Size = new Size(164, 59);
            button.TabIndex = 2;
            button.Text = "button1";
            button.UseVisualStyleBackColor = true;
            button.Click += button_Click;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(100, 156);
            label.Name = "label";
            label.Size = new Size(50, 20);
            label.TabIndex = 1;
            label.Text = "label1";
            // 
            // pictureBox
            // 
            pictureBox.Image = (Image)resources.GetObject("pictureBox.Image");
            pictureBox.Location = new Point(71, 24);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(408, 95);
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;
            // 
            // SuccessPopupForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 365);
            Controls.Add(panel1);
            Name = "SuccessPopupForm";
            Text = "SuccessPopupForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button;
        private Label label;
        private PictureBox pictureBox;
    }
}