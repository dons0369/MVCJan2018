using BusinessSerivice;
using MVCJan2018.Models;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace MVCJan2018.Controllers
{
   //[Authorize]
   public class ProductController : Controller
   {
      private EmployeeService _employeeService;

      public ProductController()
      {
         _employeeService = new EmployeeService();
      }
      public string Print()
      {
         return "Pragim Tech";
      }

      //public string ShowName()
      //{
      //   string id = RouteData.Values["id"].ToString();
      //   return "This is Krishna with id : " + id;
      //}

      //Below ShowName Action Method way with Parameters to 
      //capture data from url is Mostly Used and preferred, rather than the above ShowName method
      public string ShowName(string id)
      {
         return "This is Krishna with id : " + id;
      }
      //Returns Info.cshtml view to the Browser
      //[AllowAnonymous]
      //[Authorize]
      //[HandleError]
      public ActionResult Info(string id)
      {
         //throw new Exception("Error Occurred");

         ViewData["dName"] = "HareKrishna";
         ViewData["dEmail"] = "HareKrishna@gmail.com";
         ViewData["dDate"] = DateTime.Now;

         ViewBag.bName = "HareRama";
         ViewBag.bEmail = "HareRama@gmail.com";
         ViewBag.bDate = DateTime.Now;

         if (id == "redirect")
         {
            TempData["MyValue"] = "Session Data Temp Data";
            return RedirectToAction("info2", "Product");
         }
         return View();
      }

      public ActionResult ControllerRedirect(string id)
      {
         if (id == "anothercontroller")
         {
            TempData["TDValue"] = "TD/Session Value From Product Controller";
            return RedirectToAction("Contact", "Home");
         }
         return View();
      }

      //Returns RazorView.cshtml view to the Browser though the 
      //Action Method name is info. But, It has return View("RazorView")
      //public ActionResult Info()
      //{
      //   return View("RazorView");
      //}

      //return Content:- Returns the String as the return value
      //Since it is not returning View but returning just content.
      public ActionResult Info2()
      {
         string strVariable = TempData["MyValue"].ToString();
         return View();

         //TempData.Keep();
         //return RedirectToAction("Content", "Product");
      }
      //[Authorize]
      //[AllowAnonymous]
      public ActionResult Content()
      {
         return Content("This is content type");
      }
      public ActionResult RazorView()
      {
         return View();
      }

      public ActionResult Variables()
      {
         ViewData["Name"] = "HareKrishna";
         ViewData["Email"] = "HareKrishna@gmail.com";
         ViewData["Date"] = DateTime.Now;

         ViewBag.Name = "HareRama";
         ViewBag.Email = "HareRama@gmail.com";
         ViewBag.Date = DateTime.Now;

         return View();
      }

      public ActionResult Employee()
      {
         ViewBag.Name = "Gauranga";
         Employee empObj = new Employee
         //{ Id = 1, Name = "HareKrsna", Email = "HareKrsna@gmail.com", Address = "Srila Prabhupaad" };
         {
            Id = 1,
            Name = "HareKrsna",
            Email = "HareKrsna@gmail.com",
            Address = "Srila Prabhupaad",
            dept = new Department { Id = 10, Name = "Software", Location = "NYC" }
         };
         return View(empObj);
      }
      public ActionResult EmployeeList()
      {
         List<Employee> emplist = new List<Models.Employee>
         {
            new Employee {Id=2, Name="second", Email="secondEmail",Address="secondAddress" },
            new Employee {Id=3, Name="Three", Email="ThreeEmail",Address="ThreeAddress" },
            new Employee {Id=4, Name="Four", Email="Four Email",Address="Four Address" },
         };
         return View(emplist);
      }

      public ActionResult EmpDept()
      {
         ViewBag.Name = "Nithai";
         Employee empObj = new Employee
         { Id = 1, Name = "skrr", Email = "skrrEmail", Address = "Addresskrr ED" };

         Department deptObj = new Department
         { Id = 10, Name = "software", Location = "NY empdept" };

         EmpDept empdept = new EmpDept
         {
            emp = empObj,
            dept = deptObj
         };
         //EmpDept empdept = new EmpDept();
         //empdept.emp = empObj;
         //empdept.dept = deptObj;

         return View(empdept);
      }

      public ActionResult Emp()
      {
         Employee empObj = new Employee
         {
            Id = 1,
            Name = "HareKrsna",
            Email = "HareKrsna@gmail.com",
            Address = "Srila Prabhupaad"
         };
         return Json(empObj, JsonRequestBehavior.AllowGet);
      }

      //By Default it is HttpGet, when u don't specify Get or Post
      public ActionResult Create()
      {
         return View();
      }

      [HttpPost]
      public ActionResult Create(ProductVM product)
      {
         if (ModelState.IsValid)
         {

         }
         return RedirectToAction("Employee");
      }
   }
}