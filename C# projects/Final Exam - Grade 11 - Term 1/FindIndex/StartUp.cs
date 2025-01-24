namespace FindIndex
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine()
                .Split(", ")
                .ToList();

            string newWord = Console.ReadLine();

            names.Add(newWord);

            names = BubbleSort(names);

            int index = FindIndex(names, newWord);

            Console.WriteLine(index);
        }
        public static int FindIndex(List<string> list, string wordToFind)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == wordToFind)
                {
                    return i;
                }
            }
            return -1;
        }
        public static List<string> BubbleSort(List<string> list)
        {
            int indexOfLastUnsortedElement = list.Count - 1;

            for (int i = 0; i < list.Count; i++)
            {
                for (int k = 1; k < list.Count - i; k++)
                {
                    string firstElement = list[k - 1];
                    string secondElement = list[k];

                    if (firstElement.First() > secondElement.First())
                    {
                        Swap(list, k - 1, k);
                    }
                    else if (firstElement.First() == secondElement.First())
                    {
                        int endOfLoop = Math.Min(firstElement.Length, secondElement.Length);

                        if (firstElement.Length > secondElement.Length && firstElement.Contains(secondElement))
                        {
                            Swap(list, k - 1, k);
                            break;
                        }
                        else if (secondElement.Length > firstElement.Length && secondElement.Contains(firstElement))
                        {
                            
                        }
                        else
                        {
                            for (int h = 0; h < endOfLoop - 1; h++)
                            {
                                if (firstElement[h] > secondElement[h])
                                {
                                    Swap(list, k - 1, k);
                                    break;
                                }
                                else if (firstElement[h] < secondElement[h])
                                {
                                    break;
                                }
                            }
                        }
                    }
                }
            }

            return list;
        }
        public static List<string> Swap(List<string> list, int firstIndex, int secondIndex)
        {
            string holdValue = list[firstIndex];
            list[firstIndex] = list[secondIndex];
            list[secondIndex] = holdValue;
            return list;
        }
    }
}
