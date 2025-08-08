using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nugara
{
    public partial class frmPayment : Form
    {
        string connectionstring = (@"Data Source=DESKTOP-3F04SHD;Initial Catalog=Nugara;Integrated Security=True");
        public frmPayment()
        {
            InitializeComponent();

            dataGridViewpayment.CellClick += dataGridViewpayment_CellContentClick;

            // Start the timer when the form loads
            timerDateTime.Tick += timerDateTime_Tick;
            timerDateTime.Start();
        }

        private void lblCut_Click(object sender, EventArgs e)
        {
            Application.Exit();


        }

        private void frmPayment_Load(object sender, EventArgs e)
        {
            LoadData();

            // Optional: Set initial value for the label
            lblDateTime.Text = DateTime.Now.ToString("dddd, MMMM dd yyyy - hh:mm:ss tt");
        }

        private void LoadData()
        {
            DataTable table = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionstring))

                try
                {
                    connection.Open();
                    string query = "SELECT  * FROM tblPayment";
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        adapter.Fill(table);
                    }
                    dataGridViewpayment.DataSource = table;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error", ex.Message);
                }
                finally
                {
                    connection.Close();
                }
        }

        private void timerDateTime_Tick(object sender, EventArgs e)
        {
            // Update the label with the current date and time
            lblDateTime.Text = DateTime.Now.ToString("dddd, MMMM dd yyyy - hh:mm:ss tt");
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHome hp = new frmHome();
            hp.Show();
        }

        private void lblBalance_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTotalamount_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewpayment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridViewpayment.Rows[e.RowIndex];
                txtpaymentID.Text = selectedRow.Cells[0].Value.ToString();
                cmbpaymenttype.Text = selectedRow.Cells[1].Value.ToString();
                txttotalamount.Text = selectedRow.Cells[2].Value.ToString();
                txtbalance.Text = selectedRow.Cells[3].Value.ToString();

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Add Data
            string Payment_ID = txtpaymentID.Text;
            string Payment_Type = cmbpaymenttype.Text;
            double Total_Amount = Convert.ToDouble(txttotalamount.Text);
            double Balance = Convert.ToDouble(txtbalance.Text);

            //SQL INSERT query
            string query = "INSERT INTO tblPayment (Payment_ID,Payment_Type,Total_Amount,Balance)" +
                "VALUES (@Payment_ID,@Payment_Type,@Total_Amount,@Balance)";

            using (SqlConnection connection = new SqlConnection(connectionstring))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Payment_ID", Payment_ID);
                command.Parameters.AddWithValue("@Payment_Type", Payment_Type);
                command.Parameters.AddWithValue("@Total_Amount", Total_Amount);
                command.Parameters.AddWithValue("@Balance", Balance);
                

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("New Record added successfully");
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("No rows affected. Record not added");
                    }
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error", ex.Message);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtpaymentID.Text))
            {
                MessageBox.Show("Please select a row to update.");
                return;
            }


            string Payment_ID = txtpaymentID.Text;
            string Payment_Type = cmbpaymenttype.Text;
            double Total_Amount = Convert.ToDouble(txttotalamount.Text);
            double Balance = Convert.ToDouble(txtbalance.Text);


            //SQL UPDATE query
            string query = "UPDATE tblPayment SET Payment_Type = @Payment_Type, Total_Amount = @Total_Amount, Balance = @Balance WHERE Payment_ID = @Payment_ID";

            using (SqlConnection connection = new SqlConnection(connectionstring))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Payment_ID", Payment_ID);
                command.Parameters.AddWithValue("@Payment_Type", Payment_Type);
                command.Parameters.AddWithValue("@Total_Amount", Total_Amount);
                command.Parameters.AddWithValue("@Balance", Balance);
               


                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("New Record updated successfully");
                        LoadData(); //Reload data into the DataGridView
                    }
                    else
                    {
                        MessageBox.Show("No rows affected. Record not updated.");
                    }
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error", ex.Message);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtpaymentID.Text))
            {

                MessageBox.Show("Please select a row to deleted.");
                return;

            }

            else
            {
                string query = "DELETE FROM tblPayment WHERE Payment_ID = @Payment_ID";

                using (SqlConnection connection = new SqlConnection(connectionstring))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Payment_ID", txtpaymentID.Text);
                    try
                    {
                        connection.Open();
                        int rowAffected = command.ExecuteNonQuery();
                        if (rowAffected > 0)
                        {
                            MessageBox.Show("Deleted successfully");
                            LoadData(); //Refresh DataGridView

                        }
                        else
                        {
                            MessageBox.Show("No Order found wih Payment_ID" + txtpaymentID);
                        }
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show("Error:" + ex.Message);
                    }
                }
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            txtpaymentID.Text = "";
            cmbpaymenttype.Text = "";
            txttotalamount.Text = "";
            txtbalance.Text = "";

        }
    }
}
