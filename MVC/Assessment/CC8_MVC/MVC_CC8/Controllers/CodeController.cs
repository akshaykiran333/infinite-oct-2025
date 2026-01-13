using MVC_CC8.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_CC8.Controllers
{

    public class CodeController : Controller

    {
        northwinddbEntities db = new northwinddbEntities();

        //// GET: Code
        public ActionResult CustomersInGermany()
        {
            var customers = db.Customers.Where(c => c.Country == "Germany").ToList();
            return View(customers);
        }

        public ActionResult CustomerByOrder()
        {
            var customer = db.Orders
                           .Where(o => o.OrderID == 10248)
                           .Select(o => o.Customer).ToList();


            return View(customer);

        }
    }
}