namespace Tuple
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Tuple<string, string> tuple1 = new Tuple<string, string>();
            Tuple<string, int> tuple2 = new Tuple<string, int>();
            Tuple<int, double> tuple3 = new Tuple<int, double>();

            string[] input1 = Console.ReadLine()
                .Split()
                .ToArray();
        }
    }
}