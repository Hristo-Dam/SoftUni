using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    public class Car
    {
        public string Model {  get; set; }
        public string Color { get; set; }

        public Car(string model, string Color)
        {
            this.Model = model;
            this.Color = Color;
        }
    }
}
