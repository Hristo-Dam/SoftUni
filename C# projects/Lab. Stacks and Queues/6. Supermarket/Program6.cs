using System;
using System.Linq;
using System.Collections.Generic;

namespace _6._Supermarket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> queue = new Queue<string>();

            while (true)
            {
                string currenCommand = Console.ReadLine();

                if (currenCommand == "End")
                {
                    Console.WriteLine($"{queue.Count} people remaining.");
                    return;
                }
                else if (currenCommand == "Paid")
                {
                    foreach (string name in queue.ToList())
                    {
                        Console.WriteLine(name);
                    }
                    queue.Clear();
                }
                else
                {
                    queue.Enqueue(currenCommand);
                }
            }
        }
    }
}
