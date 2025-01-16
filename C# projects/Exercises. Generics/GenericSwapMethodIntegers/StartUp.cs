namespace GenericSwapMethodIntegers
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<int> list = new List<int>();

            for (int i = 0; i < n; i++)
            {
                int element = int.Parse(Console.ReadLine());
                list.Add(element);
            }

            int[] indexToSwap = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int indexOne = indexToSwap[0];
            int indexTwo = indexToSwap[1];

            NameAndValue.GetNameAndValue(list, indexOne, indexTwo);
        }
        
    }
}