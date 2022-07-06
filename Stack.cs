using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    class StackList<T>
    {
        private LinkList<T> m_list;

        public StackList()
        {
            m_list = new LinkList<T>();
        }

        public void Push(T value)
        {
            m_list.AddLast(value);
        }

        public T Pop()
        {
            T value = m_list.GetLastValue();
            m_list.DeleteLast();
            return value;
        }

        public T Peek()
        {
            T value = m_list.GetLastValue();
            return value;
        }

        public int Size
        {
            get { return m_list.Size; }
        }
    }

    class StackArray<T>
    {
        private T[] array;

        private int size;
        private int arraySize;

        public int Size { get { return size; } }

        public StackArray()
        {
            arraySize = 1;
            array = new T[arraySize];
            size = 0;
        }

        public void Push(T value)
        {
            if (size == arraySize)
            {
                arraySize *= 2;
                T[] tempArray = new T[arraySize];
                for (int i = 0; i < size; i++)
                {
                    tempArray[i] = array[i];
                }
                array = tempArray;
            }
            array[size++] = value;
        }

        public T Pop()
        {
            if (size == 0) return default(T);
            T temp = array[--size];
            return temp;
        }

        public T Peek()
        {
            if (size == 0) return default(T);
            return array[size - 1];
        }
    }
}
