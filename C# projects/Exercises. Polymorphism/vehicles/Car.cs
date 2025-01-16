using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace vehicles
{
    public class Car : Vehicle
    {
        public Car(decimal fuelQuantity, decimal fuelConsumption) : base(fuelQuantity, fuelConsumption)
        {

        }
    }
}
