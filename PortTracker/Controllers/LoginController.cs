using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PortTracker.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Login()
        {
            return View();
        }

        // GET: LogOut
        public ActionResult LogOut()
        {
            return View();
        }

        // GET: SignUP
        public ActionResult SignUp()
        {
            return View();
        }
    }
}