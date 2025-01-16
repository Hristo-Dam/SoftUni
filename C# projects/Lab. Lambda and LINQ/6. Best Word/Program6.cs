using System;
using System.Linq;
using System.Collections.Generic;

namespace _6._Best_Word
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split()
                .Where(x => x.EndsWith("est"))
                .Where(x => x.StartsWith("b") || x.StartsWith("B"))
                .Select(x => x.ToUpper())
                .ToArray();

            if (words.Length > 0)
            {
                Console.WriteLine($"First best word: {words[0]}");
                Console.WriteLine($"Last best word: {words[words.Length - 1]}");
                return;
            }
            else
            {
                return;
            }
        }
    }
}
