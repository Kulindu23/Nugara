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
    public partial class frmCustomer : Form
    {
        string connectionstring = (@"Data Source=DESKTOP-3F04SHD;Initial Catalog=Nugara;Integrated Security=True");
        public frmCustomer()
        {
            InitializeComponent();

            dataGridViewCustomer.CellClick += dataGridViewCustomer_CellContentClick;

            // Start the timer when the form loads
            timerDateTime.Tick += timerDateTime_Tick;
            timerDateTime.Start();
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            LoadData();
            // Optional: Set initial value for the label
            lblDateTime.Text = DateTime.Now.ToString("dddd, MMMM dd yyyy - hh:mm:ss tt");
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

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHome2 hp = new frmHome2();
            hp.Show();
        }

        private void LoadData()
        {
            DataTable table = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionstring))

                try
                {
                    connection.Open();
                    string query = "SELECT  * FROM tblCustomer";
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        adapter.Fill(table);
                    }
                    dataGridViewCustomer.DataSource = table;
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

        private void lblBalance_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Add Data
            string Customer_ID = txtCustomerID.Text;
            string Customer_Name = txtCustomerName.Text;
            string Address = txtAddress.Text;
            int Phone = Convert.ToInt32(txtPhone.Text);
            string Email = txtEmail.Text;
            string NIC = txtNIC.Text;

            //SQL INSERT query
            string query = "INSERT INTO tblCustomer (Customer_ID,Customer_Name,Address,Telephone,Email,NIC)" +
                "VALUES (@Customer_ID,@Customer_Name,@Address,@Telephone,@Email,@NIC)";

            using (SqlConnection connection = new SqlConnection(connectionstring))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Customer_ID", Customer_ID);
                command.Parameters.AddWithValue("@Customer_Name", Customer_Name);
                command.Parameters.AddWithValue("@Address", Address);
                command.Parameters.AddWithValue("@Telephone", Phone);
                command.Parameters.AddWithValue("@Email", Email);
                command.Parameters.AddWithValue("@NIC", NIC);


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

        private void dataGridViewCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridViewCustomer.Rows[e.RowIndex];
                txtCustomerID.Text = selectedRow.Cells[0].Value.ToString();
                txtCustomerName.Text = selectedRow.Cells[1].Value.ToString();
                txtAddress.Text = selectedRow.Cells[2].Value.ToString();
                txtPhone.Text = selectedRow.Cells[3].Value.ToString();
                txtEmail.Text = selectedRow.Cells[4].Value.ToString();
                txtNIC.Text = selectedRow.Cells[5].Value.ToString();

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
                string query = "DELETE FROM tblCustomer WHERE Customer_ID = @Customer_ID";

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
                            MessageBox.Show("Deleted successfully");
                            LoadData(); //Refresh DataGridView

                        }
                        else
                        {
                            MessageBox.Show("No Order found wih Customer_ID" + txtCustomerID);
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



            //SQL UPDATE query
            string query = "UPDATE tblCustomer SET Customer_Name = @Customer_Name, Address = @Address, Telephone = @Telephone, Email = @Email, NIC = @NIC WHERE Customer_ID = @Customer_ID";

            using (SqlConnection connection = new SqlConnection(connectionstring))
            using (SqlCommand command = new SqlCommand(query, connection))
            {

                command.Parameters.AddWithValue("@Customer_ID", Customer_ID);
                command.Parameters.AddWithValue("@Customer_Name", Customer_Name);
                command.Parameters.AddWithValue("@Address", Address);
                command.Parameters.AddWithValue("@Telephone", Phone);
                command.Parameters.AddWithValue("@Email", Email);
                command.Parameters.AddWithValue("@NIC", NIC);



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

        private void btnnext_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLoyalty hp = new frmLoyalty();
            hp.Show();
        }
    }
    
}
