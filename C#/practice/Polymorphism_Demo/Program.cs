using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Overloading_Demo overloading = new Overloading_Demo();
            overloading.GetEmployeeInfo(1001);
            overloading.GetEmployeeInfo("Akshay");
            overloading.GetEmployeeInfo(1002, "sai");
            overloading.GetEmployeeInfo("Mani", 1003);
            Console.ReadLine();
        }
    }
}
