using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world");
            Console.Write("Welcome to the session");
            Console.WriteLine("Good mrng every one");
            
            //datatypes int
            int a = 10;
            int b = 20;
            Console.WriteLine(a + b);
            Console.WriteLine(a.GetType());
            //float
            float c = 5.235f;
            Console.WriteLine(c.GetType());
            //bool
            bool d = true;
            Console.WriteLine(d.GetType());
            //double
            double e = 50.35629;
            Console.WriteLine(e.GetType());
            //string
            string f = ("akshay kiran");
            Console.WriteLine(f.GetType());
            //char
            char  g = 'a';
            Console.WriteLine(g.GetType());
            Console.ReadKey();
            
        }
    }
}
