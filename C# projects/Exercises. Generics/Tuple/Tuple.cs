using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuple
{
    public class Tuple<T, V>
    {
        private T _item1;
        private V _item2;

        public T Item1
        {
            get { return _item1; }
            set { _item1 = value; }
        }

        public V Item2
        {
            get { return _item2; }
            set { _item2 = value; }
        }
    }
}
