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
            // For each row in datatable of customer details
            foreach (DataRow row in dataTable.Rows)
            {
                // Get specific details from data table
                string customerNumber = row["CustomerNumber"].ToString();       // Get customer number
                string customerName = row["CustomerName"].ToString();           // Get customer name
                string customerPostcode = row["Postcode"].ToString();           // Get customer postcode
                string houseNumber = row["AddressLine1"].ToString().Split()[0]; // Get customer adress and trim to only house number

                // Add Data to table
                customers_DataGridView.Rows.Add(customerNumber, customerName, customerPostcode, houseNumber); 
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
    }
}
