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
    public partial class frmKOT : Form
    {
        string connectionstring = (@"Data Source=DESKTOP-3F04SHD;Initial Catalog=Nugara;Integrated Security=True");
        public frmKOT()
        {
            InitializeComponent();

            // Start the timer when the form loads
            timerDateTime.Tick += timerDateTime_Tick;
            timerDateTime.Start();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmOrder hp = new frmOrder();
            hp.Show();
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

        private void frmKOT_Load(object sender, EventArgs e)
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
                    string query = "SELECT  * FROM tblKOT";
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        adapter.Fill(table);
                    }
                    dataGridViewKOT.DataSource = table;
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
        private void btnPrint_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewrKOT2 cryRpt = new ViewrKOT2();
            cryRpt.Show();
        }

        private void btnView_Click(object sender, EventArgs e)
        {

            
            

        }

        private void dataGridViewKOT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtOrderID.Text = "";
            txtItemName.Text = "";
            txtQuantity.Text = "";
            cmbSize.Text = "";
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Add Data
           
            string Order_ID = txtOrderID.Text;          
            string Item_Name = txtItemName.Text;
            string Size = cmbSize.Text;
            int Quantity = Convert.ToInt32(txtQuantity.Text);
            
            

            //SQL INSERT query
            string query = "INSERT INTO tblKOT (Order_ID,Item_Name,Quantity,Size)" +
                "VALUES (@Order_ID,@Item_Name,@Quantity,@Size)";

            using (SqlConnection connection = new SqlConnection(connectionstring))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                
                command.Parameters.AddWithValue("@Order_ID", Order_ID);
                command.Parameters.AddWithValue("@Item_Name", Item_Name);
                command.Parameters.AddWithValue("@Size", Size);
                command.Parameters.AddWithValue("Quantity", Quantity);
                
                
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

        }
    }
}
