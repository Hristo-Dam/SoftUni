using System;
using System.Linq;
using System.Collections.Generic;

namespace _3._List_Operations
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
                        int indexToRemove = int.Parse(elements[1]);
                        numbers.RemoveAt(indexToRemove);
                        break;
                    case "Delete":
                        int numberToRemove = int.Parse(elements[1]);
                        numbers.Remove(numberToRemove);
                        break;
                    case "Insert":
                        int numberToInsert = int.Parse(elements[1]);
                        int indexToInsert = int.Parse(elements[2]);
                        numbers.Insert(indexToInsert, numberToInsert);
                        break;
                    case "Shift left":
                        int timesToMoveLeft = int.Parse(elements[1]);
                        for (int i = 0; i < timesToMoveLeft; i++)
                        {
                            int firstNum = numbers[0];
                            numbers.Add(firstNum);
                            numbers.Remove(numbers[0]);
                        }
                        break;
                    case "Shift right":
                        int timesToMoveRight = int.Parse(elements[1]);
                        for (int i = 0; i < timesToMoveRight; i++)
                        {
                            int lastNum = numbers[numbers.Count - 1];
                            int indexToInsertAt = int.Parse(elements[2]);
                            numbers.Insert(indexToInsertAt, lastNum);
                            numbers.Remove(numbers[numbers.Count - 1]);
                        }
                        break;
                }
                break;
            }
            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}
