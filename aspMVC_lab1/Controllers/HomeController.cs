using aspMVC_lab1.Managers;
using aspMVC_lab1.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace aspMVC_lab1.Controllers
{


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
        public ViewResult RsvpForm(Employee employee) {
            var M = ModelState;
            if (ModelState.IsValid) {
                EmployeeManager em = new EmployeeManager();
                var x = em.Add(employee);

                return View("Welcome", employee);
            }
            return View(employee);
        }
    }
}