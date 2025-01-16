using System;
using System.Linq;
using System.Collections.Generic;

namespace _5._Word_Filter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split()
                .Where(w => w.Length % 2 == 0)
                .ToArray();

            for (int i = 0; i < words.Length; i++)
            {
                Console.WriteLine(words[i]);
            }
        }
    }
}
