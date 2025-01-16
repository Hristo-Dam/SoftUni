using System;

namespace _8._Greater_of_Two_Values
{
    internal class Program
    {
        static int CompareIntInputs(int a, int b)
        {
            int result = 0;
            if (a > b)
            {
                result = a;
            }
            else if (a < b)
            {
               result = b;
            }

            return result;
        }

        static string CompareStringInputs(string a, string b)
        {
            string result = string.Empty;
            
            if (string.Compare(a, b) > 0)
            {
                result = a;
            }
            else if (string.Compare(a, b) < 0)
            {
                result = b;
            }

            return result;
        }

        static char CompareCharInputs(char a, char b)
        {
            char result = ' ';

            if (a > b)
            {
                result = a;
            }
            else if (a < b)
            {
                result = b;
            }

            return result;
        }

        static void Main(string[] args)
        {
            string typeOfInput = Console.ReadLine();
            
            if (typeOfInput == "int")
            {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                int result = CompareIntInputs(a, b);
                Console.WriteLine(result);
            }
            else if (typeOfInput == "string")
            {
                string a = Console.ReadLine();
                string b = Console.ReadLine();
                string result = CompareStringInputs(a, b);
                Console.WriteLine(result);
            }
            else if (typeOfInput == "char")
            {
                char a = char.Parse(Console.ReadLine());
                char b = char.Parse(Console.ReadLine());
                char result = CompareCharInputs(a, b);
                Console.WriteLine(result);
            }
        }
    }
}
