using System;

namespace Product
{
    // Define a class to represent a watch product
    public class Watch
    {
        // Properties of the watch
        public string Brand { get; private set; }
        public string Model { get; private set; }
        public string Movement { get; private set; }
        public string CaseMaterial { get; private set; }
        public decimal Price { get; private set; }
        public string WaterResistance { get; private set; }
        public int StockQuantity { get; private set; }

        // Default constructor
        public Watch()
        {
            // Default values
            Brand = "Unknown";
            Model = "Unknown";
            Movement = "Unknown";
            CaseMaterial = "Unknown";
            Price = 0.0m;
            WaterResistance = "Unknown";
            StockQuantity = 0;
        }

        // Parameterized constructor
        public Watch(string brand, string model, string movement, string caseMaterial, decimal price, string waterResistance, int stockQuantity)
        {
            Brand = brand;
            Model = model;
            Movement = movement;
            CaseMaterial = caseMaterial;
            Price = price;
            WaterResistance = waterResistance;
            StockQuantity = stockQuantity;
        }

        // Method to display watch details
        public void DisplayWatchDetails()
        {
            Console.WriteLine("Watch Details:");
            Console.WriteLine($"Brand: {Brand}");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Movement: {Movement}");
            Console.WriteLine($"Case Material: {CaseMaterial}");
            Console.WriteLine($"Price: ${Price:F2}"); // Format price to 2 decimal places
            Console.WriteLine($"Water Resistance: {WaterResistance}");
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
//             // Create a new watch instance using the default constructor
//             Watch defaultWatch = new Watch();
//             defaultWatch.DisplayWatchDetails();

//             // Create a new watch instance using the parameterized constructor
//             Watch watch1 = new Watch(
//                 "Rolex",
//                 "Submariner",
//                 "Automatic",
//                 "Stainless Steel",
//                 7999.99m,
//                 "300 meters",
//                 20
//             );

//             // Display the watch details
//             watch1.DisplayWatchDetails();

//             // Update and display the watch price and stock quantity
//             watch1.UpdatePrice(7599.99m);
//             watch1.UpdateStockQuantity(18);
//             watch1.DisplayWatchDetails();
//         }
//     }
// }
