namespace LinkedList
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            CustomLinkedList list = new CustomLinkedList();

            list.Add("some element");
            list.Add(5);
            list.Add("something");

            foreach (var n in list)
            {
                Console.WriteLine(n.ToString());
            }
        }
    }
}