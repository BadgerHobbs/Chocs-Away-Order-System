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
    public partial class CustomerOrderHistory_Form : Form
    {
        public CustomerOrderHistory_Form()
        {
            InitializeComponent();
        }

        // Get Order From Database
        private DataTable GetOrders()
        {
            // Create data table object to hold products from database
            DataTable OrderDataTable = new DataTable();
            // Create SQL connection
            SqlConnection connection = new SqlConnection(@"Server=ANDREW-PC\SQLEXPRESS;Database=ChocsAway;Trusted_Connection=true");
            // Create SQL command using connection information
            SqlCommand command = new SqlCommand("select * from Orders", connection);
            // Open the SQL connection
            connection.Open();
            // create data adapter
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            // this will query your database and return the result to your datatable
            dataAdapter.Fill(OrderDataTable);
            // Close the SQL connection
            connection.Close();
            // Close the data adapter
            dataAdapter.Dispose();
            // Return data table with new results
            return OrderDataTable;
        }

        // Get Order Items From Database
        private DataTable GetOrderItems()
        {
            // Create data table object to hold products from database
            DataTable OrderItemsDataTable = new DataTable();
            // Create SQL connection
            SqlConnection connection = new SqlConnection(@"Server=ANDREW-PC\SQLEXPRESS;Database=ChocsAway;Trusted_Connection=true");
            // Create SQL command using connection information
            SqlCommand command = new SqlCommand("select * from OrderItems", connection);
            // Open the SQL connection
            connection.Open();
            // create data adapter
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            // this will query your database and return the result to your datatable
            dataAdapter.Fill(OrderItemsDataTable);
            // Close the SQL connection
            connection.Close();
            // Close the data adapter
            dataAdapter.Dispose();
            // Return data table with new results
            return OrderItemsDataTable;
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
                //customers_DataGridView.Rows.Add(customerName, customerPostcode, houseNumber);
            }
        }
    }
}
