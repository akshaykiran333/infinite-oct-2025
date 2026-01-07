using MVC_Database_First.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace MVC_Database_First.Controllers
{
    public class ProductsController : Controller
    {
        northwinddbEntities dbo = new northwinddbEntities();
        // GET: Products
        public ActionResult Index()
        {
            // using eager loading by including supplier and category models along with prodct model
            var products = dbo.Products.Include(p1=>p1.Category).Include(p1=>p1.Supplier);
            return View(products.ToList());
        }

        //1. add a product
        public ActionResult Create()
        {
            ViewBag.CategoryID = new SelectList(dbo.Categories, "CategoryID", "CategoryName");
            ViewBag.SupplierID = new SelectList(dbo.Suppliers, "SupplierID", "CompanyName");
            return View();

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                dbo.Products.Add(product);
                dbo.SaveChanges();
                return RedirectToAction("Index");
            }

            //for category n supplir dropdown
            ViewBag.CategoryID = new SelectList(dbo.Categories, "CategoryID", "CategoryName",product.CategoryID);
            ViewBag.SupplierID = new SelectList(dbo.Suppliers, "SupplierID", "CompanyName",product.SupplierID);
            return View(product);


        }
        //.EDIT

        public ActionResult Edit(int id)
        {
            Product product = dbo.Products.Find(id);

            ViewBag.CategoryID = new SelectList(dbo.Categories, "CategoryID", "CategoryName");
            ViewBag.SupplierID = new SelectList(dbo.Suppliers, "SupplierID", "CompanyName");
            return View(product);

        }

        [HttpPost]  
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Product product)
        {
            if (ModelState.IsValid)
            {
                dbo.Entry(product).State = System.Data.Entity.EntityState.Modified;
                dbo.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CategoryID = new SelectList(dbo.Categories, "CategoryID", "CategoryName", product.CategoryID);
            ViewBag.SupplierID = new SelectList(dbo.Suppliers, "SupplierID", "CompanyName",product.SupplierID);
            return View(product);
        }

        ///DELETE

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = dbo.Products.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        // POST:
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
           
            Product product = dbo.Products.Find(id);
            dbo.Products.Remove(product);

            var orderDetails = dbo.Order_Details.Where(od => od.ProductID == id).ToList();
            dbo.Order_Details.RemoveRange(orderDetails);

            dbo.SaveChanges();
            return RedirectToAction("Index");
        }


    }
}