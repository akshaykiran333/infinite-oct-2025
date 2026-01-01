using First_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using First_MVC.Models;

namespace First_MVC.Controllers
{
    public class HRController : Controller
    {
        // GET: HR
      

        //1. binding a model object to view
        public ActionResult DisplayEmployee()
        {
            Employee employee = new Employee() { ID = 100, Name = "kiran", Age = 23 };
            return View(employee);
        }

        //2. binding a collection model object to view

        public ActionResult EmployeeList()
        {
            List<Employee> emplist = new List<Employee>()
            {
                new Employee{ID=10,Name="Ragul",Age=30},
                new Employee{ID=11,Name="Mani",Age=35 },
                new Employee{ID=12,Name="sai",Age=60}
            };
            return View(emplist);
        }

        //3.calling another view and passing model obj
        public ActionResult Index()
        {
            List<Department> dlist = new List<Department>()
            {
                new Department {Id=1,Departmnt="AIML"},
                new Department {Id=2,Departmnt="CSE" },
                new Department {Id=3,Departmnt="ECE" },
                new Department {Id=4,Departmnt="EEE" },
            };
            return View("DepartmentList",dlist);
        }

        //receiving view
        public ActionResult DepartmentList(Department d)
        {
            return View();
        }
    }
}