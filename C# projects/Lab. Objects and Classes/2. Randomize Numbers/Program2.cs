using System;
using System.Linq;
using System.Collections.Generic;

namespace _2._Randomize_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> rndNumbers = new List<int>(); 

            Random rnd = new Random();

            for (int i = 0; i < numbers.Count; i++)
            {
                int posToSwap = rnd.Next(0, numbers.Count);

                if (!rndNumbers.Contains(posToSwap))
                {
                    Console.WriteLine(numbers[posToSwap]);
                }
                else
                {
                    posToSwap = rnd.Next(0, numbers.Count);
                }

                rndNumbers.Add(posToSwap);
            }
        }
    }
}
