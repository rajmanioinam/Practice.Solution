using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Practice.DesignPatternFactoryWeb.Logger;

namespace Practice.DesignPatternFactoryWeb.Controllers
{
    public class BaseController : Controller
    {
        // GET: Base
        private ILog _Ilog;
        public BaseController()
        {
            _Ilog = Log.GetInstance;
        }
        protected override void OnException(ExceptionContext filterContext)
        {
            _Ilog.LogException(filterContext.Exception.ToString());
            filterContext.ExceptionHandled = true;
            this.View("Error").ExecuteResult(this.ControllerContext);
        }
    }
}