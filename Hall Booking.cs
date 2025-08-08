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
    public partial class frmBooking : Form
    {
        string connectionstring = (@"Data Source=DESKTOP-3F04SHD;Initial Catalog=Nugara;Integrated Security=True");
        public frmBooking()
        {
            InitializeComponent();
            dgvBooking.CellClick += dgvBooking_CellContentClick;

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

        private void timerDateTime_Tick(object sender, EventArgs e)
        {
            // Update the label with the current date and time
            lblDateTime.Text = DateTime.Now.ToString("dddd, MMMM dd yyyy - hh:mm:ss tt");
        }

        private void frmBooking_Load(object sender, EventArgs e)
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
                    string query = "SELECT  * FROM tblHallBooking";
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        adapter.Fill(table);
                    }
                    dgvBooking.DataSource = table;
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

        private void dgvBooking_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvBooking.Rows[e.RowIndex];
                txtBookingID.Text = selectedRow.Cells[0].Value.ToString();
                txtCustomerName.Text = selectedRow.Cells[1].Value.ToString();
                txtPhoneNo.Text = selectedRow.Cells[2].Value.ToString();
                cmbavailability.Text = selectedRow.Cells[3].Value.ToString();
                txtNoofGuest.Text = selectedRow.Cells[4].Value.ToString();
                dateTimePickerdate.Text = selectedRow.Cells[5].Value.ToString();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Add Data
            string Booking_ID = txtBookingID.Text;
            string Customer_Name = txtCustomerName.Text;
            int No_Of_Guests = Convert.ToInt32(txtNoofGuest.Text);
            string Availability = cmbavailability.Text;
            int Phone_No = Convert.ToInt32(txtPhoneNo.Text);
            DateTime Date = dateTimePickerdate.Value;

            //SQL INSERT query
            string query = "INSERT INTO tblHallBooking (Booking_ID,Customer_Name,No_Of_Guests,Availability,Telephone,Date)" +
                "VALUES (@Booking_ID,@Customer_Name,@No_Of_Guests,@Availability,@Telephone,@Date)";

            using (SqlConnection connection = new SqlConnection(connectionstring))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Booking_ID", Booking_ID);
                command.Parameters.AddWithValue("@Customer_Name", Customer_Name);
                command.Parameters.AddWithValue("@No_Of_Guests", No_Of_Guests);
                command.Parameters.AddWithValue("@Availability", Availability);
                command.Parameters.AddWithValue("@Telephone", Phone_No);
                command.Parameters.AddWithValue("@Date", Date);


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
            if (string.IsNullOrEmpty(txtBookingID.Text))
            {
                MessageBox.Show("Please select a row to update.");
                return;
            }


            string Booking_ID = txtBookingID.Text;
            string Customer_Name = txtCustomerName.Text;
            int No_Of_Guests = Convert.ToInt32(txtNoofGuest.Text);
            string Availability = cmbavailability.Text;
            int Phone_No = Convert.ToInt32(txtPhoneNo.Text);
            DateTime Date = dateTimePickerdate.Value;

            //SQL UPDATE query
            string query = "UPDATE tblHallBooking SET Date = @Date, Customer_Name = @Customer_Name, No_Of_Guests = @No_Of_Guests, Availability = @Availability, Telephone = @Telephone WHERE Booking_ID = @Booking_ID";

            using (SqlConnection connection = new SqlConnection(connectionstring))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Booking_ID", Booking_ID);
                command.Parameters.AddWithValue("@Customer_Name", Customer_Name);
                command.Parameters.AddWithValue("@No_Of_Guests", No_Of_Guests);
                command.Parameters.AddWithValue("@Availability", Availability);
                command.Parameters.AddWithValue("@Telephone", Phone_No);
                command.Parameters.AddWithValue("@Date", Date);

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
            if (string.IsNullOrEmpty(txtBookingID.Text))
            {

                MessageBox.Show("Please select a row to deleted.");
                return;

            }

            else
            {
                string query = "DELETE FROM tblHallBooking WHERE Booking_ID = @Booking_ID";

                using (SqlConnection connection = new SqlConnection(connectionstring))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Booking_ID", txtBookingID.Text);
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
                            MessageBox.Show("No Hall Booking found wih Booking_ID" + txtBookingID.Text);
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
            txtBookingID.Text = "";
            txtCustomerName.Text = "";
            cmbavailability.Text = "";
            txtNoofGuest.Text = "";
            txtPhoneNo.Text = "";
            dateTimePickerdate.Text = "";
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            try
            {
                // Ensure a valid Booking ID is entered
                if (string.IsNullOrWhiteSpace(txtBookingID.Text))
                {
                    MessageBox.Show("Please enter a valid Booking ID to cancel.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Confirm cancellation
                var confirmResult = MessageBox.Show("Are you sure you want to cancel this booking?","Confirm Cancellation",MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {

                    string connectionString = @"Data Source=DESKTOP-3F04SHD;Initial Catalog=Nugara;Integrated Security=True";

                    // Query 
                    string query = "DELETE FROM tblHallBooking WHERE Booking_ID = @Booking_ID";

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {

                        connection.Open();


                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            // Add the parameter 
                            command.Parameters.AddWithValue("@Booking_ID", txtBookingID.Text);

                            // Execute the query and get the number of rows affected
                            int rowsAffected = command.ExecuteNonQuery();

                            // Check if the booking was successfully canceled
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Booking successfully canceled.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                //Clear
                                ClearFields();
                            }
                            else
                            {
                                MessageBox.Show("No booking found with the entered Booking ID.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }

                // Clear the DataGridView
                if (dgvBooking.Rows.Count > 0)
                {
                    dgvBooking.DataSource = null; 
                    
                    dgvBooking.Rows.Clear();
                }

                // Clear the input fields
                ClearFields();

                // Notify the user
                MessageBox.Show("Booking details cleared successfully.", "Cleared", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Display error message
                MessageBox.Show("An error occurred while canceling the booking: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        private void ClearFields()
        {
            txtBookingID.Text = string.Empty;
            txtCustomerName.Text = string.Empty;
            txtPhoneNo.Text = string.Empty;
            txtNoofGuest.Text = string.Empty;
            cmbavailability.SelectedIndex = -1;
            dateTimePickerdate.Value = DateTime.Now;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchBooking_ID = txtSearch.Text.Trim();

            if (!string.IsNullOrEmpty(searchBooking_ID))
            {
                try
                {
                    string query = "SELECT * FROM tblHallBooking WHERE Booking_ID = @searchBooking_ID";

                    using (SqlConnection connection = new SqlConnection(connectionstring))
                    {
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@searchBooking_ID", searchBooking_ID);

                            connection.Open();

                            //Use SqlDataAdapter to fill a DataTable with the results
                            SqlDataAdapter adapter = new SqlDataAdapter(command);
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            if (dataTable.Rows.Count > 0)
                            {
                                //Bind the DataTable to a DataGridView to display the results
                                dgvBooking.DataSource = dataTable;
                            }
                            else
                            {
                                MessageBox.Show("No matching Booking_ID found.");
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

        private void btnView_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewrHallBooking cryRpt = new ViewrHallBooking();
            cryRpt.Show();
        }
    }
}
    

       