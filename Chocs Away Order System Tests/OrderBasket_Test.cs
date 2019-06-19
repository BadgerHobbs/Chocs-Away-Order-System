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
            OrderBasket orderBasket = new OrderBasket();

            orderBasket.AddItem(1, "TestName", 1.5, 10, "TestDesc");

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
            OrderBasket orderBasket = new OrderBasket();

            orderBasket.AddItem(99, "TestName", 1.5, 10, "TestDesc");

            orderBasket.RemoveItem(99);

            Assert.AreEqual(orderBasket.BasketItems.Contains(new BasketItem(99, "TestName", 1.5, 10, "TestDesc")), false);
        }

        // Test clearing order basket
        [TestMethod]
        public void ClearBasket_Test()
        {
            OrderBasket orderBasket = new OrderBasket();

            orderBasket.AddItem(83, "TestName", 1.5, 10, "TestDesc");

            orderBasket.ClearBasket();

            Assert.AreEqual(orderBasket.BasketItems.Count, 0);
        }

        // Test calculating totals of order basket (no. products, items and basket total)
        [TestMethod]
        public void Totals_Test()
        {
            OrderBasket orderBasket = new OrderBasket();

            orderBasket.AddItem(83, "TestName", 1.5, 10, "TestDesc");

            orderBasket.UpdateTotals();

            Assert.AreEqual(orderBasket.NumberOfProducts, 1);
            Assert.AreEqual(orderBasket.NumberOfItems, 10);
            Assert.AreEqual(orderBasket.BasketTotal, 15);
        }
    }
}
    