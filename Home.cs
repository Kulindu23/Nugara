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
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();

            // Start the timer when the form loads
            timerDateTime.Tick += timerDateTime_Tick;
            timerDateTime.Start();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin hp = new frmLogin();
            hp.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void btnManagerOrder_Click(object sender, EventArgs e)
        {
            

        }

        private void btnmenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenuItem hp = new frmMenuItem();
            hp.Show();
        }

        private void btnother_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHome2 hp = new frmHome2();
            hp.Show();
        }

        private void lblCut_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnorder_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmOrder hp = new frmOrder();
            hp.Show();
        }

        private void timerDateTime_Tick(object sender, EventArgs e)
        {
            // Update the label with the current date and time
            lblDateTime.Text = DateTime.Now.ToString("dddd, MMMM dd yyyy - hh:mm:ss tt");
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            // Optional: Set initial value for the label
            lblDateTime.Text = DateTime.Now.ToString("dddd, MMMM dd yyyy - hh:mm:ss tt");
        }

        private void btnprepare_Click(object sender, EventArgs e)
        {
           
        }

        private void btnpayment_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPayment hp = new frmPayment();
            hp.Show();
        }

        private void btnbilling_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmBill hp = new frmBill();
            hp.Show();
        }
    }
}
