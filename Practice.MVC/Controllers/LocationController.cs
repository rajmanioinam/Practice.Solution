using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Practice.MVC.Models;
using PagedList.Mvc;
using PagedList;

namespace Practice.MVC.Controllers
{
    public class LocationController : Controller
    {
        Entities db = new Entities();
        // GET: Location
        public ActionResult Index(string search, int? page, string sortOrder)
        {
            //List<tblcountry> countries = db.tblcountries.Where(c=>c.countryname.StartsWith(search)||search == null).ToList();
            var countries = db.tblcountries.Where(c => c.countryname.StartsWith(search) || search == null);
            ViewBag.NameSort = string.IsNullOrEmpty(sortOrder)?"name_desc":"";
            switch(sortOrder)
            {
                case "name_desc":
                    countries = countries.OrderByDescending(c=>c.countryname);
                    break;
                default:
                    countries = countries.OrderBy(c => c.countryname);
                    break;
            }

            return View(countries.ToList().ToPagedList(page??1,5));
        }
        public ActionResult GetStates(int id)
        {
            List<tblstate> states = db.tblstates.Where(s => s.country_id == id).OrderByDescending(c=>c.country_id==id).Take(10).ToList();
            return View(states);
        }
        public ActionResult GetCities(int id)
        {
            List<tblcity> cities = db.tblcities.Where(c=>c.state_id==id).OrderByDescending(c => c.cityname).Take(10).ToList();
            return View(cities);
        }
    }
}