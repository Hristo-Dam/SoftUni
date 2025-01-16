using System;
using System.Linq;
using System.Collections.Generic;

namespace _1._Count_Real_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            list.Sort();

            Dictionary<int, int> numbers = new Dictionary<int, int>();

            foreach (int i in list)
            {
                if (numbers.ContainsKey(i))
                {
                    numbers[i]++;
                }
                else
                {
                    numbers.Add(i, 1);
                }
            }

            foreach (KeyValuePair<int, int> pair in numbers)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }
    }
}
