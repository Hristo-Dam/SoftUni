using System;

namespace _2._Simple_Calculator
{
    internal class Program
    {
        static int Subtract(int a, int b)
        {
            int result = a - b;
            return result;
        }

        static int Add(int a, int b)
        {
            int result = a + b;
            return result;
        }

        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thurdNumber = int.Parse(Console.ReadLine());
            Add(firstNumber, secondNumber);
            Console.WriteLine(Subtract(Add(firstNumber, secondNumber), thurdNumber));
        }
    }
}
