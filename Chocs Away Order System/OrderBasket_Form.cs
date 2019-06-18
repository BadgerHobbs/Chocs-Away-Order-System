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
            // Update drop down menu with items
            UpdateItemsDropdown();
            // Update item table
            UpdateItemTable();
            // Clear the order basket
            orderBasket.ClearBasket();
            // Update the item table (data grid view table)
            UpdateItemTable();
        }

        // Add Product Database Values to Items Dropdown (ComboBox)
        private void UpdateItemsDropdown()
        {
            // For each row in products database get product
            using (var db = new chocsawayEntities())
            {
                foreach (Product p in db.Products)
                {
                    Item_ComboBox.Items.Add(p.ProductName);
                }
            }
        }

        // Add Product Database Values to Items Dropdown (ComboBox)
        private void UpdateItemDetails(string itemName)
        {
            // For each row in products database get product
            using (var db = new chocsawayEntities())
            {
                // Iterate through each product in the database
                foreach (Product p in db.Products)
                {
                    // If the product name is the search item name
                    if (p.ProductName == itemName)
                    {
                        // Set price box text as the price of that item
                        Price_TextBox.Text = "£" + Math.Round(p.UnitPrice, 2).ToString();
                        // Set desctiption box text as the item description
                        Description_TextBox.Text = p.Description.ToString();
                    }
                }
            }
        }

        // Add Product Database Values to Items Dropdown (ComboBox)
        private void AddItemToBasket (string itemName)
        {
            // For each row in products database get product
            using (var db = new chocsawayEntities())
            {
                // Iterate through each product in the database
                foreach (Product p in db.Products)
                {
                    // If the product name is the search item name
                    if (p.ProductName == itemName)
                    {
                        // Add the item to the order basket
                        orderBasket.AddItem(Convert.ToInt32(p.ProductNumber),p.ProductName.ToString(), Convert.ToDouble(p.UnitPrice), Convert.ToInt32(Quantity_NumericUpDown.Text),p.Description.ToString());
                        // Update the item table (data grid view table)
                        UpdateItemTable();
                    }
                }
            }
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
            // Clear the order basket
            orderBasket.ClearBasket();
            // Update the item table (data grid view table)
            UpdateItemTable();
            // Close the order basket form
            this.Close();
        }
         
        // When the exit button has been clicked, this function runs
        private void Exit_Button_Click(object sender, EventArgs e)
        {
            // Clear the order basket
            orderBasket.ClearBasket();
            // Update the item table (data grid view table)
            UpdateItemTable();
            // Exit the application (entire program)
            Application.Exit();
        }

        // When the add button has clicked, this function runs
        private void Add_Button_Click(object sender, EventArgs e)
        {
            // Add item to basket
            AddItemToBasket(Item_ComboBox.Text);
            UpdateItemTable();
        }

        private void Item_ComboBox_ValueMemberChanged(object sender, EventArgs e)
        {
            
        }

        // When the text in the drop down menu (combo box) changes, this runs
        private void Item_ComboBox_TextChanged(object sender, EventArgs e)
        {
            // Update the item details
            UpdateItemDetails(Item_ComboBox.Text);
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

        private void Quantity_NumericUpDown_ValueChanged(object sender, EventArgs e)
        {
        }

        private void Price_TextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
