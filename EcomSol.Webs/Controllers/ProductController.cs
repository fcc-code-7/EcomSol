using EcomSol.Entities;
using EcomSol.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EcomSol.Webs.Controllers
{
    public class ProductController : Controller
    {
        ProductServices services=new ProductServices();
        public ActionResult Index()
        {
            var product = services.getProducts();
            return View(product);
        }
        public ActionResult ProduuctTable()
        {
            return View();
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Product product)
        {
            if(ModelState.IsValid)
            {
                services.AddProducts(product);
                ModelState.Clear();
                return RedirectToAction("Index");
            }
            
            return View(product);
        }
        public ActionResult Edit(int id)
        {
            var product = services.FindProduct(id);
            return View(product);
        }
        [HttpPost]
        public ActionResult Edit(Product product)
        {
            if (ModelState.IsValid)
            {
                services.UpdateProduct(product);
                ModelState.Clear();
                return RedirectToAction("Index");
            }

            return View(product);
        }
        public ActionResult Delete(int id)
        {
            var product = services.FindProduct(id);
            return View(product);

        }
        [HttpPost]
        public ActionResult DeleteConfirmed(int id)
        {
        
                services.DeleteProduct(id);
                return RedirectToAction("Index");
       
        }
    }
}