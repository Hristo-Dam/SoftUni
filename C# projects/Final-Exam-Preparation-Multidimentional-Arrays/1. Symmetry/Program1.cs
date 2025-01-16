using System;

namespace _1._Symmetry
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix1 = {
                {3, 2, 3 },
                {5, 0, 5 },
                {3, 2, 3 },
            };

            int[,] matrix2 = {
                {1, 2, 3, 7},
                {4, 5, 6, 8},
                {7, 8, 9, 0},
                {4, 4, 4, 4},
            };

            int[,] matrix3 = {
                {1, 2, 2, 1},
                {4, 5, 5, 4},
                {3, 4, 4, 3},
                {9, 8, 8, 9},
            };

            int[,] matrix4 = {
                {1, 2, 3, 7},
                {4, 5, 6, 8},
                {7, 8, 9, 0},
            };

            Console.WriteLine(CheckSymmetry(matrix1));
            Console.WriteLine(CheckSymmetry(matrix2));
            Console.WriteLine(CheckSymmetry(matrix3));
            Console.WriteLine(CheckSymmetry(matrix4));
        }

        static bool CheckSymmetry(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            if (rows != cols)
            {
                return false;
            }

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols / 2; col++)
                {
                    if (matrix[row, col] != matrix[row, cols - 1 - col])
                    {
                        return false;
                    }
                }
            }

            for (int col = 0; col < cols; col++)
            {
                for (int row = 0; row < rows / 2; row++)
                {
                    if (matrix[row, col] != matrix[rows - 1 - row, col])
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }

}
