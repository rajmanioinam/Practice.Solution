using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Practice.MVC.Models;

namespace Practice.MVC.CustomActionFilters
{
    public class TrackActionExecution : ActionFilterAttribute, IExceptionFilter
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            LogExecution(filterContext.ActionDescriptor.ActionName, "OnActionExecuting", "On Action Executing");
        }
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            LogExecution(filterContext.ActionDescriptor.ActionName, "OnActionExecuted", "On Action Executed");
        }
        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            LogExecution(filterContext.RouteData.Values["action"].ToString(), "OnResultExecuting", "On Result Executing");
        }
        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            LogExecution(filterContext.RouteData.Values["action"].ToString(), "OnResultExecuted", "On Result Executed");
        }
        public void OnException(ExceptionContext filterContext)
        {
            LogExecution(filterContext.RouteData.Values["action"].ToString(),"OnException",filterContext.Exception.Message);
        }
        private void LogExecution(string ActionName, string EventName, string Message)
        {
            Entities db = new Entities();
            ApplicationLog appLog = new ApplicationLog();
            appLog.ActionName = ActionName;
            appLog.EventName = EventName;
            appLog.Message = Message;
            appLog.DateAdded = DateTime.Now;
            db.ApplicationLogs.Add(appLog);
            db.SaveChanges();
        }
    }
}