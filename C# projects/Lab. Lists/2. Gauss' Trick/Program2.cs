using System;
using System.Linq;
using System.Collections.Generic;
namespace _2._Gauss__Trick
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int initialCount = numbers.Count;
            for(int i = 0; i < initialCount / 2; i++)
            {
                int currentNumber = numbers[i];
                int lastIndex = numbers.Count - 1;
                int lastNumber = numbers[lastIndex];
                numbers[i] = currentNumber + lastNumber;

                numbers.RemoveAt(lastIndex);
            }
            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}
