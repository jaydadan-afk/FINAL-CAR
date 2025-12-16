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
    public partial class CUSTOMERS : Form
    {

        public void LoadAdminCustomers()
        {
            var bookings = JsonHelper.Load<BookingRecord>("bookings.json");

            dgvCustomer.DataSource = null;
            dgvCustomer.DataSource = bookings;
        }


        public CUSTOMERS()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CUSTOMERS_Load(object sender, EventArgs e)
        {
            LoadAdminCustomers();
        }
    }
}
