using System;

namespace Product
{
    // Define a class to represent a wire product
    public class WireProduct
    {
        // Properties of the wire product
        public string Type { get; private set; }
        public string Material { get; private set; }
        public double Length { get; private set; } // Length in meters
        public double Diameter { get; private set; } // Diameter in millimeters
        public decimal PricePerMeter { get; private set; }
        public int StockQuantity { get; private set; }

        // Default constructor
        public WireProduct()
        {
            // Default values
            Type = "Unknown";
            Material = "Unknown";
            Length = 0.0;
            Diameter = 0.0;
            PricePerMeter = 0.0m;
            StockQuantity = 0;
        }

        // Parameterized constructor
        public WireProduct(string type, string material, double length, double diameter, decimal pricePerMeter, int stockQuantity)
        {
            Type = type;
            Material = material;
            Length = length;
            Diameter = diameter;
            PricePerMeter = pricePerMeter;
            StockQuantity = stockQuantity;
        }

        // Method to display wire product details
        public void DisplayProductDetails()
        {
            Console.WriteLine("Wire Product Details:");
            Console.WriteLine($"Type: {Type}");
            Console.WriteLine($"Material: {Material}");
            Console.WriteLine($"Length: {Length:F2} meters");
            Console.WriteLine($"Diameter: {Diameter:F2} mm");
            Console.WriteLine($"Price per Meter: ${PricePerMeter:F2}"); // Format price to 2 decimal places
            Console.WriteLine($"Stock Quantity: {StockQuantity}");
        }

        // Method to update the price per meter
        public void UpdatePricePerMeter(decimal newPricePerMeter)
        {
            if (newPricePerMeter >= 0)
            {
                PricePerMeter = newPricePerMeter;
                Console.WriteLine($"Price per meter updated to ${PricePerMeter:F2}");
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
//             // Create a new wire product instance using the default constructor
//             WireProduct defaultWire = new WireProduct();
//             defaultWire.DisplayProductDetails();

//             // Create a new wire product instance using the parameterized constructor
//             WireProduct wire1 = new WireProduct(
//                 "Electrical Wire",
//                 "Copper",
//                 1000.0,  // Length in meters
//                 2.5,      // Diameter in millimeters
//                 1.20m,    // Price per meter
//                 150
//             );

//             // Display the product details
//             wire1.DisplayProductDetails();

//             // Update and display the product price per meter and stock quantity
//             wire1.UpdatePricePerMeter(1.15m);
//             wire1.UpdateStockQuantity(120);
//             wire1.DisplayProductDetails();
//         }
//     }
// }

