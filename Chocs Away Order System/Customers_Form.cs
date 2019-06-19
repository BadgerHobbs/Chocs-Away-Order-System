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
        public static string chosenCustomerNumber;
        public static string chosenCustomerName;

        public Customers_Form()
        {
            // Initialise form
            InitializeComponent();
            UpdateCustomersTable();
            //UpdateCustomersTable(GetCustomers()); // Update customers table with values from database
        }

        // Add Customers Database Values to Customer Table (DataGridView)
        private void UpdateCustomersTable()
        {
            // Clear the data grid view rows and refresh
            customers_DataGridView.Rows.Clear();
            customers_DataGridView.Refresh();

            // For each row in customers database of customer details
            using (var database = new chocsawayEntities())
            {
                var customers = database.Customers;

                foreach (Customer customer in database.Customers)
                {
                    // Get specific details from data table
                    string customerNumber = customer.CustomerNumber.ToString();       // Get customer number
                    string customerName = customer.CustomerName.ToString();           // Get customer name
                    string customerPostcode = customer.Postcode.ToString();           // Get customer postcode
                    string houseNumber = customer.AddressLine1.ToString().Split()[0]; // Get customer adress and trim to only house number

                    bool firstNameFilter = false;
                    bool lastNameFilter = false;
                    bool postcodeFilter = false;
                    bool houseNumberFilter = false;

                    if (FirstName_TextBox.Text != "")
                    {
                        firstNameFilter = true;
                    }
                    if (LastName_TextBox.Text != "")
                    {
                        lastNameFilter = true;
                    }
                    if (Postcode_TextBox.Text != "")
                    {
                        postcodeFilter = true;
                    }
                    if (HouseNumber_TextBox.Text != "")
                    {
                        houseNumberFilter = true;
                    }

                    bool fitsFilter = false;

                    // Check First Name
                    // If search box contains search text or is empty (no search query)
                    if (firstNameFilter == true)
                    {
                        if (customerName.ToLower().Contains(FirstName_TextBox.Text.ToLower()))
                        {
                            fitsFilter = true;
                        }
                        else
                        {
                            fitsFilter = false;
                        }
                    }

                    // Check Last Name
                    // If search box contains search text or is empty (no search query)
                    if (lastNameFilter == true)
                    {
                        if (customerName.ToLower().Contains(LastName_TextBox.Text.ToLower()))
                        {
                            fitsFilter = true;
                        }
                        else
                        {
                            fitsFilter = false;
                        }
                    }

                    // Check Postcode
                    if (postcodeFilter == true)
                    {
                        if (customerPostcode.ToLower().Contains(Postcode_TextBox.Text.ToLower()))
                        {
                            fitsFilter = true;
                        }
                        else
                        {
                            fitsFilter = false;
                        }
                    }

                    // Check House Number
                    if (houseNumberFilter == true)
                    {
                        if (houseNumber.ToLower().Contains(HouseNumber_TextBox.Text.ToLower()))
                        {
                            fitsFilter = true;
                        }
                        else
                        {
                            fitsFilter = false;
                        }
                    }

                    // If a filter is on and the result fits it, add to data grid view
                    if (((firstNameFilter == true) || (lastNameFilter == true) || (postcodeFilter == true) || (houseNumberFilter == true)) && (fitsFilter == true))
                    {
                        // Add Data to table
                        customers_DataGridView.Rows.Add(customerNumber, customerName, customerPostcode, houseNumber);
                    }
                    // Else if no filters are on, add to data grid view
                    else if ((firstNameFilter == false) && (lastNameFilter == false) && (postcodeFilter == false) && (houseNumberFilter == false))
                    {
                        // Add Data to table
                        customers_DataGridView.Rows.Add(customerNumber, customerName, customerPostcode, houseNumber);
                    }
                }

            }
        }

        // Function run when cell is double clicked
        // Saves customer name and number selected
        // Opens order basket form
        private void customers_DataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Get index of row selected in data grid view (table)
            int selectedrowindex = customers_DataGridView.SelectedCells[0].RowIndex;
            // Gets selected row in data grid view (table)
            DataGridViewRow selectedRow = customers_DataGridView.Rows[selectedrowindex];
            // Set chosen customer name and number from data grid view (table)
            chosenCustomerNumber = Convert.ToString(selectedRow.Cells["CustomerNumber"].Value);
            chosenCustomerName = Convert.ToString(selectedRow.Cells["customerName"].Value);
            // Create new order basket form object
            OrderBasket_Form orderBasketForm = new OrderBasket_Form();
            // Create Form closed event handler for form (so when form closed runs orderbasketclosed function)
            orderBasketForm.FormClosed += new FormClosedEventHandler(OrderBasketClosed);
            // Set order basket form text as chosen customer name
            orderBasketForm.Text = chosenCustomerName;
            // Show order basket form
            orderBasketForm.Show();
            // Hide this form (customers form)
            this.Hide();
        }

        // Function to run when order basket form is closed
        private void OrderBasketClosed(object sender, FormClosedEventArgs e)
        {
            this.Show(); // Show this form
        }

        // Function to run when add customer form is closed
        private void AddCustomerClosed(object sender, FormClosedEventArgs e)
        {
            UpdateCustomersTable(); // Update customers table with values from database
            this.Show(); // Show this form
        }

        private void Name_TextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateCustomersTable();
        }

        private void Postcode_TextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateCustomersTable();
        }

        private void HouseNumber_TextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateCustomersTable();
        }

        private void LastName_TextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateCustomersTable();
        }

        private void AddCustomer_Button_Click(object sender, EventArgs e)
        {
            // Get index of row selected in data grid view (table)
            int selectedrowindex = customers_DataGridView.SelectedCells[0].RowIndex;
            // Gets selected row in data grid view (table)
            DataGridViewRow selectedRow = customers_DataGridView.Rows[selectedrowindex];
            // Create new order basket form object
            AddCustomer_Form addCustomerForm = new AddCustomer_Form();
            // Create Form closed event handler for form (so when form closed runs orderbasketclosed function)
            addCustomerForm.FormClosed += new FormClosedEventHandler(AddCustomerClosed);
            // Show order basket form
            addCustomerForm.Show();
            // Hide this form (customers form)
            this.Hide();
        }
    }
}
