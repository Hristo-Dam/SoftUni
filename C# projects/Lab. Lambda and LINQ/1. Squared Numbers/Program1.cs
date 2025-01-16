using System;
using System.Linq;
using System.Collections.Generic;

namespace _1._Squared_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            static int Squared(int x) => x * x;

            Console.WriteLine(Squared(number));
        }
    }
}
