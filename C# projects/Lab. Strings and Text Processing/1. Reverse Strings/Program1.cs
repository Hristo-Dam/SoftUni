using System;
using System.Linq;
using System.Collections.Generic;

namespace _1._Reverse_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            while (true)
            {
                if (text == "end")
                {
                    break;
                }
                else
                {
                    List<char> revText = new List<char>();

                    for (int i = text.Length - 1; i >= 0; i--)
                    {
                        revText.Add(text[i]);
                    }

                    Console.WriteLine(text + " = " + string.Join("", revText));
                    text = Console.ReadLine();
                }
            }
        }
    }
}
