using System;
using System.Linq;
using System.Collections.Generic;

namespace _1._Average_score
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> data = new Dictionary<string, List<double>>();
            data["Hristo"] = new List<double>() { 6, 5, 6, 3, 5, 5, 6};
            data["Koko"] = new List<double>() { 6, 4, 5, 5, 6 };
            Console.WriteLine(string.Join(", ", FinalScores(data)));
        }

        static Dictionary<string, double> FinalScores (Dictionary<string, List<double>> input)
        {
            Dictionary<string , double> scores = new Dictionary<string , double>();

            foreach (KeyValuePair<string, List<double>> pair in input)
            {
                string name = pair.Key;
                List<double> values = pair.Value;
                double average = values.Average();
                scores[name] = Math.Round(average, 2);
            }
            return scores;
        }
    }
}
