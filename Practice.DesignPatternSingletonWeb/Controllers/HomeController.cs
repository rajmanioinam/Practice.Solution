using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Practice.DesignPatternSingletonWeb.Models;
using System.Net;

namespace Practice.DesignPatternSingletonWeb.Controllers
{
    public class HomeController : Controller
    {
        private ILog _Ilog;
        public HomeController()
        {
            _Ilog = Logger.GetInstance;
        }
        protected override void OnException(ExceptionContext filterContext)
        {
            _Ilog.LogException(filterContext.Exception.ToString());
            filterContext.ExceptionHandled = true;
            this.View("Error").ExecuteResult(this.ControllerContext);
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            if(1==1)
            {
                throw new Exception("test exception");
            }
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}