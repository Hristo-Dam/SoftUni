namespace SumRectangleAreas
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
           Console.WriteLine(SumRectAreas(2, 2));
        }

        static int SumRectAreas(int width, int height)
        {
            int sum = 0;
            for (int x = 1; x <= width; x++)
            {
                for (int y = 1; y <= height; y++)
                {
                    sum = sum + x * y;
                }
            }
            return sum;
        }
    }
}
