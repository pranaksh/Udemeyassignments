using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Udemeyassignment.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult About()
        {
            return View();
        }

        public ActionResult Index(string arg="")
        {
            if(arg=="")
            {
                return View();
            }

            else if (arg=="sample")
            {
                return File("~/Sample.pdf","application/pdf");
            }
            else if (arg=="gotoabout")
            {
                return RedirectToAction("About");
            }
            else if (arg=="login")
            {
                return View("Login");
            }
            else
            {
                return Content("You have typed :"+arg);
            }
        }
    }
}