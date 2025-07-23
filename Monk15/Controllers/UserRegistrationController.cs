using Monk15.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Monk15.Controllers
{
    public class UserRegistrationController : Controller
    {
        // GET: UserRegistration
        public ActionResult UserRegistrationIndex()
        {
            return View();
        }

        public ActionResult SaveUserRegistration(UserRegistrationModel model)
        {
            try
            {
                return Json (new { Message = (new UserRegistrationModel().SaveUserRegistration(model)) }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return Json(new { ex.Message }, JsonRequestBehavior.AllowGet);
            }

        }
    }
    
}