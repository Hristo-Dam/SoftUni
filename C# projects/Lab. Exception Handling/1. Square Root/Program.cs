using System;

namespace _1._Square_Root
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string input = Console.ReadLine();
            int input = int.Parse(Console.ReadLine());

            if (input < 0)
            {
                throw new ArgumentException("The number cannot be negative!");
            }

            try
            {
                //int.Parse(input);
                Console.WriteLine("Your numbers is: " + input);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid integer number!");
            }
            catch (OverflowException)
            {
                Console.WriteLine("The number is too big!");
            }
            finally
            {
                Console.WriteLine("Good bye");
            }
        }
    }
}
