using System;
using System.Linq;
using System.Collections.Generic;

namespace _3._Print_Even_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            Queue<int> queue = new Queue<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                queue.Enqueue(numbers[i]);
            }

            List<int> result = new List<int>();
            
            int count = queue.Count;

            for (int i = 0; i < count; i++)
            {
                if (queue.Peek() % 2 == 0)
                {
                    result.Add(queue.Dequeue());
                }
                else
                {
                    queue.Dequeue();
                }
            }

            Console.WriteLine(string.Join(", ", result));
        }
    }
}
