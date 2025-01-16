using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListOfT
{
    public class CustomListT<T>
    {
        private const int INITIAL_CAPACITY = 4;

        private T[] _array;
        private int _count;
        private int _capacity;

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

        public CustomListT()
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
            this._array[Count] = item;
            this.Count++;
        }
        public void Insert(int index, T item)
        {
            if (this.Count == this._array.Length)
            {
                Resize();
            }

            if (IsIndexValid(index))
            {
                for (int i = this._array.Length - 1; i > index; i--)
                {
                    this._array[i] = this._array[i - 1];
                }
                _array[index] = item;
                this.Count++;
            }
            else
            {
                throw new IndexOutOfRangeException("Index bigger than array!");
            }
        }
        public void RemoveAt(int index)
        {
            if (IsIndexValid(index))
            {
                this._array[index] = default;

                for (int i = index; i < Count - 1; i++)
                {
                    this._array[i] = this._array[i + 1];
                }

                this.Count--;
            }
        }
        public void Remove(T item)
        {
            for (int i = 0; i < Count; i++)
            {
                if (this._array[i].Equals(item))
                {
                    RemoveAt(i);
                    return;
                }
            }
        }
        public int IndexOf(T item)
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
            _array = new T[INITIAL_CAPACITY];
            _count = 0;
        }
        public bool Contains(T item)
        {
            if (IndexOf(item) != -1)
            {
                return true;
            }
            return false;
        }
        public T this[int index]
        {
            get { return this._array[index]; }
            set { this._array[index] = value; }
        }
        private void Resize()
        {
            T[] newArray = new T[_array.Length * 2];

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
