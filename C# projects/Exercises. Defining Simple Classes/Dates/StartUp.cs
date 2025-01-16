namespace Dates
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            string firstInput = Console.ReadLine();
            string secondInput = Console.ReadLine();

            DateCounter dateCounter = new DateCounter();
            dateCounter.Calculate(firstInput, secondInput);
        }
    }
}