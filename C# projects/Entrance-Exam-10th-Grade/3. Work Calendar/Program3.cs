using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace _3._Work_Calendar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder input = new StringBuilder();
            input.Append(Console.ReadLine());

            string[] commands = Console.ReadLine()
                .Split()
                .ToArray();

            List<string> commandPartTwo = new List<string>();   

            while (commands[0] != "End")
            {
                if (commands[0] == "Add")
                {
                    commandPartTwo = commands[1]
                        .Split(":")
                        .ToList();

                    int index = int.Parse(commandPartTwo[1]);

                    if (input.Length < index)
                    {
                        input.Insert(index, commandPartTwo[2]);
                    }

                    Console.WriteLine(input.ToString());
                }
                else if (commands[0] == "Remove")
                {
                    commandPartTwo = commands[1]
                        .Split(":")
                        .ToList();

                    int startIndex = int.Parse(commandPartTwo[1]);
                    int endIndex = int.Parse(commandPartTwo[2]);
                    int lenghtToRemove = endIndex - startIndex;

                    if (input.Length >= endIndex)
                    {
                        input.Remove(startIndex, lenghtToRemove);
                    }

                    Console.WriteLine(input.ToString());
                }
                else if (commands[0] == "Switch:")
                {
                    commandPartTwo = commands[1]
                        .Split(":")
                        .ToList();

                    string oldString = commandPartTwo[1];
                    string newString = commandPartTwo[2];

                    input.Replace(oldString, newString);

                    Console.WriteLine(input.ToString());
                }

                commands = Console.ReadLine()
                    .Split()
                    .ToArray();
            }

            Console.WriteLine($"Your work calendar for the day is ready: {input.ToString()}");//school, meeting with John, family diner
        }
    }
}
