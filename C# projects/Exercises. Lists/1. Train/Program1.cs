using System;
using System.Linq;
using System.Collections.Generic;

namespace _1._Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> passengersAndWagons = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int maxPassengers = int.Parse(Console.ReadLine());
            
            int passengersToAdd = 0;

            while (true)
            {
                string command = Console.ReadLine();
                string[] elementsOfCommand = command.Split();

                if (command == "end")
                {
                    Console.WriteLine(string.Join(" ", passengersAndWagons));
                    return;
                }
                else if (elementsOfCommand[0] == "Add")
                {
                    passengersToAdd = int.Parse(elementsOfCommand[1]);
                    passengersAndWagons.Add(passengersToAdd);
                }
                else if (elementsOfCommand[0] != "Add")
                {
                    passengersToAdd = int.Parse(elementsOfCommand[0]);
                    for (int i = 0; i < passengersAndWagons.Count; i++)
                    {
                        if ((passengersAndWagons[i] + passengersToAdd) <= maxPassengers)
                        {
                            passengersAndWagons[i] += passengersToAdd;
                            break;
                        }
                    }
                }

            }
            Console.WriteLine(String.Join(' ', passengersAndWagons));
        }
    }
}
