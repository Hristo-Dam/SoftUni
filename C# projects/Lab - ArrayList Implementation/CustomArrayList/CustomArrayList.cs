using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ImplementArrayList
{
    internal class CustomArrayList<T> : IEnumerable<T>
    {
        private const int INITIAL_CAPACITY = 4;

        private int _count;
        private T[] _array;

        public CustomArrayList()
        {
            _array = new T[INITIAL_CAPACITY];
            _count = 0;
        }

        public int Count
        {
            get { return this._count; }
            private set { this._count = value; }
        }
        public T this[int index]
        {
            get { return this._array[index]; }
            set { this._array[index] = value; }
        }

        public void Add(T item)
        {
            Resize();
            this._array[Count] = item;
            this.Count++;
        }
        public void Insert(int index, T item)
        {
            Resize();
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
        public int IndexOf(T item)
        {
            for (int i = 0; i < this.Count; i++)
            {
                if (this._array[i].Equals(item))
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
                    this.RemoveAt(i);
                    return;
                }
            }
        }

        private bool IsIndexValid(int index)
        {
            if (index >= 0 && index < this.Count)
            {
                return true;
            }
            return false;
        }
        private void Resize()
        {
            if (this.Count == this._array.Length)
            {
                T[] resizedArray = new T[this._array.Length * 2];
                for (int i = 0; i < this._array.Length; i++)
                {
                    resizedArray[i] = this._array[i];
                }
                this._array = resizedArray;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < this.Count; i++)
            {
                yield return this._array[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
