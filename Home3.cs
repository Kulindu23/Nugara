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
    public partial class frmHome3 : Form
    {
        public frmHome3()
        {
            InitializeComponent();

            // Start the timer when the form loads
            timerDateTime.Tick += timerDateTime_Tick;
            timerDateTime.Start();


        }

        private void lblNugara_Click(object sender, EventArgs e)
        {

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHome2 hp = new frmHome2();
            hp.Show();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHome4 hp = new frmHome4();
            hp.Show();
        }

        private void lblCut_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmHome3_Load(object sender, EventArgs e)
        {
            // Optional: Set initial value for the label
            lblDateTime.Text = DateTime.Now.ToString("dddd, MMMM dd yyyy - hh:mm:ss tt");
        }

        private void timerDateTime_Tick(object sender, EventArgs e)
        {
            // Update the label with the current date and time
            lblDateTime.Text = DateTime.Now.ToString("dddd, MMMM dd yyyy - hh:mm:ss tt");
        }

        private void btnEmpDetails_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmEmpDetails hp = new frmEmpDetails();
            hp.Show();
        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSupplier hp = new frmSupplier();
            hp.Show();
        }

        private void btnSupplierpayment_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSupplierPayment hp = new frmSupplierPayment();
            hp.Show();
        }

        private void btnpayroll_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPayRoll hp = new frmPayRoll();
            hp.Show();
        }

        private void btnEmpAttendence_Click(object sender, EventArgs e)
        {
            
        }
    }
}
