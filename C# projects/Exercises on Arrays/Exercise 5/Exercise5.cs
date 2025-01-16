using System;
using System.Linq;
using System.Collections.Generic;

namespace Exercise_5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Input
            int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            // Solution
            List<int> result = FindLongestSequence(numbers);

            // Output
            Console.WriteLine(String.Join(" ", result));
        }

        static List<int> FindLongestSequence(int[] numbers)
        {
            List<int> result = new List<int>();

            int maxLength = 1;
            int currentLength = 1;
            int maxNum = 0;
            int lastNum = 0;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                int currentNum = numbers[i];
                int nextNum = numbers[i + 1];
                if (currentNum == nextNum - 1)
                {
                    currentLength++;
                    if (currentLength > maxNum)
                    {
                        maxNum = currentNum;
                    }
                }
                else
                {
                    if (currentLength > maxLength)
                    {
                        maxLength = currentLength;
                        maxNum = currentNum;
                    }
                    currentLength = 1; // reset the current length
                }
            }



            for (int i = maxNum - maxLength; i < maxLength; i--)
            {
                result.Add(numbers[i]);
            }

            result.Reverse();
            
            return result;
        }
    }
}
