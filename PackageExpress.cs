using System;

namespace PackageExpress
{
    class Program
    {
        static void Main(string[] args)
        {
            // Display welcome message to the user
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            // Prompt user for package weight and convert input to decimal
            Console.WriteLine("Please enter the package weight:");
            decimal weight = Convert.ToDecimal(Console.ReadLine());

            // Check if package weight exceeds the maximum allowed weight (50)
            if (weight > 50)
            {
                // Display error message if package is too heavy
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                // End the program
                return;
            }

            // Prompt user for package width and convert input to decimal
            Console.WriteLine("Please enter the package width:");
            decimal width = Convert.ToDecimal(Console.ReadLine());

            // Prompt user for package height and convert input to decimal
            Console.WriteLine("Please enter the package height:");
            decimal height = Convert.ToDecimal(Console.ReadLine());

            // Prompt user for package length and convert input to decimal
            Console.WriteLine("Please enter the package length:");
            decimal length = Convert.ToDecimal(Console.ReadLine());

            // Calculate the total dimensions by adding width, height, and length
            decimal totalDimensions = width + height + length;

            // Check if total dimensions exceed the maximum allowed (50)
            if (totalDimensions > 50)
            {
                // Display error message if package is too big
                Console.WriteLine("Package too big to be shipped via Package Express.");
                // End the program
                return;
            }

            // Calculate the shipping quote:
            // 1. Multiply the three dimensions together
            // 2. Multiply the result by the weight
            // 3. Divide the outcome by 100
            decimal quote = (height * width * length * weight) / 100;

            // Display the quote to the user as a dollar amount with 2 decimal places
            Console.WriteLine($"Your estimated total for shipping this package is: ${quote:F2}");
            
            // Display thank you message
            Console.WriteLine("Thank you!");

            // Wait for user to press a key before closing the console window
            Console.ReadKey();
        }
    }
} 