using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.Mvc;

namespace First_MVC.Controllers
{
    public class DataController : Controller
    {
        // GET: Data
        public ActionResult Index()
        {
            ////1. passing an obj to the view that will be used as a model
            //ViewBag.data = "Flowers list";
            //List<string> flowers = new List<string>
            //{
            //    "Roses","lilly","jasmine","raguls"
            //};
            //return View(flowers);
            List<string> stlist = TempData["stores"] as List<string>;
            return RedirectToAction("Test_TempData_across_controllers", "Demo");
        }

        //2. checking if the viewbag can pass on data to furthr requests
        public ActionResult TestDataTransfer()
        {
            ViewBag.data1 = "Data one";
            ViewBag.data2 = "data two";
            //return View();     //data passed to the currnt view

            return RedirectToAction("Index");

        }

        //3. passing data thru viewbag and viewdata

        public ActionResult officeRules()
        {
            List<string> rules = new List<string>
            {
                "Be on time",
                    "carry laptop and id card",
                    "complete work on time",
                    "be in formal"
          };

            //3.1 transfer data trugh viewbag

            ViewBag.rules = rules;
            return View();

            //3.2 trnsfer data through viewdata
           // ViewData["or"]=rules;
           //// return View();
           // return RedirectToAction("TestDataTrnasfer");

        }
        public ActionResult FirstTempRequest()

        {

            List<string> fruits = new List<string>()

            {

         "Apple","Orange","Grapes","Banana","Pinapple"

                };

            TempData["fruit"] = fruits;

            //4.1 using tempdata in the current view

            // return View();

            //4.2 redirecting to see if tempdata is available

            return RedirectToAction("SecondTempRequest");

        }

        public ActionResult SecondTempRequest()

        {


            return RedirectToAction("Index");

        }



    }
}