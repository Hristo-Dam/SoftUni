using System;

namespace _3._Calculations
{
    internal class Program
    {
        static double Add(double a, double b)
        {
            return a + b;
        }

        static double Subtract(double a, double b)
        {
            return a - b;
        }

        static double Multiply(double a, double b)
        {
            return a * b;
        }

        static double Divide(double a, double b)
        {
            return a / b;
        }

        static double Calculate(double a, double b, string operation)
        {
            double result = 0;

            if (operation == "add")
            {
                result = Add(a, b);
            }
            else if (operation == "subtract")
            {
                result = Subtract(a, b);
            }
            else if (operation == "multiply")
            {
                result = Multiply(a, b);
            }
            else if (operation == "divide")
            {
                result = Divide(a, b);
            }

            return result;
        }

        static void Main(string[] args)
        {
            string operation = Console.ReadLine();
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine(Calculate(a, b, operation));
        }
    }
}
