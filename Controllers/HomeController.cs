using AttributesRequired.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AttributesProject.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            Person newFriend = new Person();
            return View(newFriend);
        }

        [HttpPost]
        public ActionResult Index(Person friendToCreate)
        {
            if (ModelState.IsValid)
            {
                ModelState.Clear();
                ViewData["Message"] = String.Format("{0} was added.", friendToCreate.First);
                return View(new Person());
            }

            ViewData["Message"] = "There was an error.";
            return View(friendToCreate);
        }
    }
}