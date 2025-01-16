using System;

namespace _2._Vowels_Count
{
    internal class Program
    {
        static  bool IsVowel(char letter)
        {
            if (letter == 'a' || letter == 'o' || letter == 'u' || letter == 'e' || letter == 'i')
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static int CountVowels(string text)
        {
            int count = 0;
            text = text.ToLower();

            for (int i = 0; i < text.Length; i++)
            {
                if (IsVowel(text[i]))
                {
                    count++;
                }
            }

            return count;
        }

        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int count = CountVowels(text);
            Console.WriteLine(count);
        }
    }
}
