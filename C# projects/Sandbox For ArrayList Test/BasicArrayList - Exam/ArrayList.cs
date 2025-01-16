using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicArrayList___Exam
{
    internal class ArrayList
    {
        private const int INITIAL_CAPACITY = 2;
        private int[] _array;
        private int _count;

        public ArrayList()
        {
            this._array = new int[INITIAL_CAPACITY];
        }

        public int Count
        {
            get { return this._count; }
            private set { this._count = value; }
        }

        public void Add(int item)
        {
            if (this.Count == this._array.Length)
            {
                int[] copy = new int[this._array.Length * 2];
                for (int i = 0; i < this._array.Length; i++)
                {
                    copy[i] = this._array[i];
                }
                this._array = copy;
            }

            this._array[this.Count] = item;
            this.Count++;
        }

        public int CountFreePositions()
        {
            int result;
            if (this.Count == this._array.Length)
            {
                result = 0;
            }
            else
            {
                result = this._array.Length - this.Count;
            }
            return result;
        }

        public void Cut(int numberOfElementsToRemove)
        {
            if (numberOfElementsToRemove >= 0 && numberOfElementsToRemove <= this.Count)
            {
                int[] newArr = new int[this.Count - numberOfElementsToRemove];
                Array.Copy(this._array, newArr, this.Count - numberOfElementsToRemove);
                this._array = newArr;
                this.Count = this._array.Length;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Number is out of range.");
            }
        }

        public int Change(int element, int newElement)
        {
            for (int i = 0; i < this.Count; i++)
            {
                if (this._array[i] == element)
                {
                    this._array[i] = newElement;
                    return i;
                }
            }
            return -1;
        }
    }
}
