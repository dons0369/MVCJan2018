using System.Web.Mvc;

namespace MVCJan2018.Controllers
{
   public class HomeController : Controller
   {
      public ActionResult Index()
      {
         return View();
      }

      public ActionResult About()
      {
         ViewBag.Message = "Your application description page.";

         return View();
      }

      //[NonAction]

      //[ChildActionOnly]
      public ActionResult Contact()
      {
         ViewBag.Message = "Your contact page.";
         //string value = TempData["TDvalue"].ToString();
         return View();
      }

      public ActionResult Info3()
      {
         ViewBag.Message = "Your contact page.";
         //string value = TempData["TDvalue"].ToString();
         return View();
      }
   }
}