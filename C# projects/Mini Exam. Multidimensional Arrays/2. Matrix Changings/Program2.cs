using System;
using System.Linq;
using System.Collections.Generic;

namespace _2._Matrix_Changings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] matrixSize = new int[2];
            int rows = matrixSize[0];
            int cols = matrixSize[1];

            int[,] matrix = new int[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                int[] nums = Console.ReadLine()
                    .Split(' ')
                    .Select(int.Parse)
                    .ToArray();
                for (int k = 0; k < cols; k++)
                {
                    matrix[i, k] = nums[k];
                }
            }

            string commandInput = Console.ReadLine();

            while (commandInput != "END")
            {
                string[] inputArray = commandInput.Split(' ');
                string[] commands = new string[inputArray.Length - 4];
                commands[0] = inputArray[0];
                commands[1] = inputArray[2];
                commands[2] = inputArray[4];
                commands[3] = inputArray[6];
                commands[4] = inputArray[8];

                if (commands[0] != "exchange" )
                {
                    Console.WriteLine("The input is invalid!");
                }
                else
                {
                    int first = int.Parse(commands[1]);
                    int second = int.Parse(commands[2]);
                    int third = int.Parse(commands[3]);
                    int fourth = int.Parse(commands[4]);

                    int save1 = first;
                    int save2 = second;

                    matrix[first, second] = matrix[third, fourth];
                    matrix[third, fourth] = matrix[save1, save2];
                }
                
                commandInput = Console.ReadLine();
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int k = 0; k < matrix.GetLength(1); k++)
                {
                    Console.Write(matrix[i, k] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
