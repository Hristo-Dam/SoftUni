﻿using System;
using System.Linq;
using System.Collections.Generic;

namespace CarManufacturer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Make = "VW";
            car.Model = "MK3";
            car.Year = 1992;
            car.FuelQuantity = 200;
            car.FuelConsumption = 200;

            car.Drive(2000);

            Console.WriteLine(car.WhoAmI());
        }
    }
}
