using First_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace First_MVC.Controllers
{
    public class DemoController : Controller
    {
        // GET: Demo
        public ActionResult Index()
        {
            return View();
        }

        //1.Normal method
        public string NormalMethod()
        {
            return "welcome to infinite.........";
        }

        //2. ViewResult

        public  ViewResult ViewMethod()
        {
            return View();
        }

        //3.ContentResult
        public ContentResult ContentMethod()
        {
            // return Content("Hello this is Akshay", "text/plain");
            return Content("<h1 style=color:red;>Happy new year 2026</h1>");
        }
        //4. EmptyResult

        public EmptyResult EmptyMethod()
        {
            int amount = 25000;
            float si = (amount * 3 * 3) / 100;
            return new EmptyResult();
      
        }

        //5. Redirect

        public ActionResult redirectMethod()
        {
            //  return RedirectToAction("ContentMethod");   //redirect to othr action method of same control

            return RedirectToAction("index", "home");      //redircting to index page
        }

        //6. Json rslt
        public JsonResult JsonMethod()
        {
            Employee employee = new Employee() { ID = 101, Name = "akshay", Age = 23 };
            return Json(employee,JsonRequestBehavior.AllowGet);
        }
    }
}