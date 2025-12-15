using Microsoft.VisualBasic;
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

    public partial class Customer : Form

    {

        private CUSTOMER_PAYMENT paymentForm;
        private CUSTOMER_BOOKING bookingForm;

        bool sidebarExpand = true;
        public Customer()
        {
            InitializeComponent();
        }

        private void Customer_Load(object sender, EventArgs e)
        {

        }

        private void iconMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void iconRestorer_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            iconRestorer.Visible = false;
            iconMaximize.Visible = true;
        }

        private void iconMaximize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            iconRestorer.Visible = true;
            iconMaximize.Visible = false;
        }

        private void iconClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Slidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sideBarTimer_Tick(object sender, EventArgs e)
        {

            if (sidebarExpand)
            {

                Slidebar.Width -= 10;
                if (Slidebar.Width <= Slidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sideBarTimer.Stop();
                }
            }
            else
            {

                Slidebar.Width += 10;
                if (Slidebar.Width >= Slidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sideBarTimer.Stop();
                }
            }
        }
        private void AbrirFormInPanel(Form formHijo)
        {
            panel1.Controls.Clear();
            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;
            panel1.Controls.Add(formHijo);
            formHijo.Show();
        }
        private void btnPayment_Click(object sender, EventArgs e)
        {

            if (paymentForm == null || paymentForm.IsDisposed)
                paymentForm = new CUSTOMER_PAYMENT();

            AbrirFormInPanel(paymentForm);

        }

        private void btnVehicle_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new CUSTOMER_VEHICLE());
        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            if (paymentForm == null || paymentForm.IsDisposed)
                paymentForm = new CUSTOMER_PAYMENT();

            if (bookingForm == null || bookingForm.IsDisposed)
                bookingForm = new CUSTOMER_BOOKING(paymentForm);

            AbrirFormInPanel(bookingForm);
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new CUSTOMER_PROFILE());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form1().Show();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            sideBarTimer.Start();
        }
    }
}
 
 