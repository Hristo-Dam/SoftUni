using System;
using System.Linq;
using System.Collections.Generic;
namespace _3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine()
                .Split()
                .ToList();

            string[] command = Console.ReadLine()
                .Split()
                .ToArray();

            while(command[0] != "end")
            {
                if (command[0] == "Add")
                {
                    list.Add(command[1]);
                }
                else if (command[0] == "Remove")
                {
                    list.Remove(command[1]);
                }
                else if (command[0] == "RemoveAt")
                {
                    list.RemoveAt(int.Parse(command[1]));
                }
                else if (command[0] == "Insert")
                {
                    list.Insert(int.Parse(command[2]), command[1]);
                }

                command = Console.ReadLine()
                    .Split()
                    .ToArray();
            }

            Console.WriteLine(String.Join(" ", list));
        }
    }
}
//4 19 2 53 6 43
//Add 3
//Remove 2
//RemoveAt 1
//Insert 8 3
//end