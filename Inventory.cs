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
    public partial class frmInventory : Form
    {
        string connectionstring = (@"Data Source=DESKTOP-3F04SHD;Initial Catalog=Nugara;Integrated Security=True");
        public frmInventory()
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

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHome2 hp = new frmHome2();
            hp.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void frmInventory_Load(object sender, EventArgs e)
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
                    string query = "SELECT  * FROM tblInventory";
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

        private void timerDateTime_Tick(object sender, EventArgs e)
        {
            // Update the label with the current date and time
            lblDateTime.Text = DateTime.Now.ToString("dddd, MMMM dd yyyy - hh:mm:ss tt");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                txtMaterialID.Text = selectedRow.Cells[0].Value.ToString();
                txtMaterialName.Text = selectedRow.Cells[1].Value.ToString();
                dateTimePickerAdd.Text = selectedRow.Cells[2].Value.ToString();
                dateTimePickerOut.Text = selectedRow.Cells[3].Value.ToString();
                txtReturn.Text = selectedRow.Cells[4].Value.ToString();
                txtAvailable.Text = selectedRow.Cells[5].Value.ToString();

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtMaterialID.Text = "";
            txtMaterialName.Text = "";
            dateTimePickerAdd.Text = "";
            dateTimePickerOut.Text = "";
            txtReturn.Text = "";
            txtAvailable.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaterialID.Text))
            {

                MessageBox.Show("Please select a row to deleted.");
                return;

            }

            else
            {
                string query = "DELETE FROM tblInventory WHERE Material_ID = @Material_ID";

                using (SqlConnection connection = new SqlConnection(connectionstring))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Material_ID", txtMaterialID.Text);
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
                            MessageBox.Show("No Order found wih Material_ID" + txtMaterialID);
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
            string Material_ID = txtMaterialID.Text;
            string Material_Name = txtMaterialName.Text;
            DateTime Add_Date = dateTimePickerAdd.Value;
            DateTime Out_Date = dateTimePickerOut.Value;
            int Return = Convert.ToInt32(txtReturn.Text);
            int Available = Convert.ToInt32(txtAvailable.Text);

            //SQL INSERT query
            string query = "INSERT INTO tblInventory (Material_ID,Material_Name,Add_Date,Out_Date,Return_Quantity,Available_Quantity)" +
                "VALUES (@Material_ID,@Material_Name,@Add_Date,@Out_Date,@Return_Quantity,@Available_Quantity)";

            using (SqlConnection connection = new SqlConnection(connectionstring))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Material_ID", Material_ID);
                command.Parameters.AddWithValue("@Material_Name", Material_Name);
                command.Parameters.AddWithValue("@Add_Date", Add_Date);
                command.Parameters.AddWithValue("@Out_Date", Out_Date);
                command.Parameters.AddWithValue("@Return_Quantity", Return);
                command.Parameters.AddWithValue("@Available_Quantity", Available);


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
            if (string.IsNullOrEmpty(txtMaterialID.Text))
            {
                MessageBox.Show("Please select a row to update.");
                return;
            }


            string Material_ID = txtMaterialID.Text;
            string Material_Name = txtMaterialName.Text;
            DateTime Add_Date = dateTimePickerAdd.Value;
            DateTime Out_Date = dateTimePickerOut.Value;
            int Return = Convert.ToInt32(txtReturn.Text);
            int Available = Convert.ToInt32(txtAvailable.Text);


            //SQL UPDATE query
            string query = "UPDATE tblInventory SET Material_Name = @Material_Name, Add_Date = @Add_Date, Out_Date = @Out_Date, Return_Quantity = @Return_Quantity, Available_Quantity = @Available_Quantity WHERE Material_ID = @Material_ID";

            using (SqlConnection connection = new SqlConnection(connectionstring))
            using (SqlCommand command = new SqlCommand(query, connection))
            {

                command.Parameters.AddWithValue("@Material_ID", Material_ID);
                command.Parameters.AddWithValue("@Material_Name", Material_Name);
                command.Parameters.AddWithValue("@Add_Date", Add_Date);
                command.Parameters.AddWithValue("@Out_Date", Out_Date);
                command.Parameters.AddWithValue("@Return_Quantity", Return);
                command.Parameters.AddWithValue("@Available_Quantity", Available);



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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchMaterial_ID = txtSearch.Text.Trim();

            if (!string.IsNullOrEmpty(searchMaterial_ID))
            {
                try
                {
                    string query = "SELECT * FROM tblInventory WHERE Material_ID = @searchMaterial_ID";

                    using (SqlConnection connection = new SqlConnection(connectionstring))
                    {
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@searchMaterial_ID", searchMaterial_ID);

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
                                MessageBox.Show("No matching Material_ID found.");
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

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnView_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewerInventory2 cryRpt = new ViewerInventory2();
            cryRpt.Show();
        }
    }
}
                
            
        
    


