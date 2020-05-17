using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ViewsSample.Controllers
{
    public class Data
    {
        public int Counter { get; set; }
    }
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewData["my_data"] = new Data
            {
                Counter = 10
            };

            ViewBag.Counter = 15;
            ViewBag.UserName = "SeperAdmin";

            TempData["my_data"] = new Data
            {
                Counter = 20
            };

            return View();
        }

        // Get request
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Data model)
        {
            return View();
        }

        public ActionResult Banner()
        {
            return View();
        }
    }
}