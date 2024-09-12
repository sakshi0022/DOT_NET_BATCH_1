using System;

namespace Product
{
    // Define a class to represent a car product
    public class Car
    {
        // Properties of the car
        public string Make { get; private set; }
        public string Model { get; private set; }
        public int Year { get; private set; }
        public string Color { get; private set; }
        public decimal Price { get; private set; }
        public string EngineType { get; private set; }
        public int StockQuantity { get; private set; }

        // Default constructor
        public Car()
        {
            // Default values
            Make = "Unknown";
            Model = "Unknown";
            Year = 0;
            Color = "Unknown";
            Price = 0.0m;
            EngineType = "Unknown";
            StockQuantity = 0;
        }

        // Parameterized constructor
        public Car(string make, string model, int year, string color, decimal price, string engineType, int stockQuantity)
        {
            Make = make;
            Model = model;
            Year = year;
            Color = color;
            Price = price;
            EngineType = engineType;
            StockQuantity = stockQuantity;
        }

        // Method to display car details
        public void DisplayCarDetails()
        {
            Console.WriteLine("Car Details:");
            Console.WriteLine($"Make: {Make}");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Year: {Year}");
            Console.WriteLine($"Color: {Color}");
            Console.WriteLine($"Price: ${Price:F2}"); // Format price to 2 decimal places
            Console.WriteLine($"Engine Type: {EngineType}");
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
//             // Create a new car instance using the default constructor
//             Car defaultCar = new Car();
//             defaultCar.DisplayCarDetails();

//             // Create a new car instance using the parameterized constructor
//             Car car1 = new Car(
//                 "Tesla",
//                 "Model S",
//                 2023,
//                 "Red",
//                 89999.99m,
//                 "Electric",
//                 10
//             );

//             // Display the car details
//             car1.DisplayCarDetails();

//             // Update and display the car price and stock quantity
//             car1.UpdatePrice(84999.99m);
//             car1.UpdateStockQuantity(8);
//             car1.DisplayCarDetails();
//         }
//     }
// }
