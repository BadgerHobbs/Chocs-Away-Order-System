using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chocs_Away_Order_System
{
    public class OrderBasket
    {
        // Initialise variables to hold basket items and details
        // Initialise basket items list
        private List<BasketItem> basketItems = new List<BasketItem>();
        // Initialise basket total, number of products and number of items
        private double basketTotal; 
        private int numberOfProducts;
        private int numberOfItems;

        public List<BasketItem> BasketItems
        {
            get
            {
                return basketItems;
            }
            private set
            {
                basketItems = value;
            }
        }

        public double BasketTotal
        {
            get
            {
                return basketTotal;
            }
            private set
            {
                basketTotal = value;
            }
        }

        public int NumberOfItems
        {
            get
            {
                return numberOfItems;
            }
            private set
            {
                numberOfItems = value;
            }
        }

        public int NumberOfProducts
        {
            get
            {
                return numberOfProducts;
            }
            private set
            {
                numberOfProducts = value;
            }
        }

        // Method to add item to basket
        public void AddItem(int productNumber, string productName, double latestPrice, int quantity, string description)
        {
            // Initialise index variable for position in basket item list
            int index = 0;
            // Iterate through each item in basket
            foreach (BasketItem basketItem in basketItems)
            {
                // If basket item with same product number (same item) exists
                if (basketItem.ProductNumber == productNumber)
                {
                    // Add to that item's quanity the amount of this item
                    basketItems[index].IncreaseQuantity(quantity);
                    // Update totals of basket
                    UpdateTotals();
                    // Exit Method
                    return;
                }
                // Increase index position in list
                index++;
            }
            // Add item to basket
            basketItems.Add(new BasketItem(productNumber, productName, latestPrice, quantity, description));
            // Update totals of basket
            UpdateTotals();
        }

        // Method to remove item from basket based on product number
        public void RemoveItem(int productNumber)
        {
            // Iterate through each item in the basket
            foreach (BasketItem basketItem in basketItems)
            {
                // If the current basket item's product number is the one being searched for
                if (basketItem.ProductNumber == productNumber)
                {
                    // Remove item from basket
                    basketItems.Remove(basketItem);
                    // Update totals of basket
                    UpdateTotals();
                    // Exit Method
                    return;
                }
            }
            // Update totals of basket
            UpdateTotals();
        }

        // Method to clear basket of all items
        public void ClearBasket()
        {
            // Set basket items list as a new empty list of items
            BasketItems = new List<BasketItem>();
            // Update totals of basket
            UpdateTotals();
        }

        // Method to update totals of basket
        public void UpdateTotals()
        {
            // Recaltulate and set number of items
            NumberOfItems = CalculateNumberOfItems();
            // Recalculate and set number of products
            NumberOfProducts = CalculateNumberOfProducts();
            // Recalculare and set basket total
            BasketTotal = CalculateTotalCost();
        }

        // Method to calculate and return number of products in basket
        private int CalculateNumberOfProducts()
        {
            // Return number items in basket
            return basketItems.Count;
        }

        // Method to calculate and return number of items in basket
        private int CalculateNumberOfItems()
        {
            // Initalise variable to store number of items
            int numberOfItems = 0;
            // Iterate through each item in basket
            foreach (BasketItem basketItem in BasketItems)
            {
                // Add the quantity of the item to the number of items
                numberOfItems += basketItem.Quantity;
            }
            // Return the number of items
            return numberOfItems;
        }

        // Method to calculate the total cost of the basket
        private double CalculateTotalCost()
        {
            // Initialise variable to store total cost
            double totalCost = 0;
            // Iterate through each item in basket items
            foreach (BasketItem basketItem in BasketItems)
            {
                // Add basket item quantity times latest prices to the total cost
                totalCost += basketItem.Quantity * basketItem.LatestPrice;
            }
            // Return the total cost
            return totalCost;
        }
    }
}