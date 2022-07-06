using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    class Priorty_Queue<T>
    {
        public delegate bool Compare(T a, T b);
        private Compare cmp;
        public Compare Comp
        {
            set { cmp = value; }
        }

        private T[] array;
        private int arraySize;
        private int size;

        public int Size
        {
            get { return size - 1; }
        }

        public Priorty_Queue(Compare tempCmp)
        {
            arraySize = 2;
            array = new T[arraySize];
            size = 1;
            cmp = tempCmp;
        }

        public void Push(T value)
        {
            if (size == arraySize)
            {
                arraySize <<= 1;
                T[] tempArray = new T[arraySize];
                for (int i = 1; i < size; i++)
                {
                    tempArray[i] = array[i];
                }
                array = tempArray;
            }

            Insert(value);
        }

        private void Insert(T value)
        {
            int index = size;
            array[size] = value;
            size++;
            while (index > 1)
            {
                bool flag = cmp(array[index], array[index >> 1]);
                if (flag) Swap(index, index >> 1);
                else break;
                index >>= 1;
            }
        }


        public T Top()
        {
            if (size == 1) return default(T);
            return array[1];
        }

        public void Pop()
        {
            Delete();
        }

        private T Delete()
        {
            T deleteNum = array[1];
            array[1] = array[size - 1];
            array[size - 1] = default(T);
            size--;

            int index = 1;

            int bias;
            for (bias = 1; bias < size; bias <<= 1) ;
            bias >>= 1;

            while (index < bias)
            {
                int left = index << 1;
                int right = (index << 1) + 1;

                if (left >= size) break;

                if (right >= size)
                {
                    if (CmpArray(index, left))
                    {
                        index = left;
                        continue;
                    }
                    else break;
                }
                if (cmp(array[left], array[right]) == false) Swap(left, right);

                if (CmpArray(index, left)) index = left;
                else break;
            }
            return deleteNum;
        }

        bool CmpArray(int first, int second)
        {
            if (cmp(array[first], array[second]) == false)
            {
                Swap(first, second);
                return true;
            }
            return false;
        }

        void Swap(int from, int to)
        {
            T temp = array[from];
            array[from] = array[to];
            array[to] = temp;
        }

        public void PrintAll()
        {
            for (int i = 1; i < size; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine("");
        }
    }
}
