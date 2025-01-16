using System;

namespace _3._Matrix_of_Integers
{
    internal class Program
    {
        static void CreateQuareMatrix(int numberToSquare)
        {
            for (int i = 0; i < numberToSquare; i++)
            {
                for (int k = 0; k < numberToSquare; k++)
                {
                    Console.Write(numberToSquare + " ");  
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            int numberToSquare = int.Parse(Console.ReadLine());
            CreateQuareMatrix(numberToSquare);
        }
    }
}
