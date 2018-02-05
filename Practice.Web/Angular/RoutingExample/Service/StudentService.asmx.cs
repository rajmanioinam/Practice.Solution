using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Practice.Web.Angular.RoutingExample.Service
{
    /// <summary>
    /// Summary description for StudentService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class StudentService : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public List<Student> GetStudents()
        {
            List<Student> students = new List<Student>() {
                new Student { Name="Jon Doe", Department="Engineering", Major="Computer"},
                new Student{Name="Jane Doe",Department="Engineering",Major="Electrical"},
                new Student{Name="Jon Nash", Department="Engineering",Major="IT-Infra"}
            };
            return students;
        }

        [WebMethod]
        public List<Course> GetCourses()
        {
            List<Course> courses = new List<Course>() {
                new Course{Name="Computer 101",Department="Engineering"},
                new Course{Name="Computer 102", Department="Engineering"},
                new Course{Name="Electrical 101",Department="Engineering"}
            };

            return courses;
        }
    }
}
