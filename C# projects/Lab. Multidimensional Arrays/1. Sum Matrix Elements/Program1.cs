using System;
using System.Linq;
using System.Collections.Generic;

namespace _1._Sum_Matrix_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numberOfRowsAndCols = Console.ReadLine()
                .Split(", ")
                .Select(int.Parse)
                .ToArray();

            int rows = numberOfRowsAndCols[0];
            int cols = numberOfRowsAndCols[1];

            int[,] matrix = new int[rows, cols];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] nums = Console.ReadLine()
                    .Split(", ")
                    .Select(int.Parse)
                    .ToArray();

                for (int k = 0; k < matrix.GetLength(1); k++)
                {
                    matrix[i, k] = nums[k];
                }
                Console.WriteLine();
            }

            int sum = 0;

            foreach (int element in matrix)
            {
                sum += element;
            }

            Console.WriteLine(rows);
            Console.WriteLine(cols);
            Console.WriteLine(sum);
        }
    }
}
