using System;
using System.Linq;
using System.Collections.Generic;

namespace _1._Count_Real_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> input = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToList();

            SortedDictionary<double, int> counts = new SortedDictionary<double, int>();

            foreach (int number in input)
            {
                if (counts.ContainsKey(number))
                {
                    counts[number]++;
                }
                else
                {
                    counts.Add(number, 1);
                }
            }

            foreach (KeyValuePair<double, int> number in counts)
            {
                Console.WriteLine($"{number.Key} -> {number.Value}");
            }
        }
    }
}
