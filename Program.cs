using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            Priorty_Queue<int> q = new Priorty_Queue<int>((int a, int b) =>
            {
                return a < b;
            });

            for (int i = 0; i < 5; i++)
            {
                q.Push(i);
            }

            q.Push(-1);
            q.Push(-3);
            q.Push(-5);

            q.PrintAll();
            while (q.Size != 0)
            {
                int number = q.Top();
                Console.WriteLine("Value : " + number);
                q.Pop();
                q.PrintAll();
            }

            //StackArray<int> stack = new StackArray<int>();

            //for(int i = 0; i < 5; i++)
            //{
            //    stack.Push(i);
            //}

            //while(stack.Size != 0)
            //{
            //    Console.WriteLine(stack.Pop());
            //}

            //QueueList<int> queue = new QueueList<int>();

            //for(int i = 0; i < 5; i++)
            //{
            //    queue.Enqueue(i);
            //}

            //while(queue.Size != 0)
            //{
            //    Console.WriteLine(queue.Peek());
            //    queue.Dequeue();
            //}


            //StackList<int> stack = new StackList<int>();
            //for(int i = 0; i < 5; i++)
            //{
            //    stack.Push(i);
            //}

            //while(stack.Size != 0)
            //{
            //    Console.WriteLine(stack.Peek());
            //    stack.Pop();
            //}

            //LinkList<int> list = new LinkList<int>();
            //for(int i = 0; i < 5; i++)
            //{
            //    list.AddLast(i);
            //}

            //list.PrintAll();

            //Node<int> tempNode = list.GetNodeIndex(3);
            //list.Insert(tempNode, 1);

            //list.PrintAll();

            //list.DeleteLast();
            //list.DeleteLast();

            //list.PrintAll();

            //list.DeleteFirst();
            //list.DeleteFirst();

            //list.PrintAll();
        }
    }
}
