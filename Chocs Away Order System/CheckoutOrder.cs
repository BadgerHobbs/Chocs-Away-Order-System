using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chocs_Away_Order_System
{
    class CheckoutOrder
    {
        // Initialse order number
        static int orderNumber = 0;

        // Get Order From Database
        public static void AddOrder()
        {
            OrderBasket orderBasket = new OrderBasket();
            orderBasket = OrderBasket_Form.orderBasket;

            orderBasket.UpdateTotals();

            // Create SQL connection
            using (SqlConnection connection = new SqlConnection(@"Server=ANDREW-PC\SQLEXPRESS;Database=ChocsAway;Trusted_Connection=true"))
            {
                // Open SQL connection
                connection.Open();
                // Create and use new SQL command
                using (SqlCommand command = connection.CreateCommand())
                {
                    // Add SQL command query to insert into orders specific values
                    command.CommandText = "INSERT INTO Orders(CustomerNumber, OrderDate, OrderTotal, OrderStatus) VALUES(@customerNumber, @orderDate, @orderTotal, @orderStatus); SELECT SCOPE_IDENTITY(); ";
                    // Add data to values in SQL query string
                    // Get customer number
                    command.Parameters.AddWithValue("@customerNumber", Customers_Form.chosenCustomerNumber);
                    // Get date of order
                    command.Parameters.AddWithValue("@orderDate", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.sss"));
                    // Get basket total
                    command.Parameters.AddWithValue("@orderTotal", orderBasket.BasketTotal);
                    // Set order status to 1
                    command.Parameters.AddWithValue("@orderStatus", "1");
                    //  Execute SQL query/command & Get order number from database and store as ordernumber
                    orderNumber = Convert.ToInt32(command.ExecuteScalar());
                }
            }
        }
        

        // Get Order From Database
        public static void AddOrderItems()
        {
            // Create new orderbasket variable
            OrderBasket orderBasket = new OrderBasket();
            // Set order basket variable as existing from order basket form
            orderBasket = OrderBasket_Form.orderBasket;
            // Update order basket totals
            orderBasket.UpdateTotals();

            // Iterate through each item in the basket
            foreach (BasketItem basketItem in orderBasket.BasketItems)
            {
                // Create SQL command using connection information
                using (SqlConnection connection = new SqlConnection(@"Server=ANDREW-PC\SQLEXPRESS;Database=ChocsAway;Trusted_Connection=true"))
                {
                    // Open the SQL connection
                    connection.Open();
                    // Create and use new SQL command
                    using (SqlCommand command = connection.CreateCommand())
                    {
                        // Add SQL command query to insert into orders specific values
                        command.CommandText = "INSERT INTO OrderItems(OrderNumber, ProductNumber, Quantity) VALUES(@orderNumber, @productNumber, @quantity)";
                        // Add data to values in SQL query string
                        // Add order number
                        command.Parameters.AddWithValue("@orderNumber", orderNumber);
                        // Add product number
                        command.Parameters.AddWithValue("@productNumber", basketItem.ProductNumber);
                        // Add product quantity
                        command.Parameters.AddWithValue("@quantity", basketItem.Quantity);
                        // Execute SQL query/command
                        command.ExecuteNonQuery();
                    }
                }
            }
        }
    }
}
