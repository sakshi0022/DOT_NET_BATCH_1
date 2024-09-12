using System;

namespace Product
{
    // Define a class to represent a product
    public class Product
    {
        // Properties of the product
        public string Name 
        public string Brand
        public decimal Price
        public string Category
        public string Description
        public int StockQuantity { }

        // Default constructor
        public Product()
        {
            // Default values can be set here
            Name = "Unknown";
            Brand = "Unknown";
            Price = 0.0m;
            Category = "Unknown";
            Description = "No description available.";
            StockQuantity = 0;
        }

        // Parameterized constructor
        public Product(string name, string brand, decimal price, string category, string description, int stockQuantity)
        {
            Name = name;
            Brand = brand;
            Price = price;
            Category = category;
            Description = description;
            StockQuantity = stockQuantity;
        }

        // Method to display product details
        public void DisplayProductDetails()
        {
            Console.WriteLine("Product Details:");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Brand: {Brand}");
            Console.WriteLine($"Price: ${Price:F2}"); // Format price to 2 decimal places
            Console.WriteLine($"Category: {Category}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Stock Quantity: {StockQuantity}");
        }

        // Method to update the price
        public void UpdatePrice(decimal newPrice)
        {
            if (newPrice >= 0)
            {
                Price = newPrice;
                Console.WriteLine($"Price updated to ${Price:F2}");
            }
            else
            {
                Console.WriteLine("Invalid price. Price cannot be negative.");
            }
        }

        // Method to update stock quantity
        public void UpdateStockQuantity(int newQuantity)
        {
            if (newQuantity >= 0)
            {
                StockQuantity = newQuantity;
                Console.WriteLine($"Stock quantity updated to {StockQuantity}");
            }
            else
            {
                Console.WriteLine("Invalid quantity. Quantity cannot be negative.");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create a new product instance using the default constructor
            Product defaultProduct = new Product();
            defaultProduct.DisplayProductDetails();

            // Create a new product instance using the parameterized constructor
            Product product1 = new Product(
                "Smartphone XYZ",
                "BrandTech",
                299.99m,
                "Electronics",
                "Latest smartphone with high-end features and a sleek design.",
                50
            );

            // Display the product details
            product1.DisplayProductDetails();

            // Update and display the product price and stock quantity
            product1.UpdatePrice(279.99m);
            product1.UpdateStockQuantity(45);
            product1.DisplayProductDetails();
        }
    }
}
