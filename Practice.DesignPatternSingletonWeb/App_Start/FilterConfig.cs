using System.Web;
using System.Web.Mvc;

namespace Practice.DesignPatternSingletonWeb
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
