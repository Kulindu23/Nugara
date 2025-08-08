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
    public partial class frmGRN : Form
    {
        string connectionstring = (@"Data Source=DESKTOP-3F04SHD;Initial Catalog=Nugara;Integrated Security=True");
        public frmGRN()
        {
            InitializeComponent();
            dataGridViewGRN.CellClick += dataGridViewGRN_CellContentClick;

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

        private void txtGRNID_TextChanged(object sender, EventArgs e)
        {

        }

        private void timerDateTime_Tick(object sender, EventArgs e)
        {
            // Update the label with the current date and time
            lblDateTime.Text = DateTime.Now.ToString("dddd, MMMM dd yyyy - hh:mm:ss tt");
        }

        private void frmGRN_Load(object sender, EventArgs e)
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
                    string query = "SELECT  * FROM tblGRN";
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        adapter.Fill(table);
                    }
                    dataGridViewGRN.DataSource = table;
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Add Data
            int GRN_ID = Convert.ToInt32(txtGRNID.Text);
            int Invoice_No = Convert.ToInt32(txtInvoiceNo.Text);
            DateTime Date = dtpDate.Value;
            string Conditions_Of_Raw_Material = txtCORM.Text;


            //SQL INSERT query
            string query = "INSERT INTO tblGRN (GRN_ID,Inovice_No,Date,Condition_Of_Raw_Material)" +
                "VALUES (@GRN_ID,@Inovice_No,@Date,@Condition_Of_Raw_Material)";

            using (SqlConnection connection = new SqlConnection(connectionstring))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@GRN_ID", GRN_ID);
                command.Parameters.AddWithValue("@Inovice_No", Invoice_No);
                command.Parameters.AddWithValue("@Date", Date );
                command.Parameters.AddWithValue("@Condition_Of_Raw_Material", Conditions_Of_Raw_Material);


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

        private void dataGridViewGRN_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridViewGRN.Rows[e.RowIndex];
                txtGRNID.Text = selectedRow.Cells[0].Value.ToString();
                txtInvoiceNo.Text = selectedRow.Cells[1].Value.ToString();
                dtpDate.Text = selectedRow.Cells[2].Value.ToString();
                txtCORM.Text = selectedRow.Cells[3].Value.ToString();

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtGRNID.Text))
            {
                MessageBox.Show("Please select a row to update.");
                return;
            }


            int GRN_ID = Convert.ToInt32(txtGRNID.Text);
            int Invoice_No = Convert.ToInt32(txtInvoiceNo.Text);
            DateTime Date = dtpDate.Value;
            string Conditions_Of_Raw_Material = txtCORM.Text;

            //SQL UPDATE query
            string query = "UPDATE tblGRN SET Inovice_No = @Inovice_NO, Date = @Date, Condition_Of_Raw_Material = @Condition_Of_Raw_Material WHERE GRN_ID = @GRN_ID";

            using (SqlConnection connection = new SqlConnection(connectionstring))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@GRN_ID", GRN_ID);
                command.Parameters.AddWithValue("@Inovice_No", Invoice_No);
                command.Parameters.AddWithValue("@Date", Date );
                command.Parameters.AddWithValue("@Condition_Of_Raw_Material", Conditions_Of_Raw_Material);

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
            if (string.IsNullOrEmpty(txtGRNID.Text))
            {

                MessageBox.Show("Please select a row to deleted.");
                return;

            }

            else
            {
                string query = "DELETE FROM tblGRN WHERE GRN_ID = @GRN_ID";

                using (SqlConnection connection = new SqlConnection(connectionstring))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@GRN_ID", txtGRNID.Text);
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
                            MessageBox.Show("No GRN found wih GRN_ID" + txtGRNID.Text);
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
            txtGRNID.Text = "";
            txtInvoiceNo.Text = "";
            dtpDate.Text = "";
            txtCORM.Text = "";
            
        }
    }
}
    
