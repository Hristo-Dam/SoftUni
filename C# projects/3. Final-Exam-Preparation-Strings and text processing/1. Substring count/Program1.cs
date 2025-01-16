using System;
using System.Linq;
using System.Collections.Generic;

namespace _1._Substring_count
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "Text something i need to find out how many times the word kiwi apears in the text. Something something text text kiwi kivi not kiwi bannana ananas.";
            string str = "kiwi";
            Console.WriteLine(StringCounter(text, str));
        }

        static int StringCounter(string text, string str)
        {
            int counter = 0;
            string[] textArray = text.Split().ToArray();
            for (int i = 0; i < textArray.Length; i++)
            {
                if (textArray[i] == str)
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}
