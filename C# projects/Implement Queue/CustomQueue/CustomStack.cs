using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MyStack
{
    public class CustomStack<T>
    {
        private const int INITIAL_CAPACITY = 4;
        private object[] _array;
        private int _count;
        private int _capacity;

        public Queue()
        {
            _array = new object[INITIAL_CAPACITY];
            _count = 0;
        }

        public int Count
        {
            get { return _count; }
            private set { _count = value; }
        }

        public void Enqueue(T input)
        {
            _array[Count] = input;
            Count++;
        }

        private void Resize()
        {
            object[] newArray = new object[_array.Length * 2];

            Array.Copy(_array, newArray, _array.Length);
            _array = newArray;
        }

    }
}
