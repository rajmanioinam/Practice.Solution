using System;
using System.ComponentModel.DataAnnotations;

namespace Practice.MVC.CustomValidators
{
    public class DateRangeAttribute: RangeAttribute
    {
        //validate the range from given date to current date
        public DateRangeAttribute(string dateVal):base(typeof(DateTime),dateVal,DateTime.Now.ToString())
        { }
    }
}