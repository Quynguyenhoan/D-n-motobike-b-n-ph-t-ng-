﻿using Project_62131673.Models;
using Project_62131673.Models.EF_62131673;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project_62131673.Areas.Admin.Controllers
{
    public class ProductImage_62131673Controller : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: Admin/ProductImage_62131673
        public ActionResult Index(int id)
        {
            ViewBag.ProductId = id;
            var items = db.ProductImages.Where(x => x.ProductId == id).ToList();
            return View(items);
        }
        [HttpPost]
        public ActionResult AddImage(int productId,string url)
        {
            db.ProductImages.Add(new ProductImage_62131673 {
                ProductId=productId,
                Image=url,
                IsDefault=false
            });
            db.SaveChanges();
            return Json(new { Success=true });
        }
        [HttpPost]
        public ActionResult Delete(int id)
        {
            var item = db.ProductImages.Find(id);
            db.ProductImages.Remove(item);
            db.SaveChanges();
            return Json(new { success = true });
        }
    }
}