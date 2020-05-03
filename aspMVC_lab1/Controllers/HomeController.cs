using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace aspMVC_lab1.Controllers
{

    public class User {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }

    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View();
        }

        [HttpPost]
        public ViewResult RsvpForm(User user) {
            if (user != null && user.Name != null) {
                ViewData["name"] = user.Name;
                return View("Welcome");
            }
                return View();
        }
    }
}