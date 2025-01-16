using System;
using System.Linq;
using System.Collections.Generic;

namespace _1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inout = int.Parse(Console.ReadLine());

            List<string> list = new List<string>();

            for (int i = 0; i < inout; i++)
            {
                string word = Console.ReadLine();
                list.Add(word);
            }

            list.Sort();
            
            for (int k = 0; k < list.Count; k++)
            {
                Console.WriteLine((k + 1) + ". " + list[k]);
            }
        }
    }
}
