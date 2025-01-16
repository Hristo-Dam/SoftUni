using System;

namespace _6._Repeat_String
{
    internal class Program
    {
        static string NewText(string text, double n)
        {
            string result = string.Empty;

            for (int i = 0; i < n; i++)
            {
                Console.Write(text);
            }

            return result;
        }

        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            double number = double.Parse(Console.ReadLine());

            string newResult = NewText(word, number);
        }
    }
}
