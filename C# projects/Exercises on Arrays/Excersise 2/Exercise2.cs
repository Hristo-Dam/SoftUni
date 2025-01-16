using System;
using System.Linq;
using System.Collections.Generic;

namespace Exercise_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] firstArray = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int[] secondArray = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            if (firstArray.Length != secondArray.Length)
            {
                Console.WriteLine("Array are NOT the same!");
            }
            else if (firstArray.Length == secondArray.Length)
            {
                for (int i = 0; i < firstArray.Length; i++)
                {
                    if (firstArray[i] != secondArray[i])
                    {
                        Console.WriteLine("Arrays are NOT the same!");
                        return;
                    }
                }
                Console.WriteLine("Array ARE the same!");
            }

        }
    }
}
