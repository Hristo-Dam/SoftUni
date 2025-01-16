using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LinkedList
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
                this._element = element;
            }
            public Node(object element, Node prevNode)
            {
                prevNode.Next = this;
                this.Element = element;

            }
        }

        private Node _head;
        private Node _tail;
        private int _count;

        public int Count
        {
            get { return _count; }
            private set { _count = value; }
        }

        public void Add(object item)
        {
            Node newNode = new Node(item);

            if (this._head == null)
            {
                this._head = newNode;
                this._tail = newNode;
            }
            else
            {
                this._tail.Next = newNode;
                this._tail = newNode;
            }

            this.Count++;
        }
        //public object Remove(int index)
        //{
        //}
        public int IndexOf(object item)
        {
            Node currentNode = this._head;
            for (int i = 0; i < this.Count; i++)
            {
                if (currentNode.Element.Equals(item))
                {
                    return i;
                }
                currentNode = currentNode.Next;
            }
            return -1;
        }
        public bool Contains(object item)
        {
            int index = IndexOf(item);
            if (index != -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }



    }
}
