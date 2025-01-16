using System;
using System.Linq;
using System.Collections.Generic;

namespace _1._Basic_Stack_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < input[0]; i++)
            {
                stack.Push(numbers[i]);
            }

            for (int i = 0; i < input[1]; i++)
            {
                stack.Pop();
            }

            if (stack.Count != 0)
            {
                if (stack.Contains(input[2]))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine(stack.Min());
                }
            }
            else
            {
                Console.WriteLine("0");
            }
        }
    }
}
