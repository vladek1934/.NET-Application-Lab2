using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LaboratoryWork2.Models;
using System.Data.Entity;

namespace LaboratoryWork2.Controllers
{
    public class HomeController : Controller
    {
        private RegistryEntities1 data = new RegistryEntities1();

        public ActionResult Index()
        {
            return View(data.Students.ToList());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }

        public ActionResult Table()
        {
            return View(data.Students.ToList());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost, ActionName("Create")]
        public ActionResult Create([Bind(Exclude = "Id")] Student person)
        {
            if (!ModelState.IsValid)
                return View();
            data.Students.Add(person);
            data.SaveChanges();
            return RedirectToAction("Table");
        }
        
        public ActionResult Delete(int id)
        {
            Student person = data.Students.Find(id);
            return View(person);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Student person = data.Students.Find(id);
            data.Students.Remove(person);
            data.SaveChanges();
            return RedirectToAction("Table");
        }


        public ActionResult Edit(int id)
        {
            Student person = data.Students.Find(id);
            return View(person);
        }

        [HttpPost, ActionName("Edit")]
        public ActionResult EditConfirmed(Student person)
        {
            if (ModelState.IsValid)
            {        
                data.Entry(person).State = EntityState.Modified;
                data.SaveChanges();
                return RedirectToAction("Table");
            }
            return View(person);

        }
    }

}