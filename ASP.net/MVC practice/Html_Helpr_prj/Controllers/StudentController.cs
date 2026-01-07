using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Html_Helpr_prj.Models;
namespace Html_Helpr_prj.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }

        //1. strongly typed helper
        public ActionResult Strongly_Typed_Helper()
        {
            return View();
        }

        //2.Templater helper individual

        public ActionResult TemplatedHelper()
        {
            return View();
        }

        //3. templated helpr for entire model (1. editor template)
        public ActionResult TemplateForModel()
        {
            return View();
        }

        //4. Disply template

        public ActionResult StudentDisplay()
        {
            Student student = new Student()
            {
                Rno = 10,
                Name="Ragul",
                Address ="Chennai",
            };
            ViewData["stddata"]=student;
            return View(student);
        }
        //5. standard helper

        public ActionResult StandardHelper()
        {
            return View();  
        }
    }
}