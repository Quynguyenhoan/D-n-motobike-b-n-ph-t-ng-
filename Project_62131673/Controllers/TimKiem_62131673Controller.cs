using PagedList;
using Project_62131673.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project_62131673.Controllers
{
    public class TimKiem_62131673Controller : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: TimKiem_62131673
        [HttpGet]
        public ActionResult KQTimKiem(string sTuKhoa, int? page)
        {
            if (Request.HttpMethod != "GET")
            {
                page = 1;
            }
            int pageSize = 10;
            int pageNumber = (page ?? 1);
            //tìm kiếm theo tên sản phẩm 
            var lstSP = db.Products.Where(n => n.Title.Contains(sTuKhoa));
            ViewBag.TuKhoa = sTuKhoa;
            return View(lstSP.OrderBy(n=>n.Title).ToPagedList(pageNumber,pageSize));
        }
        [HttpPost]
        public ActionResult LayTuKhoaTimKiem(string sTuKhoa)
        {
            // Gọi về hàm get tìm kiếm
            return RedirectToAction("KQTimKiem", new { @sTuKhoa = sTuKhoa});
        }
    }
}