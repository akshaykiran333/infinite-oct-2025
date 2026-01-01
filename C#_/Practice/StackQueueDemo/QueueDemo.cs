using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace StackQueueDemo
{
    internal class QueueDemo
    {
        static void Main(string[] args)
        {
            Queue queue = new Queue();
            queue.Enqueue(10);
            queue.Enqueue(200);
            queue.Enqueue("hello");
            queue.Enqueue(true);
            queue.Enqueue("A");
            foreach (var item in queue)
            {
                Console.WriteLine(item);
                
            }
            queue.Dequeue();
            Console.WriteLine("After dequeue()" + queue.Count);
            Console.WriteLine("top item in queue" + queue.Peek());
            Console.ReadLine();
        }
    }
}
