using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace _1._Secret_Message
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();
            StringBuilder sb = new StringBuilder();
            sb.Append(message);

            string[] command = Console.ReadLine()
                .Split("<->")
                .ToArray();

            while (command[0] != "Read")
            {
                if (command[0] == "Space")
                {
                    int index = int.Parse(command[1]);
                    sb.Insert(index, ' ');
                    Console.WriteLine(sb);
                }
                else if (command[0] == "Backward")
                {
                    if (message.Contains(command[1]))
                    {
                        int indexToRemove = message.IndexOf(command[1]);
                        string subStringToFlip = command[1];
                        sb.Remove(indexToRemove, command[1].Length);

                        string flippedSubString = "";
                        for (int i = subStringToFlip.Length - 1; i > -1; i--)
                        {
                            flippedSubString += subStringToFlip[i];
                        }
                        sb.Append(flippedSubString);
                        Console.WriteLine(sb);
                    }
                    else if (!message.Contains(command[1]))
                    {
                        Console.WriteLine("error");
                    }
                }
                else if (command[0] == "ReplaceAll")
                {
                    sb.Replace(command[1], command[2]);
                    Console.WriteLine(sb);
                }

                command = Console.ReadLine().Split("<->").ToArray();
            }

            Console.Write($"You have a secret text message: {sb}");
        }
    }
}
