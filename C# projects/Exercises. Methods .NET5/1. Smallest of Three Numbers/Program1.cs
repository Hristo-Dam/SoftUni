using System;

namespace _1._Smallest_of_Three_Numbers
{
    internal class Program
    {
        static int FindSmallestInt(int a, int b, int c)
        {
            int result = 0;

            result = Math.Min(Math.Min(a, b), c);

            return result;
        }

        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine(FindSmallestInt(a, b, c));
        }
    }
}
