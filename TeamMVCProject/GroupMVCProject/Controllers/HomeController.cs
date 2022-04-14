using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GroupMVCProject.Controllers
{
    public class HomeController : Controller
    {
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
    }
}