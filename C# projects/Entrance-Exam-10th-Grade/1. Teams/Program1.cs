using System;
using System.Linq;
using System.Collections.Generic;

namespace _1._Teams
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int avalablePeople = int.Parse(Console.ReadLine());
            List<int> teams = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            
            for (int i = 0; i < teams.Count; i++)
            {
                for (int k = 0; k < 4; k++)
                {
                    if (teams[i] < 4 && avalablePeople > 0)
                    {
                        teams[i]++;
                        avalablePeople--;
                    }
                }
            }

            if (avalablePeople == 0 && teams[teams.Count - 1] < 4)
            {
                Console.WriteLine("There are free positions in the teams!");
            }
            else if (avalablePeople > 0 && teams[teams.Count - 1] == 4)
            {
                Console.WriteLine($"There isn't enough free positions! {avalablePeople} people are available!");
            }

            Console.WriteLine(String.Join(" ", teams));
        }
    }
}
