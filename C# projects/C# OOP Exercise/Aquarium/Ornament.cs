using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aquarium
{
    public class Ornament : Decoration
    {
        public Ornament(int comfort, decimal price) : base(comfort, price)
        {
            this.Comfort = 1;
            this.Price = 5;
        }
    }
}
