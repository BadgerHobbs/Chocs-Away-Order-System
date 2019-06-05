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
    public partial class OrderBasket_Form : Form
    {
        // Initialise a new order basket object
        public static OrderBasket orderBasket = new OrderBasket();

        public OrderBasket_Form()
        {
            InitializeComponent();
            // Set data table items to hold shop items when getItems function run
            DataTable items = GetItems();
            // Update drop down menu with items
            UpdateItemsDropdown(items);
            // Update item table
            UpdateItemTable();
        }

        // Get Products From Database
        private DataTable GetItems()
        {
            // Create data table object to hold products from database
            DataTable itemsDataTable = new DataTable();
            // Create SQL connection
            SqlConnection connection = new SqlConnection(@"Server=ANDREW-PC\SQLEXPRESS;Database=ChocsAway;Trusted_Connection=true");
            // Create SQL command using connection information
            SqlCommand command = new SqlCommand("select * from Products", connection);
            // Open the SQL connection
            connection.Open();
            // create data adapter
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            // this will query your database and return the result to your datatable
            dataAdapter.Fill(itemsDataTable);
            // Close the SQL connection
            connection.Close();
            // Close the data adapter
            dataAdapter.Dispose();
            // Return data table with new results
            return itemsDataTable;
        }

        // Add Product Database Values to Items Dropdown (ComboBox)
        private void UpdateItemsDropdown(DataTable dataTable)
        {
            foreach (DataRow row in dataTable.Rows)
            {
                // Get specific details from data table
                string itemName = row["ProductName"].ToString();         // Get product name

                // Add Data to dropdown
                Item_ComboBox.Items.Add(itemName);
            }
        }

        // Add Product Database Values to Items Dropdown (ComboBox)
        private void UpdateItemDetails(DataTable dataTable,string itemName)
        {
            // Iterate through each row in the data table
            foreach (DataRow row in dataTable.Rows)
            {
                // If row item in column product name is same as paramater item name provided
                if (row["ProductName"].ToString() == itemName)
                {
                    // Set price box text as the price of that item
                    Price_TextBox.Text = "£" + Math.Round(Convert.ToDouble(row["UnitPrice"]), 2).ToString();
                    // Set desctiption box text as the item description
                    Description_TextBox.Text = row["Description"].ToString();
                }      
            }
        }

        // Add Product Database Values to Items Dropdown (ComboBox)
        private DataRow GetItemDetails(DataTable dataTable, string itemName)
        {
            // Iterate through each row in the data table
            foreach (DataRow row in dataTable.Rows)
            {
                // If the product name column in the row is the same as the item name
                if (row["ProductName"].ToString() == itemName)
                {
                    // Return the row from the datatable
                    return row;
                }
            }
            // Return nothing
            return null;
        }

        // Function to update the item table with items
        private void UpdateItemTable()
        {
            // Update the order basket totals
            orderBasket.UpdateTotals();
            // Update the totals of the order basket form
            UpdateTotals();
            // Clear the data grid view rows and refresh
            Basket_DataGridView.Rows.Clear();
            Basket_DataGridView.Refresh();
            // Iterate through each item in order basket
            foreach (BasketItem basketItem in orderBasket.BasketItems)
            {
                // Add item to the data grid view (table) as a row
                Basket_DataGridView.Rows.Add(basketItem.ProductNumber, basketItem.ProductName, basketItem.Quantity, "£" + basketItem.LatestPrice.ToString(), "£" + (basketItem.LatestPrice * basketItem.Quantity).ToString(), basketItem.Description);
            }

            // Show/Hide buttons if any items are in the basket
            if (orderBasket.BasketItems.Count > 0)
            {
                // Enable the remove, clear and checkout buttons
                RemoveItem_Button.Enabled = true;
                ClearBasket_Button.Enabled = true;
                Checkout_Button.Enabled = true;
            }
            else
            {
                // Disable the remove, clear and checkout buttons
                RemoveItem_Button.Enabled = false;
                ClearBasket_Button.Enabled = false;
                Checkout_Button.Enabled = false;
            }
        }
        // Function run when checkout button is clicked
        // Add orders to database
        // Opens order history form
        private void Checkout_Button_Click(object sender, EventArgs e)
        {
            // Add order and order items to database
            CheckoutOrder.AddOrder();
            CheckoutOrder.AddOrderItems();
            // Initialise new form object of customer history form
            CustomerOrderHistory_Form customerOrderHistoryForm = new CustomerOrderHistory_Form();
            // Create Form closed event handler for form (so when form closed runs customerOrderHistoryFormClosed  function)
            customerOrderHistoryForm.FormClosed += new FormClosedEventHandler(customerOrderHistoryFormClosed);
            // Set customer order history form text label
            customerOrderHistoryForm.Text = "customerOrderHistoryForm";
            // Show customer order history form
            customerOrderHistoryForm.Show();
            // Hide this form
            this.Hide();
        }

        // When customer order history form has been closed, this runs
        private void customerOrderHistoryFormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close(); // Close this form
        }

        // When the remove button has been clicked, this function runs
        private void RemoveItem_Button_Click(object sender, EventArgs e)
        {
            // If there is an item in the data grid view (basket)
            if (Basket_DataGridView.SelectedCells.Count > 0)
            {
                // Get the currently selected row index
                int selectedrowindex = Basket_DataGridView.SelectedCells[0].RowIndex;
                // Get the currently selected row
                DataGridViewRow selectedRow = Basket_DataGridView.Rows[selectedrowindex];
                // Get the id of the item in that row
                string itemId = Convert.ToString(selectedRow.Cells["id"].Value);
                // Remove the item with that id from the order basket
                orderBasket.RemoveItem(Convert.ToInt32(itemId));
                // Update the item table (data grid view table)
                UpdateItemTable();
            }
        }

        // When the clear basket button has been clicked, this function runs
        private void ClearBasket_Button_Click(object sender, EventArgs e)
        {
            // Clear the order basket
            orderBasket.ClearBasket();
            // Update the item table (data grid view table)
            UpdateItemTable();
        }

        // When the cancel button has been clicked, this function runs
        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            // Close the order basket form
            this.Close();
        }
         
        // When the exit button has been clicked, this function runs
        private void Exit_Button_Click(object sender, EventArgs e)
        {
            // Exit the application (entire program)
            Application.Exit();
        }

        // When the add button has clicked, this function runs
        private void Add_Button_Click(object sender, EventArgs e)
        {
            // Get the details of the item selected in the drop down box
            DataRow item = GetItemDetails(GetItems(), Item_ComboBox.Text);
            // Add the item to the order basket
            orderBasket.AddItem(Convert.ToInt32(item["ProductNumber"]), item["ProductName"].ToString(), Convert.ToDouble(item["UnitPrice"]), Convert.ToInt32(Quantity_DomainUpDown.Text), item["Description"].ToString());
            // Update the item table (data grid view table)
            UpdateItemTable();
        }

        private void Item_ComboBox_ValueMemberChanged(object sender, EventArgs e)
        {
            
        }

        // When the text in the drop down menu (combo box) changes, this runs
        private void Item_ComboBox_TextChanged(object sender, EventArgs e)
        {
            // Update the item details
            UpdateItemDetails(GetItems(), Item_ComboBox.Text);
        }

        // Function to update the totals of the basket show in the form
        private void UpdateTotals()
        {
            // Set the products number as that from the order basket
            ProductsNumber_Label.Text = orderBasket.NumberOfProducts.ToString();
            // Set the items number as that from the order basket
            ItemsNumber_Label.Text = orderBasket.NumberOfItems.ToString();
            // Set the total cost number as that from the order basket
            TotalCost_Label.Text = "£" + orderBasket.BasketTotal.ToString();
        }

        private void TotalCost_Label_Click(object sender, EventArgs e)
        {

        }

        private void ProductsNumber_Label_Click(object sender, EventArgs e)
        {

        }

        public OrderBasket OrderBasket
        {
            get;
            set;
        }
    }
}
