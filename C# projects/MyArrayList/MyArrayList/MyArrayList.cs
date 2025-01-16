using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyArrayList
{
    public class CustomArrayList<T>
    {
        private const int INITIAL_CAPACITY = 4;
        private T[] _array;
        private int _capacity;
        private int _count;
        public int Count
        {
            get { return _count; }
            private set { _count = value; }
        }

        public CustomArrayList()
        {
            _array = new T[INITIAL_CAPACITY];
            _count = 0;
        }
        public void Add(T item)
        {
            if (this.Count == this._array.Length)
            {
                Resize();
            }
            _array[Count] = item;
            Count++;
        }
        public void Insert(int index, T item)
        {
        }
        //public int IndexOf(T item)
        //{
        //}
        public void Clear()
        {
            _array = new T[INITIAL_CAPACITY];
            _count = 0;
        }
        public bool Contains(T item)
        {
            for (int i = 0; i < this.Count; i++)
            {
                if (_array[i].Equals(item))
                {
                    return true;
                }
            }
            return false;
        }
        //public T this[int index]
        //{
        //}
        //public T RemoveAt(int index)
        //{
        //}
        //public int Remove(T item)
        //{
        //}
        private void Resize()
        {

        }
    }

}
