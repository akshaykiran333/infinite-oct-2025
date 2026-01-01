using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<EmployeeManagementSystem> employeesList = new List<EmployeeManagementSystem>()
            {
                new EmployeeManagementSystem(101, "Akshay", "IT", 60000, 4),
                new EmployeeManagementSystem(102, "Kiran", "HR", 55000, 3),
                new EmployeeManagementSystem(103, "Ram", "Finance", 780000, 8),
                new EmployeeManagementSystem(104, "Ravi", "IT", 90000, 10),
                new EmployeeManagementSystem(105, "Mani", "Sales", 45000, 2),
                new EmployeeManagementSystem(106, "Pradeep", "HR", 52000, 4),
                new EmployeeManagementSystem(107, "Pavan", "Finance", 45000, 2),
                new EmployeeManagementSystem(108, "Ganesh", "HR", 65000, 5),
                new EmployeeManagementSystem(109, "Chiru", "Sales", 37000, 1),
                new EmployeeManagementSystem(1010, "Hanu", "IT", 95000, 10)
            };
            //

            Console.WriteLine("List All Employees");
            foreach (var emp in employeesList)
            {
                Console.WriteLine(emp.Id + "\t" + emp.Name + "\t" + emp.Department + "\t" + emp.Salary + "\t" + emp.Experience + " yrs");

            }



            //


            var SalaryAbove50k = employeesList.Where(e => e.Salary > 50000);
            var ItEmployees = employeesList.Where(e => e.Department == "IT");
            var ExpAbove5 = employeesList.Where(e => e.Experience > 5);
            var StartsWithA = employeesList.Where(e => e.Name.StartsWith("A"));

            Console.WriteLine("\nFiltered Results");

            Console.WriteLine("\nEmployees with Salary > 50,000:");
            foreach (var emp in SalaryAbove50k)
            {
                Console.WriteLine(emp.Id + "\t" + emp.Name + "\t" + emp.Department + "\t" + emp.Salary + "\t" + emp.Experience + " yrs");
            }

            Console.WriteLine("\nEmployees in IT Department:");
            foreach (var emp in ItEmployees)
            {
                Console.WriteLine(emp.Id + "\t" + emp.Name + "\t" + emp.Department + "\t" + emp.Salary + "\t" + emp.Experience + " yrs");
            }

            Console.WriteLine("\nEmployees with Experience > 5 years:");
            foreach (var emp in ExpAbove5)
            {
                Console.WriteLine(emp.Id + "\t" + emp.Name + "\t" + emp.Department + "\t" + emp.Salary + "\t" + emp.Experience + " yrs");
            }

            Console.WriteLine("\nEmployees whose name starts with 'A':");
            foreach (var emp in StartsWithA)
            {
                Console.WriteLine(emp.Id + "\t" + emp.Name + "\t" + emp.Department + "\t" + emp.Salary + "\t" + emp.Experience + " yrs");
            }


            // 


            var sortByName = employeesList.OrderBy(e => e.Name);
            var sortBySalaryDesc = employeesList.OrderByDescending(e => e.Salary);
            var sortByExperience = employeesList.OrderBy(e => e.Experience);

            Console.WriteLine("\n Sorted Results");

            Console.WriteLine("\nSorted by Name (A–Z):");
            foreach (var emp in sortByName)
            {
                Console.WriteLine(emp.Id + "\t" + emp.Name + "\t" + emp.Department + "\t" + emp.Salary + "\t" + emp.Experience + " yrs");
            }

            Console.WriteLine("\n Sorted by Salary (High-Low):");
            foreach (var emp in sortBySalaryDesc)
            {
                Console.WriteLine(emp.Id + "\t" + emp.Name + "\t" + emp.Department + "\t" + emp.Salary + "\t" + emp.Experience + " yrs");
            }

            Console.WriteLine("\n Sorted by Experience (Low-High):");
            foreach (var emp in sortByExperience)
            {
                Console.WriteLine(emp.Id + "\t" + emp.Name + "\t" + emp.Department + "\t" + emp.Salary + "\t" + emp.Experience + " yrs");
            }

            
            // 
            
            var promotionList = employeesList.Where(e => e.Experience > 7);

            Console.WriteLine("\n Promotion List");
            foreach (var emp in promotionList)
            {
                Console.WriteLine(emp.Id + "\t" + emp.Name + "\t" + emp.Department + "\t" + emp.Salary + "\t" + emp.Experience + " yrs");
            }
        }
    }
}

