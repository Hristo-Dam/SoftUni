using System;
using System.Linq;
using System.Collections.Generic;

namespace _7._Five_Odd_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(',')
                .Select(int.Parse)
                .Where(x => x % 2 != 0)
                .OrderByDescending(n => n)
                .ToArray();

            if (numbers.Length < 5)
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
            else
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.Write(numbers[i] + " ");
                }
            }
            
        }
    }
}
