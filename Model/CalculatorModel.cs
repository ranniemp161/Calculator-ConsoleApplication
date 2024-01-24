using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Calculator_Application.Model
{
    internal class CalculatorModel
    {

        public delegate double CalculatorFunction(double x, double y);


        public static double Add (double a, double b)
        {
            return a + b;
        }

        public static double Subtract(double a, double b)
        {
            return a - b;
        }

        public static double Multiply(double a, double b)
        {
            return a * b;
        }

        public static double Divide(double a, double b)
        {
            return a / b;
        }

        public static double PerformOperation(CalculatorFunction operation, double x, double y)
        {
            return operation(x, y);
        }


    }
}
