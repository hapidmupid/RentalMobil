namespace RentalMobil.Views.pelanggan_
{
    partial class BelumBayar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BelumBayar));
            npgsqlDataAdapter1 = new Npgsql.NpgsqlDataAdapter();
            dgBelumBayar = new DataGridView();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgBelumBayar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // npgsqlDataAdapter1
            // 
            npgsqlDataAdapter1.DeleteCommand = null;
            npgsqlDataAdapter1.InsertCommand = null;
            npgsqlDataAdapter1.SelectCommand = null;
            npgsqlDataAdapter1.UpdateCommand = null;
            // 
            // dgBelumBayar
            // 
            dgBelumBayar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgBelumBayar.Location = new Point(24, 159);
            dgBelumBayar.Name = "dgBelumBayar";
            dgBelumBayar.RowHeadersWidth = 51;
            dgBelumBayar.Size = new Size(1392, 709);
            dgBelumBayar.TabIndex = 0;
            dgBelumBayar.CellContentClick += dgBelumBayar_CellContentClick;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(38, 898);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(261, 78);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // BelumBayar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1442, 1023);
            Controls.Add(pictureBox1);
            Controls.Add(dgBelumBayar);
            ForeColor = SystemColors.ControlText;
            Name = "BelumBayar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BelumBayar";
            ((System.ComponentModel.ISupportInitialize)dgBelumBayar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Npgsql.NpgsqlDataAdapter npgsqlDataAdapter1;
        private DataGridView dgBelumBayar;
        private PictureBox pictureBox1;
    }
}