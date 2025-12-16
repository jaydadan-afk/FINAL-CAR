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
    public partial class BOOKINGS : Form
    {
        private void LoadAdminBookingsFromJson()
        {
            var bookings = JsonHelper.Load<BookingRecord>("bookings.json");

            dgvAdminBooking.DataSource = null;
            dgvAdminBooking.DataSource = bookings;
        }

        public BOOKINGS()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvPayment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BOOKINGS_Load(object sender, EventArgs e)
        {
            LoadAdminBookingsFromJson();
        }

        private void BOOKINGS_Shown(object sender, EventArgs e)
        {
            LoadAdminBookingsFromJson();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            if (dgvAdminBooking.CurrentRow == null)
            {
                MessageBox.Show("Please select a booking.");
                return;
            }

            if (dgvAdminBooking.CurrentRow.Cells["Status"].Value.ToString() == "Paid")
            {
                MessageBox.Show("This booking is already paid.");
                return;
            }

            var confirm = MessageBox.Show(
                "Confirm booking payment?",
                "Confirm",
                MessageBoxButtons.YesNo
            );

            if (confirm != DialogResult.Yes)
                return;

            var bookings = JsonHelper.Load<BookingRecord>("bookings.json");

            string customerName =
                dgvAdminBooking.CurrentRow.Cells["CustomerName"].Value.ToString();

            var booking = bookings.FirstOrDefault(b => b.CustomerName == customerName);

            if (booking != null)
            {
                booking.Status = "Paid";
                JsonHelper.Save("bookings.json", bookings);
            }

            LoadAdminBookingsFromJson();

            if (Application.OpenForms["ADMIN_CUSTOMER"] is CUSTOMERS adminCustomer)
            {
                adminCustomer.LoadAdminCustomers();
            }

            if (Application.OpenForms["CUSTOMER_PAYMENT"] is CUSTOMER_PAYMENT customerPayment)
            {
                
            }

            MessageBox.Show("Booking confirmed as PAID.");

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
              if (dgvAdminBooking.CurrentRow == null)
            {
                MessageBox.Show("Please select a booking.");
                return;
            }

            int index = dgvAdminBooking.CurrentRow.Index;

            if (MessageBox.Show("Delete this booking?", "Delete",
                MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;

            var bookings = JsonHelper.Load<BookingRecord>("bookings.json");
            bookings.RemoveAt(index);
            JsonHelper.Save("bookings.json", bookings);
            LoadAdminBookingsFromJson();

            MessageBox.Show("Booking deleted.");
        }
    }
}
