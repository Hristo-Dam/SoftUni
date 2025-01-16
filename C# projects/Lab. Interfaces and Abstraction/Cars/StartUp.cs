namespace Cars
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Renault renault = new Renault("Duster", "Grey");
            Tesla tesla = new Tesla("Model 3", "Red", 2);

            Console.WriteLine(renault);
            Console.WriteLine(tesla);
        }
    }
}
