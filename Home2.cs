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
    public partial class frmHome2 : Form
    {
        public frmHome2()
        {
            InitializeComponent();

            // Start the timer when the form loads
            timerDateTime.Tick += timerDateTime_Tick;
            timerDateTime.Start();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHome hp = new frmHome();
            hp.Show();
        }

        private void btnother_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHome3 hp = new frmHome3();
            hp.Show();
        }

        private void lblCut_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmHome2_Load(object sender, EventArgs e)
        {
            // Optional: Set initial value for the label
            lblDateTime.Text = DateTime.Now.ToString("dddd, MMMM dd yyyy - hh:mm:ss tt");

        }

        private void timerDateTime_Tick(object sender, EventArgs e)
        {
            // Update the label with the current date and time
            lblDateTime.Text = DateTime.Now.ToString("dddd, MMMM dd yyyy - hh:mm:ss tt");
        }

        private void btncustomer_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCustomer hp = new frmCustomer();
            hp.Show();
        }

        private void btnReservation_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmReservation hp = new frmReservation();
            hp.Show();
        }

        private void btnHall_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmBooking hp = new frmBooking();
            hp.Show();
        }

        private void btninventory_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmInventory hp = new frmInventory();
            hp.Show();
        }

        private void btnPromotion_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPromotion hp = new frmPromotion();
            hp.Show();
        }
    }
}
