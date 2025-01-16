using System;
using System.Linq;
using System.Collections.Generic;

namespace _2._Stack_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Stack<int> stack = new Stack<int>(array);

            string commandInput = Console.ReadLine().ToLower();

            while (commandInput != "end")
            {
                string[] commands = commandInput.Split();

                if (commands[0] == "add")
                {
                    int first = int.Parse(commands[1]);
                    int second = int.Parse(commands[2]);

                    stack.Push(first);
                    stack.Push(second);
                }
                else if (commands[0] == "remove")
                {
                    int count = int.Parse(commands[1]);

                    if (count < stack.Count)
                    {
                        for (int i = 0; i < count; i++)
                        {
                            stack.Pop();
                        }
                    }
                }

                commandInput = Console.ReadLine();
            }

            int result = stack.Sum();
            Console.WriteLine($"Sum: {result}");
        }
    }
}
