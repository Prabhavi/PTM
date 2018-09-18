using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TrackerModule.Controllers
{
    public class homeController : Controller
    {
        // GET: home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult add()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult edit()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}