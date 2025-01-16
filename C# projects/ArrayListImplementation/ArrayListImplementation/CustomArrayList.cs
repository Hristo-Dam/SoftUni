using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListImplementation
{
    public class CustomArrayList
    {
        private const int INITIAL_CAPACITY = 4;

        private object[] _array;
        private int _count;
        private int _capacity;

        public CustomArrayList()
        {
            _array = new object[INITIAL_CAPACITY];
            _count = 0;
        }

        public int Count
        {
            get { return _count; }
            private set { _count = value; }
        }
        public int Capacity
        {
            get { return _capacity; }
            private set { _capacity = value; }
        }

        public void Add(object item)
        {
            if (this.Count == this._array.Length)
            {
                Resize();
            }
            _array[Count] = item;
            Count++;
        }

        public int IndexOf(object item)
        {
            for (int i = 0; i < _array.Length; i++)
            {
                if (_array[i].Equals(item))
                {
                    return i;
                }
            }
            return -1;
        }
        public void Clear()
        {
            _array = new object[INITIAL_CAPACITY];
            _count = 0;
        }
        public bool Contains(object item)
        {
            if (IndexOf(item) != -1)
            {
                return true;
            }
            return false;
        }
        public object this[int index]
        {
            get { return this._array[index]; }
            set { this._array[index] = value; }
        }
        private void Resize()
        {
            object[] newArray = new object[_array.Length * 2];

            Array.Copy(_array, newArray, _array.Length);
            _array = newArray;
        }
        private bool IsIndexValid(int index)
        {
            if (index < 0 || index > this.Count)
            {
                return false;
            }
            return true;
        }
    }
}
