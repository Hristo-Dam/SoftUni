using System;
using System.Linq;
using System.Collections.Generic;

namespace _2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .Where(x => x > 0)
                .ToList();

            if (list.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                for (int i = list.Count - 1; i >= 0; i--)
                {
                    Console.WriteLine(String.Join(" ", list[i]));
                }
            }

        }
    }
}
