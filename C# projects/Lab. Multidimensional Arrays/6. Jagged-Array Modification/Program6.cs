using System;
using System.Linq;

namespace _6._Jagged_Array_Modification
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int[][] jagged = new int[size][];

            for (int row = 0; row < size; row++)
            {
                jagged[row] = new int[size];
            }

        }
    }
}
