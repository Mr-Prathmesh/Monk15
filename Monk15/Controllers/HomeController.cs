using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Monk15.Controllers
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

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult OnboardingInfoIndex()
        {  

            return View();
        }

        public ActionResult CommunitySocialConnectIndex()
        {

            return View();
        }

        public ActionResult PersonalizedQuestionsIndex()
        {

            return View();
        }
    }
}