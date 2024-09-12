using System;

namespace Product
{
    // Define a class to represent a clothing product
    public class ClothingProduct
    {
        // Properties of the clothing product
        public string Name { get; private set; }
        public string Brand { get; private set; }
        public string Size { get; private set; }
        public string Color { get; private set; }
        public decimal Price { get; private set; }
        public string Material { get; private set; }
        public int StockQuantity { get; private set; }

        // Default constructor
        public ClothingProduct()
        {
            // Default values can be set here
            Name = "Unknown";
            Brand = "Unknown";
            Size = "Unknown";
            Color = "Unknown";
            Price = 0.0m;
            Material = "Unknown";
            StockQuantity = 0;
        }

        // Parameterized constructor
        public ClothingProduct(string name, string brand, string size, string color, decimal price, string material, int stockQuantity)
        {
            Name = name;
            Brand = brand;
            Size = size;
            Color = color;
            Price = price;
            Material = material;
            StockQuantity = stockQuantity;
        }

        // Method to display clothing product details
        public void DisplayProductDetails()
        {
            Console.WriteLine("Clothing Product Details:");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Brand: {Brand}");
            Console.WriteLine($"Size: {Size}");
            Console.WriteLine($"Color: {Color}");
            Console.WriteLine($"Price: ${Price:F2}"); // Format price to 2 decimal places
            Console.WriteLine($"Material: {Material}");
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
            // Create a new clothing product instance using the default constructor
            ClothingProduct defaultClothing = new ClothingProduct();
            defaultClothing.DisplayProductDetails();

            // Create a new clothing product instance using the parameterized constructor
            ClothingProduct product1 = new ClothingProduct(
                "Slim Fit Jeans",
                "DenimBrand",
                "32",
                "Dark Blue",
                49.99m,
                "Denim",
                100
            );

            // Display the product details
            product1.DisplayProductDetails();

            // Update and display the product price and stock quantity
            product1.UpdatePrice(44.99m);
            product1.UpdateStockQuantity(80);
            product1.DisplayProductDetails();
        }
    }
}

