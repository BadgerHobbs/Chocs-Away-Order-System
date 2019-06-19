using Microsoft.VisualStudio.TestTools.UnitTesting;
using Chocs_Away_Order_System;

namespace Chocs_AwayChocs_Away_Order_System.Tests
{
    [TestClass]
    public class BasketItem_Test
    {
        // Test adding item to orderbasket
        [TestMethod]
        public void InitiateItem_Test()
        {
            BasketItem basketItem = new BasketItem(99,"TestName",1.5,10,"TestDesc");

            Assert.AreEqual(99, basketItem.ProductNumber);
            Assert.AreEqual("TestName", basketItem.ProductName);
            Assert.AreEqual(1.5, basketItem.LatestPrice);
            Assert.AreEqual(10, basketItem.Quantity);
            Assert.AreEqual("TestDesc", basketItem.Description);

            Assert.AreEqual(15, basketItem.TotalValueOfBasketItem);
        }

        // Test adding item to orderbasket
        [TestMethod]
        public void IncreaseQuantity_Test()
        {
            BasketItem basketItem = new BasketItem(99, "TestName", 1.5, 10, "TestDesc");

            basketItem.IncreaseQuantity(5);

            Assert.AreEqual(15, basketItem.Quantity);
        }
    }
}
