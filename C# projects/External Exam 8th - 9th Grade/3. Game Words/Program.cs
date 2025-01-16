using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Text;

namespace _3._Game_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> wordsResult = new List<string>();
            List<string> pointsResult = new List<string>();

            Dictionary<string, int> wordsAndPoints = new Dictionary<string, int>();

            string input = Console.ReadLine();
            
            while (input != "End")
            {
                string wordRegex = @"&[a-z]{4}e";
                MatchCollection words = Regex.Matches(input, wordRegex);

                string pointsRegex = @"\^\d\d\d";
                MatchCollection points = Regex.Matches(input, pointsRegex);

                if (words.Count > 0 && points.Count > 0)
                {
                    StringBuilder sbWords = new StringBuilder();
                    sbWords.Append(words[0]);
                    sbWords.Remove(0, 1);

                    StringBuilder sbPoints = new StringBuilder();
                    sbPoints.Append(points[0]);
                    sbPoints.Remove(0, 1);

                    if (wordsAndPoints.ContainsKey(sbWords.ToString()))
                    {
                        int newValue = wordsAndPoints[sbWords.ToString()] + int.Parse(sbPoints.ToString());
                        wordsAndPoints[sbWords.ToString()] = newValue;
                    }
                    else
                    {
                        wordsAndPoints.Add(sbWords.ToString(), int.Parse(sbPoints.ToString()));
                    }
                }
                else
                {
                    Console.WriteLine("No word found!");
                }

                input = Console.ReadLine();
            }

            foreach (KeyValuePair<string, int> pair in wordsAndPoints)
            {
                Console.WriteLine($"Word: {pair.Key}. Points: {pair.Value}.");
            }
        }
    }
}
