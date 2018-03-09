using MVCJan2018.Infrastructure;
using MVCJan2018.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace MVCJan2018.Controllers
{
   public class StudentDBController : Controller
   {
      // GET: StudentDB
      MVCDBContext dbcontext = new MVCDBContext();


      public ActionResult Index()
      {
         //List<Student> students = dbcontext.Student.ToList();
         Users userData = (Users)Session["UserSession"];
         List<Student> students = dbcontext.Student.Where(i => i.UserId == userData.Id).ToList();
         return View(students);
      }

      public ActionResult Create()
      {
         return View();
      }

      [HttpPost]
      public ActionResult Create(Student studentObj)
      {
         dbcontext.Student.Add(studentObj);
         dbcontext.SaveChanges();
         return RedirectToAction("Index");
      }

      public ActionResult Edit(int id)
      {
         Student studentObj = dbcontext.Student.First(i => i.Id == id);
         return View(studentObj);
      }

      [HttpPost]
      public ActionResult Edit(Student studentObj)
      {
         dbcontext.Entry(studentObj).State = System.Data.Entity.EntityState.Modified;
         dbcontext.SaveChanges();
         return RedirectToAction("Index");
      }

      public ActionResult Delete(int id)
      {
         Student studentObj = dbcontext.Student.First(i => i.Id == id);
         dbcontext.Student.Remove(studentObj);
         dbcontext.SaveChanges();
         return RedirectToAction("Index");
      }
   }
}