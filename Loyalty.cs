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
    public partial class frmLoyalty : Form
    {
        string connectionstring = (@"Data Source=DESKTOP-3F04SHD;Initial Catalog=Nugara;Integrated Security=True");
        public frmLoyalty()
        {
            InitializeComponent();

            // Start the timer when the form loads
            timerDateTime.Tick += timerDateTime_Tick;
            timerDateTime.Start();
        }

        private void lblCut_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCustomer hp = new frmCustomer();
            hp.Show();
        }

        private void timerDateTime_Tick(object sender, EventArgs e)
        {
            // Update the label with the current date and time
            lblDateTime.Text = DateTime.Now.ToString("dddd, MMMM dd yyyy - hh:mm:ss tt");
        }

        private void frmLoyalty_Load(object sender, EventArgs e)
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
                    string query = "SELECT  * FROM tblLoyaltyAccount";
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        adapter.Fill(table);
                    }
                    dataGridViewloyalty.DataSource = table;
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCustomerID.Text = "";
            txtCustomerName.Text = "";
            txtAddress.Text = "";
            txtPhone.Text = "";
            txtEmail.Text = "";
            txtNIC.Text = "";
            txtUsername.Text = "";
            txtLoyaltyPoints.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCustomerID.Text))
            {

                MessageBox.Show("Please select a row to deleted.");
                return;

            }

            else
            {
                string query = "DELETE FROM tblLoyaltyAccount WHERE Customer_ID = @Customer_ID";

                using (SqlConnection connection = new SqlConnection(connectionstring))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Customer_ID", txtCustomerID.Text);
                    try
                    {
                        connection.Open();
                        int rowAffected = command.ExecuteNonQuery();
                        if (rowAffected > 0)
                        {
                            MessageBox.Show("Account Deleted successfully");
                            LoadData(); //Refresh DataGridView

                        }
                        else
                        {
                            MessageBox.Show("No Account found wih Customer_ID" + txtCustomerID);
                        }
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show("Error:" + ex.Message);
                    }
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCustomerID.Text))
            {
                MessageBox.Show("Please select a row to update.");
                return;
            }

            string Customer_ID = txtCustomerID.Text;
            string Customer_Name = txtCustomerName.Text;
            string Address = txtAddress.Text;
            int Phone = Convert.ToInt32(txtPhone.Text);
            string Email = txtEmail.Text;
            string NIC = txtNIC.Text;
            string User_Name = txtUsername.Text;
            double Loyalty_Points = Convert.ToDouble(txtLoyaltyPoints.Text);



            //SQL UPDATE query
            string query = "UPDATE tblLoyaltyAccount SET User_Name = @User_Name, Loyalty_Points = @Loyalty_Points, Customer_Name = @Customer_Name, Address = @Address, Telephone = @Telephone, Email = @Email, NIC = @NIC WHERE Customer_ID = @Customer_ID";

            using (SqlConnection connection = new SqlConnection(connectionstring))
            using (SqlCommand command = new SqlCommand(query, connection))
            {

                command.Parameters.AddWithValue("@Customer_ID", Customer_ID);
                command.Parameters.AddWithValue("@Customer_Name", Customer_Name);
                command.Parameters.AddWithValue("@Address", Address);
                command.Parameters.AddWithValue("@Telephone", Phone);
                command.Parameters.AddWithValue("@Email", Email);
                command.Parameters.AddWithValue("@NIC", NIC);
                command.Parameters.AddWithValue("@User_Name", User_Name);
                command.Parameters.AddWithValue("@Loyalty_Points", Loyalty_Points);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Account updated successfully");
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

        private void btnCreate_Click(object sender, EventArgs e)
        {
            //Add Data
            string Customer_ID = txtCustomerID.Text;
            string Customer_Name = txtCustomerName.Text;
            string Address = txtAddress.Text;
            string User_Name = txtUsername.Text;
            int Phone = Convert.ToInt32(txtPhone.Text);
            string Email = txtEmail.Text;
            string NIC = txtNIC.Text;
            int Loyalty_Points = Convert.ToInt32(txtLoyaltyPoints.Text);

            //SQL INSERT query
            string query = "INSERT INTO tblLoyaltyAccount (Customer_ID,Customer_Name,Address,User_Name,Telephone,Email,NIC,Loyalty_Points)" +
                "VALUES (@Customer_ID,@Customer_Name,@Address,@User_Name,@Telephone,@Email,@NIC,@Loyalty_Points)";

            using (SqlConnection connection = new SqlConnection(connectionstring))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Customer_ID", Customer_ID);
                command.Parameters.AddWithValue("@Customer_Name", Customer_Name );
                command.Parameters.AddWithValue("@Address", Address);
                command.Parameters.AddWithValue("@User_Name", User_Name);
                command.Parameters.AddWithValue("@Telephone", Phone);
                command.Parameters.AddWithValue("@Email", Email);
                command.Parameters.AddWithValue("@NIC", NIC);
                command.Parameters.AddWithValue("@Loyalty_Points", Loyalty_Points);


                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("New Account create successfully");
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

        private void dataGridViewloyalty_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridViewloyalty.Rows[e.RowIndex];
                txtCustomerID.Text = selectedRow.Cells[0].Value.ToString();
                txtCustomerName.Text = selectedRow.Cells[1].Value.ToString();
                txtAddress.Text = selectedRow.Cells[2].Value.ToString();
                txtPhone.Text = selectedRow.Cells[3].Value.ToString();
                txtEmail.Text = selectedRow.Cells[4].Value.ToString();
                txtNIC.Text = selectedRow.Cells[5].Value.ToString();
                txtUsername.Text = selectedRow.Cells[6].Value.ToString();
                txtLoyaltyPoints.Text = selectedRow.Cells[7].Value.ToString();

            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewerLoyaltyAccount2 cryRpt = new ViewerLoyaltyAccount2();
            cryRpt.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchCustomer_ID = txtSearch.Text.Trim();

            if (!string.IsNullOrEmpty(searchCustomer_ID))
            {
                try
                {
                    string query = "SELECT * FROM tblLoyaltyAccount WHERE Customer_ID = @searchCustomer_ID";

                    using (SqlConnection connection = new SqlConnection(connectionstring))
                    {
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@searchCustomer_ID", searchCustomer_ID);

                            connection.Open();

                            //Use SqlDataAdapter to fill a DataTable with the results
                            SqlDataAdapter adapter = new SqlDataAdapter(command);
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            if (dataTable.Rows.Count > 0)
                            {
                                //Bind the DataTable to a DataGridView to display the results
                                dataGridViewloyalty.DataSource = dataTable;
                            }
                            else
                            {
                                MessageBox.Show("No matching Customer_ID found.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error:" + ex.Message);
                }
            }    
        }

                
                

    }
}
