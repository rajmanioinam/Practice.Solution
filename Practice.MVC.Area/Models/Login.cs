using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Practice.MVC.Area.Models
{
    public class Login
    {
        [Required(ErrorMessage ="User Name required",AllowEmptyStrings =false)]
        public string UserName { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}