using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedRacing
{
    public class Car
    {
        private string _model;
        private double _fuelAmount;
        private double _fuelConsumptionPer1km;
        private double _traveledDistance;

        public Car(string model, double fuelAmount, double fuelConsumptionPer1km)
        {
            this.Model = model;
            this.FuelAmount = fuelAmount;
            this.FuelConsumptionPer1km = fuelConsumptionPer1km;
            this.TraveledDistance = 0.0;
        }

        public string Model
        {
            get { return _model; }
            set { this._model = value; }
        }
        public double FuelAmount
        {
            get { return _fuelAmount; }
            set { this._fuelAmount = value; }
        }
        public double FuelConsumptionPer1km
        {
            get { return _fuelConsumptionPer1km; }
            set { this._fuelConsumptionPer1km = value; }
        }
        public double TraveledDistance
        {
            get { return _traveledDistance; }
            set { this._traveledDistance = value; }
        }

        public void Calculate(string carModel, double amountOfKm)
        {
            if (this.FuelAmount >= this.FuelConsumptionPer1km * amountOfKm)
            {
                this.FuelAmount -= amountOfKm * this.FuelConsumptionPer1km;
                this.TraveledDistance += amountOfKm;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for thedrive");
            }
        }
    }
}
