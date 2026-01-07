using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.Mvc;

using MVC_CodeFirst.Models;
using MVC_CodeFirst.Repository;

namespace MVC_CodeFirst.Controllers
{
    public class ProductController : Controller
    {
        IProductRepository<Products> _productRepo = null;

        //controllr constructor

        public ProductController()
        {
            _productRepo = new ProductRepository<Products>();
        }
        // GET: Product
        // all products
        public ActionResult Index()
        {
            var products = _productRepo.GetAll();
            return View(products);
        }

        // 2.creating a new product
        public ActionResult Create()
            {
            return View();
        }

        // 2.1 craete post 
        [HttpPost]
        public ActionResult Create(Products products)
        {
            if (ModelState.IsValid)
            {
                _productRepo.Insert(products);
                _productRepo.Save();
                return RedirectToAction("Index");
            }
            else
            {
                return View(products);
            }
        }
        //3. update
        public ActionResult Edit(int id)
        {
            Products products = _productRepo.GetByID(id);
           
            return View(products);

        }
        [HttpPost]
        public ActionResult Edit(Products products)
        {
            if ( ModelState.IsValid)
            {
                _productRepo.Update(products);
                _productRepo.Save();
                return RedirectToAction("Index");
                
            }
            else
            {
                return View(products);
            }
            
            
        }

        //4. delete

        public ActionResult Delete(int id)
        {
            Products products =_productRepo.GetByID(id);
            return View(products);
        }
        [HttpPost,ActionName("Delete")]

        public ActionResult DeleteConfirmed(Products products)
        {
            if (ModelState.IsValid)
            {
                _productRepo.Delete(products);
                _productRepo.Save();
                return RedirectToAction("Index");

            }
            else
            {
                return View(products);
            }
        }
        //5.Deatils

        public ActionResult Details(int id)
        {
            Products product = _productRepo.GetByID(id);
            return View(product);
        }
    }
}