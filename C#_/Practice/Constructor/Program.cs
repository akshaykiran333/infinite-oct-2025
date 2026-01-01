using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Department dept= new Department();
            dept.DisplayDepartmentInfo();
            Department dpcon1 = new Department(1002, "IT", "Bengaluru");
            dpcon1.DisplayDepartmentInfo();

            Department dpcon3 = new Department(1003, "SE", "Vizag");
            dpcon3.DisplayDepartmentInfo();

            Department dpcon4 = new Department(dpcon3);
            dpcon4.DisplayDepartmentInfo();
            Console.ReadLine();

        }
    }
}
