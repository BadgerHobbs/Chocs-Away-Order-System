using Microsoft.VisualStudio.TestTools.UnitTesting;
using Chocs_Away_Order_System;

namespace Chocs_AwayChocs_Away_Order_System.Tests
{
    [TestClass]
    public class OrderBasket_Test
    {
        // Test adding item to orderbasket
        [TestMethod]
        public void AddItem_Test()
        {
            // Create order basket object for test
            OrderBasket orderBasket = new OrderBasket();
            // Add test item to order basket
            orderBasket.AddItem(1, "TestName", 1.5, 10, "TestDesc");
            // Check that the item has been added to the basket with all the correct values
            Assert.AreEqual(orderBasket.BasketItems[0].ProductNumber, 1);
            Assert.AreEqual(orderBasket.BasketItems[0].ProductName, "TestName");
            Assert.AreEqual(orderBasket.BasketItems[0].LatestPrice, 1.5);
            Assert.AreEqual(orderBasket.BasketItems[0].Quantity, 10);
            Assert.AreEqual(orderBasket.BasketItems[0].Description, "TestDesc");
        }

        // Test removing item from orderbasket
        [TestMethod]
        public void RemoveItem_Test()
        {
            // Create order basket object for test
            OrderBasket orderBasket = new OrderBasket();
            // Add test item to order basket
            orderBasket.AddItem(99, "TestName", 1.5, 10, "TestDesc");
            // Remove the item just added to order basket
            orderBasket.RemoveItem(99);
            // Check that the item is no longer in the basket and has been removed
            Assert.AreEqual(orderBasket.BasketItems.Contains(new BasketItem(99, "TestName", 1.5, 10, "TestDesc")), false);
        }

        // Test clearing order basket
        [TestMethod]
        public void ClearBasket_Test()
        {
            // Create order basket object for test
            OrderBasket orderBasket = new OrderBasket();
            // Add test item to order basket
            orderBasket.AddItem(83, "TestName", 1.5, 10, "TestDesc");
            // Clear the order basket
            orderBasket.ClearBasket();
            // Check that there are not items in the order basket
            Assert.AreEqual(orderBasket.BasketItems.Count, 0);
        }

        // Test calculating totals of order basket (no. products, items and basket total)
        [TestMethod]
        public void Totals_Test()
        {
            // Create order basket object for test
            OrderBasket orderBasket = new OrderBasket();
            // Add test item to order basket
            orderBasket.AddItem(83, "TestName", 1.5, 10, "TestDesc");
            // Update totals of order basket
            orderBasket.UpdateTotals();
            // Check that the number of products, items and total is correct
            Assert.AreEqual(orderBasket.NumberOfProducts, 1);
            Assert.AreEqual(orderBasket.NumberOfItems, 10);
            Assert.AreEqual(orderBasket.BasketTotal, 15);
        }
    }
}
    