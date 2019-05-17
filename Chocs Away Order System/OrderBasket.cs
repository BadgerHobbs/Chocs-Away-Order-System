using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chocs_Away_Order_System
{
    class OrderBasket
    {
        private List<BasketItem> basketItems = new List<BasketItem>();
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

        public void AddItem(int productNumber, string productName, double latestPrice, int quantity, string description)
        {
            int index = 0;

            foreach (BasketItem basketItem in basketItems)
            {
                if (basketItem.ProductNumber == productNumber)
                {
                    basketItems[index].IncreaseQuantity(quantity);
                    UpdateTotals();
                    return;
                }

                index++;
            }

            basketItems.Add(new BasketItem(productNumber, productName, latestPrice, quantity, description));

            UpdateTotals();
        }

        public void RemoveItem(int productNumber)
        {
            foreach (BasketItem basketItem in basketItems)
            {
                if (basketItem.ProductNumber == productNumber)
                {
                    basketItems.Remove(basketItem);
                    UpdateTotals();
                    return;
                }
            }

            UpdateTotals();
        }

        public void ClearBasket()
        {
            BasketItems = new List<BasketItem>();

            UpdateTotals();
        }

        public void UpdateTotals()
        {
            NumberOfItems = CalculateNumberOfItems();
            NumberOfProducts = CalculateNumberOfProducts();
            BasketTotal = CalculateTotalCost();
        }

        private int CalculateNumberOfProducts()
        {
            return basketItems.Count;
        }

        private int CalculateNumberOfItems()
        {
            int numberOfItems = 0;

            foreach (BasketItem basketItem in BasketItems)
            {
                numberOfItems += basketItem.Quantity;
            }

            return numberOfItems;
        }

        private double CalculateTotalCost()
        {
            double totalCost = 0;

            foreach (BasketItem basketItem in BasketItems)
            {
                totalCost += basketItem.Quantity * basketItem.LatestPrice;
            }

            return totalCost;
        }
    }
}