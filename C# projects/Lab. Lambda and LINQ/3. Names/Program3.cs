using System;

namespace _3._Names
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name =  Console.ReadLine();

            for (int i = 0; i < name.Length; i++)
            {
                if (name[i] >= 48 && name[i] <= 57)
                {
                    Console.WriteLine("Invalid name!");
                }
            }

            

            if (name.Length < 3)
            {
                Console.WriteLine("Invalid name!");
            }
            else if (name[0] >= 65 && name[0] <= 90)
            {
                Console.WriteLine($"Hello, {name}!");

                for (int k = 0; k < name.Length; k++)
                {
                    Console.WriteLine(ConvertToASCII(name[k]));
                }
            }
            else if (name[0] < 65 || name[0] > 90)
            {
                Console.WriteLine("Invalid name!");
            }
        }
        static int ConvertToASCII(char letter) => (int)letter + 10;
    }
}
