using MVC_Assign.Models;
using MVC_Assign.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using MVC_Assign.Models;
using MVC_Assign.Repository;

namespace MVC_Assign.Controllers
{
    public class ContactController : Controller
    {
        
       
            
        private IContactRepository _repository;
        public ContactController()
        {
            _repository = new ContactRepository(new ContactContext());
        }

        //// GET: Contact

        public async Task<ActionResult> Index()
        {
            var contacts = await _repository.GetAllAsync();
            return View(contacts);
        }
        /// Create
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(Contact contact)
        {
            if (ModelState.IsValid)
            {
                await _repository.CreateAsync(contact);
                return RedirectToAction("Index");
            }
            return View(contact);
        }
        ///Delete
        public async Task<ActionResult> Delete(long id)
        {
            await _repository.DeleteAsync(id);
            return RedirectToAction("Index");
        }

    }

}