using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManufacturer
{
    public class Car
    {
        public Car()
        {
            this.Make = "VW";
            this.Model = "Golf";
            this.Year = 2025;
 
        }

        private string make;
        private string model;
        private int year;
        private double fuelQuantity;
        private double fuelConusumption;

        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double FuelQuantity { get; set; }
        public double FuelConsumption { get; set; }

        public void Drive(double distance)
        {
            if (this.FuelQuantity - distance * this. FuelConsumption > 0)
            {
                this.FuelQuantity -= distance * this.FuelConsumption;
            }
            else
            {
                Console.WriteLine("Not enough fuel to perform this trip!");
            }
        }

        public string WhoAmI()
        {
            string message = $"Make: {this.Make}\nModel: {this.Model}\nYear: {this.Year}\nFuel:{ this.FuelQuantity:F2}L";
            return message;
        }
    }
}
