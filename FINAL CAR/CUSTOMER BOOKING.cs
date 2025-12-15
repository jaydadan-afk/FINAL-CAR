using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace FINAL_CAR
{
    public partial class CUSTOMER_BOOKING : Form
    {
        private CUSTOMER_PAYMENT _paymentForm;
        
        public string CustomerName { get; set; }
        public string Contact { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public CUSTOMER_BOOKING(CUSTOMER_PAYMENT paymentForm)
        {
            InitializeComponent();
            _paymentForm = paymentForm;
        }



        private void CUSTOMER_BOOKING_Load(object sender, EventArgs e)
        {
            txtCustomerName.Text = CustomerName;
            txtContact.Text = Contact;
            txtEmail.Text = Email;
            txtAddress.Text = Address;
            comboCar.Items.AddRange(new string[] { "Toyota Camry", "Honda Civic", "Ford Ranger", "Mitsubishi Montero", "Nissan Altima" });

            if (comboCar.Items.Count > 0)
                comboCar.SelectedIndex = 0;
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog(); openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png"; if (openFileDialog.ShowDialog() == DialogResult.OK) { pictureBoxLicense.Image = Image.FromFile(openFileDialog.FileName); }

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            decimal totalAmount = CalculateTotalAmount();
            txtAmount.Text = totalAmount.ToString("0.00");


            _paymentForm.AddPaymentRow(
        txtCustomerName.Text,
        txtContact.Text,
        txtEmail.Text,
        txtAddress.Text,
        comboCar.Text,
        (int)numericDays.Value,
        datePickup.Value.ToShortDateString(),
        dateTime.Value.ToShortTimeString(),
        totalAmount
    );

            MessageBox.Show(
                "Booking confirmed!\nCheck the Payment tab.",
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void txtCustomerName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtContact_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAddress_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void date_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTime_ValueChanged(object sender, EventArgs e)
        {

        }
        private decimal CalculateTotalAmount()
        {
            decimal total = 0;

            switch (comboCar.Text)
            {
                case "Toyota Camry":
                    total = 1500m;
                    break;
                case "Honda Civic":
                    total = 1200m;
                    break;
                case "Ford Ranger":
                    total = 2000m;
                    break;
                case "Mitsubishi Montero":
                    total = 2500m;
                    break;
                case "Nissan Altima":
                    total = 1300m;
                    break;
                default:
                    total = 0;
                    break;
            }


            total *= (int)numericDays.Value;

            return total;
        }
        private void comboCar_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtAmount.Text = CalculateTotalAmount().ToString("0.00");

        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericDays_ValueChanged(object sender, EventArgs e)
        {

            txtAmount.Text = CalculateTotalAmount().ToString("0.00");
        }

        private void datePickup_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
