using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aquarium
{
    public class FreshwaterFish : Fish
    {
        public FreshwaterFish(string name, string species, decimal price) : base(name, species, price)
        {
            this.Size = 3;
        }

        public override void Eat()
        {
            throw new NotImplementedException();
        }
    }
}
