namespace SimpleSorts
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            //int[] array = Console.ReadLine()
            //    .Split()
            //    .Select(int.Parse)
            //    .ToArray();

            int[] arr = new int[] { 2, 4, 3, 5, 1 };

            //Console.WriteLine("Bubble sort result: " + string.Join(" ", BubbleSort(arr)));
            //Console.WriteLine("Insertion sort result: " + string.Join(" ", InsertionSort(arr)));
            //Console.WriteLine("Selection sort result: " + string.Join(" ", SelectionSort(arr)));
        }

        public static int[] SelectionSort(int[] arr)
        {
            for (int start = 0; start < arr.Length - 1; start++)
            {
                int posМin = start;

                for (int next = start + 1; next < arr.Length; next++)
                {
                    if (arr[next] < arr[posМin])
                    {
                        posМin = next;
                    }
                }

                if (posМin != start)
                {
                    Swap(arr, posМin, start);
                }
            }

            return arr;
        }

        public static int[] BubbleSort(int[] arr)
        {
            int indexOfLastUnsortedElement = arr.Length - 1;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int k = 1; k < arr.Length - i; k++)
                {
                    if (arr[k - 1] > arr[k])
                    {
                        Swap(arr, k - 1, k);
                    }
                }
            }

            return arr;
        }

        public static int[] InsertionSort(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int currentElement = arr[i];
                int k = i - 1;
                while (k >= 0 && arr[k] > currentElement)
                {
                    arr[k + 1] = arr[k];
                    k--;
                }
                arr[k + 1] = currentElement;
            }
            return arr;
        }

        public static int[] Swap(int[] arr, int firstIndex, int secondIndex)
        {
            int holdValue = arr[firstIndex];
            arr[firstIndex] = arr[secondIndex];
            arr[secondIndex] = holdValue;
            return arr;
        }
    }
}
