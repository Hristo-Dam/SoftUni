using System;
using System.Linq;

namespace DrawReversed_K_
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintHashtags(n, 0);
            int currentPos = 1;
            PrintAsterisks(n, currentPos, n - 1);
        }

        static void PrintHashtags(int n, int emptySpaces)
        {

            if (n == 0)
            {
                return;
            }

            // TODO: Pre-action: print n asterisks
            if (n > 0)
            {
                Console.Write(new string(' ', emptySpaces));
                Console.WriteLine(new string('#', n));

                PrintHashtags(n - 1, emptySpaces + 1);
            }
        }

        static void PrintAsterisks(int n, int currentPos, int emptySpaces)
        {
            //TODO: Post - action: print n hashtags
            if (currentPos > n)
            {
                return;
            }
            Console.Write(new string(' ', emptySpaces));
            Console.WriteLine(new string('*', currentPos));

            PrintAsterisks(n, currentPos + 1, emptySpaces - 1);
        }
    }
}
