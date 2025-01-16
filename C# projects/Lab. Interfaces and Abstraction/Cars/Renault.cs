using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    public class Renault : Car
    {
        public Renault(string model, string color) : base(model, color)
        {
            
        }

        public override string ToString()
        {
            return $"{this.Color} Reanult {this.Model}\nEngine start\nBreaaak!";
        }
    }
}
