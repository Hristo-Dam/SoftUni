using System;
using System.Linq;
using System.Collections.Generic;

namespace _3._Swap_keys_with_values
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> keyValuePairs = new Dictionary<string, string>();
            keyValuePairs.Add("Sofia", "Bulgaria");
            Console.WriteLine(string.Join(", ", swapKeyValue(keyValuePairs)));
        }

        static Dictionary<string, string> swapKeyValue (Dictionary<string, string> input)
        {
            Dictionary<string, string> result = new Dictionary<string, string>();

            foreach (KeyValuePair<string, string> pair in input)
            {
                result.Add(pair.Value, pair.Key);
            }

            return result;
        }
    }
}
