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
            using (var db = new chocsawayEntities())
            {
                foreach (Customer o in db.Customers)
                {
                    if (o.CustomerNumber == customerNumber)
                    {
                        customerName = o.CustomerName;
                    }
                }
            }

            // Return data table with new results
            return customerName;
        }

        // Get Product name from Product number
        public string GetProductName(int productNumber)
        {
            string productName = "";

            // For each row in orders database of orders
            using (var db = new chocsawayEntities())
            {
                foreach (Product p in db.Products)
                {
                    if (p.ProductNumber == productNumber)
                    {
                        productName = p.ProductName;
                    }
                }
            }

            // Return data table with new results
            return productName;
        }


        // Add Customers Database Values to Orders Table (DataGridView)
        private void UpdateOrdersTable()
        {
            // For each row in orders database of orders
            using (var db = new chocsawayEntities())
            {
                foreach (Order c in db.Orders)
                {
                    if (c.CustomerNumber == Convert.ToInt32(Customers_Form.chosenCustomerNumber))
                    {
                        // Get specific details from data table
                        string orderNumber = c.OrderNumber.ToString();                                      // Get customer orderNumber
                        string customerNumber = c.CustomerNumber.ToString();                                // Get customer customerNumber
                        string orderDate = c.OrderDate.ToString();                                          // Get customer orderDate
                        double orderTotal = Math.Round(Convert.ToDouble(c.OrderTotal), 2);                  // Get customer orderTotal
                        string orderStatus = "";                                                            // Set customer orderStatus

                        if (c.OrderStatus.ToString() == "1")
                        {
                            orderStatus = "Taken";
                        }
                        else if (c.OrderStatus.ToString() == "2")
                        {
                            orderStatus = "Dispatched";
                        }
                        else if (c.OrderStatus.ToString() == "3")
                        {
                            orderStatus = "Waiting for Stock";
                        }

                        // Get Customer Name
                        string customerName = GetCustomerName(Convert.ToInt32(customerNumber));

                        // Add Data to table
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
            using (var db = new chocsawayEntities())
            {
                foreach (OrderItem o in db.OrderItems)
                {
                    if (o.OrderNumber == orderNumber)
                    {
                        // Get specific details from data table
                        string productNumber =o.ProductNumber.ToString();   // Get customer customerNumber
                        string quantity = o.Quantity.ToString();             // Get customer orderDate

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
