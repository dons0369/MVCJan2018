using System.Web.Mvc;
using System.Web.Routing;

namespace MVCJan2018
{
   public class CustomRouteConfig
   {
      public static void LoadRoutes(RouteCollection routes)
      {
         //routes.IgnoreRoute("product/ShowName/");
         routes.MapRoute("MyRoute",
         //"HareKrsna{controller}/{action}/{id}/{*id1}",
         "{controller}/{action}/{id}",
         new
         {
            controller = "Product",
            action = "info",
            id = UrlParameter.Optional,
            id1 = UrlParameter.Optional
         }
            //, new { id = "^r.*" }
            //         routes.MapRoute
            //"firstroute",
            //"{controller}/{action}/{id}",
            //new { id = UrlParameter.Optional, action = "ShowName", controller = "product" }

            );
      }

   }
}