using System;

namespace Product
{
    // Define a class to represent an electronic product
    public class ElectronicProduct
    {
        // Properties of the electronic product
        public string Name { get; private set; }
        public string Brand { get; private set; }
        public string Model { get; private set; }
        public decimal Price { get; private set; }
        public string Specifications { get; private set; }
        public int StockQuantity { get; private set; }

        // Default constructor
        public ElectronicProduct()
        {
            // Default values
            Name = "Unknown";
            Brand = "Unknown";
            Model = "Unknown";
            Price = 0.0m;
            Specifications = "No specifications available.";
            StockQuantity = 0;
        }

        // Parameterized constructor
        public ElectronicProduct(string name, string brand, string model, decimal price, string specifications, int stockQuantity)
        {
            Name = name;
            Brand = brand;
            Model = model;
            Price = price;
            Specifications = specifications;
            StockQuantity = stockQuantity;
        }

        // Method to display electronic product details
        public void DisplayProductDetails()
        {
            Console.WriteLine("Electronic Product Details:");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Brand: {Brand}");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Price: ${Price:F2}"); // Format price to 2 decimal places
            Console.WriteLine($"Specifications: {Specifications}");
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
}

//     class Program
//     {
//         static void Main(string[] args)
//         {
//             // Create a new electronic product instance using the default constructor
//             ElectronicProduct defaultProduct = new ElectronicProduct();
//             defaultProduct.DisplayProductDetails();

//             // Create a new electronic product instance using the parameterized constructor
//             ElectronicProduct product1 = new ElectronicProduct(
//                 "Smart TV",
//                 "TechVision",
//                 "X1234",
//                 799.99m,
//                 "55-inch 4K UHD Smart TV with HDR and Dolby Atmos",
//                 25
//             );

//             // Display the product details
//             product1.DisplayProductDetails();

//             // Update and display the product price and stock quantity
//             product1.UpdatePrice(749.99m);
//             product1.UpdateStockQuantity(20);
//             product1.DisplayProductDetails();
//         }
//     }
// }
