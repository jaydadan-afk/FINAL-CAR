using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FINAL_CAR
{
    public partial class CUSTOMER_BOOKING : Form
    {
        public CUSTOMER_BOOKING()
        {
            InitializeComponent();
        }




        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void CUSTOMER_BOOKING_Load(object sender, EventArgs e)
        {

        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBoxLicense.Image = Image.FromFile(openFileDialog.FileName);
    
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (pictureBoxLicense.Image == null)
            {
                MessageBox.Show("Please upload your driving license before confirming booking.", "License Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            MessageBox.Show("Booking Confirmed! Thank you.");
        }
    }
}
