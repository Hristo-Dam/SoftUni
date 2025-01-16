using System;
using System.Linq;
using System.Collections.Generic;

namespace _5._Print_Even_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            Queue<int> queue = new Queue<int>(numbers);

            int currentNum = 0;

            List<int> evenNumbers = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                currentNum = queue.Peek();
                
                if (currentNum % 2 == 0)
                {
                    evenNumbers.Add(currentNum);
                    queue.Dequeue();
                }
                else if (currentNum % 2 == 1)
                {
                    queue.Dequeue();
                }
            }

            Console.WriteLine(String.Join(", ", evenNumbers));
        }
    }
}
