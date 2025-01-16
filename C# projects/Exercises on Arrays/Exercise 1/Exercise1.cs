using System;
using System.Linq;
using System.Collections.Generic;

namespace Exercise_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[20];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = i * 5;
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
