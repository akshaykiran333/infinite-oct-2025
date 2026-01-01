using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo
{
    public delegate void PrintNumberDelegate(int number);
    public delegate string GreetDelegate(string str);

    internal class Program
    {
        
        static void Main(string[] args)
        {
            // singleCast delegate
            PrintNumberDelegate printNumberDelegate = PrintNumber;
            GreetDelegate greetDel = GreetMessage;
            printNumberDelegate(15000);
            printNumberDelegate(25000);

            // MultiCast delegate

            printNumberDelegate += DisplayMessage;
            printNumberDelegate += ShowDate;
            Console.WriteLine("\n\n Multicast delegate demo");
            printNumberDelegate(30000);

            //Removing a method from invocation list
            printNumberDelegate -= DisplayMessage;

            Console.WriteLine("\n\n Multicast delegate demo afer removing reference od DisplayMessage");
            printNumberDelegate(30000);
            Console.WriteLine(greetDel("sai"));
            Console.ReadLine();
        }
        public static void PrintNumber(int number)
        {
            Console.WriteLine("number{0:C}:", number);
        }
        public static void DisplayMessage(int customerId)
        {
            Console.WriteLine($"Hello from {customerId}");
        }
        public static void ShowDate(int dummy)
        {
            Console.WriteLine(DateTime.Now.ToShortDateString());
        }
        public static string GreetMessage(string str)
        {
            return "Hello" + str;
        }
    }
}
