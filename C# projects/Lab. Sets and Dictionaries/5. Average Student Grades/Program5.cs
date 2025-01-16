using System;
using System.Linq;
using System.Collections.Generic;

namespace _5._Average_Student_Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> grades = new Dictionary<string, List<double>>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split();
                string name = input[0];
                double grade = double .Parse(input[1]);

                if (!grades.ContainsKey(name))
                {
                    grades[name] = new List<double>();
                }
                grades[name].Add(grade);
            }

            foreach (string name in grades.Keys)
            {
                Console.Write($"{name} -> {string.Join(" ", grades[name])}");
                Console.WriteLine($" (avg: {grades[name].Average():F2})");
            }
        }
    }
}
