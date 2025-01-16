using System;

namespace _3._Characters_in_Range
{
    internal class Program
    {
        static void PrintASCIIBetween(int lowerLimit, int upperLimit)
        {
            for (int i = lowerLimit + 1; i < upperLimit; i++)
            {
                char symbol = (char)i;
                Console.Write(symbol + " ");
            }
        }
        static void Main(string[] args)
        {
            char symbolA = char.Parse(Console.ReadLine());
            char symbolB = char.Parse(Console.ReadLine());
            int lowerLimit = Math.Min(symbolA, symbolB);
            int upperLimit = Math.Max(symbolA, symbolB);
            PrintASCIIBetween(lowerLimit, upperLimit);
        }
    }
}
