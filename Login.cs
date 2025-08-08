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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void toolStripUN_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                String username = txtUN.Text;
                String password = txtPW.Text;
                String Employee_Position = cmbEmpPos.Text;

                //Validate Employee Position
                if (string.IsNullOrEmpty(cmbEmpPos.Text))
                {
                    MessageBox.Show("Employee Position can not be blank", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //Validate Username & Password
                if (string.IsNullOrEmpty(txtUN.Text))
                {
                    MessageBox.Show("User Name cannot be blank", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!username.Equals("USER", StringComparison.OrdinalIgnoreCase)) // Case-insensitive validation
                {
                    MessageBox.Show("Invalid Username! Cannot login.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrEmpty(txtPW.Text))
                {
                    MessageBox.Show("Password can not be blank","Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //Set Password based on Employee Position
                if (password == "A1234" && Employee_Position == "Admin")
                {
                    this.Hide();
                    frmHome hp = new frmHome();
                    hp.Show();
                }
                else if(password == "C1234" && Employee_Position == "Cashier")
                {
                    this.Hide();
                    frmHome hp = new frmHome();
                    hp.Show();
                }

                else if (password == "M1234" && Employee_Position == "Manager")
                {
                    this.Hide();
                    frmHome hp = new frmHome();
                    hp.Show();
                }
                else if (password == "S1234" && Employee_Position == "Store Manager")
                {
                    this.Hide();
                    frmHome hp = new frmHome();
                    hp.Show();
                }
                else
                {
                    MessageBox.Show("Incorrect password! Please Enter the correct password", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }
            }

            catch (FormatException)
            {
                MessageBox.Show("Please Enter the valid format");
            }
            catch(Exception ex)
            {
                MessageBox.Show("An error occured"+ex.Message);
            }

           

            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void lblCut_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBoxShowPW_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPW.Checked)
            {
                txtPW.UseSystemPasswordChar = true; // Hide password
            }
            else
            {
                txtPW.UseSystemPasswordChar = false; // Show password
            }
        }

        private void linkLabelForgetPW_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmResetPW frmResetPW = new frmResetPW();
            frmResetPW.Show();
            this.Hide();
        }

        private void linkLabelSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
