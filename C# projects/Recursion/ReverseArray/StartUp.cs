using System;
using System.Linq;

namespace ReverseArray
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            PrintArrayInReveseOrder(nums, 0);
            Console.WriteLine();
        }

        private static void PrintArrayInReveseOrder(int[] nums, int index)
        {
            if (index > nums.Length - 1)
            {
                return;
            }

            PrintArrayInReveseOrder(nums, index + 1);
            Console.Write(nums[index] + " ");
        }
    }
}
