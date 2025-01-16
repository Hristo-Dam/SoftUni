using System;
using System.Linq;
using System.Collections.Generic;

namespace _2._Odd_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            static bool IsOdd(int x) => x % 2 != 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"{numbers[i]} is odd - " + IsOdd(numbers[i]));
            }
        }
    }
}
