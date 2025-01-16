namespace DateModifier
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            DateModifier dateModifier = new DateModifier();

            string inputOne = Console.ReadLine();
            string inputTwo = Console.ReadLine();

            dateModifier.CalculateDif(inputOne, inputTwo);


        }
    }
}