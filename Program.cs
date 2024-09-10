// using System;

// namespace BasicDataTypesDemo
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             // Integer types
//             int numberOfBooks = 10;     // 32-bit signed integer
//             long distanceToMoon = 38400L; // 64-bit signed integer

//             // Floating-point types
//             float heightInMeters = 1.75f;   // 32-bit floating-point number
//             double bankBalance = 12345.67;  // 64-bit floating-point number

//             // Character type
//             char initialLetter = 'C';  // Single 16-bit Unicode character

//             // Boolean type
//             bool isLibraryOpen = true; // Boolean value (true or false)

//             // String type
//             string welcomeMessage = "Welcome to the Library!"; // Sequence of characters

//             // Display the values
//             Console.WriteLine("Number of Books: " + numberOfBooks);
//             Console.WriteLine("Distance to the Moon (in km): " + distanceToMoon);
//             Console.WriteLine("Height in meters: " + heightInMeters);
//             Console.WriteLine("Bank Balance: $" + bankBalance);
//             Console.WriteLine("Initial Letter: " + initialLetter);
//             Console.WriteLine("Is Library Open? " + isLibraryOpen);
//             Console.WriteLine("Message: " + welcomeMessage);

//             // Additional usage examples
//             int newNumberOfBooks = numberOfBooks + 5;
//             Console.WriteLine("New Number of Books: " + newNumberOfBooks);

//             double discountedBalance = bankBalance * 0.95;
//             Console.WriteLine("Discounted Balance: $" + discountedBalance);

//             string userName = "Alice";
//             string personalizedMessage = $"Hello, {userName}!";
//             Console.WriteLine(personalizedMessage);
//         }
//     }
// }




//2 - 

using System;

namespace ArrayDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Array of integers
            int[] numbers = { 1, 2, 3, 4, 5 };
            
            // Display the contents of the integer array
            Console.WriteLine("Integer Array:");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"Element at index {i}: {numbers[i]}");
            }

            // Modify an element in the array
            numbers[2] = 99;
            Console.WriteLine("\nAfter modification:");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"Element at index {i}: {numbers[i]}");
            }

            // Array of strings
            string[] names = { "Alice", "Bob", "Charlie", "Diana" };

            // Display the contents of the string array
            Console.WriteLine("\nString Array:");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            // Add a new element to the string array (note: arrays are fixed-size; this is for demonstration purposes only)
            // To actually handle dynamic sizes, consider using a `List<T>`.
            // For demonstration, we will just display the existing array contents.
            Console.WriteLine("\nString Array (without modification, as arrays are fixed-size):");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
