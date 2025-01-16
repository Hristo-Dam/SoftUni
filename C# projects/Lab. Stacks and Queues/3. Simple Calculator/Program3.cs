using System;
using System.Linq;
using System.Collections.Generic;

namespace _3._Simple_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine()
                .Split()
                .Reverse()
                .ToList();

            Stack<string> stack = new Stack<string>(list);
            
            int sum = 0;
            int firstNum = 0;
            int secondNum = 0;
            string operation = "";

            while (stack.Count > 1)
            {
                firstNum = int.Parse(stack.Pop());

                operation = stack.Pop();

                secondNum = int.Parse(stack.Pop());

                if (operation == "+")
                {
                    sum = firstNum + secondNum;
                }
                else if (operation == "-")
                {
                    sum = firstNum - secondNum;
                }

                stack.Push("" + sum);
            }
            Console.WriteLine(sum);
        }
    }
}
