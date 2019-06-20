using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chocs_Away_Order_System
{
    public class CheckoutOrder
    {
        // Initialse order number
        static int orderNumber = 0;

        // Add order to base
        public static void AddOrder()
        {
            // Set order basket as order basket form order basket
            OrderBasket orderBasket = OrderBasket_Form.orderBasket;
            // Update totals in order basket
            orderBasket.UpdateTotals();

            // For each row in customers database of customer details
            using (var database = new chocsawayEntities())
            {
                // Create new order object
                Order newOrder = new Order() { CustomerNumber = Convert.ToInt32(Customers_Form.chosenCustomerNumber), OrderDate = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.sss")), OrderTotal = Convert.ToDecimal(orderBasket.BasketTotal), OrderStatus = 1 };
                // Add new order with parameters to orders database
                database.Orders.Add(newOrder);
                // Save changes to order database
                database.SaveChanges();
                // Retrieve the new order number for the order
                orderNumber = newOrder.OrderNumber;
            }
        }

        // Add order items to database
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
                // For each row in customers database of customer details
                using (var database = new chocsawayEntities())
                {
                    // Add new order item with parameters to orderitems database
                    database.OrderItems.Add(new OrderItem() { OrderNumber = orderNumber, ProductNumber = basketItem.ProductNumber, Quantity = basketItem.Quantity });
                    // Save database changes
                    database.SaveChanges();
                }
            }
        }
    }
}
