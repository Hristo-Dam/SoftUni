using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BoxOfT
{
    public class Box<T>
    {
        private Stack<T> _stack;
        private int _count;

        public Box()
        {
            _stack = new Stack<T>();
            _count = 0;
        }

        public int Count
        {
            get { return _count; }
            private set { _count = value; }
        }

        public void Add(T item)
        {
            _stack.Push(item);
            Count = _stack.Count;
        }
        public T Remove()
        {
            T result = _stack.Pop();
            Count = _stack.Count;
            return result;
        }
    }
}
