namespace LinkedString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> strings = new LinkedList<string>();

            string first = Console.ReadLine();
            string second = Console.ReadLine();
            string third = Console.ReadLine();
            string fourth = Console.ReadLine();

            strings.AddFirst(first);
            strings.AddLast(second);
            strings.AddAfter(strings.First, third);
            strings.AddBefore(strings.Last, fourth);

            Console.WriteLine(string.Join(", ", strings));
        }
    }
}
