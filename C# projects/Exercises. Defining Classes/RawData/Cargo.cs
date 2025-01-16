using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawData
{
    public class Cargo
    {
        private string _type;
        private int _weight;

        public Cargo()
        {

        }
        public Cargo(int weight, string type)
        {
            Weight = weight;
            Type = type;
        }

        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }
        public int Weight
        {
            get { return _weight; }
            set { _weight = value; }
        }
    }
}
