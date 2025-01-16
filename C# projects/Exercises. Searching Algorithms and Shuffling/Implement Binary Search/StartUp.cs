namespace Implement_Binary_Search
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int key = 5;
            int index = BinarySearch.IndexOf(arr, key);
            if (index != -1)
            {
                Console.WriteLine($"Element found at index {index}");
            }
            else
            {
                Console.WriteLine("Element not found");
            }
        }
    }
}
