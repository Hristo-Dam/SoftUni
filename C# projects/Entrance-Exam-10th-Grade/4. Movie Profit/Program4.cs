using System;
using System.Linq;
using System.Collections.Generic;

namespace _4._Movie_Profit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(":").ToArray();
            Dictionary<string, double> movieProfits = new Dictionary<string, double>();
            List<string> canceled = new List<string>();

            while (input[0] != "End")
            {
                if (input[0] == "Canceled")
                {
                    canceled.Add(input[1]);
                }
                else
                {
                    string film = input[0];
                    double profit = double.Parse(input[1]);
                    if (!canceled.Contains(film))
                    {
                        if (movieProfits.ContainsKey(film))
                        {
                            movieProfits[film] += profit;
                        }
                        else
                        {
                            movieProfits.Add(film, profit);
                        }
                    }
                }
                input = Console.ReadLine().Split(":").ToArray();
            }

            movieProfits = movieProfits.OrderByDescending(kvp => kvp.Value).ToDictionary(x => x.Key, x => x.Value);

            foreach (KeyValuePair<string, double> pair in movieProfits)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value:F2}");
            }
        }
    }
}
