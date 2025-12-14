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
    public partial class Admin : Form
    {
        bool sidebarExpand = true;
        public Admin()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
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

        private void btnMenu_Click(object sender, EventArgs e)
        {
            sideBarTimer.Start();
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
            panelMain.Controls.Clear();

            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;

            panelMain.Controls.Add(formHijo);
            panelMain.Tag = formHijo;
            formHijo.Show();
        }

        private void btnVehicle_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new VEHICLE());
        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new BOOKINGS());
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new CUSTOMERS());
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new PAYMENTS());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Slidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}

