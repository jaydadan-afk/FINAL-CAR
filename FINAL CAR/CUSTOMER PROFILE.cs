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
            txtCustomerName.ReadOnly = true;
            txtContact.ReadOnly = true;
            txtEmail.ReadOnly = true;
            txtAddress.ReadOnly = true;
        }
        private void SetTextBoxesReadOnly(bool isReadOnly)
        {
            txtCustomerName.ReadOnly = isReadOnly;
            txtContact.ReadOnly = isReadOnly;
            txtEmail.ReadOnly = isReadOnly;
            txtAddress.ReadOnly = isReadOnly;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            SetTextBoxesReadOnly(false);
            btnSave.Enabled = true;
            btnEdit.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SetTextBoxesReadOnly(true);
            btnSave.Enabled = false;
            btnEdit.Enabled = true;

            MessageBox.Show("Profile updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtCustomerName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
           
        }
    }

}
