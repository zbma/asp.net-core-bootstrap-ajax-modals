using AjaxModals.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace AjaxModals.Controllers
{
    public class HomeController : Controller
    {
        private readonly static List<Contact> Contacts = new List<Contact>();

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Contact()
        {
            var model = new Contact { };

            return PartialView("_ContactModalPartial", model);
        }

        [HttpPost]
        public IActionResult Contact(Contact model)
        {
            if (ModelState.IsValid)
            {
                Contacts.Add(model);
            }

            return PartialView("_ContactModalPartial", model);
        }
    }
}
