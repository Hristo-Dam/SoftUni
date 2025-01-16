using System;

namespace _5._Calculate_Rectangle_Area
{
    internal class Program
    {
        static double RectangleArea(double width, double height)
        {
            return width * height;
        }
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            Console.WriteLine(RectangleArea(width, height));
        }


    }
}
