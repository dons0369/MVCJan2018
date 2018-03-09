using System.Web.Optimization;

namespace MVCJan2018
{
   public class CustomBundle
   {
      public static void LoadBundle(BundleCollection bundle)
      {
         ScriptBundle script = new ScriptBundle("~/bundle/script");
         script.Include("~/Scripts/jquery-{version}.js");
         script.Include("~/Scripts/jquery.validate*");
         script.Include("~/Scripts/bootstrap.js");

         bundle.Add(script);

         StyleBundle style = new StyleBundle("~/bundle/style");
         style.Include("~/Content/bootstrap.css");
         style.Include("~/Content/site.css");

         bundle.Add(style);
      }
   }
}