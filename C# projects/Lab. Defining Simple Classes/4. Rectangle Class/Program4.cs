using System;
using System.Linq;
using System.Collections.Generic;

namespace _4._Rectangle_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            string color = Console.ReadLine();

            Rectangle rectangle = new Rectangle();
            rectangle.Width = width;
            rectangle.Height = height;
            rectangle.Color = color; 

            Console.WriteLine($"Rect {rectangle.Width}, {rectangle.Height}, {rectangle.Color} has area {rectangle.CalcArea()}.");
        }
    }
}
