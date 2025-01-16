namespace AbcstractClass
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            int n = 5;

            DerivedClass newClass = new DerivedClass();
            Console.WriteLine(newClass.Calculate(n));

            OtherClass newOtherClass = new OtherClass();
            Console.WriteLine(newOtherClass.Calculate(n));
        }
    }
}
