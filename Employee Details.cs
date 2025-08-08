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
    public partial class frmEmpDetails : Form
    {
        string connectionstring = (@"Data Source=DESKTOP-3F04SHD;Initial Catalog=Nugara;Integrated Security=True");

        public frmEmpDetails()
        {
            InitializeComponent();

            dataGridViewEmpDetails.CellClick += dataGridViewEmpDetails_CellContentClick;

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
            frmHome3 hp = new frmHome3();
            hp.Show();
        }

        private void frmEmpDetails_Load(object sender, EventArgs e)
        {
            LoadData();

            // Optional: Set initial value for the label
            label10.Text = DateTime.Now.ToString("dddd, MMMM dd yyyy - hh:mm:ss tt");
        }

        private void LoadData()
        {
            DataTable table = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionstring))

                try
                {
                    connection.Open();
                    string query = "SELECT  * FROM tblEmpDetails";
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        adapter.Fill(table);
                    }
                    dataGridViewEmpDetails.DataSource = table;
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
            if (string.IsNullOrEmpty(txtEmpID.Text))
            {
                MessageBox.Show("Please select a row to update.");
                return;
            }

            string Employee_ID = txtEmpID.Text;
            string Employee_Name = txtEmpName.Text;
            string Address = txtAddress.Text;
            int Telephone = Convert.ToInt32(txtTelepone.Text);
            string Emp_Position = cmbEmpPosition.Text;
            DateTime DOB = dateTimePickerDOB.Value;
            
            string Email = txtEmail.Text;
            string NIC = txtNIC.Text;
            string Username = txtUserName.Text;
            string Password = txtPassword.Text;
            DateTime Join_Date = dateTimePicker1.Value;
            double Salary = Convert.ToDouble(txtSalary.Text);
            string Status = txtStatus.Text;


            //SQL UPDATE query
            string query = "UPDATE tblEmpDetails SET Email = @Email, Joining_Date = @Joining_Date, Telephone = @Telephone, Address = @Address, DOB = @DOB, Status = @Status, Password = @Password, User_Name = @User_Name, NIC = @NIC, Emp_Name = @Emp_Name, Position = @Position, Salary = @Salary WHERE Emp_ID = @Emp_ID";

            using (SqlConnection connection = new SqlConnection(connectionstring))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Emp_ID", Employee_ID);
                command.Parameters.AddWithValue("@Emp_Name", Employee_Name);
                command.Parameters.AddWithValue("@Address", Address);
                command.Parameters.AddWithValue("@Telephone", Telephone);
                command.Parameters.AddWithValue("@Position", Emp_Position);
                command.Parameters.AddWithValue("@DOB", DOB);
                
                command.Parameters.AddWithValue("@Email", Email);
                command.Parameters.AddWithValue("@NIC", NIC);
                command.Parameters.AddWithValue("@User_Name", Username);
                command.Parameters.AddWithValue("@Password", Password);
                command.Parameters.AddWithValue("@Joining_Date", Join_Date);
                command.Parameters.AddWithValue("@Salary", Salary);
                command.Parameters.AddWithValue("@Status", Status);

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

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtEmpID.Text = "";
            txtSalary.Text = "";
            txtEmpName.Text = "";
            txtAddress.Text = "";
            txtNIC.Text = "";
            txtTelepone.Text = "";
            txtEmail.Text = "";
            cmbEmpPosition.Text = "";
            dateTimePickerDOB.Text = "";
            dateTimePicker1.Text = "";
           ;
            txtStatus.Text = "";
            txtUserName.Text = "";
            txtPassword.Text = "";
        }

        private void timerDateTime_Tick(object sender, EventArgs e)
        {
            // Update the label with the current date and time
            label10.Text = DateTime.Now.ToString("dddd, MMMM dd yyyy - hh:mm:ss tt");
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void checkBoxFemale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewEmpDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridViewEmpDetails.Rows[e.RowIndex];
                txtEmpID.Text = selectedRow.Cells[0].Value.ToString();
                txtEmpName.Text = selectedRow.Cells[1].Value.ToString();
                txtAddress.Text = selectedRow.Cells[2].Value.ToString();
                txtTelepone.Text = selectedRow.Cells[3].Value.ToString();
                cmbEmpPosition.Text = selectedRow.Cells[4].Value.ToString();
                dateTimePickerDOB.Text = selectedRow.Cells[5].Value.ToString();
               
                txtEmail.Text = selectedRow.Cells[6].Value.ToString();
                txtNIC.Text = selectedRow.Cells[7].Value.ToString();
                txtUserName.Text = selectedRow.Cells[8].Value.ToString();
                txtPassword.Text = selectedRow.Cells[9].Value.ToString();
                dateTimePicker1.Text = selectedRow.Cells[10].Value.ToString();
                txtSalary.Text = selectedRow.Cells[11].Value.ToString();
                txtStatus.Text = selectedRow.Cells[12].Value.ToString();
                
                
                
               
                
               
            }
        }

        private void txtTelepone_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Add Data
            string Employee_ID = txtEmpID.Text;
            string Employee_Name = txtEmpName.Text;
            string Address = txtAddress.Text;
            int Telephone = Convert.ToInt32(txtTelepone.Text);
            string Emp_Position = cmbEmpPosition.Text;
            DateTime DOB = dateTimePickerDOB.Value;
            
            string Email = txtEmail.Text;
            string NIC = txtNIC.Text;
            string Username = txtUserName.Text;
            string Password = txtPassword.Text;
            DateTime Join_Date = dateTimePicker1.Value;
            double Salary = Convert.ToDouble(txtSalary.Text);
            string Status = txtStatus.Text;

            //SQL INSERT query
            string query = "INSERT INTO tblEmpDetails (Emp_ID,Emp_Name,Address,Telephone,Position,DOB,Email,NIC,User_Name,Password,Joining_Date,Salary,Status)" +
                "VALUES (@Emp_ID,@Emp_Name,@Address,@Telephone,@Position,@DOB,@Email,@NIC,@User_Name,@Password,@Joining_Date,@Salary,@Status)";

            using (SqlConnection connection = new SqlConnection(connectionstring))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Emp_ID",Employee_ID);
                command.Parameters.AddWithValue("@Emp_Name",Employee_Name);
                command.Parameters.AddWithValue("@Address",Address);
                command.Parameters.AddWithValue("@Telephone", Telephone);
                command.Parameters.AddWithValue("@Position", Emp_Position);
                command.Parameters.AddWithValue("@DOB", DOB);
                
                command.Parameters.AddWithValue("@Email", Email);
                command.Parameters.AddWithValue("@NIC", NIC);
                command.Parameters.AddWithValue("@User_Name", Username);
                command.Parameters.AddWithValue("@Password", Password);
                command.Parameters.AddWithValue("@Joining_Date", Join_Date);
                command.Parameters.AddWithValue("@Salary", Salary);
                command.Parameters.AddWithValue("@Status", Status);

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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmpID.Text))
            {

                MessageBox.Show("Please select a row to deleted.");
                return;

            }

            else
            {
                string query = "DELETE FROM tblEmpDetails WHERE Emp_ID = @Emp_ID";

                using (SqlConnection connection = new SqlConnection(connectionstring))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Emp_ID", txtEmpID.Text);
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
                            MessageBox.Show("No Pay Roll found wih Emp_ID" + txtEmpID.Text);
                        }
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show("Error:" + ex.Message);
                    }
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchEmp_ID = txtSearch.Text.Trim();

            if (!string.IsNullOrEmpty(searchEmp_ID))
            {
                try
                {
                    string query = "SELECT * FROM tblEmpDetails WHERE Emp_ID = @searchEmp_ID";

                    using (SqlConnection connection = new SqlConnection(connectionstring))
                    {
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@searchEmp_ID", searchEmp_ID);

                            connection.Open();

                            //Use SqlDataAdapter to fill a DataTable with the results
                            SqlDataAdapter adapter = new SqlDataAdapter(command);
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            if (dataTable.Rows.Count > 0)
                            {
                                //Bind the DataTable to a DataGridView to display the results
                                dataGridViewEmpDetails.DataSource = dataTable;
                            }
                            else
                            {
                                MessageBox.Show("No matching Emp_ID found.");
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

        private void rdbFemale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnView_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewerEmployeeDetails cryRpt = new ViewerEmployeeDetails();
            cryRpt.Show();
        }
    }
}
