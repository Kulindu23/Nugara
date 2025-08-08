using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nugara
{
    public partial class frmHome4 : Form
    {
        public frmHome4()
        {
            InitializeComponent();

            // Start the timer when the form loads
            timerDateTime.Tick += timerDateTime_Tick;
            //timerDateTime.Start();
        }

        private void btnSupplierInvoice_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSupplierInvoice hp = new frmSupplierInvoice();
            hp.Show();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHome3 hp = new frmHome3();
            hp.Show();
        }

        private void frmHome4_Load(object sender, EventArgs e)
        {
            // Optional: Set initial value for the label
            lblDateTime.Text = DateTime.Now.ToString("dddd, MMMM dd yyyy - hh:mm:ss tt");
        }

        private void timerDateTime_Tick(object sender, EventArgs e)
        {
            // Update the label with the current date and time
            lblDateTime.Text = DateTime.Now.ToString("dddd, MMMM dd yyyy - hh:mm:ss tt");
        }

        private void lblCut_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMenuCategory_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenuCategoryid hp = new frmMenuCategoryid();
            hp.Show();
        }

        private void btnGRN_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmGRN hp = new frmGRN();
            hp.Show();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmReport hp = new frmReport();
            hp.Show();
        }

        private void btnCookedItems_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCookedItem hp = new frmCookedItem();
            hp.Show();
        }
    }
}
