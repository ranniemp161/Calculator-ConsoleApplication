using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Calculator_Application.View
{
    internal class CalculatorView
    {
        public static int DisplayMenu()
        {
            Console.WriteLine("Select an operation:");
            Console.WriteLine("1) Addition");
            Console.WriteLine("2) Subtraction");
            Console.WriteLine("3) Multiplication");
            Console.WriteLine("4) Division");
            Console.WriteLine("5) Exit");
            int choice = int.Parse(Console.ReadLine());
            return choice;
        }

        // Define a method that prompts the user for two numbers and returns them as a tuple
        public static (double, double) GetNumbers()
        {
            Console.WriteLine("Enter the first number:");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            double y = double.Parse(Console.ReadLine());
            return (x, y);
        }

        // Define a method that displays the result
        public static void DisplayResult(double result)
        {
            Console.WriteLine($"The result is: {result}");
        }

        // Define a method that displays an error message
        public static void DisplayError(string message)
        {
            Console.WriteLine(message);
        }

        // Define a method that displays a farewell message
        public static void DisplayFarewell()
        {
            Console.WriteLine("Thank you for using the calculator app. Goodbye!");
        }
    }
}
