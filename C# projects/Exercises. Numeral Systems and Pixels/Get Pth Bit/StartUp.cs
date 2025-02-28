namespace Get_Pth_Bit
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            int mask = 1 << p;
            int result = n & mask;
            result = result >> p;
            Console.WriteLine(result);
        }
    }
}
