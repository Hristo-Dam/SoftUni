using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._Rectangle_Class
{
    public class Rectangle
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public string Color { get; set; }

        public int CalcArea()
        {
            return Width * Height;
        }
    }
}
