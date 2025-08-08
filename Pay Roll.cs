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
    public partial class frmPayRoll : Form
    {
        string connectionstring = (@"Data Source=DESKTOP-3F04SHD;Initial Catalog=Nugara;Integrated Security=True");
        public frmPayRoll()
        {
            InitializeComponent();

            dataGridView1.CellClick += dataGridView1_CellContentClick;

            // Start the timer when the form loads
            timerDateTime.Tick += timerDateTime_Tick;
            timerDateTime.Start();
        }

        private void lblCut_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timerDateTime_Tick(object sender, EventArgs e)
        {
            // Update the label with the current date and time
            lblDateTime.Text = DateTime.Now.ToString("dddd, MMMM dd yyyy - hh:mm:ss tt");
        }

        private void frmPayRoll_Load(object sender, EventArgs e)
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
                    string query = "SELECT  * FROM tblPayRoll";
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        adapter.Fill(table);
                    }
                    dataGridView1.DataSource = table;
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
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHome3 hp = new frmHome3();
            hp.Show();

        }

        private void dateTimePickerDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPayRollID.Text))
            {
                MessageBox.Show("Please select a row to update.");
                return;
            }

            int Pay_Roll_ID = Convert.ToInt32(txtPayRollID.Text);
            string Employee_ID = txtEmpID.Text;
            string Employee_Name = txtEmpName.Text;
            string Employee_Position = cmbEmpPosition.Text;
            DateTime Date = dateTimePickerDate.Value;
            double Salary = Convert.ToDouble(txtSalary.Text);
            int Working_Date = Convert.ToInt32(numericUpDown1.Value);

            //SQL UPDATE query
            string query = "UPDATE tblPayRoll SET Employee_ID = @Employee_ID, Employee_Name = @Employee_Name, Employee_Position = @Employee_Position, Date = @Date, Salary = @Salary, Working_Dates = @Working_Dates WHERE Pay_Roll_ID = @Pay_Roll_ID";

            using (SqlConnection connection = new SqlConnection(connectionstring))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Pay_Roll_ID", Pay_Roll_ID);
                command.Parameters.AddWithValue("@Employee_ID", Employee_ID);
                command.Parameters.AddWithValue("@Employee_Name", Employee_Name);
                command.Parameters.AddWithValue("@Employee_Position", Employee_Position);
                command.Parameters.AddWithValue("@Date", Date);
                command.Parameters.AddWithValue("@Salary",Salary);
                command.Parameters.AddWithValue("@Working_Dates", Working_Date);

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                txtPayRollID.Text = selectedRow.Cells[0].Value.ToString();
                txtEmpID.Text = selectedRow.Cells[1].Value.ToString();
                txtEmpName.Text = selectedRow.Cells[2].Value.ToString();
                cmbEmpPosition.Text = selectedRow.Cells[3].Value.ToString();
                dateTimePickerDate.Text = selectedRow.Cells[4].Value.ToString();
                txtSalary.Text = selectedRow.Cells[5].Value.ToString();
                numericUpDown1.Text = selectedRow.Cells[6].Value.ToString();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPayRollID.Text = "";
            txtEmpID.Text = "";
            txtEmpName.Text = "";
            txtSalary.Text = "";
            dateTimePickerDate.Text = "";
            cmbEmpPosition.Text = "";
            numericUpDown1.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPayRollID.Text))
            {

                MessageBox.Show("Please select a row to deleted.");
                return;

            }

            else
            {
                string query = "DELETE FROM tblPayRoll WHERE Pay_Roll_ID = @Pay_Roll_ID";

                using (SqlConnection connection = new SqlConnection(connectionstring))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Pay_Roll_ID", txtPayRollID.Text);
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
                            MessageBox.Show("No Pay Roll found wih Pay_Roll_ID" + txtPayRollID.Text);
                        }
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show("Error:" + ex.Message);
                    }
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Add Data
            int Pay_Roll_ID = Convert.ToInt32(txtPayRollID.Text);
            string Employee_ID = txtEmpID.Text;
            string Employee_Name = txtEmpName.Text;
            string Employee_Position = cmbEmpPosition.Text;
            DateTime Date = dateTimePickerDate.Value;
            double Salary = Convert.ToDouble(txtSalary.Text);
            int Working_Date = Convert.ToInt32(numericUpDown1.Value);

            //SQL INSERT query
            string query = "INSERT INTO tblPayRoll (Pay_Roll_ID,Employee_ID,Employee_Name,Employee_Position,Date,Salary,Working_Dates)" +
                "VALUES (@Pay_Roll_ID,@Employee_ID,@Employee_name,@Employee_Position,@Date,@Salary,@Working_Dates)";

            using (SqlConnection connection = new SqlConnection(connectionstring))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Pay_Roll_ID", Pay_Roll_ID);
                command.Parameters.AddWithValue("@Employee_ID", Employee_ID);
                command.Parameters.AddWithValue("@Employee_Name", Employee_Name);
                command.Parameters.AddWithValue("@Employee_Position", Employee_Position);
                command.Parameters.AddWithValue("@Date", Date);
                command.Parameters.AddWithValue("@Salary", Salary);
                command.Parameters.AddWithValue("@Working_Dates", Working_Date);

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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchEmployee_ID = txtSearch.Text.Trim();

            if (!string.IsNullOrEmpty(searchEmployee_ID))
            {
                try
                {
                    string query = "SELECT * FROM tblPayRoll WHERE Employee_ID = @searchEmployee_ID";

                    using (SqlConnection connection = new SqlConnection(connectionstring))
                    {
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@searchEmployee_ID", searchEmployee_ID);

                            connection.Open();

                            //Use SqlDataAdapter to fill a DataTable with the results
                            SqlDataAdapter adapter = new SqlDataAdapter(command);
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            if (dataTable.Rows.Count > 0)
                            {
                                //Bind the DataTable to a DataGridView to display the results
                                dataGridView1.DataSource = dataTable;
                            }
                            else
                            {
                                MessageBox.Show("No matching Employee_ID found.");
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

        private void btnPrint_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewerPayRoll cryRpt = new ViewerPayRoll();
            cryRpt.Show();
        }
    }
}
