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

            // For each row in customers database of customer details
            using (var db = new chocsawayEntities())
            {
                Order newOrder = new Order() { CustomerNumber = Convert.ToInt32(Customers_Form.chosenCustomerNumber), OrderDate = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.sss")), OrderTotal = Convert.ToDecimal(orderBasket.BasketTotal), OrderStatus = 1 };
                db.Orders.Add(newOrder);
                db.SaveChanges();
                orderNumber = newOrder.OrderNumber;
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
                // For each row in customers database of customer details
                using (var db = new chocsawayEntities())
                {
                    db.OrderItems.Add(new OrderItem() { OrderNumber = orderNumber, ProductNumber = basketItem.ProductNumber, Quantity = basketItem.Quantity });
                    db.SaveChanges();
                }
            }
        }
    }
}
