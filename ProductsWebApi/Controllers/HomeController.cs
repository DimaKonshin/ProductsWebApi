using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Domain.Repository;
using Domain.DataBaseContextAndEntitiesDb;
using System.Net;

namespace ProductsWebApi.Controllers
{
    public class HomeController : Controller
    {
        IRepository<Product> repository;

        public HomeController(IRepository<Product> repository)
        {
            this.repository = repository;
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                repository.Create(product);
                return RedirectToAction("Read");
            }

            return View(product);
        }

        public ActionResult Read()
        {
            return View(repository.Read());
        }

        public ActionResult Update(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Product product = repository.FindById(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Update(Product product)
        {
            if (ModelState.IsValid)
            {
                repository.Update(product);
                return RedirectToAction("Read");
            }
            return View(product);
        }

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = repository.FindById(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Product product = repository.FindById(id);
            repository.Delete(product);
            return RedirectToAction("Read");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                repository.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}