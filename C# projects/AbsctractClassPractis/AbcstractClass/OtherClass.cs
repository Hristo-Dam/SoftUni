using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbcstractClass
{
    public class OtherClass : AbstractClass
    {
        public override int Calculate(int x)
        {
            int result;
            result = x * 2;
            return result;
        }
    }
}
