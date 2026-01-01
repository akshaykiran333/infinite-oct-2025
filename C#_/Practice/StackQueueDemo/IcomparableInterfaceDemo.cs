using StackQueueDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackQueueDemo
{
    public class InfiniteEmployee : IComparable<InfiniteEmployee>
    {
        public int Empid { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public int Age { get; set; }
        public string Location { get; set; }

        public int CompareTo(InfiniteEmployee other)
        {
            return this.Empid.CompareTo(other.Empid);
        }
    }


    internal class IcomparableInterfaceDemo
    {
        static void Main(string[] args)
        {

            List<InfiniteEmployee> infiniteEmployees = new List<InfiniteEmployee>();
            infiniteEmployees.Add(new InfiniteEmployee { Empid = 2, Name = "Sakthivel", Salary = 9000, Age = 21, Location = "Hydrebad" });
            infiniteEmployees.Add(new InfiniteEmployee { Empid = 3, Name = "Madavi", Salary = 800000, Age = 23, Location = "Bangalore" });
            infiniteEmployees.Add(new InfiniteEmployee { Empid = 1807018, Name = "Kanishka Chandran", Salary = 37500, Age = 20, Location = "Hyderabad" });
            infiniteEmployees.Add(new InfiniteEmployee { Empid = 1807023, Name = "Deepalakshmi", Salary = 60000, Age = 21, Location = "Hyderabad" });
            infiniteEmployees.Add(new InfiniteEmployee { Empid = 6, Name = "Sairam", Salary = 18000, Age = 23, Location = "Chennai" });
            infiniteEmployees.Add(new InfiniteEmployee { Empid = 1807013, Name = "Akshay", Salary = 29000, Age = 23, Location = "Chennai" });

            infiniteEmployees.Add(new InfiniteEmployee { Empid = 1807004, Name = "keerthi", Salary = 21000, Age = 22, Location = "Hyderabad" });

            Console.WriteLine("Employee details are :");
            foreach (var emp in infiniteEmployees)
            {
                Console.WriteLine($"EmpId: {emp.Empid}, name:{emp.Name},salary:{emp.Salary},Age:{emp.Age},Location:{emp.Location}");

            }
            infiniteEmployees.Sort();
            Console.WriteLine("\nEmployee details after sorting by salary");
            foreach (var emp in infiniteEmployees)
            {
                Console.WriteLine($"EmpId:{emp.Empid},Name:{emp.Name},salary:{emp.Salary},age:{emp.Age},location:{emp.Location}");
                
            }
        }
    }
}

