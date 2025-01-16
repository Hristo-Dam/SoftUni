﻿using System;
using System.Linq;
using System.Collections.Generic;

namespace _2._Change_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "end")
                {
                    break;
                }

                string[] elements = command.Split();

                switch (elements[0])
                {
                    case "Delete":
                        int numberToRemove = int.Parse(elements[1]);
                        numbers.Remove(numberToRemove);
                        break;
                    case "Insert":
                        int numberToInsert = int.Parse(elements[1]);
                        int indexToInsert = int.Parse(elements[2]);
                        numbers.Insert(indexToInsert, numberToInsert);
                        break;
                }
            }
            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}
