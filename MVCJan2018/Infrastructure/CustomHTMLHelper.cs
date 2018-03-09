using System;
using System.Web;
using System.Web.Mvc;

namespace MVCJan2018.Infrastructure
{
   public static class CustomHTMLHelper
   {
      public static HtmlString LabelWithBold(string content)
      {
         string htmlstring = String.Format("<label><bold>{0}<bold><label>", content);
         return new HtmlString(htmlstring);
      }

      public static HtmlString LabelWithBoldHTML(this HtmlHelper helper, string content)
      {
         string htmlstring = String.Format("<label><bold>{0}<bold><label>", content);
         return new HtmlString(htmlstring);
      }
   }
}