﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Practice.WebApi.Models;
using System.Web.Http.Cors;

namespace Practice.WebApi.Controllers
{
    //[EnableCorsAttribute("*", "*", "*")]
    //[RequireHttps]//Enable requires https
    //[BasicAuthentication]
    public class EmployeesController : ApiController
    {
        public HttpResponseMessage Get()
        {
            using (Entities db = new Entities())
            {
                var entity = db.Employees.ToList();
                if(entity!=null)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, entity);
                }
                else
                {
                    return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Employee not Found");
                }
            }
        }
        [DisableCors]//Disbale CORS for the method
        public HttpResponseMessage Get(int id)
        {
            using (Entities db = new Entities())
            {
                var entity = db.Employees.SingleOrDefault(x => x.ID == id);
                if(entity!=null)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, entity);
                }
                else
                {
                    return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Employee with id= " + id.ToString() + "not found");
                }
            }
        }
        [Route("api/Employees/{id}/Employee")]
        public HttpResponseMessage GetEmployee(int id)
        {
            using (Entities db = new Entities())
            {
                var entity = db.Employees.SingleOrDefault(x => x.ID == id);
                if (entity != null)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, entity);
                }
                else
                {
                    return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Employee with id= " + id.ToString() + "not found");
                }
            }
        }
        public HttpResponseMessage Post([FromBody] Employee employee)
        {
            try
            {
                using (Entities db = new Entities())
                {
                    db.Employees.Add(employee);
                    db.SaveChanges();

                    var message = Request.CreateResponse(HttpStatusCode.Created, employee);
                    message.Headers.Location = new Uri(Request.RequestUri + employee.ID.ToString());

                    return message;
                }
            }
            catch(Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }
        public HttpResponseMessage Delete(int id)
        {
            try
            {
                using (Entities db = new Entities())
                {
                    var entity = db.Employees.FirstOrDefault(e => e.ID == id);
                    if (entity != null)
                    {
                        db.Employees.Remove(entity);
                        db.SaveChanges();
                        return Request.CreateResponse(HttpStatusCode.OK);
                    }
                    else
                    {
                        return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Employee with id= " + id.ToString() + " not found");
                    }
                }
            }
            catch(Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }
        public HttpResponseMessage Put(int id, [FromBody]Employee employee)
        {
            try
            {
                using (Entities db = new Entities())
                {
                    var entity = db.Employees.FirstOrDefault(e => e.ID == id);
                    if (entity != null)
                    {
                        entity.FirstName = employee.FirstName;
                        entity.LastName = employee.LastName;
                        entity.Gender = employee.Gender;
                        entity.Salary = employee.Salary;
                        db.SaveChanges();
                        return Request.CreateResponse(HttpStatusCode.OK, entity);
                    }
                    else
                    {
                        return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Employee with Id= " + id.ToString() + " not found");
                    }
                }
            }
            catch(Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }
    }
}
