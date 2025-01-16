using System;
using System.Linq;
using System.Collections.Generic;

namespace _1._Same_Weekday
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] firstInput = Console.ReadLine()
                .Split("-")
                .Select(int.Parse)
                .ToArray();

            int[] secondInput = Console.ReadLine()
                .Split("-")
                .Select(int.Parse)
                .ToArray();

            int firstDay = firstInput[0];
            int firstMounth = firstInput[1];
            int firstYear = firstInput[2];


            int secondDay = secondInput[0];
            int secondMounth = secondInput[1];
            int secondYear = secondInput[2];

            DateTime firstDate = new DateTime(firstYear, firstMounth, firstDay);

            DateTime secondDate = new DateTime(secondYear, secondMounth, secondDay);

            if (firstDate.DayOfWeek == secondDate.DayOfWeek)
            {
                Console.WriteLine("Yes");
                Console.WriteLine(firstDate.DayOfWeek);
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
