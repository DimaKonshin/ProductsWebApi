using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Domain.Repository;
using Domain.DataBaseContextAndEntitiesDb;

namespace ProductsWebApi.Controllers
{
    public class HomeController : Controller
    {
        IRepository<Product> repository;

        public HomeController(IRepository<Product> repository)
        {
            this.repository = repository;
        }

        public ActionResult Index()
        {
            return View(repository.Read());
        }
    }
}