using System;
using System.Linq;
using System.Collections.Generic;

namespace _4._Text_Filter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string bannedWords = Console.ReadLine();
            string[] bannedArray = bannedWords.Split(", ");
            string input = Console.ReadLine();
            string result = "";

            for (int i = 0; i < bannedArray.Length; i++)
            {
                result = input.Replace(bannedArray[i], "*****");
            }

            Console.WriteLine(result);
        }
    }
}
