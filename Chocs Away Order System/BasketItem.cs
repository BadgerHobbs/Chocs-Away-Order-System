using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chocs_Away_Order_System
{
    public class BasketItem
    {
        private int productNumber;
        private string productName;
        private double latestPrice;
        private int quantity;
        private string description;
        private double totalValueOfBasketItem;

        public BasketItem(int productNumber, string productName, double latestPrice, int quantity, string description)
        {
            this.productNumber = productNumber;
            this.productName = productName;
            this.latestPrice = latestPrice;
            this.quantity = quantity;
            this.description = description;
            this.totalValueOfBasketItem = latestPrice * quantity;
        }

        public string Description
        {
            get
            {
                return description;
            }
            private set
            {
                description = value;
            }
        }

        public double LatestPrice
        {
            get
            {
                return latestPrice;
            }
            private set
            {
                latestPrice = value;
            }
        }

        public string ProductName
        {
            get
            {
                return productName;
            }
            private set
            {
                productName = value;
            }
        }

        public int ProductNumber
        {
            get
            {
                return productNumber;
            }
            private set
            {
                productNumber = value;
            }
        }

        public int Quantity
        {
            get
            {
                return quantity;
            }
            set
            {
                quantity = value;
            }
        }

        public double TotalValueOfBasket
        {
            get
            {
                return totalValueOfBasketItem;
            }
            private set
            {
                totalValueOfBasketItem = value;
            }
        }

        public void IncreaseQuantity(int increase)
        {
            this.Quantity += increase;
            TotalValueOfBasket = LatestPrice * Quantity;
        }
    }
}