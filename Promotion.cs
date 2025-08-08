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
    public partial class frmPromotion : Form
    {
        string connectionstring = (@"Data Source=DESKTOP-3F04SHD;Initial Catalog=Nugara;Integrated Security=True");
        public frmPromotion()
        {
            InitializeComponent();

            dataGridViewPromotion.CellClick += dataGridViewPromotion_CellContentClick;

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

        private void frmPromotion_Load(object sender, EventArgs e)
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
                    string query = "SELECT  * FROM tblPromotion";
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        adapter.Fill(table);
                    }
                    dataGridViewPromotion.DataSource = table;
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

        private void dataGridViewPromotion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridViewPromotion.Rows[e.RowIndex];
                txtPromotionID.Text = selectedRow.Cells[0].Value.ToString();
                txtPromotionName.Text = selectedRow.Cells[1].Value.ToString();
                cmbPromotionType.Text = selectedRow.Cells[2].Value.ToString();
                txtDiscountPrecentage.Text = selectedRow.Cells[3].Value.ToString();
                dtpDate.Text = selectedRow.Cells[4].Value.ToString();
                txtPromotionStatus.Text = selectedRow.Cells[5].Value.ToString();

            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            txtPromotionID.Text = "";
            txtPromotionName.Text = "";
            cmbPromotionType.Text = "";
            txtDiscountPrecentage.Text = "";
            dtpDate.Text = "";
            txtPromotionStatus.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Add Data
            string Promotion_ID = txtPromotionID.Text;
            string Promotion_Name = txtPromotionName.Text;
            string Promotion_Type = cmbPromotionType.Text;
            string Discount_Precentage = txtDiscountPrecentage.Text;
            DateTime Date = dtpDate.Value;
            string Promotion_Status = txtPromotionID.Text;

            

            //SQL INSERT query
            string query = "INSERT INTO tblPromotion (Promotion_ID,Promotion_Name,Promotion_Type,Discount_Percentage,Date,Promotion_Status)" +
                "VALUES (@Promotion_ID,@Promotion_Name,@Promotion_Type,@Discount_Percentage,@Date,@Promotion_Status)";

            using (SqlConnection connection = new SqlConnection(connectionstring))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Promotion_ID", Promotion_ID);
                command.Parameters.AddWithValue("@Promotion_Name", Promotion_Name);
                command.Parameters.AddWithValue("@Promotion_Type", Promotion_Type);
                command.Parameters.AddWithValue("@Discount_Percentage", Discount_Precentage);
                command.Parameters.AddWithValue("@Date", Date);
                command.Parameters.AddWithValue("@Promotion_Status", Promotion_Status);


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
            if (string.IsNullOrEmpty(txtPromotionID.Text))
            {
                MessageBox.Show("Please select a row to update.");
                return;
            }

            string Promotion_ID = txtPromotionID.Text;
            string Promotion_Name = txtPromotionName.Text;
            string Promotion_Type = cmbPromotionType.Text;
            string Discount_Precentage = txtDiscountPrecentage.Text;
            DateTime Date = dtpDate.Value;
            string Promotion_Status = txtPromotionID.Text;



            //SQL UPDATE query
            string query = "UPDATE tblPromotion SET Promotion_Name = @Promotion_Name, Promotion_Type = @Promotion_Type, Discount_Percentage = @Discount_Percentage, Date = @Date, Promotion_Status = @Promotion_Status WHERE Promotion_ID = @Promotion_ID";

            using (SqlConnection connection = new SqlConnection(connectionstring))
            using (SqlCommand command = new SqlCommand(query, connection))
            {

                command.Parameters.AddWithValue("@Promotion_ID", Promotion_ID);
                command.Parameters.AddWithValue("@Promotion_Name", Promotion_Name);
                command.Parameters.AddWithValue("@Promotion_Type", Promotion_Type);
                command.Parameters.AddWithValue("@Discount_Percentage", Discount_Precentage);
                command.Parameters.AddWithValue("@Date", Date);
                command.Parameters.AddWithValue("@Promotion_Status", Promotion_Status);


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
            if (string.IsNullOrEmpty(txtPromotionID.Text))
            {

                MessageBox.Show("Please select a row to deleted.");
                return;

            }

            else
            {
                string query = "DELETE FROM tblPromotion WHERE Promotion_ID = @Promotion_ID";

                using (SqlConnection connection = new SqlConnection(connectionstring))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Promotion_ID", txtPromotionID.Text);
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
                            MessageBox.Show("No Order found wih Promotion_ID" + txtPromotionID);
                        }
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show("Error:" + ex.Message);
                    }
                }
            }
        }
    }
}
