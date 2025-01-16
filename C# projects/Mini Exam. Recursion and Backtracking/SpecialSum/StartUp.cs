namespace SpecialSum
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SpecialSum(2, 4));
        }
        static int SpecialSum(int start, int end)
        {
            int sum = 0;
            for (int p = start; p <= end; p++)
            {
                for (int q = end; q <= start; q++)
                {
                    for (int k = 1; k <= end; k++)
                        sum++;
                }
                sum = sum + 50;
            }
            return sum;
        }
    }
}
