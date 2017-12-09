using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Practice.WebApi.Models;

namespace Practice.WebApi
{
    public class EmployeeSecurity
    {
        public static bool Login(string userName, string password)
        {
            using (Entities db = new Entities())
            {
                return db.Users.Any(user => user.Username.Equals(userName, StringComparison.OrdinalIgnoreCase)
                && user.Password.Equals(password));
            }
        }
    }
}