using System;
using System.Linq;
using System.Collections.Generic;

namespace _2._Dictionary_to_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> keyValuePairs = new Dictionary<string, int>();
            keyValuePairs.Add("apple", 3);
            keyValuePairs.Add("kiwi", 5);
            keyValuePairs.Add("orange", 7);

            Console.WriteLine(string.Join(", ", buildArray(keyValuePairs)));
        }

        static List<string> buildArray (Dictionary<string, int> input)
        {
            List<string> list = new List<string>();
            foreach(KeyValuePair<string, int> pair in input)
            {
                for (int i = 0; i < pair.Value; i++)
                {
                    list.Add(pair.Key);
                }
            }

            return list;
        }
    }
}
