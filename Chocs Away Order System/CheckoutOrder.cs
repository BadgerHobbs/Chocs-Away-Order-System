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
        // Add Order to Orders Database
        // [Order No, Customer No, Date, Total, Status]
        // Add Items from order to OrderItems Database
        // [OrderItemNumber, OrderNumber, ProductNumber, Quantity]

        static int orderNumber = 0;

        // Get Order From Database
        public static void AddOrder()
        {
            OrderBasket orderBasket = new OrderBasket();
            orderBasket = OrderBasket_Form.orderBasket;

            orderBasket.UpdateTotals();

            // Create SQL connection
            //SqlConnection connection = new SqlConnection(@"Server=ANDREW-PC\SQLEXPRESS;Database=ChocsAway;Trusted_Connection=true");

            using (SqlConnection connection = new SqlConnection(@"Server=ANDREW-PC\SQLEXPRESS;Database=ChocsAway;Trusted_Connection=true"))
            {
                connection.Open();
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "INSERT INTO Orders(CustomerNumber, OrderDate, OrderTotal, OrderStatus) VALUES(@customerNumber, @orderDate, @orderTotal, @orderStatus); SELECT SCOPE_IDENTITY(); ";
                    //command.Parameters.AddWithValue("@orderNumber", GetOrderNumber());
                    command.Parameters.AddWithValue("@customerNumber", Customers_Form.chosenCustomerNumber);
                    command.Parameters.AddWithValue("@orderDate", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.sss"));
                    command.Parameters.AddWithValue("@orderTotal", orderBasket.BasketTotal);
                    command.Parameters.AddWithValue("@orderStatus", "1");

                    orderNumber = Convert.ToInt32(command.ExecuteScalar());

                    //command.ExecuteNonQuery();
                }
            }
        }
        

        // Get Order From Database
        public static void AddOrderItems()
        {
            OrderBasket orderBasket = new OrderBasket();
            orderBasket = OrderBasket_Form.orderBasket;

            orderBasket.UpdateTotals();
            
            // Create SQL connection
            //SqlConnection connection = new SqlConnection(@"Server=ANDREW-PC\SQLEXPRESS;Database=ChocsAway;Trusted_Connection=true");

            foreach (BasketItem basketItem in orderBasket.BasketItems)
            {
                // Open the SQL connection
                //connection.Open();

                // Create SQL command using connection information
                //SqlCommand command = new SqlCommand("INSERT OrderItems (OrderItemNumber, OrderNumber, ProductNumber, Quantity) values(" + orderItemNumber.ToString() + "," + orderNumber.ToString() + "," + basketItem.ProductNumber.ToString() + "," + basketItem.Quantity.ToString() + ")", connection);

                // create data adapter
                //SqlDataAdapter dataAdapter = new SqlDataAdapter(command);

                // Close the SQL connection
                //connection.Close();
                // Close the data adapter
                //dataAdapter.Dispose();
                // Return data table with new results

                using (SqlConnection connection = new SqlConnection(@"Server=ANDREW-PC\SQLEXPRESS;Database=ChocsAway;Trusted_Connection=true"))
                {
                    connection.Open();
                    using (SqlCommand command = connection.CreateCommand())
                    {
                        command.CommandText = "INSERT INTO OrderItems(OrderNumber, ProductNumber, Quantity) VALUES(@orderNumber, @productNumber, @quantity)";

                        command.Parameters.AddWithValue("@orderNumber", orderNumber);
                        command.Parameters.AddWithValue("@productNumber", basketItem.ProductNumber);
                        command.Parameters.AddWithValue("@quantity", basketItem.Quantity);

                        command.ExecuteNonQuery();
                    }
                }
            }
            
            
        }

        static int GetOrderNumber()
        {
            string stmt = "SELECT COUNT(*) FROM Orders";
            int orderNumber = 0;

            using (SqlConnection thisConnection = new SqlConnection(@"Server=ANDREW-PC\SQLEXPRESS;Database=ChocsAway;Trusted_Connection=true"))
            {
                using (SqlCommand cmdCount = new SqlCommand(stmt, thisConnection))
                {
                    thisConnection.Open();
                    orderNumber = (int)cmdCount.ExecuteScalar();
                }
            }

            return orderNumber + 1;
        }
    }
}
