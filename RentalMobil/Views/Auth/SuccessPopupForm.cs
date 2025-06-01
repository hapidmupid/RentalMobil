using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentalMobil.Views
{
    public partial class SuccessPopupForm : Form
    {
        public SuccessPopupForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }



        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginPelangganForm dashboard = new LoginPelangganForm();
            dashboard.Show();
            
        }

        private void SuccessPopupForm_Load(object sender, EventArgs e)
        {

        }
    }
}
