using System;

namespace _9._Multiply_Evens_by_Odds
{
    internal class Program
    {
            static int GetMultipleOfEvenAndOdds(int number)
            {
                int evenSum = GetSumOfEvenDigits(number);
                int oddSum = GetSumOfOddDigits(number);
                int product = evenSum * oddSum;

                return product;
            }

            static int GetSumOfEvenDigits(int number)
            {
                int sum = 0;
                while (number > 0)
                {
                    int lastDigit = number % 10;

                    if (isEven(lastDigit)) //if the digit is even
                    {
                        sum += lastDigit;
                    }

                    number = number / 10;
                }
                return sum;
            }

            static int GetSumOfOddDigits(int number)
            {
                int sum = 0;
                while (number > 0)
                {
                    int lastDigit = number % 10;

                    if (!isEven(lastDigit)) //if the digit is odd
                    {
                        sum += lastDigit;
                    }

                    number = number / 10;
                }
                return sum;
            }

            static bool isEven(int num)
            {
                return num % 2 == 0;
            }

            static void Main()
            {
                int number = int.Parse(Console.ReadLine());
                number = Math.Abs(number);

                int result = GetMultipleOfEvenAndOdds(number);
                Console.WriteLine(result);
            }
    }
}
