using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aquarium
{
    public abstract class Decoration
    {
        private int _comfort;
        private decimal _price;

        public Decoration(int comfort, decimal price)
        {
            this.Comfort = comfort;
            this.Price = price;
        }

        public int Comfort
        {
            get { return this._comfort; }
            set { this._comfort = value; }
        }
        public decimal Price
        {
            get { return this._price; }
            set { this._price = value; }
        }
    }
}
