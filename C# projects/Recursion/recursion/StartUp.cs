namespace recursion
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] nums = new int[n];
            Loop(nums, n);
        }

        static void Loop(int[] nums, int index)
        {
            if (index > nums.Length - 1)
            {
                Console.WriteLine(string.Join(" ", nums));
                return;
            }

            for (int i = 1; i <= nums.Length; i++)
            {
                nums[index] = i;
                Loop(nums, index + 1);
            }
        }
    }
}
