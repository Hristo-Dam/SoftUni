using System;

namespace _7._Math_Power
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            int powerTo = int.Parse(Console.ReadLine());
            Console.WriteLine(RaisedToPower(num, powerTo));
        }

        static double RaisedToPower(double number, int power)
        {
            double result = 0;
            result = Math.Pow(number, power);
            return result;
        }
    }
}
