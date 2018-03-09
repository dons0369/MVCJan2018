using System.Web.Mvc;
namespace MVCJan2018
{
   public class FilterConfig
   {
      public static void RegisterGlobalFilters(GlobalFilterCollection filters)
      {
         //filters.Add(new AuthorizeAttribute());
         //filters.Add(new HandleErrorAttribute());

         filters.Add(new AuthorizeAttribute());
         //filters.Add(new CustomActionFilter());
         filters.Add(new HandleErrorAttribute());
      }
   }
}
