using System;
using System.Linq;
using System.Collections.Generic;

namespace _2._Simple_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine()
                .Split()
                .ToList();

            list.Reverse();

            Stack<string> stack = new Stack<string>(list);

            int result = int.Parse(stack.Pop());

            while (stack.Count > 0)
            {
                if (stack.Pop() == "-")
                {
                    result -= int.Parse(stack.Pop());
                }
                else
                {
                    result += int.Parse(stack.Pop());
                }
            }

            Console.WriteLine(result);
        }
    }
}
