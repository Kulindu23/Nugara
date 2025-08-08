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
    public partial class frmOrder : Form
    {
        string connectionstring = (@"Data Source=DESKTOP-3F04SHD;Initial Catalog=Nugara;Integrated Security=True");
        public frmOrder()
        {
            InitializeComponent();
            dataGridViewOrder.CellClick += dataGridViewOrder_CellContentClick;

            // Start the timer when the form loads
            timerDateTime.Tick += timerDateTime_Tick;
            timerDateTime.Start();
        }

        private void frmOrder_Load(object sender, EventArgs e)
        {
            LoadData();
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

        private void cmbItemID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtItemName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblsize_Click(object sender, EventArgs e)
        {

        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHome hp = new frmHome();
            hp.Show();
        }

        private void dataGridViewOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridViewOrder.Rows[e.RowIndex];
                txtOrderID.Text = selectedRow.Cells[0].Value.ToString();
                cmbItemID.Text = selectedRow.Cells[1].Value.ToString();
                txtItemName.Text = selectedRow.Cells[2].Value.ToString();
                cmbOrdertype.Text = selectedRow.Cells[6].Value.ToString();
                txtQuantity.Text = selectedRow.Cells[3].Value.ToString();
                cmbSize.Text = selectedRow.Cells[4].Value.ToString();
                txtPrice.Text = selectedRow.Cells[5].Value.ToString();
                txttotalprice.Text = selectedRow.Cells[6].Value.ToString();
            }
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmKOT hp = new frmKOT();
            hp.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtOrderID.Text))
            {
                MessageBox.Show("Please select a row to update.");
                return;
            }

            
            string Order_ID = txtOrderID.Text;
            string Item_ID = cmbItemID.Text;
            string Item_Name = txtItemName.Text;
            string Order_Type = cmbOrdertype.Text;
            int Quantity = Convert.ToInt32(txtQuantity.Text);
            string Size = cmbSize.Text;
            double Price = Convert.ToDouble(txtPrice.Text);
           


            //SQL UPDATE query
            string query = "UPDATE tblOrder SET  Item_ID = @Item_ID, Item_Name = @Item_Name, Order_Type = @Order_Type, Quantity = @Quantity, Size = @Size, Price = @Price WHERE Order_ID = @Order_ID"; 

            using (SqlConnection connection = new SqlConnection(connectionstring))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Order_ID", Order_ID);
                command.Parameters.AddWithValue("@Item_ID", Item_ID);
                command.Parameters.AddWithValue("@Item_Name", Item_Name);
                command.Parameters.AddWithValue("@Order_Type", Order_Type);
                command.Parameters.AddWithValue("@Quantity", Quantity);
                command.Parameters.AddWithValue("@Size", Size);
                command.Parameters.AddWithValue("@Price", Price);
                


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

        private void btnAdd_Click(object sender, EventArgs e)
        {

            

            //Add Data
            string Order_ID = txtOrderID.Text;
            string Item_ID = cmbItemID.Text;
            string Item_Name = txtItemName.Text;
            string Order_Type = cmbOrdertype.Text;
            int Quantity = Convert.ToInt32(txtQuantity.Text);
            string Size = cmbSize.Text;
            double Price = Convert.ToDouble(txtPrice.Text);
            
            

            //SQL INSERT query
            string query = "INSERT INTO tblOrder (Order_ID,Item_ID,Item_Name,Order_Type,Quantity,Size,Price)" +
                "VALUES (@Order_ID,@Item_ID,@Item_Name,@Order_Type,@Quantity,@Size,@Price)";

            using (SqlConnection connection = new SqlConnection(connectionstring))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Order_ID", Order_ID);
                command.Parameters.AddWithValue("@Item_ID", Item_ID);
                command.Parameters.AddWithValue("@Item_Name", Item_Name);
                command.Parameters.AddWithValue("@Order_Type", Order_Type);
                command.Parameters.AddWithValue("Quantity", Quantity);
                command.Parameters.AddWithValue("@Size", Size);
                command.Parameters.AddWithValue("@Price", Price);
                
                

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
        private void LoadData()
        {
            DataTable table = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionstring))

                try
                {
                    connection.Open();
                    string query = "SELECT  * FROM tblOrder";
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        adapter.Fill(table);
                    }
                    dataGridViewOrder.DataSource = table;
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtOrderID.Text))
            {

                MessageBox.Show("Please select a row to deleted.");
                return;

            }

            else
            {
                string query = "DELETE FROM tblOrder WHERE Order_ID = @Order_ID";

                using (SqlConnection connection = new SqlConnection(connectionstring))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Order_ID", txtOrderID.Text);
                    try
                    {
                        connection.Open();
                        int rowAffected = command.ExecuteNonQuery();
                        if (rowAffected > 0)
                        {
                            MessageBox.Show( "Deleted successfully");
                            LoadData(); //Refresh DataGridView

                        }
                        else
                        {
                            MessageBox.Show("No Order found wih Order_ID" + txtOrderID);
                        }
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show("Error:" + ex.Message);
                    }
                }
            }
        }

        private void dataGridViewOrder_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtOrderID.Text = "";
            cmbItemID.Text = "";
            txtItemName.Text = "";
            cmbOrdertype.Text = "";
            txtQuantity.Text = "";
            cmbSize.Text = "";
            txtPrice.Text = "";
            
           

        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            try
            {
                // Ensure a valid Booking ID is entered
                if (string.IsNullOrWhiteSpace(txtOrderID.Text))
                {
                    MessageBox.Show("Please enter a valid Order ID to cancel.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Confirm cancellation
                var confirmResult = MessageBox.Show("Are you sure you want to cancel this order?", "Confirm Cancellation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {

                    string connectionString = @"Data Source=DESKTOP-3F04SHD;Initial Catalog=Nugara;Integrated Security=True";

                    // Query 
                    string query = "DELETE FROM tblOrder WHERE Order_ID = @Order_ID";

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {

                        connection.Open();


                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            // Add the parameter 
                            command.Parameters.AddWithValue("@Order_ID", txtOrderID.Text);

                            // Execute the query and get the number of rows affected
                            int rowsAffected = command.ExecuteNonQuery();

                            // Check if the booking was successfully canceled
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Order successfully canceled.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                // Clear the input fields
                                ClearFields();
                            }
                            else
                            {
                                MessageBox.Show("No order found with the entered Order ID.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }

                // Clear the DataGridView
                if (dataGridViewOrder.Rows.Count > 0)
                {
                    dataGridViewOrder.DataSource = null;

                    dataGridViewOrder.Rows.Clear();
                }

                // Clear the input fields
                ClearFields();

                // Notify the user
                MessageBox.Show("Order details cleared successfully.", "Cleared", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Display error message
                MessageBox.Show("An error occurred while canceling the order: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void ClearFields()
        {
            txtOrderID.Text = string.Empty;
            txtItemName.Text = string.Empty;
            txtPrice.Text = string.Empty;
            txtQuantity.Text = string.Empty;
            cmbItemID.SelectedIndex = -1;
            cmbOrdertype.SelectedIndex = -1;
            cmbSize.SelectedIndex = -1;
            
           
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewerOrder cryRpt = new ViewerOrder();
            cryRpt.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchOrder_ID = txtSearch.Text.Trim();

            if (!string.IsNullOrEmpty(searchOrder_ID))
            {
                try
                {
                    string query = "SELECT * FROM tblOrder WHERE Order_ID = @searchOrder_ID";

                    using (SqlConnection connection = new SqlConnection(connectionstring))
                    {
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@searchOrder_ID", searchOrder_ID);

                            connection.Open();

                            //Use SqlDataAdapter to fill a DataTable with the results
                            SqlDataAdapter adapter = new SqlDataAdapter(command);
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            if (dataTable.Rows.Count > 0)
                            {
                                //Bind the DataTable to a DataGridView to display the results
                                dataGridViewOrder.DataSource = dataTable;
                            }
                            else
                            {
                                MessageBox.Show("No matching Order_ID found.");
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Input values
                double price = Convert.ToDouble(txtPrice.Text);
                int quantity = Convert.ToInt32(txtQuantity.Text);


                // Calculate the total cost
                double totalCost = price * quantity;

                // Display the total cost in a specific textbox or message box
                txttotalprice.Text = totalCost.ToString("F2"); // Displays result with 2 decimal points

                 
            }
            catch (FormatException)
            {
                // Handle invalid input formats
                MessageBox.Show("Please enter valid numbers for Price and Quantity.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // Handle other unexpected errors
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
    

