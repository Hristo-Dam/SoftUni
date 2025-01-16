using System;
using System.Linq;
using System.Collections.Generic;

namespace _1._Sort_Even_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Func<int, int> TenFold = n => n * 10;

            numbers = numbers.Select(TenFold).ToArray();
            //numbers = numbers.Where(x => x% 2 == 0).ToArray();

            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}
