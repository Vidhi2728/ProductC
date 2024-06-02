using System;
using ProductC;

namespace ProductC
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new Product
            Product product = new Product(1, "Laptop", 1200m, 50);

            // Display initial product details
            Console.WriteLine("Product Details:");
            Console.WriteLine($"ID: {product.GetProductId()}");
            Console.WriteLine($"Name: {product.GetProductName()}");
            Console.WriteLine($"Price: {product.GetPrice()}");
            Console.WriteLine($"Stock: {product.GetStock()}");

            // Increase stock
            Console.WriteLine("\nIncreasing stock by 10...");
            product.IncreaseStock(10);
            Console.WriteLine($"New Stock: {product.GetStock()}");

            // Decrease stock
            Console.WriteLine("\nDecreasing stock by 5...");
            product.DecreaseStock(5);
            Console.WriteLine($"New Stock: {product.GetStock()}");

            // Attempt to set an invalid price (This will throw an exception)
            try
            {
                Console.WriteLine("\nAttempting to create a product with invalid price...");
                Product invalidProduct = new Product(2, "Tablet", 0, 20);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }

            // Attempt to decrease stock by more than available (This will throw an exception)
            try
            {
                Console.WriteLine("\nAttempting to decrease stock by more than available...");
                product.DecreaseStock(100);
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
        }
    }
}
