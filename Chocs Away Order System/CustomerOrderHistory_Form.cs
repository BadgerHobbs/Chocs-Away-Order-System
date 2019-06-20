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
            UpdateOrdersTable();
        }

        // Get customer name from customer number
        public string GetCustomerName(int customerNumber)
        {
            string customerName = "";

            // For each row in orders database of orders
            using (var database = new chocsawayEntities())
            {
                // Iterate through each customer in customers database
                foreach (Customer customer in database.Customers)
                {
                    // If the customer number is the search customer number
                    if (customer.CustomerNumber == customerNumber)
                    {
                        // Set the customer name as database customer name
                        customerName = customer.CustomerName;
                    }
                }
            }

            // Return the customer number
            return customerName;
        }

        // Get Product name from Product number
        public string GetProductName(int productNumber)
        {
            string productName = "";

            // For each row in orders database of orders
            using (var database = new chocsawayEntities())
            {
                // Iterate through each product in products database
                foreach (Product product in database.Products)
                {
                    // If product number is search product number
                    if (product.ProductNumber == productNumber)
                    {
                        // Set product name as database product name
                        productName = product.ProductName;
                    }
                }
            }

            // Return the product name
            return productName;
        }


        // Add Customers Database Values to Orders Table (DataGridView)
        private void UpdateOrdersTable()
        {
            // For each row in orders database of orders
            using (var database = new chocsawayEntities())
            {
                // Iterate through each order in orders database
                foreach (Order order in database.Orders)
                {
                    // If the order is for the current chosen customer (by comparing the customer number from the order and this customer number)
                    if (order.CustomerNumber == Convert.ToInt32(Customers_Form.chosenCustomerNumber))
                    {
                        // Get specific details from data table
                        string orderNumber = order.OrderNumber.ToString();                      // Get customer orderNumber
                        string customerNumber = order.CustomerNumber.ToString();                // Get customer customerNumber
                        string orderDate = order.OrderDate.ToString();                          // Get customer orderDate
                        double orderTotal = Math.Round(Convert.ToDouble(order.OrderTotal), 2);  // Get customer orderTotal
                        string orderStatus = "1";                                               // Set customer orderStatus

                        // If order status in database is 1
                        if (order.OrderStatus.ToString() == "1")
                        {
                            // Set order status as taken
                            orderStatus = "Taken";
                        }
                        // If order status is 2
                        else if (order.OrderStatus.ToString() == "2")
                        {
                            // Set order status as dispatched
                            orderStatus = "Dispatched";
                        }
                        // If order status is 3
                        else if (order.OrderStatus.ToString() == "3")
                        {
                            // Set order status as waiting for stock
                            orderStatus = "Waiting for Stock";
                        }

                        // Get Customer Name
                        string customerName = GetCustomerName(Convert.ToInt32(customerNumber));

                        // Add Data to data table
                        CutomerOrders_DataGridView.Rows.Add(customerName, orderNumber, orderDate, orderStatus, orderTotal);
                    }
                }
            }
        }

        // Add Customers Database Values of orders to Customer Table (DataGridView)
        private void UpdateOrderItemsTable(int orderNumber)
        {
            // Clear the order items data grid view table of rows
            OrderItems_DataGridView.Rows.Clear();

            // For each row in orders database of orders
            using (var database = new chocsawayEntities())
            {
                foreach (OrderItem orderItem in database.OrderItems)
                {
                    if (orderItem.OrderNumber == orderNumber)
                    {
                        // Get specific details from data table
                        string productNumber = orderItem.ProductNumber.ToString();   // Get customer customerNumber
                        string quantity = orderItem.Quantity.ToString();             // Get customer orderDate

                        // Get product name
                        string productName = GetProductName(Convert.ToInt32(productNumber));

                        // Add Data to table
                        OrderItems_DataGridView.Rows.Add(orderNumber, productNumber, productName, quantity);
                    }
                }
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
            UpdateOrderItemsTable(chosenOrderNumber);
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
