using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FINAL_CAR
{
    public partial class CUSTOMER_PAYMENT : Form
    {
        bool sidebarExpand = true;

        public CUSTOMER_PAYMENT()
        {
            InitializeComponent();
            dgvPayment.AutoGenerateColumns = true;
        }

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
        }

        private void LoadPaymentsFromJson()
        {
            var bookings = JsonHelper.Load<BookingRecord>("bookings.json");
            dgvPayment.DataSource = null;
            dgvPayment.DataSource = bookings;
        }

        private void CUSTOMER_PAYMENT_Load_1(object sender, EventArgs e)
        {
            LoadPaymentsFromJson();
        }

        private void CUSTOMER_PAYMENT_Shown(object sender, EventArgs e)
        {
            LoadPaymentsFromJson();
        }

        private void CUSTOMER_PAYMENT_Activated(object sender, EventArgs e)
        {
            LoadPaymentsFromJson();
        }

        private void btnConfirmPayment_Click(object sender, EventArgs e)
        {
            if (dgvPayment.CurrentRow == null)
            {
                MessageBox.Show("Please select a booking.");
                return;
            }

            int index = dgvPayment.CurrentRow.Index;
            var bookings = JsonHelper.Load<BookingRecord>("bookings.json");

            if (bookings[index].Status == "Paid")
            {
                MessageBox.Show("This booking is already paid.");
                return;
            }

            if (MessageBox.Show("Confirm payment?", "Confirm",
                MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;

            bookings[index].Status = "Paid";
            JsonHelper.Save("bookings.json", bookings);
            LoadPaymentsFromJson();

            MessageBox.Show("Payment confirmed.");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvPayment.CurrentRow == null)
            {
                MessageBox.Show("Please select a booking.");
                return;
            }

            int index = dgvPayment.CurrentRow.Index;

            if (MessageBox.Show("Delete this booking?", "Delete",
                MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;

            var bookings = JsonHelper.Load<BookingRecord>("bookings.json");
            bookings.RemoveAt(index);
            JsonHelper.Save("bookings.json", bookings);
            LoadPaymentsFromJson();

            MessageBox.Show("Booking deleted.");
        }

        private void dgvPayment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
    }
}
