using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CSharp_Project.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult xml()
        {
            ViewBag.Title = "Playlist xml";
            ViewBag.Message = "Onze Top Songs";
            return View();
        }

        public ActionResult json()
        {
            ViewBag.Message = "Onze Top Songs";

            return View();
        }
    }
}