using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericSwapMethodIntegers
{
    public static class NameAndValue
    {
        public static void GetNameAndValue<T>(List<T> input, int indexOne, int indexTwo)
        {
            T saveIndex = input[indexOne];

            input[indexOne] = input[indexTwo];
            input[indexTwo] = saveIndex;
            Print(input);
        }

        public static void Print<T>(List<T> input)
        {
            foreach (T element in input)
            {
                string elementType = element.GetType().FullName;
                Console.WriteLine($"{elementType}: {element}");
            }
        }
    }
}
