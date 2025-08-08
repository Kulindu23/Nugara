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
    public partial class frmReport : Form
    {
        string connectionstring = (@"Data Source=DESKTOP-3F04SHD;Initial Catalog=Nugara;Integrated Security=True");
        public frmReport()
        {
            InitializeComponent();

            // Update the label with the current date and time
            lblDateTime.Text = DateTime.Now.ToString("dddd, MMMM dd yyyy - hh:mm:ss tt");
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

        private void frmReport_Load(object sender, EventArgs e)
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
                    string query = "SELECT  * FROM tblReport";
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewerReservation cryRpt = new ViewerReservation();
            cryRpt.Show();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Add Data
            string Order_ID = txtOrderID.Text;
            string Customer_ID = txtCustomerID.Text;
            string Item_Name = txtItemName.Text;
            string Comment = txtComment.Text;
            int Ranking = Convert.ToInt32(txtRanking.Text);
           

            //SQL INSERT query
            string query = "INSERT INTO tblReport (Order_ID,Customer_ID,Item_Name,Rating,Comment)" +
                "VALUES (@Order_ID,@Customer_ID,@Item_Name,@Rating,@Comment)";

            using (SqlConnection connection = new SqlConnection(connectionstring))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Order_ID", Order_ID);
                command.Parameters.AddWithValue("@Item_Name", Item_Name);
                command.Parameters.AddWithValue("Customer_ID", Customer_ID);
                command.Parameters.AddWithValue("@Rating", Ranking);
                command.Parameters.AddWithValue("@Comment", Comment);
                

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

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtOrderID.Text = "";
            txtItemName.Text = "";
            txtComment.Text = "";
            txtCustomerID.Text = "";
            txtRanking.Text = "";

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewerReport cryRpt = new ViewerReport();
            cryRpt.Show();
        }
    }
}
