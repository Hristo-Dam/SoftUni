namespace zadacha
{
    public class StartUp
    {
        private static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            //int k = int.Parse(Console.ReadLine());
            int[] nums = new int[1];
            Duplicates(input.Length, 0, 0, nums, input/*, 1, 0*/);
        }

        /*static void Duplicates(int n, int index, int[] nums, List<HashSet<int>> allCombos, bool checkPrespective)
        {
            if (index > nums.Length - 1)
            {
                if (checkPrespective)
                {


                        allCombos.Add(new HashSet<int>(nums));



                    Console.WriteLine(string.Join(" ", nums));
                    return;
                }
                return;
            }

            for (int i = 1; i <= n; i++)
            {
                nums[index] = i;

                HashSet<int> set = new HashSet<int>(nums);
                foreach(HashSet<int> combo in allCombos)
                {
                    if (combo.SetEquals(set))
                    {
                        checkPrespective = false;
                        break;
                    }
                }

                Duplicates(n, index + 1, nums, allCombos, checkPrespective);
                checkPrespective = true;
            }
        }

    }*/

        /*private static void NestedLoops(int[] arr, int index, int n)
        {
            if (index == n)
            {
                Console.WriteLine(string.Join((arr)));
                return;
            }

            for (int i = 1; i <= arr.Length; i++)
            {
                if (arr[arrInc] == n)
                {
                    arr[arrInc] = 1;
                }
                else
                {
                    arr[index]++;
                }

                NestedLoops(arr, index + 1, n);
            }
        }*/

        static void Duplicates(int end, int start, int index, int[] nums, int[] input)
        {
            if (index > nums.Length - 1)
            {

                Console.WriteLine(string.Join(" ", nums));
                return;

            }

            for (int i = start; i < end; i++)
            {
                nums[index] = input[i];


                if (nums == input)
                {
                    return;

                }
                else
                {
                    Duplicates(end, i + 1, index + 1, nums, input);
                }

            }

            if (nums.Length < input.Length)
            {
                if (nums[0] == input[input.Length - 1])
                {
                    Duplicates(end, 0, 0, new int[nums.Length + 1], input);
                }

            }

        }

    }

}