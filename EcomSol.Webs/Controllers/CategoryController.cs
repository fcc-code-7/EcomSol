using EcomSol.Entities;
using EcomSol.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EcomSol.Webs.Controllers
{
    public class CategoryController : Controller
    {
        CategoryServices services = new CategoryServices();
        // GET: Category
        [HttpGet]
        public ActionResult Index()
        {
            var data = services.getCategories();
            return View(data);
        }
        [HttpGet]
        public ActionResult Create()
        {
          
            return View();
        }
        [HttpPost]
        public ActionResult Create(Category category)
        {
            if (ModelState.IsValid)
            {
                services.AddCategories(category);
                return RedirectToAction("Index");
            }
            return View(category);
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var data = services.FindCategory(id);
            return View(data);
        }
        [HttpGet]
        public ActionResult Details(int id)
        {
            var data = services.FindCategory(id);
            return View(data);
        }
        [HttpPost]
        public ActionResult Edit(Category category)
        {
            if (ModelState.IsValid)
            {
                services.UpdateCategory(category);
                return RedirectToAction("Index");
            }
            return View(category);

        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            var data = services.FindCategory(id);
            return View(data);
        }
        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            services.DeleteCategory(id);
            return RedirectToAction("Index");

        }
    }
}