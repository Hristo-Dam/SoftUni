using System;

namespace _10._Math_operations
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

        static double Devide(double a, double b)
        {
            return a / b;
        }

        static double Calculate(double a, double b, string operation)
        {
            double result = 0;

            if (operation == "+")
            {
                result = Add(a, b);
            }
            else if (operation == "-")
            {
                result = Subtract(a, b);
            }
            else if (operation == "*")
            {
                result = Multiply(a, b);
            }
            else if (operation == "/")
            {
                result = Devide(a, b);
            }

            return result;
        }

        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            string operation = Console.ReadLine();
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine(Calculate(a, b, operation));
        }
    }
}
