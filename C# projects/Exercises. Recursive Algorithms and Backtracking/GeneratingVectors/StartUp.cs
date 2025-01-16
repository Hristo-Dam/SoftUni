using System;
using System.Linq;

namespace GeneratingVectors
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] nums = new int[n];

            CreateVector(nums, 0);
        }
        private static void CreateVector(int[] nums, int index)
        {
            if (index > nums.Length - 1)
            {
                Console.WriteLine(string.Join("", nums));
                return;
            }

            for (int i = 0; i <= 1; i++)
            {
                nums[index] = i;
                CreateVector(nums, index + 1);
            }
        }
    }
}
