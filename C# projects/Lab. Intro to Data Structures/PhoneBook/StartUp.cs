using Wintellect.PowerCollections;
using System;
using System.Linq;
using System.Collections.Generic;

namespace PhoneBook
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            bool Duplicates = true;
            MultiDictionary<string, string> phones = new MultiDictionary<string, string>(Duplicates);

            for (int i = 0; i < num; i++) 
            {
                string[] input = Console.ReadLine().Split(" - ").ToArray();
                phones.Add(input[0], input[1]);
            }

            foreach (var pair in phones.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{pair.Key}: {pair.Value}");
            }
        }
    }
}
