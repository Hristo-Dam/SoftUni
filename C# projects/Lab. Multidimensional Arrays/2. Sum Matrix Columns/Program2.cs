using System;
using System.Linq;

namespace _2._Sum_Matrix_Columns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numberOfRowsAndCols = Console.ReadLine()
                .Split(", ")
                .Select(int.Parse)
                .ToArray();

            int r = numberOfRowsAndCols[0];
            int c = numberOfRowsAndCols[1];

            int[,] matrix = new int[r, c];

            int sum = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] nums = Console.ReadLine()
                    .Split(" ")
                    .Select(int.Parse)
                    .ToArray();

                for (int k = 0; k < matrix.GetLength(1); k++)
                {
                    matrix[i, k] = nums[k];
                }
                Console.WriteLine();

            }

            for (int cols = 0; cols < matrix.GetLength(1); cols++)
            {
                int currentSum = 0;

                for (int rows = 0; rows < matrix.GetLength(0); rows++)
                {
                    currentSum += matrix[rows, cols];
                }
                Console.WriteLine(currentSum);
            }
        }
    }
}
