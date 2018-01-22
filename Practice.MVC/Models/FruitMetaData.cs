using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using Practice.MVC.CustomValidators;

namespace Practice.MVC.Models
{
    [MetadataType(typeof(FruitMetaData))]
    public partial class Fruit
    {}

    public class FruitMetaData
    {
        [Display(Name = "Fruit Id")]
        [Required]
        public int FruitId { get; set; }

        [Display(Name = "Fruit Name")]
        [Required]
        [AllowHtml]
        public string FruitName { get; set; }

        [StringLength(50,MinimumLength = 3)]
        [Required(ErrorMessage = "Color is Required")]
        public string Color { get; set; }

        [DisplayFormat(DataFormatString ="{0:yyyy-MM-dd}",ApplyFormatInEditMode =true)]
        //[Range(typeof(DateTime),"01/01/2000","01/01/2020")]
        //[DateRange("01/01/2017",ErrorMessage ="Date should be between 01/01/2017 and current date")]
        [CurrentDate]
        public DateTime UpdatedDate { get; set; }

        public int Preference { get; set; }
    }
}