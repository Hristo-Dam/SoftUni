using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    public class Tesla : Car
    {
        public int Battery { get; set; }

        public Tesla(string model, string color, int battery) : base(model, color)
        {
            this.Battery = battery;
        }

        public override string ToString()
        {
            return $"{this.Color} Tesla {this.Model} with {this.Battery} Batteries\nEngine start\nBreaaak!";
        }
    }
}
