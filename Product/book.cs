using System;

namespace Product
{
    // Define a class to represent a book product
    public class Book
    {
        // Properties of the book
        public string Title { get; private set; }
        public string Author { get; private set; }
        public string ISBN { get; private set; }
        public DateTime PublicationDate { get; private set; }
        public decimal Price { get; private set; }
        public int StockQuantity { get; private set; }

        // Default constructor
        public Book()
        {
            // Default values
            Title = "Unknown Title";
            Author = "Unknown Author";
            ISBN = "000-0-00-000000-0";
            PublicationDate = DateTime.MinValue;
            Price = 0.0m;
            StockQuantity = 0;
        }

        // Parameterized constructor
        public Book(string title, string author, string isbn, DateTime publicationDate, decimal price, int stockQuantity)
        {
            Title = title;
            Author = author;
            ISBN = isbn;
            PublicationDate = publicationDate;
            Price = price;
            StockQuantity = stockQuantity;
        }

        // Method to display book details
        public void DisplayBookDetails()
        {
            Console.WriteLine("Book Details:");
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"ISBN: {ISBN}");
            Console.WriteLine($"Publication Date: {PublicationDate:MMMM d, yyyy}"); // Format date
            Console.WriteLine($"Price: ${Price:F2}"); // Format price to 2 decimal places
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
//             // Create a new book instance using the default constructor
//             Book defaultBook = new Book();
//             defaultBook.DisplayBookDetails();

//             // Create a new book instance using the parameterized constructor
//             Book book1 = new Book(
//                 "The Great Gatsby",
//                 "F. Scott Fitzgerald",
//                 "978-0743273565",
//                 new DateTime(1925, 4, 10),
//                 10.99m,
//                 100
//             );

//             // Display the book details
//             book1.DisplayBookDetails();

//             // Update and display the book price and stock quantity
//             book1.UpdatePrice(12.99m);
//             book1.UpdateStockQuantity(85);
//             book1.DisplayBookDetails();
//         }
//     }
// }
