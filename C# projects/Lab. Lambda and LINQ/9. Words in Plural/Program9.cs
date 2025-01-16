using System;
using System.Linq;
using System.Collections.Generic;

namespace _9._Words_in_Plural
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split()
                .Skip(1)
                .Where(x => x.Length < 5)
                .Where(x => !string.IsNullOrEmpty(x))
                .OrderBy(x => x.Length)
                .ThenBy(x => x)
                .ToArray();

            for (int i = 0; i < words.Length; i++)
            {
                Console.WriteLine(words[i] + "s");
            }
        }
    }
}
