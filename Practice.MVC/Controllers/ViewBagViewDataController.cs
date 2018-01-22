using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Practice.MVC.Controllers
{
    public class ViewBagViewDataController : Controller
    {
        // GET: ViewBagViewData
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ViewBagAndViewData()
        {
            ViewBag.Fruits = new List<string>() {
                "Apple",
                "Mangp",
                "Pineapple",
                "Guava"
            };

            ViewData["Fruits"] = new List<string>() {
                "Apple",
                "Mangp",
                "Pineapple",
                "Guava"
            };
            return View();
        }
    }
}