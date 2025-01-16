using System;
using System.Linq;
using System.Collections.Generic;

namespace _2._Value_Seeker_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> firstSet = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> secondSet = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int totalSum = 0;

            while (firstSet.Count != 0 && secondSet.Count != 0)
            {
                int lastPositionOne = firstSet.Count - 1;
                int lastPosition2 = secondSet.Count - 1;
                int currentSum = firstSet[0] + secondSet[lastPosition2];

                if (currentSum % 2 == 0)
                {
                    totalSum += (firstSet[0] + secondSet[lastPosition2]);
                    firstSet.RemoveAt(0);
                    secondSet.RemoveAt(lastPosition2);
                }
                else
                {
                    firstSet.Add(secondSet[lastPosition2]);
                    secondSet.RemoveAt(lastPosition2);
                }
            }

            if (firstSet.Count == 0)
            {
                Console.WriteLine("First set is empty");
            }
            else
            {
                Console.WriteLine("Second set is empty");
            }

            if (totalSum >= 100)
            {
                Console.WriteLine($"Your bets were amazing! Value: {totalSum}");
            }
            else
            {
                Console.WriteLine($"Your bets were poor. Value: {totalSum}");
            }
        }
    }
}
