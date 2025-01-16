using System;
using System.Linq;
using System.Collections.Generic;

namespace _2._Remove_duplicates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, string> capitals = new SortedDictionary<string, string>();
            capitals["Bulgaria"] = "Sofia";
            capitals["England"] = "London";
            capitals["Scotland"] = "Glasgow";
            capitals["Wales"] = "London";

            RemoveDuplicates(capitals);

            foreach (KeyValuePair<string, string> pair in capitals)
            {
                Console.WriteLine($"{pair.Key}: {pair.Value}");
            }
        }

        static void RemoveDuplicates(SortedDictionary<string, string> dict)
        {
            SortedDictionary<string, string> result = new SortedDictionary<string, string>();

            foreach (KeyValuePair<string, string> pair in dict)
            {
                if (!result.ContainsValue(pair.Value))
                {
                    result.Add(pair.Key, pair.Value);
                }
            }

            dict.Clear();
            foreach (KeyValuePair<string, string> pair in result)
            {
                dict.Add(pair.Key, pair.Value);
            }
        }
    }
}
