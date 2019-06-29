using Microsoft.VisualStudio.TestTools.UnitTesting;
using Chocs_Away_Order_System;

namespace Chocs_AwayChocs_Away_Order_System.Tests
{
    [TestClass]
    public class BasketItem_Test
    {
        // Test creating new basket item
        [TestMethod]
        public void InitiateItem_Test()
        {
            // Create basket item object for test
            BasketItem basketItem = new BasketItem(99,"TestName",1.5,10,"TestDesc");
            // Check that the basket item has been created with the correct values
            Assert.AreEqual(99, basketItem.ProductNumber);
            Assert.AreEqual("TestName", basketItem.ProductName);
            Assert.AreEqual(1.5, basketItem.LatestPrice);
            Assert.AreEqual(10, basketItem.Quantity);
            Assert.AreEqual("TestDesc", basketItem.Description);
            // Check that the total value of the basket item is correctly calculated
            Assert.AreEqual(15, basketItem.TotalValueOfBasketItem);
        }

        // Test increasing quantity of item
        [TestMethod]
        public void IncreaseQuantity_Test()
        {
            // Create basket item object for test
            BasketItem basketItem = new BasketItem(99, "TestName", 1.5, 10, "TestDesc");
            // Increase the quantity of the item
            basketItem.IncreaseQuantity(5);
            // Check that the quantity of the item has been updated
            Assert.AreEqual(15, basketItem.Quantity);
        }
    }
}
