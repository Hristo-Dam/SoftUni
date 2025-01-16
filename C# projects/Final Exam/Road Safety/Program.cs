using System;
using System.Linq;
using System.Collections.Generic;

namespace Road_Safety
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int greenLinght = int.Parse(Console.ReadLine());
            int freeWindow = int.Parse(Console.ReadLine());
            int passedCars = 0;
            int countOfLetters = 0;
            int countOfGreenLight = 0;
            int secondsLeft = greenLinght + freeWindow;

            while (true)
            {
                countOfGreenLight = greenLinght;
                string command = Console.ReadLine();

                
                if (command == "light")
                {

                }
                else if (command != "STOP")
                {
                    if (command.Length - countOfGreenLight > 0)
                    {
                        passedCars++;
                        secondsLeft -= command.Length;
                        string nextCar = Console.ReadLine();
                    }
                    else
                    {
                        secondsLeft -= command.Length;
                        if (command.Length - (countOfGreenLight + freeWindow) > 0)
                        {
                            passedCars++;
                        }
                        else
                        {
                            Console.WriteLine("Accident!");
                            Console.WriteLine($"{command} was crushed at {command[secondsLeft - command.Length]}");
                        }
                    }
                }
                else if (command == "STOP")
                {
                    Stop(passedCars);
                }
            }
        }
        
        static void Stop(int passedCars)
        {
            Console.WriteLine("Success!");
            Console.WriteLine($"{passedCars}");
            return;
        }
    }
}
