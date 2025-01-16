using System;
using System.Linq;

namespace CombinationsWithRepetition
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int[] nums = new int[k];

            GenerateCombinations(nums, n, 1, 0);
        }

        private static void GenerateCombinations(int[] nums, int n, int startNum, int index)
        {
            if (index > nums.Length - 1)
            {
                Console.WriteLine(string.Join(" ", nums));
                return;
            }

            for (int i = startNum; i <= n; i++)
            {
                nums[index] = i;
                GenerateCombinations(nums, n, i, index + 1);
            }
        }
    }
}
