namespace QuickSort
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int[] arr = { 3, 6, 1, 5, 2, 4, 9, 7, 10, 8};
            QuickSort.Sort(arr);
            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
