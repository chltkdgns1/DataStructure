using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    class QueueList<T>
    {
        private LinkList<T> m_list;

        public QueueList()
        {
            m_list = new LinkList<T>();
        }

        public void Enqueue(T value)
        {
            m_list.AddLast(value);
        }

        public void Dequeue()
        {
            m_list.DeleteFirst();
        }

        public T Peek()
        {
            return m_list.GetFirstValue();
        }

        public int Size
        {
            get { return m_list.Size; }
        }
    }
}
