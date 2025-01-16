using System;
using System.Linq;
using System.Collections.Generic;

namespace _8._Even_Transformations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(',')
                .Select(int.Parse)
                .Where(x => x % 2 == 0)
                .OrderBy(n => n)
                .ToArray();

            for (int k = 0; k < numbers.Length; k++)
            {
                numbers[k]++;
            }

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
