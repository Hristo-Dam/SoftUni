using System;
using System.Linq;
using System.Collections.Generic;

namespace _1._Difference_of_Diagonals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int matrixSize = int.Parse(Console.ReadLine());

            int[,] matrix = new int[matrixSize, matrixSize];
            for (int i = 0; i < matrixSize; i++)
            {
                int[] nums = Console.ReadLine()
                    .Split(' ')
                    .Select(int.Parse)
                    .ToArray();
                for (int k = 0; k < matrixSize; k++)
                {
                    matrix[i,k] = nums[k];
                }
            }

            int sum1 = 0;

            for (int i = 0; i < matrixSize; i++)
            {
                sum1 += matrix[i, i];
            }

            int sum2 = 0;

            for (int k = 0; k < matrixSize; k++)
            {
                sum2 += matrix[k, matrixSize - 1 - k];
            }

            Console.WriteLine(Math.Abs(sum1 - sum2));
        }
    }
}
