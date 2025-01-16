using System;
using System.Linq;
using System.Collections.Generic;


namespace _4._Largest_3_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int[] sorted = numbers
                .OrderByDescending(n => n)
                .ToArray();

            if (sorted.Length < 3)
            {
                for (int i = 0; i < sorted.Length; i++)
                {
                    Console.Write(sorted[i] + " ");
                }
            }
            else if (sorted.Length > 2)
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.Write(sorted[i] + " ");
                }
            }

        }
    }
}   
