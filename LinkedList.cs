using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    class Node<T>
    {
        public Node<T> Before
        {
            get; set;
        }
        public Node<T> Next
        {
            get; set;
        }
        public T Value
        {
            get; set;
        }

        public Node()
        {
            Next = null;
            Before = null;
        }
        public Node(T value)
        {
            Value = value;
            Next = null;
            Before = null;
        }
    }

    class LinkList<T>
    {
        protected Node<T> head;
        protected Node<T> tail;

        private int size;

        public int Size
        {
            get { return size; }
        }

        public LinkList()
        {
            head = new Node<T>();
            tail = head;
            size = 0;
        }

        public void AddLast(T value)
        {
            Node<T> temp = new Node<T>(value);
            tail.Next = temp;
            temp.Before = tail;
            tail = temp;
            size++;
        }

        public void AddFirst(T value)
        {
            Node<T> temp = new Node<T>(value);

            Node<T> headNext = head.Next;
            head.Next = temp;
            temp.Before = head;
            temp.Next = headNext;
            headNext.Before = temp;
            size++;
        }

        public void Insert(Node<T> node, T value)
        {
            Node<T> temp = head.Next;
            while (temp != null)
            {
                if (temp == node)
                {
                    Node<T> createNode = new Node<T>(value);
                    Node<T> nextTemp = temp.Next;
                    temp.Next = createNode;
                    createNode.Before = temp;
                    createNode.Next = nextTemp;
                    nextTemp.Before = createNode;
                    size++;
                    break;
                }
                temp = temp.Next;
            }
        }

        public Node<T> GetNodeIndex(int index)
        {
            Node<T> temp = head.Next;
            int cnt = -1;
            while (temp != null)
            {
                cnt++;
                if (index == cnt) return temp;
                temp = temp.Next;
            }
            return null;
        }

        public void PrintAll()
        {
            Node<T> temp = head.Next;
            while (temp != null)
            {
                Console.WriteLine(temp.Value);
                temp = temp.Next;
            }

            Console.WriteLine("========");
        }

        public void DeleteLast()
        {
            Node<T> temp = tail.Before;
            if (temp == null) return;
            temp.Next = null;
            tail.Before = null;
            tail = temp;
            size--;
        }

        public void DeleteFirst()
        {
            Node<T> temp = head.Next;
            if (temp == null) return;

            if (temp.Next == null)
            {
                head.Next = null;
                temp.Before = null;
                size--;
                return;
            }

            head.Next = temp.Next;
            temp.Next.Before = head;
            temp.Next = null;
            temp.Before = null;
            size--;
        }

        public T GetLastValue()
        {
            return tail.Value;
        }

        public T GetFirstValue()
        {
            return head.Next.Value;
        }
    }
}
