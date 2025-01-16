using MoreComplexDataStructures;

namespace HeapOfNames
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            MaxHeap<string> heap = new MaxHeap<string>();
            int num = int.Parse(Console.ReadLine());

            for(int i = 0; i < num; i++)
            {
                string name = Console.ReadLine();
                heap.Insert(name);
            }

            while(heap.Count > 0)
            {
                Console.WriteLine(heap.ExtractMax());
            }
        }
    }
}
