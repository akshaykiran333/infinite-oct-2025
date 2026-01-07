using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using MVC_Database_First.Models;

namespace MVC_Database_First.Controllers
{
    public class NavigationController : Controller
    {
        infinite2025Entities db = new infinite2025Entities();
        // GET: Navigation
        public ActionResult Index()
        {
            return View();
        }
        //1. fetching data from multiple tables / objs using navigation property
        public ActionResult MultipleData()
        {
            return View(db.Orders3.ToList());
        }
    }
}