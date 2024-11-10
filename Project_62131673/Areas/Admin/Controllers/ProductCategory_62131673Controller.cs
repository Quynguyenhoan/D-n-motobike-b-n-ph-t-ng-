using Project_62131673.Models;
using Project_62131673.Models.EF_62131673;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.Mvc;

namespace Project_62131673.Areas.Admin.Controllers
{
    public class ProductCategory_62131673Controller : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: Admin/ProductCategory_62131673
        public ActionResult Index()
        {
            var items = db.ProductCategories;
            return View(items);
        }
        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Add( ProductCategory_62131673 model)
        {
            if (ModelState.IsValid)
            {
                model.CreatedDate = DateTime.Now;
                model.ModifiedDate = DateTime.Now;
                model.Alias = Project_62131673.Models.Common_62131673.Filter_62131673.FilterChar(model.Title);
                db.ProductCategories.Add(model);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpPost]
        public ActionResult Delete(int id)
        {
            var item = db.ProductCategories.Find(id);
            if (item != null)
            {
                db.ProductCategories.Remove(item);
                db.SaveChanges();
                return Json(new { success = true });
            }

            return Json(new { success = false });
        }

        [HttpPost]
        public ActionResult IsActive(int id)
        {
            var item = db.ProductCategories.Find(id);
            if (item != null)
            {
             
                db.Entry(item).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return Json(new { success = true });
            }

            return Json(new { success = false });
        }

        [HttpPost]
        public ActionResult DeleteAll(string ids)
        {
            if (!string.IsNullOrEmpty(ids))
            {
                var items = ids.Split(',');
                if (items != null && items.Any())
                {
                    foreach (var item in items)
                    {
                        var obj = db.ProductCategories.Find(Convert.ToInt32(item));
                        db.ProductCategories.Remove(obj);
                        db.SaveChanges();
                    }
                }
                return Json(new { success = true });
            }
            return Json(new { success = false });
        }
    }
}