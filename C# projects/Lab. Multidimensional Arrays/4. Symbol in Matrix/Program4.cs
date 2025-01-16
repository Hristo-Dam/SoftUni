using System;
using System.Linq;

namespace _4._Symbol_in_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int rows = size;
            int cols = size;

            int[,] matrix = new int[rows, cols];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                string input = Console.ReadLine();

                for (int k = 0; k < matrix.GetLength(1); k++)
                {
                    matrix[i, k] = input[k];
                }
            }

            char character = char.Parse(Console.ReadLine());

            for (int q = 0; q < rows; q++)
            {
                for (int h = 0; h < cols; h++)
                {
                    if (matrix[q, h] == character)
                    {
                        Console.Write($"({q}, {h})");
                        return;
                    }
                }
            }

            Console.WriteLine($"{character} does not occur in the matrix");


        }
    }
}
