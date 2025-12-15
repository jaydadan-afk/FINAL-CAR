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
    public partial class CUSTOMER_PAYMENT : Form
    {
        public void AddPaymentRow(
    string name,
    string contact,
    string email,
    string address,
    string car,
    int days,
    string date,
    string time,
    decimal amount)
        {
            dgvPayment.Rows.Add(
     name,
     contact,
     email,
     address,
     car,
     days,
     date,
     time,
     amount.ToString("0.00"),
     "Unpaid"
 );
        }

        bool sidebarExpand = true;

        public CUSTOMER_PAYMENT()
        {
            InitializeComponent();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvPayment.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a row to edit.");
                return;
            }

            if (dgvPayment.SelectedRows[0].Cells["Status"].Value.ToString() == "Paid")
            {
                MessageBox.Show("Paid records cannot be edited.");
                return;
            }

            MessageBox.Show("Edit logic goes here.");


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }




        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void CUSTOMER_PAYMENT_Load_1(object sender, EventArgs e)
        {

        }

        private void btnConfirmPayment_Click(object sender, EventArgs e)
        {
            if (dgvPayment.CurrentRow == null)
            {
                MessageBox.Show("Please select a booking to confirm payment.",
                                "No Selection",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow row = dgvPayment.CurrentRow;

            if (row.Cells["Status"].Value.ToString() == "Paid")
            {
                MessageBox.Show("This booking is already paid.",
                                "Info",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                return;
            }

            DialogResult result = MessageBox.Show(
                "Confirm payment for this booking?",
                "Payment Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                row.Cells["Status"].Value = "Paid";

                MessageBox.Show("Payment successfully confirmed!",
                                "Success",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
        }
        private void dgvPayment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}
