using System;
using System.Linq;
using System.Collections.Generic;

namespace _2._Odd_Occurrences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine()
                .Split()
                .Select(x => x.ToLower())
                .ToList();

            Dictionary<string, int> dic = new Dictionary<string, int>();

            foreach (string s in list)
            {
                if (dic.ContainsKey(s))
                {
                    dic[s]++;
                }
                else
                {
                    dic.Add(s, 1);
                }
            }

            foreach (KeyValuePair<string, int> pair in dic)
            {
                if (pair.Value % 2 == 0)
                {
                    dic.Remove(pair.Key);
                }
            }

            foreach (KeyValuePair<string, int> pair in dic)
            {
                Console.Write(pair.Key + " ");
            }
        }
    }
}
