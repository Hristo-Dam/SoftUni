using System;
using System.Linq;
using System.Collections.Generic;

namespace Code_Snippets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ================ 1. Multidimentional arrays ================
            // Деклариране и четене от конзола
            string[,] matrix3x5 = new string[3, 5];
            int[,] matrix7x3 = new int[7, 3];

            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());
            int[,] matrixFromConsole = new int[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrixFromConsole[i, j] = int.Parse(Console.ReadLine());
                }
            }

            // Въвеждане в kода / hardcode
            int[,] hardCodedMatrix = 
            {
                    {1, 2, 3},
                {4, 5, 6},
            };

            // Печатane в конзолата
            for (int i = 0; i < hardCodedMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < hardCodedMatrix.GetLength(1); j++)
                {
                    Console.Write(hardCodedMatrix[i, j] + " ");
                }
                Console.WriteLine();
            }

            // Допълнителни функции и действия
            hardCodedMatrix.GetLength(0); // Count of rows
            hardCodedMatrix.GetLength(1); // Count of columns

            //TODO: add other useful snippets here

            // ================ 2. Dictionaries ================ 
            // TODO: Write code snippets here
            // Деклариране и четене от конзола
            // Въвеждане в kода / hardcode
            // Печатane в конзолата
            // Допълнителни функции и действия

            // ================ 3. Functional programming / Linq ================ 
            // No need to read or print in console, however:
            // x => x      Anonymous function doing nothing. Same as:
            int doNothing(int x)
            {
                return x;
            }

            // or
            Func<int, int> DoNothing = (x => x);


            // x => x == 5  Anonymous predicate checking if x is 5. Same as:
            bool check(int x)
            {
                return x == 5;
            }

            // or
            Predicate<int> Check = (x => x == 5);


            // x => x * 10  Anonymous function to multiply x by 10. Same as:
            int tenfold(int x)
            {
                return x * 10;
            }


            // () => 5      Anonymous function always returning the number 5. Same as:
            int NoParam()
            {
                return 5;
            }

            // or
            Func<int> NoParameter = (() => 5);

            // Void functions are called Actions.
            Action<double> PrettyPrint = (num => Console.WriteLine($"{num:f2}"));

            // is the same as
            void prettyPrint(double num)
            {
                Console.WriteLine($"{num:f2}");
            }



            // ================ 4. Classes and objects ================ 
            // TODO: Write code snippets here
            // Деклариране и четене от конзола
            // Въвеждане в kода / hardcode
            // Печатane в конзолата
            // Допълнителни функции и действия

            // ================ 5. Strings, text processing and RegEx ================
            // TODO: Write code snippets here
            // String builder
            // Using strings as arrays of chars
            // Using RegEx in C# code - Match, MatchCollection...
            // RegEx rules and examples
        }
    }
}
