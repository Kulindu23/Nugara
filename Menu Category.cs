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
    public partial class frmMenuCategoryid : Form
    {
        string connectionstring = (@"Data Source=DESKTOP-3F04SHD;Initial Catalog=Nugara;Integrated Security=True");
        public frmMenuCategoryid()
        {
            InitializeComponent();

            dataGridViewMenuCategoryName.CellClick += dataGridViewMenuCategoryName_CellContentClick;

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
            frmHome4 hp = new frmHome4();
            hp.Show();
        }

        private void timerDateTime_Tick(object sender, EventArgs e)
        {
            // Update the label with the current date and time
            lblDateTime.Text = DateTime.Now.ToString("dddd, MMMM dd yyyy - hh:mm:ss tt");
        }

        private void frmMenuCategoryid_Load(object sender, EventArgs e)
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
                    string query = "SELECT  * FROM tblMenuCategory";
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        adapter.Fill(table);
                    }
                    dataGridViewMenuCategoryName.DataSource = table;
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
        private void timerimage_Tick(object sender, EventArgs e)
        {


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void lblItemName_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Add Data
            string Menu_Category_ID = cmbmenucategory.Text;
            string Menu_Category_Name = cmbMenuCategoryName.Text;
            string Item_ID = cmbItemID.Text;
            string Item_Name = cmbItemName.Text;

            //SQL INSERT query
            string query = "INSERT INTO tblMenuCategory (Menu_Category_ID,Menu_Category_Name,Item_ID,Item_Name)" +
                "VALUES (@Menu_Category_ID,@Menu_Category_Name,@Item_ID,@Item_Name)";

            using (SqlConnection connection = new SqlConnection(connectionstring))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Menu_Category_ID", Menu_Category_ID);
                command.Parameters.AddWithValue("@Menu_Category_Name", Menu_Category_Name);
                command.Parameters.AddWithValue("@Item_ID", Item_ID);
                command.Parameters.AddWithValue("@Item_Name", Item_Name);


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



        private void dataGridViewMenuCategoryName_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridViewMenuCategoryName.Rows[e.RowIndex];
                cmbmenucategory.Text = selectedRow.Cells[0].Value.ToString();
                cmbMenuCategoryName.Text = selectedRow.Cells[1].Value.ToString();
                cmbItemID.Text = selectedRow.Cells[2].Value.ToString();
                cmbItemName.Text = selectedRow.Cells[3].Value.ToString();

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(cmbmenucategory.Text))
            {
                MessageBox.Show("Please select a row to update.");
                return;
            }

            //string Menu_Category_Name = cmbMenuCategoryName.Text;
            string Menu_Category_ID = cmbmenucategory.Text;
            string Menu_Category_Name = cmbMenuCategoryName.Text;
            string Item_ID = cmbItemID.Text;
            string Item_Name = cmbItemName.Text;


            //SQL UPDATE query
            string query = "UPDATE tblMenuCategory SET Menu_Category_Name = @Menu_Category_Name, Item_ID = @Item_ID, Item_Name = @Item_Name WHERE  Menu_Category_ID = @Menu_Category_ID";

            using (SqlConnection connection = new SqlConnection(connectionstring))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Menu_Category_ID", Menu_Category_ID);
                command.Parameters.AddWithValue("@Menu_Category_Name", Menu_Category_Name);
                command.Parameters.AddWithValue("@Item_ID", Item_ID);
                command.Parameters.AddWithValue("@Item_Name", Item_Name);



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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbmenucategory.Text))
            {

                MessageBox.Show("Please select a row to deleted.");
                return;

            }

            else
            {
                string query = "DELETE FROM tblMenuCategory WHERE Menu_Category_ID = @Menu_Category_ID";

                using (SqlConnection connection = new SqlConnection(connectionstring))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Menu_Category_ID", cmbmenucategory.Text);
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
                            MessageBox.Show("No Order found wih Menu_Category_ID" + cmbmenucategory);
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
            cmbmenucategory.Text = "";
            cmbMenuCategoryName.Text = "";
            cmbItemID.Text = "";
            cmbItemName.Text = "";
        }
    }
    
    
}
    
