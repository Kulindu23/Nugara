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
    public partial class frmReservation : Form
    {
        string connectionstring = (@"Data Source=DESKTOP-3F04SHD;Initial Catalog=Nugara;Integrated Security=True");
        public frmReservation()
        {
            InitializeComponent();
            dgvReservation.CellClick += dataGridView1_CellContentClick;
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
            frmHome2 hp = new frmHome2();
            hp.Show();
        }

        private void cmbItemID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void timerDateTime_Tick(object sender, EventArgs e)
        {
            // Update the label with the current date and time
            lblDateTime.Text = DateTime.Now.ToString("dddd, MMMM dd yyyy - hh:mm:ss tt");
        }

        private void frmReservation_Load(object sender, EventArgs e)
        {
            LoadData();
            // Optional: Set initial value for the label
            lblDateTime.Text = DateTime.Now.ToString("dddd, MMMM dd yyyy - hh:mm:ss tt");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvReservation.Rows[e.RowIndex];
                txtReservationID.Text = selectedRow.Cells[0].Value.ToString();
                txtCustomerName.Text = selectedRow.Cells[1].Value.ToString();
                cmbTableNO.Text = selectedRow.Cells[2].Value.ToString();
                txtSeatingCapacity.Text = selectedRow.Cells[3].Value.ToString();
                txtPhoneNo.Text = selectedRow.Cells[4].Value.ToString();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Add Data
            string Reservation_ID = txtReservationID.Text;
            string Customer_Name = txtCustomerName.Text;
            int Table_No = Convert.ToInt32(cmbTableNO.Text);
            int Seating_Capacity = Convert.ToInt32(txtSeatingCapacity.Text);
            int Phone_No = Convert.ToInt32(txtPhoneNo.Text);

            //SQL INSERT query
            string query = "INSERT INTO tblReservation (Reservation_ID,Customer_Name,Table_No,Seating_Capacity,Telephone)" +
                "VALUES (@Reservation_ID,@Customer_Name,@Table_No,@Seating_Capacity,@Telephone)";

            using (SqlConnection connection = new SqlConnection(connectionstring))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Reservation_ID", Reservation_ID);
                command.Parameters.AddWithValue("@Customer_Name", Customer_Name);
                command.Parameters.AddWithValue("@Table_No", Table_No);
                command.Parameters.AddWithValue("@Seating_Capacity", Seating_Capacity);
                command.Parameters.AddWithValue("@Telephone", Phone_No);

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
                    string query = "SELECT  * FROM tblReservation";
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        adapter.Fill(table);
                    }
                    dgvReservation.DataSource = table;
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtReservationID.Text))
            {
                MessageBox.Show("Please select a row to update.");
                return;
            }


            string Reservation_ID = txtReservationID.Text;
            string Customer_Name = txtCustomerName.Text;
            int Table_No = Convert.ToInt32(cmbTableNO.Text);
            int Seating_Capacity = Convert.ToInt32(txtSeatingCapacity.Text);
            int Phone_NO = Convert.ToInt32(txtPhoneNo.Text);

            //SQL UPDATE query
            string query = "UPDATE tblReservation SET Customer_Name = @Customer_Name, Table_No = @Table_No, Seating_Capacity = @Seating_Capacity, Telephone = @Telephone WHERE Reservation_ID = @Reservation_ID";

            using (SqlConnection connection = new SqlConnection(connectionstring))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Reservation_ID", Reservation_ID);
                command.Parameters.AddWithValue("@Customer_Name", Customer_Name);
                command.Parameters.AddWithValue("@Table_No", Table_No);
                command.Parameters.AddWithValue("@Seating_Capacity", Seating_Capacity);
                command.Parameters.AddWithValue("@Telephone", Phone_NO);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("New Record updated successfully");
                        LoadData();
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
            if (string.IsNullOrEmpty(txtReservationID.Text))
            {

                MessageBox.Show("Please select a row to deleted.");
                return;

            }

            else
            {
                string query = "DELETE FROM tblReservation WHERE Reservation_ID = @Reservation_ID";

                using (SqlConnection connection = new SqlConnection(connectionstring))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Reservation_ID", txtReservationID.Text);
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
                            MessageBox.Show("No Reservation found wih Reservation_ID" + txtReservationID.Text);
                        }
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show("Error:" + ex.Message);
                    }
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtReservationID.Text = "";
            txtCustomerName.Text = "";
            cmbTableNO.Text = "";
            txtSeatingCapacity.Text = "";
            txtPhoneNo.Text = "";
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            try
            {
                // Ensure a valid Booking ID is entered
                if (string.IsNullOrWhiteSpace(txtReservationID.Text))
                {
                    MessageBox.Show("Please enter a valid Reservation ID to cancel.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Confirm cancellation
                var confirmResult = MessageBox.Show("Are you sure you want to cancel this reservation?", "Confirm Cancellation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {

                    string connectionString = @"Data Source=DESKTOP-3F04SHD;Initial Catalog=Nugara;Integrated Security=True";

                    // Query 
                    string query = "DELETE FROM tblReservation WHERE reservation_ID = @Reservation_ID";

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {

                        connection.Open();


                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            // Add the parameter 
                            command.Parameters.AddWithValue("@Reservation_ID", txtReservationID.Text);

                            // Execute the query and get the number of rows affected
                            int rowsAffected = command.ExecuteNonQuery();

                            // Check if the booking was successfully canceled
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Reseravtion successfully canceled.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                //Clear
                                ClearFields();
                            }
                            else
                            {
                                MessageBox.Show("No Reservation found with the entered Reservation ID.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }

                // Clear the DataGridView
                if (dgvReservation.Rows.Count > 0)
                {
                    dgvReservation.DataSource = null;

                    dgvReservation.Rows.Clear();
                }

                // Clear the input fields
                ClearFields();

                // Notify the user
                MessageBox.Show("Reservation details cleared successfully.", "Cleared", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Display error message
                MessageBox.Show("An error occurred while canceling the reservation: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void ClearFields()
        {
            txtReservationID.Text = string.Empty;
            txtCustomerName.Text = string.Empty;
            txtPhoneNo.Text = string.Empty;
            txtSeatingCapacity.Text = string.Empty;
            cmbTableNO.SelectedIndex = -1;
            
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewerReservation cryRpt = new ViewerReservation();
            cryRpt.Show();

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchReservation_ID = txtSearch.Text.Trim();

            if (!string.IsNullOrEmpty(searchReservation_ID))
            {
                try
                {
                    string query = "SELECT * FROM tblReservation WHERE Reservation_ID = @searchReservation_ID";

                    using (SqlConnection connection = new SqlConnection(connectionstring))
                    {
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@searchReservation_ID", searchReservation_ID);

                            connection.Open();

                            //Use SqlDataAdapter to fill a DataTable with the results
                            SqlDataAdapter adapter = new SqlDataAdapter(command);
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            if (dataTable.Rows.Count > 0)
                            {
                                //Bind the DataTable to a DataGridView to display the results
                                dgvReservation.DataSource = dataTable;
                            }
                            else
                            {
                                MessageBox.Show("No matching Reservation_ID found.");
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
        





