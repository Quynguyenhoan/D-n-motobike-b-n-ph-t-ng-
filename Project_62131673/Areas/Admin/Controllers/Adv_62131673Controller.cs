using Project_62131673.Models;
using Project_62131673.Models.EF_62131673;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Web;
using System.Web.Mvc;

namespace Project_62131673.Areas.Admin.Controllers
{

    public class Adv_62131673Controller : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: Admin/Adv_62131673
        public ActionResult Index()
        {
            var items = db.Posts.ToList();
            return View(items);
        }
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Add(Adv_62131673 model)
        {
            if (ModelState.IsValid)
            {
                model.CreatedDate = DateTime.Now;
                model.ModifiedDate = DateTime.Now;
                db.Advs.Add(model);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }

        public ActionResult Edit(int id)
        {
            var item = db.Advs.Find(id);
            return View(item);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Adv_62131673 model)
        {
            if (ModelState.IsValid)
            {
                model.ModifiedDate = DateTime.Now;
                db.Advs.Attach(model);
                db.Entry(model).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            var item = db.Advs.Find(id);
            if (item != null)
            {
                db.Advs.Remove(item);
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
                        var obj = db.Advs.Find(Convert.ToInt32(item));
                        db.Advs.Remove(obj);
                        db.SaveChanges();
                    }
                }
                return Json(new { success = true });
            }
            return Json(new { success = false });
        }
    }
}