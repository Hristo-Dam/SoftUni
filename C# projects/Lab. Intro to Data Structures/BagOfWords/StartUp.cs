using Wintellect.PowerCollections;

namespace BagOfWords
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            OrderedBag<string> bag = new OrderedBag<string>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                bag.Add(name);
            }

            foreach (string name in bag)
            {
                Console.WriteLine(name);
            }
        }
    }
}
