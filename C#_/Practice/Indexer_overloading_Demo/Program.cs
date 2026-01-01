using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer_overloading_Demo
{
    public class EmployeeDirectory
    {
        public string[] EmpNames = { "Akshay", "sai", "mani", "ram" };
        private int[] EmpIds = { 101, 102, 103, 104 };
        public string this[int index]
        {
            get { return EmpNames[index]; }
            set { EmpNames[index] = value; }
        }
        public string this[string Empid]
        {
            get
            {
                for (int i = 0; i < EmpIds.Length; i++)
                {
                    
                      if (EmpIds[i].ToString() == Empid)
                       return EmpNames[i];
                 }
                    return "Employee not found";
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            EmployeeDirectory empDir = new EmployeeDirectory();
            Console.WriteLine(empDir[1]);
            Console.WriteLine(empDir["103"]);
            Console.ReadLine();
        }
    }
}
