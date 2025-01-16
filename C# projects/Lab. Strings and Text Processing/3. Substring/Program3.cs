using System;
using System.Linq;
using System.Collections.Generic;

namespace _3._Substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();

            int index = str2.IndexOf(str1);
            str2.Remove(index, str1.Length);

            Console.WriteLine(str2);
        }
    }
}
