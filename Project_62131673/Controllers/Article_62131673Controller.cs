using Project_62131673.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project_62131673.Controllers
{
    public class Article_62131673Controller : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: Article_62131673
        public ActionResult Index(string alias)
        {
            var item = db.Posts.FirstOrDefault(x => x.Alias == alias);
            return View(item);
        }
    }
}