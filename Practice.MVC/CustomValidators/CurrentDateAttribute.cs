using System;
using System.ComponentModel.DataAnnotations;

namespace Practice.MVC.CustomValidators
{
    public class CurrentDateAttribute : ValidationAttribute
    {
        //Validate date which is less than or equal to current date
        public override bool IsValid(object value)
        {
            DateTime dateTime = Convert.ToDateTime(value);
            return dateTime <= DateTime.Now;
        }
    }
}