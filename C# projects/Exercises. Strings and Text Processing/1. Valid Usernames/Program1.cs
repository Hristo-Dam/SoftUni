using System;
using System.Linq;
using System.Collections.Generic;

namespace _1._Valid_Usernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine()
                .Split(", ")
                .ToList();

            foreach (string name in list)
            {
                if (name.Length > 3 && name.Length < 16)
                {
                    string result = "";
                    foreach (char c in name)
                    {
                        if (c == '@')
                        {

                        }
                        else if (char.IsDigit(c) || char.IsLetter(c) || c == 45 || c == 95)
                        {
                            result += c;
                        }
                    }

                    if (result == name)
                    {
                        Console.WriteLine(name);
                    }
                }
            }
        }
    }
}
