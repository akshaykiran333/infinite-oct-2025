using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramewrkAssign
{
    public class CRUD
    {
        Model1 dc = new Model1();

        ///
        public void insertnewEmployees()
        {
            try
            {
                Employees e = new Employees()
                {
                    Empid = "E101",
                    EmpName = "akshayk",
                    DepartmentName = "IT",
                    Salary = 49000,
                    YearOfJoining = 1990
                };
                dc.Employee.Add(e);
                int re = dc.SaveChanges();
                Console.WriteLine("Total record inserted is: " + re);
            }
            catch (Exception ex)
            {
                var res = dc.GetValidationErrors();
                foreach (var err in res)
                {
                    if (err.ValidationErrors.Count > 0)
                    {
                        foreach (var error in err.ValidationErrors)
                        {
                            Console.WriteLine(error);
                        }
                    }
                }
            }
        }
        ///
        public void ShowAllEmployees()
        {
            try
            {
                var employees = dc.Employee.ToList();

                foreach (var e in employees)
                {
                    Console.WriteLine($"{e.Empid} {e.EmpName} {e.DepartmentName} {e.Salary}");
                }
            }
            catch (Exception ex)
            {
                var res = dc.GetValidationErrors();
                foreach (var err in res)
                {
                    if (err.ValidationErrors.Count > 0)
                    {
                        foreach (var error in err.ValidationErrors)
                        {
                            Console.WriteLine(error);
                        }
                    }
                }
            }
        }
        public void UpdateEmployee()
        {
            try
            {
                var emp = dc.Employee.Where(e => e.Empid == "E101").FirstOrDefault();
                if (emp != null)
                {
                    emp.Salary = 45000;
                    dc.SaveChanges();
                    Console.WriteLine("Employee Salary Updated");
                }
            }
            catch (Exception ex)
            {
                var res = dc.GetValidationErrors();
                foreach (var err in res)
                {
                    if (err.ValidationErrors.Count > 0)
                    {
                        foreach (var error in err.ValidationErrors)
                        {
                            Console.WriteLine(error);
                        }
                    }
                }
            }
        }
        public void DeleteEmployeeRecord()
        {
            try
            {
                var emp = dc.Employee.Where(e => e.Empid == "E101").First();
                if (emp != null)
                {
                    dc.Employee.Remove(emp);
                    dc.SaveChanges();
                    Console.WriteLine("Employee deleted");
                }
            }
            catch (Exception ex)
            {
                var res = dc.GetValidationErrors();
                foreach (var err in res)
                {
                    if (err.ValidationErrors.Count > 0)
                    {
                        foreach (var error in err.ValidationErrors)
                        {
                            Console.WriteLine(error);
                        }
                    }
                }
            }
        }
    }
}
