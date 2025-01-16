namespace CustomStack
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            StackOfStrings stackOfStrings = new StackOfStrings();
            Console.WriteLine(stackOfStrings.IsEmpty());

            StackOfStrings fullStack = new StackOfStrings();
            fullStack.Push("a");
            fullStack.Push("b");

            stackOfStrings.AddRange(fullStack);

            Console.WriteLine(stackOfStrings.IsEmpty());
        }
    }
}
