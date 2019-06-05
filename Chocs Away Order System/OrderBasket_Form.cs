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
        public static OrderBasket orderBasket = new OrderBasket();

        public OrderBasket_Form()
        {
            InitializeComponent();
            DataTable items = GetItems();
            UpdateItemsDropdown(items);
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
            foreach (DataRow row in dataTable.Rows)
            {
                // Get specific details from data table
                if (row["ProductName"].ToString() == itemName)
                {
                    Price_TextBox.Text = "£" + Math.Round(Convert.ToDouble(row["UnitPrice"]), 2).ToString();
                    Description_TextBox.Text = row["Description"].ToString();
                }      

                
            }
        }

        // Add Product Database Values to Items Dropdown (ComboBox)
        private DataRow GetItemDetails(DataTable dataTable, string itemName)
        {
            foreach (DataRow row in dataTable.Rows)
            {
                // Get specific details from data table
                if (row["ProductName"].ToString() == itemName)
                {
                    return row;
                }
            }
            return null;
        }

        private void UpdateItemTable()
        {
            orderBasket.UpdateTotals();
            UpdateTotals();

            Basket_DataGridView.Rows.Clear();
            Basket_DataGridView.Refresh();

            foreach (BasketItem basketItem in orderBasket.BasketItems)
            {
                Basket_DataGridView.Rows.Add(basketItem.ProductNumber, basketItem.ProductName, basketItem.Quantity, "£" + basketItem.LatestPrice.ToString(), "£" + (basketItem.LatestPrice * basketItem.Quantity).ToString(), basketItem.Description);
            }

            // Show/Hide buttons if items are in basket

            if (orderBasket.BasketItems.Count > 0)
            {
                RemoveItem_Button.Enabled = true;
                ClearBasket_Button.Enabled = true;
                Checkout_Button.Enabled = true;
            }
            else
            {
                RemoveItem_Button.Enabled = false;
                ClearBasket_Button.Enabled = false;
                Checkout_Button.Enabled = false;
            }
            
        }

        private void Checkout_Button_Click(object sender, EventArgs e)
        {
            CheckoutOrder.AddOrder();
            CheckoutOrder.AddOrderItems();

            CustomerOrderHistory_Form customerOrderHistoryForm = new CustomerOrderHistory_Form();
            customerOrderHistoryForm.FormClosed += new FormClosedEventHandler(customerOrderHistoryFormClosed);
            customerOrderHistoryForm.Text = "customerOrderHistoryForm";
            customerOrderHistoryForm.Show();
            this.Hide();
        }

        private void customerOrderHistoryFormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close(); // Close this form
        }

        private void RemoveItem_Button_Click(object sender, EventArgs e)
        {
            if (Basket_DataGridView.SelectedCells.Count > 0)
            {
                int selectedrowindex = Basket_DataGridView.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = Basket_DataGridView.Rows[selectedrowindex];

                string itemId = Convert.ToString(selectedRow.Cells["id"].Value);

                orderBasket.RemoveItem(Convert.ToInt32(itemId));
                UpdateItemTable();
            }


        }

        private void ClearBasket_Button_Click(object sender, EventArgs e)
        {
            orderBasket.ClearBasket();
            UpdateItemTable();
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Exit_Button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Add_Button_Click(object sender, EventArgs e)
        {
            DataRow item = GetItemDetails(GetItems(), Item_ComboBox.Text);
            orderBasket.AddItem(Convert.ToInt32(item["ProductNumber"]), item["ProductName"].ToString(), Convert.ToDouble(item["UnitPrice"]), Convert.ToInt32(Quantity_DomainUpDown.Text), item["Description"].ToString());
            UpdateItemTable();
        }

        private void Item_ComboBox_ValueMemberChanged(object sender, EventArgs e)
        {
            
        }

        private void Item_ComboBox_TextChanged(object sender, EventArgs e)
        {
            UpdateItemDetails(GetItems(), Item_ComboBox.Text);
        }

        private void UpdateTotals()
        {
            ProductsNumber_Label.Text = orderBasket.NumberOfProducts.ToString();
            ItemsNumber_Label.Text = orderBasket.NumberOfItems.ToString();
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
