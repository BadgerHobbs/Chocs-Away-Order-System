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

namespace Chocs_Away_Order_System
{
    public partial class Customers_Form : Form
    {
        public Customers_Form()
        {
            InitializeComponent();
            UpdateCustomersTable(GetCustomers()); // Update customers table with values from database
        }

        // Get Customers From Database
        private DataTable GetCustomers()
        {
            // Create data table object to hold products from database
            DataTable customersDataTable = new DataTable();
            // Create SQL connection
            SqlConnection connection = new SqlConnection(@"Server=ANDREW-PC\SQLEXPRESS;Database=ChocsAway;Trusted_Connection=true");
            // Create SQL command using connection information
            SqlCommand command = new SqlCommand("select * from Customers", connection);
            // Open the SQL connection
            connection.Open();
            // create data adapter
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            // this will query your database and return the result to your datatable
            dataAdapter.Fill(customersDataTable);
            // Close the SQL connection
            connection.Close();
            // Close the data adapter
            dataAdapter.Dispose();
            // Return data table with new results
            return customersDataTable;
        }

        // Add Customers Database Values to Customer Table (DataGridView)
        private void UpdateCustomersTable(DataTable dataTable)
        {
            foreach (DataRow row in dataTable.Rows)
            {
                // Get specific details from data table
                string customerName = row["CustomerName"].ToString();         // Get customer name
                string customerPostcode = row["Postcode"].ToString();           // Get customer postcode
                string houseNumber = row["AddressLine1"].ToString().Split()[0]; // Get customer adress and trim to only house number

                // Add Data to table
                customers_DataGridView.Rows.Add(customerName, customerPostcode, houseNumber); 
            }
        }

        private void customers_DataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            OrderBasket_Form orderBasketForm = new OrderBasket_Form();
            orderBasketForm.FormClosed += new FormClosedEventHandler(OrderBasketClosed);
            orderBasketForm.Show();
            this.Hide();
        }

        private void OrderBasketClosed(object sender, FormClosedEventArgs e)
        {
            this.Show(); // Unhide this form
        }
    }
}
