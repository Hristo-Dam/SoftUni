using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    public class QuickSort
    {
        public static void Sort(int[] arr)
        {
            Sort(arr, 0, arr.Length - 1);
        }

        private static void Sort(int[] arr, int leftIndex, int rightIndex)
        {
            if (leftIndex < rightIndex)
            {
                int pivot = Partition(arr, leftIndex, rightIndex);
                Sort(arr, leftIndex, pivot - 1);
                Sort(arr, pivot + 1, rightIndex);
            }
            else
            {
                return;
            }
        }

        private static int Partition(int[] arr, int leftIndex, int rightIndex)
        {
            if (leftIndex >= rightIndex)
            {
                return leftIndex;
            }

            int i = leftIndex;
            int j = rightIndex + 1;

            while (true)
            {
                while (Less(arr[++i], arr[leftIndex]))
                {
                    if (i == rightIndex)
                    {
                        break;
                    }
                }

                while (Less(arr[leftIndex], arr[--j]))
                {
                    if (j == leftIndex)
                    {
                        break;
                    }
                }

                if (i >= j)
                {
                    break;
                }

                Swap(arr, i, j);
            }

            Swap(arr, leftIndex, j);
            return j;
        }

        private static bool Less(int first, int second)
        {
            return first < second;
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
