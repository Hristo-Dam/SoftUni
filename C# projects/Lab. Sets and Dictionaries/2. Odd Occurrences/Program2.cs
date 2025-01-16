using System;
using System.Linq;
using System.Collections.Generic;

namespace _2._Odd_Occurrences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
                .Split()
                .ToList();

            Dictionary<string, int> counts = new Dictionary<string, int>();

            foreach (string word in input)
            {
                string lowerCase = word.ToLower();

                if (counts.ContainsKey(lowerCase))
                {
                    counts[lowerCase]++;
                }
                else
                {
                    counts.Add(lowerCase, 1);
                }
            }

            foreach (KeyValuePair<string, int> number in counts)
            {
                if (number.Value % 2 == 1)
                {
                    Console.Write($"{number.Key} ");
                }
            }
        }
    }
}
