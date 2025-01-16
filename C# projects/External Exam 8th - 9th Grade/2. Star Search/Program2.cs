using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace _2._Star_Search
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 5;

            string[,] matrix = new string[x, x];

            for (int i = 0; i < x; i++)
            {
                string[] rowInput = Console.ReadLine().Split(' ');

                for (int k = 0; k < x; k++)
                {
                    matrix[i, k] = rowInput[k];
                }
            }

            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] command = input.Split(' ');
                int coordinateOne = int.Parse(command[0]);
                int coordinateTwo = int.Parse(command[1]);

                if (coordinateOne >= 0 && coordinateTwo >= 0 && coordinateOne <= 4 && coordinateTwo <= 4)
                {
                    StringBuilder sb = new StringBuilder();
                    sb.Append(matrix[coordinateOne, coordinateTwo]);

                    int numOne = int.Parse(sb[0].ToString());
                    int numTwo = int.Parse(sb[1].ToString());

                    if (numOne + numTwo == 4 || numOne + numTwo == 10)
                    {
                        matrix[coordinateOne, coordinateTwo] = "0";

                        for (int i = 0; i < x; i++)
                        {
                            for (int k = 0; k < x; k++)
                            {
                                Console.Write(matrix[i, k] + " ");
                            }
                            Console.WriteLine();
                        }

                        Console.WriteLine("A star has been found!");
                    }
                }
                else
                {
                    Console.WriteLine("The input is invalid!");
                }

                input = Console.ReadLine();
            }
        }
    }
}
