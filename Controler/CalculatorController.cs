using Simple_Calculator_Application.Model;
using Simple_Calculator_Application.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Simple_Calculator_Application.Model.CalculatorModel;

namespace Simple_Calculator_Application.Controler
{
    internal class CalculatorController
    {
        public static void Run()
        {
            // Declare a variable to store the user's choice
            int choice;

            // Declare a variable to store the delegate instance
            CalculatorFunction operation;

            // Declare variables to store the numbers and the result
            double x, y, result;

            // Use a loop to repeat the app until the user chooses to exit
            do
            {
                // Display the menu and get the user's choice
                choice = CalculatorView.DisplayMenu();

                // Use a switch statement to assign the delegate instance based on the user's choice
                switch (choice)
                {
                    case 1: // Addition
                        operation = new CalculatorFunction(Add);
                        break;
                    case 2: // Subtraction
                        operation = new CalculatorFunction(Subtract);
                        break;
                    case 3: // Multiplication
                        operation = new CalculatorFunction(Multiply);
                        break;
                    case 4: // Division
                        operation = new CalculatorFunction(Divide);
                        break;
                    case 5: // Exit
                        operation = null;
                        break;
                    default: // Invalid choice
                        operation = null;
                        CalculatorView.DisplayError("Invalid choice. Please try again.");
                        break;
                }

                // If the delegate instance is not null, proceed with the calculation
                if (operation != null)
                {
                    // Get the numbers from the user
                    (x, y) = CalculatorView.GetNumbers();

                    // Invoke the delegate with the numbers and store the result
                    result = PerformOperation(operation, x, y);

                    // Display the result
                    CalculatorView.DisplayResult(result);
                }

            } while (choice != 5); // Repeat until the user chooses to exit

            // Display a farewell message
            CalculatorView.DisplayFarewell();
        }
    }
}
