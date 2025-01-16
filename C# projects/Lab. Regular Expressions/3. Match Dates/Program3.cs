using System;
using System.Text.RegularExpressions;

namespace _3._Match_Dates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string regex = @"(\d{2})([\/.-])([A-Z][a-z]{2})\2(\d{4})";

            MatchCollection resultsList = Regex.Matches(text, regex);

            foreach (Match match in resultsList)
            {
                Console.WriteLine($"Day: {match.Groups[1]}, Month: {match.Groups[3]}, Year: {match.Groups[4]}");
            }
        }
    }
}
