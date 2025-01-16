using System;

namespace _2._Ad_Astra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"(?<separator>[#|])(?<item>[A-Z][a-z]+)\k<separator>(?<date>\d\d\/\d\d\/\d\d)\k<separator>(?<calories>\d{0-10000})\k<separator>");
        }
    }
}
