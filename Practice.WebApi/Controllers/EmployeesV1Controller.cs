using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Practice.WebApi.Models;

namespace Practice.WebApi.Controllers
{
    public class EmployeesV1Controller : ApiController
    {
        public HttpResponseMessage Get(string gender="all")
        {
            using (Entities db = new Entities())
            {
                switch (gender.ToLower())
                {
                    case "all": return Request.CreateResponse(HttpStatusCode.OK, db.Employees.ToList());
                    case "male": return Request.CreateResponse(HttpStatusCode.OK, db.Employees.Where(e => e.Gender.ToLower() == "male").ToList());
                    case "female": return Request.CreateResponse(HttpStatusCode.OK, db.Employees.Where(e => e.Gender.ToLower() == "female").ToList());
                    default: return Request.CreateErrorResponse(HttpStatusCode.BadRequest, gender + " is invalid." + " The value of gender must be All, Male or Female.");
                }
            }
        }
    }
}
