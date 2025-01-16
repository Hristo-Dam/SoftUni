using System;
using System.Linq;

namespace RecursiveFactorial
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(GetFactorial(num));
        }

        static long GetFactorial(int num)
        {
            if (num == 0)
            {
                return 1;

            }

            return num * GetFactorial(num - 1);
        }
    }
}
