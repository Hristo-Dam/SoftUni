using System;
using System.Linq;

namespace RecursiveDrawing
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintAsterisks(n);
            int currentPos = 1;
            PrintHashtags(n, currentPos);
        }

        static void PrintAsterisks(int n)
        {

            if (n == 0)
            {
                return;
            }

            // TODO: Pre-action: print n asterisks
            if (n > 0)
            {
                Console.WriteLine(new string('*', n));

                PrintAsterisks(n - 1);
            }
        }

        static void PrintHashtags(int n, int currentPos)
        {
            //TODO: Post - action: print n hashtags
            if (currentPos > n)
            {
                return;
            }
            Console.WriteLine(new string('#', currentPos));
            PrintHashtags(n, currentPos + 1);
        }
    }
}
