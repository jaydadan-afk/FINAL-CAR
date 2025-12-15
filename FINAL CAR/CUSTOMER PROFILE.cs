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
    public partial class CUSTOMER_PROFILE : Form
    {
        public CUSTOMER_PROFILE()
        {
            InitializeComponent();

         
            SetProfileReadOnly(true);
        }


        private void SetProfileReadOnly(bool isReadOnly)
        {
            txtCustomerName.ReadOnly = isReadOnly;
            txtNumber.ReadOnly = isReadOnly;
            txtEmail.ReadOnly = isReadOnly;
            txtAddress.ReadOnly = isReadOnly;

            btnSave.Enabled = !isReadOnly;
        }


        private void btnEdit_Click(object sender, EventArgs e)
        {
            SetProfileReadOnly(false);

            MessageBox.Show(
                "You can now update your profile.",
                "Edit Profile",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCustomerName.Text) ||
                string.IsNullOrWhiteSpace(txtNumber.Text))
            {
                MessageBox.Show(
                    "Customer Name and Contact are required.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            SetProfileReadOnly(true);

            MessageBox.Show(
                "Profile updated successfully.",
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void txtCustomerName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Redirecting to Booking / Payment page...",
                "Navigation",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );


        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
