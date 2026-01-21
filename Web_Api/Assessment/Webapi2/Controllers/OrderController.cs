using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Webapp2.Models;

namespace Webapp2.Controllers
{
    public class OrderController : ApiController
    {
        northwinddbEntities db = new northwinddbEntities();

        [HttpGet]
        [Route("api/orders/buchanan")]
        public IHttpActionResult GetOrdersOfBuchananSteven()
        {
            var orders = db.Orders
                .Where(o => o.EmployeeID == 5)
                .Select(o => new
                {
                    o.OrderID,
                    o.OrderDate,
                    o.CustomerID,
                    o.Customer.CompanyName,
                    o.Customer.ContactName,
                    EmployeeName = o.Employee.FirstName + " " + o.Employee.LastName
                }).ToList();

            return Ok(orders);
        }
        [HttpGet]
        [Route("api/customers/bycountry/{country}")]
        public IHttpActionResult GetCustomersByCountry(string country)
        {
            var customers = db.GetCustomersByCountry(country).ToList();
            return Ok(customers);
        }
    }
}
