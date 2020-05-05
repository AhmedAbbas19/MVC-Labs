using aspMVC_lab1.Managers;
using aspMVC_lab1.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace aspMVC_lab1.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            EmployeeManager em = new EmployeeManager();
            return View(em.GetAll().ToList());
        }

        [HttpGet]
        public ActionResult Add() {
            return View("Add");
        }


        [HttpPost]
        public ActionResult Add(Employee employee)
        {
            if (ModelState.IsValid)
            {
                EmployeeManager em = new EmployeeManager();
                em.Add(employee);
                em.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(employee);
        }

        public ActionResult Details(int id) {
            EmployeeManager em = new EmployeeManager();
            Employee employee = em.GetById(id);
            return View(employee);
        }

        [HttpGet]
        public ActionResult Edit(int id) {
            EmployeeManager em = new EmployeeManager();
            Employee employee = em.GetById(id);
            return View("Add",employee);
        }

        [HttpPost]
        public ActionResult Edit(Employee employee)
        {
            EmployeeManager em = new EmployeeManager();
            em.Update(employee);
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id) {
            EmployeeManager em = new EmployeeManager();
            Employee employee = em.GetById(id);
            em.Delete(employee);
            return RedirectToAction("Index");
        }

    }
}