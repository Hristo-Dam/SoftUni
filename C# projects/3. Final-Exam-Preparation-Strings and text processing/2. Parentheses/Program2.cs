using System;

namespace _2._Parentheses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "(x-2(y+3)) * (x+1)";
            Console.WriteLine(CheckPar(input));
        }

        static bool CheckPar(string input)
        {
            int leftParCount = 0;
            int rightParCount = 0;

            foreach (char c in input)
            {
                if (c == '(')
                {
                    leftParCount++;
                }

                if (c == ')')
                {
                    rightParCount++;
                }
            }

            if (leftParCount == rightParCount)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
