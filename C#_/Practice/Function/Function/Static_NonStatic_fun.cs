using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function
{
    internal class Static_NonStatic_fun
    {
        static int x;
        int y;
        void NonStaticMethod()
        {
            Console.WriteLine("non static function");
        }
        static void StaticMethod()
        {
            Console.WriteLine("static function");
        }
        static void Main(string[] args)
        {
            x = 200;
            Static_NonStatic_fun staticobj=new Static_NonStatic_fun();
            staticobj.y = 100;
            Console.WriteLine("static variable without accessing object" +x);
            Console.WriteLine("non static variable with accessing object" +staticobj.y);
            StaticMethod();
            staticobj.NonStaticMethod();
            Console.ReadLine();
        }

    }
}
