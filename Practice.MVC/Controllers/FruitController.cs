using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.Mvc;
using Practice.MVC.Models;
using PagedList;
using PagedList.Mvc;
using Practice.MVC.CustomActionFilters;

namespace Practice.MVC.Controllers
{
    public class FruitController : Controller
    {
        Entities db = new Entities();
        // GET: Fruit
        //[HandleError]
        //[OutputCache(Duration =10)]//The output will be cached for 10 seconds
        [OutputCache(CacheProfile ="FruitCache")]//Caching using cache profile
        [TrackActionExecution]
        public ActionResult Index(string search, int? page)
        {
            //throw new Exception("Error!! Ha Ha!!");
            List<Fruit> fruits = db.Fruits.Where(f => f.FruitName.StartsWith(search) || search == null).ToList();
            return View(fruits.ToPagedList(page ?? 1, 2));
        }

        [TrackActionExecution]
        public ActionResult FruitDetails(int Id)
        {
            //throw new Exception("testing exception");
            Fruit fruit = db.Fruits.Single(f => f.FruitId == Id);
            return View(fruit);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        /// <summary>
        /// Using FormCollection. Deprecated approach
        /// </summary>
        /// <param name="formCollection"></param>
        /// <returns></returns>
        //[HttpPost]
        //public ActionResult Create(FormCollection formCollection)
        //{
        //    Fruit fruit = new Fruit();
        //    fruit.FruitId = Convert.ToInt32(formCollection["FruitId"]);
        //    fruit.FruitName = formCollection["FruitName"];
        //    fruit.Color = formCollection["Color"];
        //    fruit.Preference = Convert.ToInt32(formCollection["Preference"]);
        //    db.Fruits.Add(fruit);
        //    db.SaveChanges();
        //    return RedirectToAction("Index");
        //}
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "FruitId,FruitName,Color,Preference,UpdatedDate,FruitImage")]Fruit fruit)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.Fruits.Add(fruit);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            catch (RetryLimitExceededException)
            {
                ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists, see your system administrator.");
            }
            return View(fruit);
        }

        public ActionResult Edit(int? id)
        {
            if(id==null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Fruit fruit = db.Fruits.Find(id);
            fruit.ConfirmColor = fruit.Color;
            if(fruit==null)
            {
                return HttpNotFound();
            }

            return View(fruit);
        }

        [ValidateAntiForgeryToken]
        [HttpPost,ActionName("Edit")]
        //[ValidateInput(false)] //to allow html for the entire action
        public ActionResult Edit_Post(int? id)
        {
            if(id==null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var fruitToUpdate = db.Fruits.Find(id);
            if(TryUpdateModel(fruitToUpdate,"", new string[] { "FruitId","FruitName","Color","ConfirmColor","Preference","UpdatedDate"}))
            {
                try
                {
                    fruitToUpdate.FruitName = EncodeString(fruitToUpdate.FruitName);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                catch(RetryLimitExceededException)
                {
                    ModelState.AddModelError("", "Unable to save changes. Please try again, and if the problem persists please contact system administrator.");
                }
            }
            return View(fruitToUpdate);
        }

        public string EncodeString(string val)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(HttpUtility.HtmlEncode(val));
            sb.Replace("&lt;b&gt;", "<b>");
            sb.Replace("&lt;/b&gt;", "</b>");
            sb.Replace("&lt;u&gt;", "<u>");
            sb.Replace("&lt;/u&gt;", "</u>");
            return sb.ToString();
        }

        public ActionResult Delete(int? id)
        {
            if(id==null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Fruit fruit = db.Fruits.Find(id);
            if(fruit==null)
            {
                return HttpNotFound();
            }
            return View(fruit);
        }

        [HttpPost,ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult Delete_Post(int? id)
        {
            Fruit fruit = db.Fruits.Find(id);
            db.Fruits.Remove(fruit);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [AllowAnonymous]
        public JsonResult IsFruitNameAvailable(string FruitName)
        {
            return Json(!db.Fruits.Any(x => x.FruitName == FruitName), JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetFruits(string term)
        {
            List<string> fruits = db.Fruits.Where(f => f.FruitName.StartsWith(term)).Select(s=>s.FruitName).ToList();
            return Json(fruits, JsonRequestBehavior.AllowGet);
        }
    }
}