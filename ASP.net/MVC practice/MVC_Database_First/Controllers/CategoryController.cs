using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Database_First.Models;
namespace MVC_Database_First.Controllers
{
    public class CategoryController : Controller
    {
        infinite2025Entities db = new infinite2025Entities();

        // GET: Category
        public ActionResult Index()
        {
            //1. below naction method uses scaffolded view
            List<Employee> catlist = db.Employees.ToList();

            return View(catlist);
        }
        //2. below action method does not use scaffolded view

        public ActionResult getcategorydetails()
        {
            List<Employee> catlist = db.Employees.ToList();
            return View(catlist);

        }

        //3. adding or inserting new category

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Employee employee)
        {
            db.Employees.Add(employee);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        //4. delete
        public ActionResult Delete(int id)
        {
            Employee emp = db.Employees.Find(id);
            return View(emp);
        }
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteEmployee(int Id)
        {
            Employee emp = db.Employees.Find(Id);
            db.Employees.Remove(emp);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        //.Edit
        //public ActionResult Edit(int id)
        //{
        //    Employee emp = db.Employees.Find(id);
        //    return View(emp);
        //}
        //[HttpPost, ActionName("Edit")]

        //public ActionResult EditCategory(int Id)
        //{
        //    Employee emp = db.Employees.Find(Id);
        //    db.Employees.AddOrUpdate(emp);
        //    db.SaveChanges();
        //    return RedirectToAction("Index");
        //}
        public ActionResult Edit(int Id) 
        { 
            Employee emp = db.Employees.Find(Id); 
            return View(emp);
        }
        [HttpPost, ActionName("Edit")]
        public ActionResult EditEmployee(Employee emp)
        {
            db.Employees.AddOrUpdate(emp);
            db.SaveChanges(); 
            return RedirectToAction("Index");
        }


        //categoryDetails
        //public ActionResult GetEmployeeByName()
        //{
        //    List<string> sortedcatlist = (from emp in db.Employees orderby emp.EmpName select emp.EmpName).ToList().ToList();

        //    return View(sortedcatlist);
        //}

    }
}