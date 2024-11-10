using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Project_62131673
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(
              name: "Contact",
              url: "lien-he",
              defaults: new { controller = "Contact_62131673", action = "Index", alias = UrlParameter.Optional },
              namespaces: new[] { "Project_62131673.Controllers" }
          );
            routes.MapRoute(
    name: "RoleEdit",
    url: "admin/Role_62131673/edit/{id}",
    defaults: new { controller = "Role_62131673", action = "Edit", id = UrlParameter.Optional },
    namespaces: new[] { "Project_62131673.Controllers" }
);

            routes.MapRoute(
         name: "CheckOut",
         url: "thanh-toan",
         defaults: new { controller = "ShoppingCart_62131673", action = "CheckOut", alias = UrlParameter.Optional },
         namespaces: new[] { "Project_62131673.Controllers" }
     );
            routes.MapRoute(
             name: "ShoppingCart",
             url: "gio-hang",
             defaults: new { controller = "ShoppingCart_62131673", action = "Index", alias = UrlParameter.Optional },
             namespaces: new[] { "Project_62131673.Controllers" }
         );
            routes.MapRoute(
              name: "CategoryProduct",
              url: "danh-muc-san-pham/{alias}-{id}",
              defaults: new { controller = "Products_62131673", action = "ProductCategory", id = UrlParameter.Optional },
              namespaces: new[] { "Project_62131673.Controllers" }
          );
            routes.MapRoute(
            name: "BaiViet",
            url: "post/{alias}",
            defaults: new { controller = "Article_62131673", action = "Index", alias = UrlParameter.Optional },
            namespaces: new[] { "Project_62131673.Controllers" }
        );

            routes.MapRoute(
              name: "detailProduct",
              url: "chi-tiet/{alias}-p{id}",
              defaults: new { controller = "Products_62131673", action = "Detail", alias = UrlParameter.Optional },
              namespaces: new[] { "Project_62131673.Controllers" }
          );
            routes.MapRoute(
               name: "Products_62131673",
               url: "san-pham",
               defaults: new { controller = "Products_62131673", action = "Index", alias = UrlParameter.Optional },
               namespaces: new[] { "Project_62131673.Controllers" }
           );
            routes.MapRoute(
          name: "DetailNew",
          url: "{alias}-n{id}",
          defaults: new { controller = "News_62131673", action = "Detail", id = UrlParameter.Optional },
          namespaces: new[] { "Project_62131673.Controllers" }
      );
            routes.MapRoute(
         name: "Search",
         url: "tim-kiem",
         defaults: new { controller = "TimKiem_62131673", action = "LayTuKhoaTimKiem", id = UrlParameter.Optional },
         namespaces: new[] { "Project_62131673.Controllers" }
     );
            routes.MapRoute(
             name: "NewsList",
             url: "tin-tuc",
             defaults: new { controller = "News_62131673", action = "Index", alias = UrlParameter.Optional },
             namespaces: new[] { "Project_62131673.Controllers" }
         );
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                 namespaces: new[] { "Project_62131673.Controllers" }
            );
            routes.MapRoute(
    name: "AccountEdit",
    url: "admin/account_62131673/edit/{userName}",
    defaults: new { controller = "Account_62131673", action = "Edit" }
);

        }
    }
}
