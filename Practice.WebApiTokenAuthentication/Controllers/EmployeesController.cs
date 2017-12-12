using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Practice.WebApiTokenAuthentication.Models;

namespace Practice.WebApiTokenAuthentication.Controllers
{
    [Authorize]
    public class EmployeesController : ApiController
    {
        public IEnumerable<Employee> Get()
        {
            using (Entities db = new Entities())
            {
                return db.Employees.ToList();
            }
        }
    }
}
