using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication7_table2_.Models;

namespace WebApplication7_table2_.Controllers
{
    public class spanController : Controller
    {
        // GET: span


        public ActionResult User()
        {
            return View();
        }
         public ActionResult UserDetails(Gopi h)
         {
            if(h.Username=="kumar" && h.Password == "hemath")
            {
                return RedirectToAction("StudentDetails");
            }
            else
            {
               return RedirectToAction("NextStudentDetails");
            }
            
         }
        public ActionResult StudentDetails()
        {
            List<Student> a = new List<Student>();
            a.Add(new Student
            {
                Name = "hemathkumar",
                Id = 1,
                Phno = 123456789

            }) ;
            a.Add(new Student
            {
                Name = "dhanush",
                Id = 2,
                Phno = 345678909
            });
            a.Add(new Student
            {
                Name = "kumar",
                Id = 1,
                Phno = 123456789
            });
            return View(a);
        }
        public ActionResult NextStudentDetails()
        {
            ViewBag.k = "not done successfully";
            return View();
        }
    }
}