﻿using System;
using System.Linq;
using System.Collections.Generic;

namespace _7._List_Manipulation_Advanced
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
                    case "Add":
                        int numberToAdd = int.Parse(elements[1]);
                        numbers.Add(numberToAdd);
                        break;
                    case "Remove":
                        int numberToRemove = int.Parse(elements[1]);
                        numbers.Remove(numberToRemove);
                        break;
                    case "RemoveAt":
                        int indexToRemove = int.Parse(elements[1]);
                        numbers.RemoveAt(indexToRemove);
                        break;
                    case "Insert":
                        int numberToInsert = int.Parse(elements[1]);
                        int indexToInsert = int.Parse(elements[2]);
                        numbers.Insert(indexToInsert, numberToInsert);
                        break;
                    case "Contains":
                        int numberToSerch = int.Parse(elements[1]);

                        break;
                    case "PrintEven":
                        break;
                    case "PrintOdd":
                        break;
                    case "GetSum":
                        break;
                    case "Filter":
                        break;
                }
            }
            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}
