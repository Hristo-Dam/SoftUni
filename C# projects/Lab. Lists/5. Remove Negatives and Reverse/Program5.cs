using System;
using System.Linq;
using System.Collections.Generic;

namespace _5._Remove_Negatives_and_Reverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            numbers.RemoveAll(x => x < 0);

            if (numbers.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                for (int i = numbers.Count; i > 0; i--)
                {
                    Console.Write(numbers[i - 1] + " ");
                }
            }
        }
    }
}
