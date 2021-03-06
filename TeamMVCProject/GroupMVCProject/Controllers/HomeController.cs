using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GroupMVCProject.Controllers
{
    public class HomeController : Controller
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your College's description page.";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }

        public ActionResult Course()
        {
            ViewBag.Message = "Your Course page.";
            return View();
        }
        public ActionResult CourseID1()
        {
            ViewBag.Message = "Computer Science";
            return View();
        }
        public ActionResult CourseID2()
        {
            ViewBag.Message = "Software Engineering";
            return View();
        }

        public ActionResult CourseID3()
        {
            ViewBag.Message = "Cyber Security";
            return View();
        }
        public ActionResult CourseModel()
        {
             //ViewBag.Message = "Your Course page.";
             return View();
        }

        public ActionResult Modules()
        {
            //ViewBag.Message = "Your Course page.";
             return View();
        }

        public ActionResult Student()
        {
            //ViewBag.Message = "Your Student's page.";
            return View();
        }
        
        public ActionResult Submit()
        {
            ViewBag.Message = "Submit page.";
            return View();
        }

        public ActionResult UpdatedDetails()
        {
            ViewBag.Message = "Updated Details";
            return View();
        }

        public ActionResult Register()
        {
            ViewBag.Message = "Please fill this with your personal details";
            return View();
        }
        public ActionResult UserPassword()
        {
            ViewBag.Message = null;
            return View();
        }
        public ActionResult UserName()
        {
            ViewBag.Message = null;
            return View();
        }
        public ActionResult UsernameModel()
        {
            // ViewBag.Message = "Please fill this with your personal details";
            return View();
        }
    }
}