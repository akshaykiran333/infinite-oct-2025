using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Collections
{
    internal class EmployeeManagementSystem
    {
       
            public int Id { get; set; }
            public string Name { get; set; }
            public string Department { get; set; }
            public double Salary { get; set; }
            public int Experience { get; set; }

        public EmployeeManagementSystem(int id, string name, string department, double salary, int experience)
        {
            Id = id;
            Name = name;
            Department = department;
            Salary = salary;
            Experience = experience;
        }
    }
}
