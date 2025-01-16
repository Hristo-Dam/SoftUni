using System;
using System.Linq;
using System.Collections.Generic;

namespace _2._Repeat_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> result = new List<string>();

            List<string> list = Console.ReadLine()
                .Split()
                .ToList();

            for (int i = 0; i < list.Count; i++)
            {
                for (int k = 0; k < list[i].Length; k++)
                {
                    result.Add(list[i]);
                }
            }

            Console.WriteLine(string.Join("", result));
        }
    }
}
