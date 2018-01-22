using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

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

        [DisplayFormat(DataFormatString ="{0:yyyy-MM-dd}",ApplyFormatInEditMode =true)]
        public DateTime UpdatedDate { get; set; }
    }
}