using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace StackQueueDemo
{   
    //1.    Stack
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            stack.Push(10);
            stack.Push("hello");
            stack.Push(30.99);
            Console.WriteLine("Items in stack");
            foreach (var item in stack)
            {
                Console.WriteLine(item);
                
            }
            Console.WriteLine("top item in stack is" + stack.Peek());

            stack.Pop();
            Console.WriteLine("items in stack after pop");
            foreach (var item in stack)
            {
                Console.WriteLine(item);
                
            }
            Console.WriteLine("hello is there in stack or not" + stack.Contains("hello"));
            Console.WriteLine("total item in stack " + stack.Count);
            stack.Clear();
            Console.WriteLine("total item in stack after clearing" + stack.Count);
        }
    }
}
