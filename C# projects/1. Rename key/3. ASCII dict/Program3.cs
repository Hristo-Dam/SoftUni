using System;
using System.Linq;
using System.Collections.Generic;

namespace _3._ASCII_dict
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] chars = input.ToCharArray();

            Dictionary<char, int> dict = new Dictionary<char, int>();

            foreach (char c in chars)
            {
                dict[c] = c;
            }

            foreach (KeyValuePair<char, int> output in dict)
            {
                Console.WriteLine(output.Key + ": " + output.Value);
            }
        }
    }
}
