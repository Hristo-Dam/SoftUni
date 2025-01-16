using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementLinkedList
{
    public class CustomLinkedList
    {
        private class Node
        {
            private object _element;
            private Node _next;
            public object Element
            {
                get { return _element; }
                set { _element = value; }
            }
            public Node Next
            {
                get { return _next; }
                set { _next = value; }
            }
            public Node(object element)
            {
            }
            public Node(object element, Node prevNode)
            {
            }
        }

        private Node _head;
        private Node _tail;
        private int _count;

        public CustomLinkedList()
        {
            this._head = null;
            this._tail = null;
            this._count = 0;
        }

        public int Count
        {
            get { return _count; }
            private set { _count = value; }
        }

        public void Add(object item)
        {
            Node newNode = new Node(item);

            if (_head == null)
            {
                _head = newNode;
                _tail = newNode;
            }
            else
            {
                this._tail.Element = item;
                this._tail.Next = null;
            }

            this.Count++;
        }
        //public object Remove(int index)
        //{
        //}
        //public int RemoveAt(object item)
        //{
        //}
        //public int IndexOf(object item)
        //{
        //}
        //public bool Contains(object item)
        //{
        //}
        //public object this[int index]
        //{
        //}

    }
}
