using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implement_Binary_Search
{
    public class BinarySearch
    {
        public static int IndexOf(int[] arr, int key)
        {
            int leftIndex = 0;
            int rightIndex = arr.Length - 1;

            while (leftIndex <= rightIndex)
            {
                int midIndex = leftIndex + (rightIndex - leftIndex) / 2;

                if (key < arr[midIndex])
                {
                    rightIndex = midIndex - 1;
                }
                else if (key > arr[midIndex])
                {
                    leftIndex = midIndex + 1;
                }
                else
                {
                    return midIndex;
                }
            }

            return -1;
        }
    }
}
