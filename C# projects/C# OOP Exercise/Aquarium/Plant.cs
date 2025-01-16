using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aquarium
{
    public class Plant : Decoration
    {
        public Plant(int comfort, decimal price) : base(comfort, price)
        {
            this.Comfort = 5;
            this.Price = 10;
        }
    }
}
