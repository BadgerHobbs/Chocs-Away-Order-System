using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chocs_Away_Order_System
{
    public class BasketItem
    {
        // Initialise fileds to store basket item data
        private int productNumber;
        private string productName;
        private double latestPrice;
        private int quantity;
        private string description;
        private double totalValueOfBasketItem;

        // Initialisation of basket item object
        public BasketItem(int productNumber, string productName, double latestPrice, int quantity, string description)
        {
            // Set parameter values to item data fields
            this.productNumber = productNumber;
            this.productName = productName;
            this.latestPrice = latestPrice;
            this.quantity = quantity;
            this.description = description;
            // Calculare value of basket item by quanity times price
            this.totalValueOfBasketItem = latestPrice * quantity;
        }

        // Get/Set Method to Return/Set description
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

        // Get/Set Method to Return/Set latest price
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

        // Get/Set Method to Return/Set product name
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

        // Get/Set Method to Return/Set product number
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

        // Get/Set Method to Return/Set quantity
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

        // Get/Set Method to Return/Set value of item basket
        public double TotalValueOfBasketItem
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

        // Function to increase quantity of item
        public void IncreaseQuantity(int increase)
        {
            // Increase quantity by increase number
            this.Quantity += increase;
            // Recalculate basket value by price times quantity
            TotalValueOfBasketItem = LatestPrice * Quantity;
        }
    }
}