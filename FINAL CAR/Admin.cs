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
    }
}
