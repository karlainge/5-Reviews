using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _5_Stars_Reviews.Controllers
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

        public ActionResult Actors ()
        {
            ViewBag.Message = "Your actors";

            return View();
        }

        public ActionResult Directors()
        {
            ViewBag.Message = "View your faverioute Directors";

            return View();
        }

        public ActionResult Genre()
        {
            ViewBag.Message = "Look for your faverioute Genre";

            return View();
        }

        public ActionResult FilmsStoriesandGossip()
        {
            ViewBag.Message = "Look at the gossip";

            return View();
        }
    }
}