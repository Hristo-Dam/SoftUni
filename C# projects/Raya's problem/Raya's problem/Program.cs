using System;
using System.Linq;
using System.Collections.Generic;

namespace Raya_s_problem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            int[] startPose = new int[input];
            foreach (int n in startPose)
            {
                startPose[n] = 0;
            }

            Console.BackgroundColor = ConsoleColor.Red;

            int execution = 0;

            int positionsToSkip = 1;
            int currentPosition = -1;
            int positionToChange = 0;

            int loopRotations = 0;

            for (int i = 1; i <= startPose.Length; i++)
            {
                loopRotations = startPose.Length / (positionsToSkip + 1); // 10 / 2 = 5

                for (int h = 0; h < loopRotations; h++)
                {
                    positionToChange = currentPosition + positionsToSkip + 1; //-1 + 1 = 0

                    if (positionToChange < startPose.Length) // if index you < 10
                    {
                        if (startPose[positionToChange] == 0) //if at index 0
                        {
                            startPose[positionToChange] = 1; //index becomes 1
                        }
                        else
                        {
                            startPose[positionToChange] = 0; //index becomes 0
                        }
                    }

                   // Console.WriteLine(string.Join(" ", startPose));
                   // Console.WriteLine($"current position is: {currentPosition}\nposition to change is: {positionToChange}");

                    currentPosition = positionToChange;
                    //execution++;

                    //Console.WriteLine($"new current position is: {currentPosition}");
                    //Console.WriteLine($"execution number: {execution}");

                    //Console.WriteLine();
                }
                
                Console.WriteLine();
                Console.WriteLine(string.Join(" ", startPose));
               // execution++;
               // Console.WriteLine($"execution: {execution}");

                currentPosition = -1;
                positionsToSkip++;
            }

            
            Console.WriteLine();
            Console.WriteLine("---------------------------------------------------------------------------");
            Console.WriteLine("Final result");
            Console.WriteLine(string.Join(" ", startPose));
        }
    }
}
