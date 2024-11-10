using Project_62131673.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project_62131673.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin,quanlykhachhang")]
    public class Home_62131673Controller : Controller
    {
        // GET: Admin/Home_62131673
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Refresh()
        {
            var item = new ThongKeModel();

            ViewBag.Visitors_online = HttpContext.Application["visitors_online"];
            var hn = HttpContext.Application["HomNay"];
            item.HomNay = HttpContext.Application["HomNay"].ToString();
            item.HomQua = HttpContext.Application["HomQua"].ToString();
            item.TuanNay = HttpContext.Application["TuanNay"].ToString();
            item.TuanTruoc = HttpContext.Application["TuanTruoc"].ToString();
            item.ThangNay = HttpContext.Application["ThangNay"].ToString();
            item.ThangTruoc = HttpContext.Application["ThangTruoc"].ToString();
            item.TatCa = HttpContext.Application["TatCa"].ToString();
            return PartialView(item);
        }
    }
}