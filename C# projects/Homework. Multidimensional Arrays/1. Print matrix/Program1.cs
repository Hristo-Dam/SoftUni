using System;
using System.Linq;

namespace _1._Print_matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix1 =
            {
                {1, 2, 3},
                {4, 5, 6},
                {7, 8, 9}
            };

            PrintMatrix(matrix1);

            int[,] matrix2 =
            {
                {11, 12, 13},
                {14, 15, 16},
                {17, 18, 19}
            };

            PrintMatrix(matrix2);

            int[,] matrix3 =
            {
                {153, 526, 24},
                {147, 185, 216},
                {5177, 128, 199}
            };

            PrintMatrix(matrix3);
        }

        static void PrintMatrix(int [,] matrix)
        {
            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    Console.Write($"{matrix[rows, cols]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
