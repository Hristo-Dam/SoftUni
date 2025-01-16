using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace _1._The_Enigma_Machine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] command = Console.ReadLine()
                .Split('|');
            string result = string.Empty;

            while (command[0] != "Decode")
            {
                if (command[0] == "Move")
                {
                    result = Move(input, (int.Parse)(command[1]));
                }
                else if (command[0] == "Insert")
                {
                    int index = int.Parse(command[1]);
                    string value = command[2];
                    result = result.Insert(index, value);
                }
                else if (command[0] == "ChangeAll")
                {
                    string strToReplace = command[1];
                    string strToReplaceWith = command[2];
                    result = result.Replace(strToReplace, strToReplaceWith);
                }

                command = Console.ReadLine().Split('|');
            }

            Console.WriteLine($"The decrypted message is: {result}");
        }

        static string Move(string input, int numOfLettersToMove)
        {
            string result = string.Empty;

            for (int i = numOfLettersToMove; i < input.Length; i++)
            {
                result += input[i];
            }

            for (int i = 0; i < numOfLettersToMove; i++)
            {
                result += input[i];
            }

            return result;
        }
    }
}
