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
            ViewBag.Message = "your actors";

            return View();
        }

        public ActionResult Directors()
        {
            ViewBag.Message = "View you faverioute Directors";

            return View();
        }

        public ActionResult Genre()
        {
            ViewBag.Message = "Look for your faverioute Genre";

            return View();
        }

        public ActionResult FilmsStoriesandGossip()
        {
            ViewBag.Message = "look at the gossip";

            return View();
        }

        public ActionResult Films()
        {
            ViewBag.Message = "Look at faverioute Films";

            return View();
        }

        public ActionResult Action()
        {
            ViewBag.Message = "Look at Action Films";
            return View();
        }

        public ActionResult Horror()
        {
            ViewBag.Message = "Look at Horror";
            return View();
        }

        public ActionResult Sciencefiction()
        {
            ViewBag.Message = "Look at Sci-Fi";
            return View();
        }

        public ActionResult MartialArts()
        {
            ViewBag.Message = "Look at Martial Arts";
            return View();
        }

        public ActionResult Drama()
        {
            ViewBag.Message = "Look at Drama";
            return View();
        }
    }
}