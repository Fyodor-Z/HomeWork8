using System;
using System.Collections;
using System.Collections.Generic;

namespace MyQueueProgram
{
    class MyQueue
    {
        private List<object> content;

        public int Count
        {
            get
            { return content.Count; }
        }


        public MyQueue()
        {
            content = new List<object>();
        }
        public void Enqueue(Object obj)
        {
            content.Add(obj);
        }

        public object Dequeue()
        {
            object result;
            if (content.Count > 0)
            {
                result = content[0];
                content.RemoveAt(0);
                return result;
            }
            else
            {
                return null;
            }

        }

        public object Peek()
        {
            if (content.Count > 0)
            {
                return content[0];
            }
            else
            {
                return null;
            }
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Example of using MyQueue for stings");
            Console.WriteLine();

            MyQueue strQueue = new MyQueue();
            strQueue.Enqueue("FirstString");
            strQueue.Enqueue("SecondString");
            strQueue.Enqueue("ThirdString");
            strQueue.Enqueue("FourthString");

            while (strQueue.Count > 0)
            {
                Console.Write($"{(string)strQueue.Dequeue()} has been deleted from the queue, ");
                if (strQueue.Peek() != null)
                {
                    Console.WriteLine($"{(string)strQueue.Peek()} is first now");
                }
                else
                {
                    Console.WriteLine("queue is empty now");
                }

            }
            Console.ReadKey();


        }
    }
}
