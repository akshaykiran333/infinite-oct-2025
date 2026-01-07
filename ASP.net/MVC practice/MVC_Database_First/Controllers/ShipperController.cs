using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using MVC_Database_First.Models;
namespace MVC_Database_First.Controllers
{
    
    public class ShipperController : Controller
    {
        northwinddbEntities northwinddb = new northwinddbEntities();
        infinite2025Entities db = new infinite2025Entities();
        // GET: Shipper
        public ActionResult Index()
        {
            return View(db.Departments.ToList());
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        ////1. passing data frm view to controllr using form collection

        //public ActionResult Create(FormCollection form)

        //{

        //    Department depart = new Department();

        //    depart.DeptID = Convert.ToInt32(form["DeptId"]);

        //    depart.DeptName = form["DeptName"].ToString();

        //    db.Departments.Add(depart);

        //    db.SaveChanges();

        //    return RedirectToAction("Index");

        //}


        ////2. passing data from view to controller using parameter collection
        ////parameter names to match the schema attribute names
        //[ActionName("Create")]
        //public ActionResult CreatePost(string CompanyName, string Phone)
        //{
        //    Department d = new Department();
        //    d.DeptID = DeptID;
        //    d.DeptName = DeptName;
        //    db.Departments.Add(d);
        //    db.SaveChanges();
        //    return RedirectToAction("Index");
        //}

        //3. passing data frm view to controller using reqst obj

        [ActionName("Create")]
        public ActionResult CreatePost()
        {
            Department d = new Department();
            d.DeptID = Convert.ToInt32(Request["DeptID"]);
            d.DeptName = Request["DeptName"].ToString();
            db.Departments.Add(d);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        //4. calling stored procedures

        public ActionResult SP_with_Parameter()
        {
            return View(northwinddb.CustOrdersOrders("vinet")); 
        }
    }
}