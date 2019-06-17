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
            // Update the orders table with the orders from the database from this customer
            UpdateOrdersTable(GetOrders());
        }

        // Get Order From Database
        private DataTable GetOrders()
        {
            // Create data table object to hold products from database
            DataTable OrderDataTable = new DataTable();
            // Create SQL connection
            SqlConnection connection = new SqlConnection(@"Server=ANDREW-PC\SQLEXPRESS;Database=ChocsAway;Trusted_Connection=true");
            // Create SQL command using connection information
            SqlCommand command = new SqlCommand("select * from Orders where CustomerNumber=@customerNumber", connection);
            // Open the SQL connection
            connection.Open();
            // create data adapter
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            // Add customer number value to SQL seach query command
            command.Parameters.AddWithValue("@customerNumber", Customers_Form.chosenCustomerNumber);
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
        private DataTable GetOrderItems(int orderNumber)
        {
            // Create data table object to hold products from database
            DataTable OrderItemsDataTable = new DataTable();
            // Create SQL connection
            SqlConnection connection = new SqlConnection(@"Server=ANDREW-PC\SQLEXPRESS;Database=ChocsAway;Trusted_Connection=true");
            // Create SQL command using connection information
            SqlCommand command = new SqlCommand("select * from OrderItems where OrderNumber=@orderNumber", connection);
            // Open the SQL connection
            connection.Open();
            // create data adapter
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            // Add order number value to SQL seach query command
            command.Parameters.AddWithValue("@orderNumber", orderNumber);
            // this will query your database and return the result to your datatable
            dataAdapter.Fill(OrderItemsDataTable);
            // Close the SQL connection
            connection.Close();
            // Close the data adapter
            dataAdapter.Dispose();
            // Return data table with new results
            return OrderItemsDataTable;
        }

        // Get customer name from customer number
        private string GetCustomerName(int customerNumber)
        {
            string customerName = "";

            // Create data table object to hold products from database
            DataTable OrderDataTable = new DataTable();
            // Create SQL connection
            SqlConnection connection = new SqlConnection(@"Server=ANDREW-PC\SQLEXPRESS;Database=ChocsAway;Trusted_Connection=true");
            // Create SQL command using connection information
            SqlCommand command = new SqlCommand("select CustomerName from Customers where CustomerNumber=@customerNumber", connection);
            // Open the SQL connection
            connection.Open();
            // create data adapter
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            // Add customer number value to SQL seach query command
            command.Parameters.AddWithValue("@customerNumber", customerNumber);
            // this will query your database and return the result to your datatable
            customerName = command.ExecuteScalar().ToString();
            // Close the SQL connection
            connection.Close();
            // Close the data adapter
            dataAdapter.Dispose();
            // Return data table with new results
            return customerName;
        }

        // Get Product name from Product number
        private string GetProductName(int productNumber)
        {
            string productName = "";

            // Create data table object to hold products from database
            DataTable OrderDataTable = new DataTable();
            // Create SQL connection
            SqlConnection connection = new SqlConnection(@"Server=ANDREW-PC\SQLEXPRESS;Database=ChocsAway;Trusted_Connection=true");
            // Create SQL command using connection information
            SqlCommand command = new SqlCommand("select ProductName from Products where ProductNumber=@productNumber", connection);
            // Open the SQL connection
            connection.Open();
            // create data adapter
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            // Add customer number value to SQL seach query command
            command.Parameters.AddWithValue("@productNumber", productNumber);
            // this will query your database and return the result to your datatable
            productName = command.ExecuteScalar().ToString();
            // Close the SQL connection
            connection.Close();
            // Close the data adapter
            dataAdapter.Dispose();
            // Return data table with new results
            return productName;
        }


        // Add Customers Database Values to Orders Table (DataGridView)
        private void UpdateOrdersTable(DataTable dataTable)
        {
            // Iterate through each row in the data table
            foreach (DataRow row in dataTable.Rows)
            {
                // Get specific details from data table
                string orderNumber = row["OrderNumber"].ToString();         // Get customer orderNumber
                string customerNumber = row["CustomerNumber"].ToString();   // Get customer customerNumber
                string orderDate = row["OrderDate"].ToString();             // Get customer orderDate
                string orderTotal = "£" + Math.Round(Convert.ToDouble(row["OrderTotal"]),2).ToString();           // Get customer orderTotal
                string orderStatus = row["OrderStatus"].ToString();         // Get customer orderStatus

                // Get Customer Name
                string customerName = GetCustomerName(Convert.ToInt32(customerNumber));

                // Add Data to table
                CutomerOrders_DataGridView.Rows.Add(customerName, orderNumber, orderDate, orderStatus, orderTotal);
            }
        }

        // Add Customers Database Values of orders to Customer Table (DataGridView)
        private void UpdateOrderItemsTable(DataTable dataTable)
        {
            // Clear the order items data grid view table of rows
            OrderItems_DataGridView.Rows.Clear();
            // Iterate through each row in the data table
            foreach (DataRow row in dataTable.Rows)
            {
                // Get specific details from data table
                string orderNumber = row["OrderNumber"].ToString();         // Get customer orderNumber
                string productNumber = row["ProductNumber"].ToString();   // Get customer customerNumber
                string quantity = row["Quantity"].ToString();             // Get customer orderDate

                // Get product name
                string productName = GetProductName(Convert.ToInt32(productNumber));

                // Add Data to table
                OrderItems_DataGridView.Rows.Add(orderNumber, productNumber, productName, quantity);
            }
        }

        // Function to refresh order items
        private void RefreshOrderItems()
        {
            // Get currently selected row index in customer orders table
            int selectedrowindex = CutomerOrders_DataGridView.SelectedCells[0].RowIndex;
            // Get currently selected row in customer orders table
            DataGridViewRow selectedRow = CutomerOrders_DataGridView.Rows[selectedrowindex];
            // Get the chosen order number from that row
            int chosenOrderNumber = Convert.ToInt32(selectedRow.Cells["OrderNumber"].Value);
            // Update order items table with the items from that order
            UpdateOrderItemsTable(GetOrderItems(chosenOrderNumber));
        }

        // Function to run when a cell has been clicked
        private void CutomerOrders_DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Refresh order items table
            RefreshOrderItems();
        }

        private void CutomerOrders_DataGridView_SelectionChanged(object sender, EventArgs e)
        {
            // Refresh order items table
            RefreshOrderItems();
        }
    }
}
