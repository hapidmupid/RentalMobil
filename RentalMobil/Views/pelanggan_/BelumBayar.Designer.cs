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
            npgsqlDataAdapter1 = new Npgsql.NpgsqlDataAdapter();
            dgBelumBayar = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgBelumBayar).BeginInit();
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
            dgBelumBayar.Location = new Point(212, 57);
            dgBelumBayar.Name = "dgBelumBayar";
            dgBelumBayar.RowHeadersWidth = 51;
            dgBelumBayar.Size = new Size(498, 257);
            dgBelumBayar.TabIndex = 0;
            dgBelumBayar.CellContentClick += dgBelumBayar_CellContentClick;
            // 
            // BelumBayar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgBelumBayar);
            Name = "BelumBayar";
            Text = "BelumBayar";
            ((System.ComponentModel.ISupportInitialize)dgBelumBayar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Npgsql.NpgsqlDataAdapter npgsqlDataAdapter1;
        private DataGridView dgBelumBayar;
    }
}