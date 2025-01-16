using System;
using System.Linq;
using System.Collections.Generic;

namespace _2._Custom_Min_Function
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            Func<List<int>, int> findNum;
            findNum = minNum;
            Console.WriteLine(findNum(list));
        }

        static int minNum (List<int> list)
        {
            int result = list[0];
            foreach (int item in list)
            {
                if (item < result)
                {
                    result = item;
                }
            }

            return result;
        }
    }
}
