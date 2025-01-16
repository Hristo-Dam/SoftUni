using System;
using System.Linq;
using System.Collections.Generic;

namespace _9._Record_Unique_Names
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            List<string> names = new List<string>();

            for (int i = 0; i < number; i++)
            {
                names.Add(Console.ReadLine());
            }

            HashSet<string> uniqueNames = new HashSet<string>();

            foreach (string name in names)
            {
                uniqueNames.Add(name);
            }
            
            foreach (string name in uniqueNames)
            {
                Console.WriteLine(name);
            }

        }
    }
}
