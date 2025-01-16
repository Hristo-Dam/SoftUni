using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vehicles
{
    public class Vehicle
    {
        private decimal _fuelQuantity;
        private decimal _fuelConsumption;

        public Vehicle(decimal fuelQuantity, decimal fuelConsumption)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
        }

        public decimal FuelQuantity
        {
            get { return this._fuelQuantity; }
            set { this._fuelQuantity = value; }
        }
        public decimal FuelConsumption
        {
            get { return this._fuelConsumption; }
            set { this._fuelConsumption = value; }
        }
    }
}
