using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LinkedList
{
    public class MyLinkedList
    {
        private class Node
        {
            private object element;
            private Node next;

            public object Element
            {
                get { return element; }
                set { element = value; }
            }

            public Node Next
            {
                get { return next; }
                set { next = value; }
            }

            public Node(object element, Node prevNode)
            {
                this.Element = element;
                prevNode.Next = this;
            }

            public Node(object element)
            {
                this.Element = element;
                this.Next = null;
            }
        }

        private Node head;
        private Node tail;
        private int count;

        public LinkedList()
        {
            this.head = null;
            this.tail = null;
            this.count = 0;
        }

        public void Add(object item)
        {
            Node newNode = new Node(item);
            Node newNode2 = new Node(item);


            if (head == null)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                //tail = new Node(item, tail);
                tail.Element = item;
                tail.Next = tail;
            }

            count++;
        }

        public object Remove(int index)
        {
            if (index < 0 || index >= count)
            {
                throw new IndexOutOfRangeException("Index out of range");
            }

            Node current = head;
            Node previous = null;


            for (int i = 0; i < index; i++)
            {
                previous = current;
                current = current.Next;
            }

            if (previous != null)
            {
                previous.Next = current.Next;
                if (current == tail)
                {
                    tail = previous;
                }
            }
            else
            {
                head = head.Next;
                if (head == null)
                {
                    tail = null;
                }
            }

            count--;
            return current.Element;
        }

        public int Remove(object item)
        {
            Node current = head;
            Node previous = null;
            int index = 0;

            while (current != null)
            {
                if (Equals(current.Element, item))
                {
                    if (previous != null)
                    {
                        previous.Next = current.Next;
                        if (current == tail)
                        {
                            tail = previous;
                        }
                    }
                    else
                    {
                        head = head.Next;
                        if (head == null)
                        {
                            tail = null;
                        }
                    }

                    count--;
                    return index;
                }

                previous = current;
                current = current.Next;
                index++;
            }

            return -1; // Item not found
        }

        public int IndexOf(object item)
        {
            Node current = head;
            int index = 0;

            while (current != null)
            {
                if (Equals(current.Element, item))
                {
                    return index;
                }

                current = current.Next;
                index++;
            }

            return -1; // Item not found
        }

        public bool Contains(object item)
        {
            return IndexOf(item) != -1;
        }

        public object this[int index]
        {
            get
            {
                if (index < 0 || index >= count)
                {
                    throw new IndexOutOfRangeException("Index out of range");
                }

                Node current = head;
                for (int i = 0; i < index; i++)
                {
                    current = current.Next;
                }

                return current.Element;
            }
        }

        public int Count
        {
            get { return count; }
            private set { count = value; }
        }
    }
}
