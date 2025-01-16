using System;
using System.Linq;
using System.Collections.Generic;

namespace _1._Action_Print
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split();

            Action<string[]> print = (string[] names) =>
            {
                for (int i = 0; i < names.Length; i++)
                {
                    Console.WriteLine(names[i]);
                }
            };
            print(input);
        }
    }
}
