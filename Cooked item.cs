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
    public partial class frmCookedItem : Form
    {
        string connectionstring = (@"Data Source=DESKTOP-3F04SHD;Initial Catalog=Nugara;Integrated Security=True");
        public frmCookedItem()
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

        private void toolTipBack_Popup(object sender, PopupEventArgs e)
        {
            
        }

        private void frmCookedItem_Load(object sender, EventArgs e)
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
                    string query = "SELECT  * FROM tblCookedItem";
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        adapter.Fill(table);
                    }
                    dataGridViewCookedItem.DataSource = table;
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCookedItemID.Text = "";
            txtcookeditemname.Text = "";
            txtQuantity.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCookedItemID.Text))
            {

                MessageBox.Show("Please select a row to deleted.");
                return;

            }

            else
            {
                string query = "DELETE FROM tblCookedItem WHERE Cooked_Item_ID = @Cooked_Item_ID";

                using (SqlConnection connection = new SqlConnection(connectionstring))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Cooked_Item_ID", txtCookedItemID.Text);
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
                            MessageBox.Show("No Order found wih Cooked_Item_ID" + txtCookedItemID);
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
            if (string.IsNullOrEmpty(txtCookedItemID.Text))
            {
                MessageBox.Show("Please select a row to update.");
                return;
            }

            string Cooked_Item_ID = txtCookedItemID.Text;
            string Cooked_Item_Name = txtcookeditemname.Text;
            int Quantity = Convert.ToInt32(txtQuantity.Text);
            



            //SQL UPDATE query
            string query = "UPDATE tblCookedItem SET Cooked_Item_Name = @Cooked_Item_Name, Quantity = @Quantity WHERE Cooked_Item_ID = @Cooked_Item_ID";

            using (SqlConnection connection = new SqlConnection(connectionstring))
            using (SqlCommand command = new SqlCommand(query, connection))
            {

                command.Parameters.AddWithValue("@Cooked_Item_ID", Cooked_Item_ID);
                command.Parameters.AddWithValue("@Cooked_Item_Name", Cooked_Item_Name);
                command.Parameters.AddWithValue("@Quantity", Quantity);
                



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
            string Cooked_Item_ID = txtCookedItemID.Text;
            string Cooked_Item_Name = txtcookeditemname.Text;
            int Quantity = Convert.ToInt32(txtQuantity.Text);
            

            //SQL INSERT query
            string query = "INSERT INTO tblCookedItem (Cooked_Item_ID,Cooked_Item_Name,Quantity)" +
                "VALUES (@Cooked_Item_ID,@Cooked_Item_Name,@Quantity)";

            using (SqlConnection connection = new SqlConnection(connectionstring))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Cooked_Item_ID", Cooked_Item_ID);
                command.Parameters.AddWithValue("@Cooked_Item_Name", Cooked_Item_Name);
                command.Parameters.AddWithValue("@Quantity", Quantity);
                


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

        private void dataGridViewCookedItem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHome4 hp = new frmHome4();
            hp.Show();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            

        }
    }
}
