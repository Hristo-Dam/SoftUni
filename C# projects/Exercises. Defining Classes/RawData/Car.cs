using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawData
{
    public class Car
    {
        const int TIRES_COLLECTON_SIZE = 4;

        private string _model;
        private Engine _engine;
        private Cargo _cargo;
        public Tire[] _tiers = new Tire[TIRES_COLLECTON_SIZE];
        
        public Car(string model, Engine engine, Cargo cargo, Tire[] tires)
        {
            Model = model;
            Engine = engine;
            Cargo = cargo;
            _tiers = tires;
        }

        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }
        public Engine Engine
        {
            get { return _engine; }
            set { _engine = value; }
        }
        public Cargo Cargo
        {
            get { return _cargo; }
            set { _cargo = value; }
        }
    }
}
