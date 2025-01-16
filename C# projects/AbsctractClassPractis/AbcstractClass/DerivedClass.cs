using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace AbcstractClass
{
    public class DerivedClass : AbstractClass
    {
        public override int Calculate(int x)
        {
            int result;
            result = x += 1;
            return result;
        }
    }
}
