using System.Web.Mvc;

namespace Practice.MVC.Area.Areas.USA
{
    public class USAAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "USA";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "USA_default",
                "USA/{controller}/{action}/{id}",
                new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}