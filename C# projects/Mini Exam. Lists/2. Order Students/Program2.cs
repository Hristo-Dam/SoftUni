using System;
using System.Linq;
using System.Collections.Generic;

namespace _2._Order_Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> groups = Console.ReadLine()
                .Split("|")
                .ToList();

            List<string> newGroups = new List<string>();

            for (int i = groups.Count - 1; i > -1; i--)
            {
                newGroups.Add(groups[i]);
            }
            
            string newGroupsString = String.Join("", newGroups);

            List<string> newGoupsWithoutSpaces;

            for (int k = 0; k < newGroups.Count; k++)
            {
                newGroups[k].Split("", StringSplitOptions.RemoveEmptyEntries);
            }

            /*(' ', StringSplitOptions.RemoveEmptyEntries);*/

            //List<string> newGoupsWithoutSpaces = newGroupsString
            //    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
            //    .ToList;

            Console.WriteLine(string.Join(" ", newGroups));
        }
    }
}
