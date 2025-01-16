using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxData
{
    public class Box
    {
        private double _length;
        private double _width;
        private double _height;

        public Box(double length, double width, double height)
        {
            Length = length;
            Width = width;
            Height = height;
        }

        public double Length
        {
            get { return _length; }
            private set
            {
                if(value > 0)
                {
                    _length = value;
                }
                else
                {
                    throw new ArgumentException("Length cannot be zero or negative.");
                }
            }
        }
        public double Width
        {
            get { return _width; }
            private set
            {
                if(value > 0)
                {
                    _width = value;
                }
                else
                {
                    throw new ArgumentException("Width cannot be zero or negative.");
                }
            }
        }
        public double Height
        {
            get { return _height; }
            private set
            {
                if(value > 0)
                {
                    _height = value;
                }
                else
                {
                    throw new ArgumentException("Height cannot be zero or negative.");
                }
            }
        }

        public void Volume()
        {
            double result = this.Length * this.Width * this.Height;
            Console.WriteLine($"Volume - {result:F2}");
        }
        public void LateralSurface()
        {
            double result = 2 * this.Length * this.Height + 2 * this.Width * this.Height;
            Console.WriteLine($"Lateral Surface Area - {result:F2}");
        }
        public void Surface()
        {
            double result = 2 * this.Length * this.Width 
                + 2 * this.Length * this.Height 
                + 2 * this.Width * this.Height;
            Console.WriteLine($"Surface Area - {result:F2}");
        }
    }
}
