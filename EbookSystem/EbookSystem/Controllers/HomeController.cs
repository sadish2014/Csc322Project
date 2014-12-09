using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EbookSystem.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to our Ebook Sale System.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Ebook Sale System";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact us Page";

            return View();
        }
    }
}
