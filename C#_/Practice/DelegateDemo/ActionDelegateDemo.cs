using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo
{
    internal class ActionDelegateDemo
    {
        static void Main(string[] args)
        {
            /// Ex for Action delegate

            PrintNumberDelegate printDel = ConsolePrint;
            printDel(100);

            // Ex 2 Action delegate
            Action<int> printAction = ConsolePrint;
            printAction(200);

            //Action delegate with anonymous method
            Action<string> greet = delegate (string name)
            {
                Console.WriteLine("Hello from anonymous method" + name);
            };
            greet("Bob");

            Console.ReadLine();

        }
        public static void ConsolePrint(int i)
        {
            Console.WriteLine("consolePrint Function " + i);
        }
        public static void greetmessage(string name)
        {
            Console.WriteLine("Hello " + name);
        }
    }
}
