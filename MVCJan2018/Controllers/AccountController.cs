using MVCJan2018.Infrastructure;
using MVCJan2018.Models;
using System.Linq;
using System.Web.Mvc;
using System.Web.Security;

namespace MVCJan2018.Controllers
{
   public class AccountController : Controller
   {
      // GET: Account
      MVCDBContext dbcontext = new MVCDBContext();
      [AllowAnonymous]
      public ActionResult Login()
      {
         return View();
      }
      [AllowAnonymous]
      [HttpPost]
      public ActionResult Login(Users userObj)
      {
         var data = dbcontext.User.FirstOrDefault(i => i.Email == userObj.Email && i.Password == userObj.Password);
         if (data != null)
         {
            Session["UserSession"] = data;
            FormsAuthentication.SetAuthCookie(userObj.Email, false);
            return RedirectToAction("Index", "StudentDB");
         }
         else
            return View();
      }

      public ActionResult Logout()
      {
         FormsAuthentication.SignOut();
         return RedirectToAction("Login");
      }
   }
}