using System;
using System.ComponentModel.DataAnnotations;
using Practice.MVC.CustomValidators;

namespace Practice.MVC.Models
{
    [MetadataType(typeof(FruitMetaData))]
    public partial class Fruit
    {
        [Compare("Color")]
        public string ConfirmColor { get; set; }
    }

    public class FruitMetaData
    {
        [Display(Name = "Fruit Id")]
        [Required]
        public int FruitId { get; set; }

        //[Display(Name = "Fruit Name")]
        //[Required]
        //[System.Web.Mvc.AllowHtml]
        //[System.Web.Mvc.Remote("IsFruitNameAvailable", "Fruit", ErrorMessage ="Fruit Name already in use.(Client validation)")]//Client side validation. Requires javascript enable in browser.
        //[RemoteClientServer("IsFruitNameAvailable", "Fruit", ErrorMessage = "Fruit Name already in use. (server validation)")]
        public string FruitName { get; set; }

        [StringLength(50,MinimumLength = 3)]
        [Required(ErrorMessage = "Color is Required")]
        [RegularExpression(@"^(([A-za-z]+[\s]{1}[A-za-z]+)|([A-Za-z]+))$",ErrorMessage ="Alphabets only")]
        public string Color { get; set; }

        [DisplayFormat(DataFormatString ="{0:yyyy-MM-dd}",ApplyFormatInEditMode =true)]
        //[Range(typeof(DateTime),"01/01/2000","01/01/2020")]
        //[DateRange("01/01/2017",ErrorMessage ="Date should be between 01/01/2017 and current date")]
        //[CurrentDate]
        public DateTime UpdatedDate { get; set; }

        public int Preference { get; set; }

        public string ConfirmColor { get; set; }
    }
}