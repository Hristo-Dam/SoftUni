﻿using System;
using System.Linq;
using System.Collections.Generic;

namespace LinkedStrings
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            LinkedList<string> list = new LinkedList<string>();
            string firstWord = Console.ReadLine();
            string secondWord = Console.ReadLine();
            string thirdWord = Console.ReadLine();
            string fourthWord = Console.ReadLine();
            list.AddFirst(firstWord);
            list.AddLast(secondWord);
            list.AddAfter(list.First, thirdWord);
            list.AddAfter(list.Last, fourthWord);

            Console.WriteLine(string.Join(", ", list));
        }   
    }
}
