using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ProductC

{
    public class Product
    {
        private int productId;
        private string productName;
        private decimal price;
        private int stock;

        public Product(int productId, string productName, decimal price, int stock)
        {
            if (productId < 1 || productId > 1000)
                throw new ArgumentOutOfRangeException("ProductID must be between 1 and 1000.");
            if (price < 1 || price > 5000)
                throw new ArgumentOutOfRangeException("Price must be between 1 and 5000.");
            if (stock < 1 || stock > 1000)
                throw new ArgumentOutOfRangeException("Stock must be between 1 and 1000.");

            this.productId = productId;
            this.productName = productName;
            this.price = price;
            this.stock = stock;
        }

        public int GetProductId()
        {
            return productId;
        }

        public string GetProductName()
        {
            return productName;
        }

        public decimal GetPrice()
        {
            return price;
        }

        public int GetStock()
        {
            return stock;
        }

        public void IncreaseStock(int amount)
        {
            if (amount < 0)
                throw new ArgumentException("Increase amount must be positive.");
            stock += amount;
        }

        public void DecreaseStock(int amount)
        {
            if (amount < 0)
                throw new ArgumentException("Decrease amount must be positive.");
            if (amount > stock)
                throw new InvalidOperationException("Cannot decrease stock below zero.");
            stock -= amount;
        }
    }
}

