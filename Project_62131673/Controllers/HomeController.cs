using Project_62131673.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Project_62131673.Models.EF_62131673;
using System.Configuration;

namespace Project_62131673.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Partial_Subcrice()
        {
            return PartialView();
        }
        [HttpPost]
        public ActionResult Subscribe(Subscribe_62131673 req)
        {
            Subscribe_62131673 Sub = new Subscribe_62131673();
            if (ModelState.IsValid)
            {
                db.Subscribes.Add(new Subscribe_62131673 { Email = req.Email, CreatedDate = DateTime.Now });
                db.SaveChanges();
                string contentSub = System.IO.File.ReadAllText(Server.MapPath("~/Content/templates/send3.html"));
                contentSub = contentSub.Replace("{{Mauudai}}",Sub.Email );
                Project_62131673.Common.Common.SendMail("{{RepairMoto}}", "Người nhận ưu đãi ", contentSub.ToString(), ConfigurationManager.AppSettings["EmailAdmin"]);
                
                return Json(new { Success = true });
            }
            return View("Partial_Subcrice", req);
        }
        public ActionResult About()
        {
            ViewBag.Message = "Trang mô tả ứng dụng của bạn.";

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
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}