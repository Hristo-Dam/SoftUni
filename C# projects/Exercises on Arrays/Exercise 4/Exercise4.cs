using System;
using System.Linq;
using System.Collections.Generic;

namespace Exercise_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //4.      Напишете програма, която намира максимална редица от последователни еднакви елементи в масив.
            //Пример: {2, 1, 1, 2, 3, 3, 2, 2, 2, 1} => {2, 2, 2}.

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

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                int currentNum = numbers[i];
                int nextNum = numbers[i + 1];
                if (currentNum == nextNum)
                {
                    currentLength++;

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

            for (int i = 0; i < maxLength; i++)
            {
                result.Add(maxNum);
            }
            return result;
        }
    }
}
