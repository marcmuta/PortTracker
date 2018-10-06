using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PortTracker.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Track you Portfolio in the crypto currency market. Project initiative by Sky, Eric and Arnold.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Coin()
        {
            ViewBag.Message = "Your Single Coin Page.";

            return View();
        }

        public ActionResult Coins()
        {
            ViewBag.Message = "Your Coins Page.";

            return View();
        }
    }
}