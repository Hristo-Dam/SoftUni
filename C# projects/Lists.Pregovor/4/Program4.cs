using System;
using System.Linq;
using System.Collections.Generic;

namespace _4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string[] command = Console.ReadLine()
                .Split();

            int sum = 0;

            while (command[0] != "end")
            {
                if (command[0] == "Contains")
                {
                    if (list.Contains(int.Parse(command[1])))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                }
                else if (command[0] == "PrintEven")
                {
                    foreach (int n in list)
                    {
                        if (n % 2 == 0)
                        {
                            Console.WriteLine(n);
                        }
                    }
                }
                else if (command[0] == "PrintOdd")
                {
                    foreach (int n in list)
                    {
                        if (n % 2 == 1)
                        {
                            Console.WriteLine(n);
                        }
                    }
                }
                else if (command[0] == "GetSum")
                {
                    foreach (int n in list)
                    {
                        sum += n;
                    }

                    Console.WriteLine(sum);
                }
                else if (command[0] == "Filter")
                {

                }
            }
        }

        static bool Filter (int num, string sign)
        {

        }

    }
}
