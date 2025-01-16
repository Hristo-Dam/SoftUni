using System;
using System.Linq;
using System.Collections.Generic;

namespace ReversedVectors
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] nums = new int[n];
            List<string> list = new List<string>();

            CreateVector(nums, 0, list);
        }
        private static void CreateVector(int[] nums, int index, List<string> list)
        {
            list = new List<string>();

            if (index > nums.Length - 1)
            {
                list.Add(string.Join("", nums));
                foreach (string s in list)
                {
                    for(int i = s.Length - 1; i > -1; i--)
                    {
                        Console.Write(s[i]);
                    }
                    Console.WriteLine();

                }
                return;
            }

            for (int i = 0; i <= 1; i++)
            {
                nums[index] = i;
                CreateVector(nums, index + 1, list);
            }
        }
    }
}
