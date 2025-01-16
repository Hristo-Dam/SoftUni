using System;
using System.Linq;
using System.Collections.Generic;

namespace _3._Merging_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list1 = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();

            List<int> list2 = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();

            List<int> result = new List<int>();

            int shorterCount = 0;

            List<int> longerList;

            if(list1.Count > list2.Count)
            {
                longerList = list1;
                shorterCount = list2.Count;
            }
            else
            {
                longerList = list2;
                shorterCount = list1.Count;
            }

            for (int i = 0; i < shorterCount; i++)
            {
                result.Add(list1[i]);
                result.Add(list2[i]);
            }

            for (int i = shorterCount; i < longerList.Count; i++)
            {
                result.Add(longerList[i]);
            }

            Console.WriteLine(String.Join(" ", result));
            
        }
    }
}
