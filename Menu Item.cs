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
    public partial class frmMenuItem : Form
    {
        string connectionstring = (@"Data Source=DESKTOP-3F04SHD;Initial Catalog=Nugara;Integrated Security=True");
        public frmMenuItem()
        {
            InitializeComponent();
            dataGridViewMenuItem.CellClick += dataGridViewMenuItem_CellContentClick;

            // Start the timer when the form loads
            timerDateTime.Tick += timerDateTime_Tick;
            timerDateTime.Start();
        }

        private void lblsize_Click(object sender, EventArgs e)
        {

        }

        private void lblmenucategory_Click(object sender, EventArgs e)
        {

        }

        private void lblprice_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Add Data
            string Menu_Category_Name = cmbMenucategoryname.Text;
            string Item_ID = cmbItemID.Text;
            string Item_Name = txtItemName.Text;
            string Size = cmbSize.Text;
            double Price = Convert.ToDouble(txtPrice.Text);

            //SQL INSERT query
            string query = "INSERT INTO tblMenuItem (Menu_Category_Name,Item_ID,Item_Name,Size,Price)" +
                "VALUES (@Menu_Category_Name,@Item_ID,@Item_Name,@Size,@Price)";

            using(SqlConnection connection=new SqlConnection (connectionstring))
            using(SqlCommand command = new SqlCommand(query,connection))
            {
                command.Parameters.AddWithValue("@Menu_Category_Name",Menu_Category_Name);
                command.Parameters.AddWithValue("@Item_ID", Item_ID);
                command.Parameters.AddWithValue("@Item_Name", Item_Name);
                command.Parameters.AddWithValue("@Size", Size);
                command.Parameters.AddWithValue("@Price", Price);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if(rowsAffected>0)
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
                catch(Exception ex)
                {
                    MessageBox.Show("Error", ex.Message);
                }
            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHome hp = new frmHome();
            hp.Show();
        }

        private void frmMenuItem_Load(object sender, EventArgs e)
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
                    string query = "SELECT  * FROM tblMenuItem";
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        adapter.Fill(table);
                    }
                    dataGridViewMenuItem.DataSource = table;
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error", ex.Message);
                }
            finally
                {
                    connection.Close();
                }
        }

        private void dataGridViewMenuItem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0)
            {
                DataGridViewRow selectedRow = dataGridViewMenuItem.Rows[e.RowIndex];
                cmbMenucategoryname.Text = selectedRow.Cells[0].Value.ToString();
                cmbItemID.Text = selectedRow.Cells[1].Value.ToString();
                txtItemName.Text = selectedRow.Cells[2].Value.ToString();
                cmbSize.Text = selectedRow.Cells[3].Value.ToString();
                txtPrice.Text=selectedRow.Cells[4].Value.ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(cmbItemID.SelectedItem.ToString()))
            {
                MessageBox.Show("Please select a row to update.");
                return;
            }

            
            string Menu_Category_Name = cmbMenucategoryname.Text;
            string Item_ID = cmbItemID.Text;
            string Item_Name = txtItemName.Text;
            string Size = cmbSize.Text;
            double Price = Convert.ToDouble(txtPrice.Text);

            //SQL UPDATE query
            string query = "UPDATE tblMenuItem SET Menu_Category_Name = @Menu_Category_Name, Item_Name = @Item_Name, Size = @Size, Price = @Price WHERE Item_ID = @Item_ID";

            using (SqlConnection connection = new SqlConnection(connectionstring))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Menu_Category_Name", Menu_Category_Name);
                command.Parameters.AddWithValue("@Item_ID", Item_ID);
                command.Parameters.AddWithValue("@Item_Name", Item_Name);
                command.Parameters.AddWithValue("@Size", Size);
                command.Parameters.AddWithValue("@Price", Price);

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
            if(string.IsNullOrEmpty(cmbItemID.SelectedItem.ToString()))
            {
                
                  MessageBox.Show("Please select a row to deleted.");
                  return;
                
            }

            else
            {
                string query = "DELETE FROM tblMenuItem WHERE Item_ID = @Item_ID";

                using (SqlConnection connection = new SqlConnection(connectionstring))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Item_ID", cmbItemID.Text);
                    try
                    {
                        connection.Open();
                        int rowAffected = command.ExecuteNonQuery();
                        if(rowAffected > 0)
                        {
                            MessageBox.Show( "Deleted successfully");
                            LoadData(); //Refresh DataGridView
                            
                        }
                        else
                        {
                            MessageBox.Show("No Menu_Item found wih Item_ID" + cmbItemID.SelectedItem.ToString());
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
            string searchItem_ID = txtSearch.Text.Trim();

            if(!string.IsNullOrEmpty(searchItem_ID))
            {
                try
                {
                    string query = "SELECT * FROM tblMenuItem WHERE Item_ID = @searchItem_ID";

                    using(SqlConnection connection = new SqlConnection(connectionstring))
                    {
                        using(SqlCommand command = new SqlCommand(query,connection))
                        {
                            command.Parameters.AddWithValue("@searchItem_ID", searchItem_ID);

                            connection.Open();

                            //Use SqlDataAdapter to fill a DataTable with the results
                            SqlDataAdapter adapter = new SqlDataAdapter(command);
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            if(dataTable.Rows.Count > 0)
                            {
                                //Bind the DataTable to a DataGridView to display the results
                                dataGridViewMenuItem.DataSource = dataTable;
                            }
                            else
                            {
                                MessageBox.Show("No matching Item_ID found.");
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

        private void lblCut_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timerDateTime_Tick(object sender, EventArgs e)
        {
            // Update the label with the current date and time
            lblDateTime.Text = DateTime.Now.ToString("dddd, MMMM dd yyyy - hh:mm:ss tt");
        }

        private void cmbMenucategoryname_SelectedIndexChanged(object sender, EventArgs e)
        {
            AutoFillDetails();
        }

        private void cmbItemID_SelectedIndexChanged(object sender, EventArgs e)
        {
            AutoFillDetails();
        }

        private void cmbSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            AutoFillDetails();
        }

        public void AutoFillDetails()
        {
            //Get selected values
            string Menu_Category_Name = cmbMenucategoryname.Text;
            string ItemID = cmbItemID.Text;
            string Size = cmbSize.Text;

            //Ensure required fields are filled
            if (string.IsNullOrEmpty(Menu_Category_Name) || string.IsNullOrEmpty(ItemID) || string.IsNullOrEmpty(Size))
            {
                return;
            }

            //SQL query to fetch ite details
            string query = "SELECT Item_Name,Price FROM tblMenuItem WHERE Menu_Category_Name = @Menu_Category_Name AND Item_ID = @Item_ID AND Size = @Size";

            using (SqlConnection connection = new SqlConnection(connectionstring))
            using (SqlCommand command = new SqlCommand(query,connection))
            {
                command.Parameters.AddWithValue("@Menu_Category_Name", Menu_Category_Name);
                command.Parameters.AddWithValue("@Item_ID", ItemID);
                command.Parameters.AddWithValue("@Size", Size);

                try
                {
                    connection.Open();
                    using(SqlDataReader reader = command.ExecuteReader())
                    {
                        if(reader.Read())
                        {
                            //Auto fill the fields
                            txtItemName.Text = reader["Item_Name"].ToString();
                            txtPrice.Text = reader["Price"].ToString();
                        }
                        else
                        {
                            //clear fields if no matching record is found
                            txtItemName.Clear();
                            txtPrice.Clear();
                        }
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error:", ex.Message);
                }

                finally
                {
                    connection.Close();
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cmbMenucategoryname.Text = "";
            cmbItemID.Text = "";
            txtItemName.Text = "";
            cmbSize.Text = "";
            txtPrice.Text = "";

        }

        private void btnView_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewerMenuItem cryRpt = new ViewerMenuItem();
            cryRpt.Show();
        }
    }
}
