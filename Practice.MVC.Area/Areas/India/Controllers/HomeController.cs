using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Practice.MVC.Area.Areas.India.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        // GET: India/Home
        public ActionResult Index()
        {
            return View();
        }
    }
}