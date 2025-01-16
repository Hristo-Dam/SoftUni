using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Cat : Animal
    {
        public Cat(string name, string favoriteFood) : base(name, favoriteFood)
        {

        }

        public override string ExplaneSelf()
        {
            return base.ExplaneSelf() + "\nMEEOW";
        }
    }
}
