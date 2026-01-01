using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    internal class Department
    {
        int departmentId;
        string departmentName, deptLocation;

        public Department()
            {
            departmentId=10001;
            departmentName="AIML";
            deptLocation= "Hyd";
            Console.WriteLine("default or parameterless constructor called");
            }
        public Department(int id, string name, string location)
        {
            Console.WriteLine("parametarised constructor called");
            this.departmentId=id;
            this.departmentName=name;
            this.deptLocation=location;
        }
        public Department(Department dept)
        {
            Console.WriteLine("copy constructor called");
            this.departmentId = 1011;
            this.departmentName = "HR";
            this.deptLocation = dept.deptLocation;
        }
        public void getDepartmentInfo()
        {
            Console.WriteLine("enter dept Id");
            departmentId=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter dept name");
            departmentName=Console.ReadLine();
            Console.WriteLine("enter dept location");
            deptLocation = Console.ReadLine(); 

        }
        public void DisplayDepartmentInfo()
        {
            Console.WriteLine("Dept details");
            Console.WriteLine("Id:" +departmentId);
            Console.WriteLine("name:" +departmentName);
            Console.WriteLine("location:" +deptLocation);
           
        }
}
}

