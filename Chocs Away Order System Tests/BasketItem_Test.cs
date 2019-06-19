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
            BasketItem bI = new BasketItem(99,"TestName",1.5,10,"TestDesc");

            Assert.AreEqual(99, bI.ProductNumber);
            Assert.AreEqual("TestName", bI.ProductName);
            Assert.AreEqual(1.5, bI.LatestPrice);
            Assert.AreEqual(10, bI.Quantity);
            Assert.AreEqual("TestDesc", bI.Description);

            Assert.AreEqual(15, bI.TotalValueOfBasketItem);
        }

        // Test adding item to orderbasket
        [TestMethod]
        public void IncreaseQuantity_Test()
        {
            BasketItem bI = new BasketItem(99, "TestName", 1.5, 10, "TestDesc");

            bI.IncreaseQuantity(5);

            Assert.AreEqual(15, bI.Quantity);
        }
    }
}
