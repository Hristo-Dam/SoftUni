using System;

namespace _4._Printing_Triangle
{
    internal class Program
    {
        // 1
        // 1 2
        // 1 2 3                        3
        static void PrintTopPart(int depth)
        {
            for (int i = 1; i <= depth; i++)
            {
                // Print single line
                for (int k = 1; k <= i; k++)
                {
                    Console.Write(k + " ");
                }
                Console.WriteLine();
            }
        }

        // 1 2
        // 1                              2
        static void PrintBottomPart(int depth)
        {
            for (int i = depth; i >= 1; i--)
            {
                // Print single line
                for (int k = 1; k <= i; k++)
                {
                    Console.Write(k + " ");
                }
                Console.WriteLine();
            }
        }

        static void Main()
        {
            // 1. Input
            int number = int.Parse(Console.ReadLine());

            // 2. Output/Solution
            // a) Print top part
            PrintTopPart(number);

            // b) Print bottom part
            PrintBottomPart(number - 1);
        }
    }
}
