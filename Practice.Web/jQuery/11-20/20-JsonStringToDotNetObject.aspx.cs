using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practice.Web.jQuery
{
    public partial class _20_JsonStringToDotNetObject : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Employee> Employees = new List<Employee>() {
                new Employee{Name="Jon",Location="Phoenix",Department="Mobility"},
                new Employee{Name="Lee",Location="Philadelphia",Department="IT-Infra" }
            };
            JavaScriptSerializer javaScriptSerializer = new JavaScriptSerializer();
            string jsonString = javaScriptSerializer.Serialize(Employees);
            Response.Write(jsonString);

            string jsonString1 = "[{\"Name\":\"Jon\",\"Location\":\"Phoenix\",\"Department\":\"Mobility\"},{\"Name\":\"Lee\",\"Location\":\"Philadelphia\",\"Department\":\"IT - Infra\"}]";
            List<Employee> employees1 = (List<Employee>)javaScriptSerializer.Deserialize(jsonString1, typeof(List<Employee>));
            foreach(var employee in employees1)
            {
                Response.Write("<br/>Name: " + employee.Name + "<br/>");
                Response.Write("Location: " + employee.Location + "<br/>");
                Response.Write("Department: " + employee.Department + "<br/>");
            }
        }
        public class Employee
        {
            public string Name { get; set; }
            public string Location { get; set; }
            public string Department { get; set; }
        }
    }
}