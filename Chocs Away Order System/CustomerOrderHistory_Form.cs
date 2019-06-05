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


        // Add Customers Database Values to Orders Table (DataGridView)
        private void UpdateOrdersTable(DataTable dataTable)
        {
            foreach (DataRow row in dataTable.Rows)
            {
                // Get specific details from data table
                string orderNumber = row["OrderNumber"].ToString();         // Get customer orderNumber
                string customerNumber = row["CustomerNumber"].ToString();   // Get customer customerNumber
                string orderDate = row["OrderDate"].ToString();             // Get customer orderDate
                string orderTotal = "£" + Math.Round(Convert.ToDouble(row["OrderTotal"]),2).ToString();           // Get customer orderTotal
                string orderStatus = row["OrderStatus"].ToString();         // Get customer orderStatus

                // Add Data to table
                CutomerOrders_DataGridView.Rows.Add(orderNumber, orderDate, orderStatus, orderTotal);
            }
        }

        // Add Customers Database Values to Customer Table (DataGridView)
        private void UpdateOrderItemsTable(DataTable dataTable)
        {
            OrderItems_DataGridView.Rows.Clear();

            foreach (DataRow row in dataTable.Rows)
            {
                // Get specific details from data table
                string orderNumber = row["OrderNumber"].ToString();         // Get customer orderNumber
                string productNumber = row["ProductNumber"].ToString();   // Get customer customerNumber
                string quantity = row["Quantity"].ToString();             // Get customer orderDate

                // Add Data to table
                OrderItems_DataGridView.Rows.Add(orderNumber, productNumber, quantity);
            }
        }

        private void RefreshOrderItems()
        {
            int selectedrowindex = CutomerOrders_DataGridView.SelectedCells[0].RowIndex;

            DataGridViewRow selectedRow = CutomerOrders_DataGridView.Rows[selectedrowindex];

            int chosenOrderNumber = Convert.ToInt32(selectedRow.Cells["OrderNumber"].Value);

            UpdateOrderItemsTable(GetOrderItems(chosenOrderNumber));
        }

        private void CutomerOrders_DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            RefreshOrderItems();
        }
        
    }
}
