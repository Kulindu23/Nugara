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
    public partial class frmBill : Form
    {
        string connectionstring = (@"Data Source=DESKTOP-3F04SHD;Initial Catalog=Nugara;Integrated Security=True");
        public frmBill()
        {
            InitializeComponent();

            dataGridViewbill.CellClick += dataGridViewbill_CellContentClick;

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
            frmHome hp = new frmHome();
            hp.Show();
        }

        private void timerDateTime_Tick(object sender, EventArgs e)
        {
            // Update the label with the current date and time
            lblDateTime.Text = DateTime.Now.ToString("dddd, MMMM dd yyyy - hh:mm:ss tt");
        }

        private void frmbill_Load(object sender, EventArgs e)
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
                    string query = "SELECT  * FROM tblBill";
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        adapter.Fill(table);
                    }
                    dataGridViewbill.DataSource = table;
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

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                // Retrieve input values from textboxes
                double price = Convert.ToDouble(txtPrice.Text);                // Price per item
                double quantity = Convert.ToDouble(txtQuantity.Text);          // Number of items
                double cash = Convert.ToDouble(txtCash.Text);                  // Cash provided by customer
                double discount = Convert.ToDouble(txtDiscount.Text);          // Discount amount
                double serviceCharge = Convert.ToDouble(txtServicecharge.Text);// Service charge

                // Calculate Total Price: (Price * Quantity) + Service Charge - Discount
                double totalPrice = (price * quantity) + serviceCharge - discount;

                // Display the Total Price
                txttotalprice.Text = totalPrice.ToString("F2");

                // Calculate Balance: Cash - Total Price
                double balance = cash - totalPrice;

                // Display the Balance
                txtBalance.Text = balance.ToString("F2");
            }
            catch (FormatException)
            {
                // Handle invalid input formats
                MessageBox.Show("Please enter valid numeric values for Price, Quantity, Cash, Discount, and Service Charge.",
                                "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // Handle any other unexpected errors
                MessageBox.Show($"An error occurred: {ex.Message}",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtOrderID.Text = "";
            txtItemName.Text = "";
            txtQuantity.Text = "";
            cmbSize.Text = "";
            txtPrice.Text = "";
            txtBalance.Text = "";
            txtServicecharge.Text = "";
            txttotalprice.Text = "";
            txtDiscount.Text = "";
            txtCash.Text = "";
        }

        private void dataGridViewbill_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridViewbill.Rows[e.RowIndex];
                txtOrderID.Text = selectedRow.Cells[0].Value.ToString();
                txtItemName.Text = selectedRow.Cells[1].Value.ToString();
                txtQuantity.Text = selectedRow.Cells[2].Value.ToString();
                cmbSize.Text = selectedRow.Cells[3].Value.ToString();
                txtPrice.Text = selectedRow.Cells[4].Value.ToString();
                txtDiscount.Text = selectedRow.Cells[5].Value.ToString();
                txtServicecharge.Text = selectedRow.Cells[6].Value.ToString();
                txtCash.Text = selectedRow.Cells[7].Value.ToString();
                
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewerBill cryRpt = new ViewerBill();
            cryRpt.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtOrderID.Text))
            {

                MessageBox.Show("Please select a row to deleted.");
                return;

            }

            else
            {
                string query = "DELETE FROM tblBill WHERE Order_ID = @Order_ID";

                using (SqlConnection connection = new SqlConnection(connectionstring))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Order_ID", txtOrderID.Text);
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
                            MessageBox.Show("No Order found wih Order_ID" + txtOrderID);
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
            if (string.IsNullOrEmpty(txtOrderID.Text))
            {
                MessageBox.Show("Please select a row to update.");
                return;
            }


            string Order_ID = txtOrderID.Text;
            string Item_Name = txtItemName.Text;
            string Discount = txtDiscount.Text;
            int Quantity = Convert.ToInt32(txtQuantity.Text);
            string Size = cmbSize.Text;
            double Price = Convert.ToDouble(txtPrice.Text);
            double Service_Charge = Convert.ToDouble(txtServicecharge.Text);
            double Cash = Convert.ToDouble(txtCash.Text);



            //SQL UPDATE query
            string query = "UPDATE tblBill SET Cash = @Cash, Item_Name = @Item_Name, Discount = @Discount, Quantity = @Quantity, Size = @Size, Price = @Price WHERE Order_ID = @Order_ID";

            using (SqlConnection connection = new SqlConnection(connectionstring))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Order_ID", Order_ID);
                command.Parameters.AddWithValue("@Item_Name", Item_Name);
                command.Parameters.AddWithValue("@Discount", Discount);
                command.Parameters.AddWithValue("@Quantity", Quantity);
                command.Parameters.AddWithValue("@Size", Size);
                command.Parameters.AddWithValue("@Price", Price);
                command.Parameters.AddWithValue("@Cash", Cash);
                command.Parameters.AddWithValue("@Service_Charge", Service_Charge);



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
            string Order_ID = txtOrderID.Text;
            string Item_Name = txtItemName.Text;
            string Discount = txtDiscount.Text;
            int Quantity = Convert.ToInt32(txtQuantity.Text);
            string Size = cmbSize.Text;
            double Price = Convert.ToDouble(txtPrice.Text);
            double Service_Charge = Convert.ToDouble(txtServicecharge.Text);
            double Cash = Convert.ToDouble(txtCash.Text);



            //SQL INSERT query
            string query = "INSERT INTO tblBill (Cash,Order_ID,Item_Name,Quantity,Size,Price,Service_Charge,Discount)" +
                "VALUES (@Cash,@Order_ID,@Item_Name,@Quantity,@Size,@Price,@Service_Charge,@Discount)";

            using (SqlConnection connection = new SqlConnection(connectionstring))
            using (SqlCommand command = new SqlCommand(query, connection))
            {

                command.Parameters.AddWithValue("@Order_ID", Order_ID);
                command.Parameters.AddWithValue("@Item_Name", Item_Name);
                command.Parameters.AddWithValue("@Discount", Discount);
                command.Parameters.AddWithValue("@Quantity", Quantity);
                command.Parameters.AddWithValue("@Size", Size);
                command.Parameters.AddWithValue("@Price", Price);
                command.Parameters.AddWithValue("@Cash", Cash);
                command.Parameters.AddWithValue("@Service_Charge", Service_Charge);



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
    }
}
