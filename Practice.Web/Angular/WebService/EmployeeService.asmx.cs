using System.Collections.Generic;
using System.Web.Script.Serialization;
using System.Web.Services;

namespace Practice.Web.Angular.WebService
{
    /// <summary>
    /// Summary description for EmployeeService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class EmployeeService : System.Web.Services.WebService
    {

        [WebMethod]
        public void GetAllEmployees()
        {
            List<Employee> listEmployees = new List<Employee>() {
                new Employee { id=1, name="Ben", salary=5500 },
                new Employee { id=2, name="Sara", salary=6500 },
                new Employee { id=3, name="Mark", salary=7500 },
                new Employee { id=4, name="Pam", salary=5000 },
                new Employee { id=5, name="Tood", salary=8500 }
            };

            JavaScriptSerializer js = new JavaScriptSerializer();
            Context.Response.Write(js.Serialize(listEmployees));
        }
    }
}
