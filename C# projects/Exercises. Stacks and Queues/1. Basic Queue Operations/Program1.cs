using System;
using System.Linq;
using System.Collections.Generic;

namespace _1._Basic_Queue_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();

            int numberOfElements = list[0];
            int numbersToRemove = list[1];
            int numberToSerch = list[2];

            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            Queue<int> queue = new Queue<int>(numbers);

            for (int i = 0; i < numbersToRemove; i++)
            {
                queue.Dequeue();
            }

            for (int k = 0; k < queue.Count; k++)
            {
                if (queue.Peek() == numberToSerch)
                {
                    Console.WriteLine("true");
                    break;
                }
                else if (queue.Peek() != numberToSerch)
                {
                    queue.Enqueue(queue.Dequeue());
                }
            }

            if (queue.Count > 0)
            {
                Console.WriteLine(queue.Min());
            }
            else
            {
                Console.WriteLine("0");
            }
        }
    }
}
