using AsgSearch.web.Classes;
using System.Web.Mvc;
using StackExchange.StacMan;
using System.Collections;
using AsgSearch.DAL;
using System.Collections.Generic;
using System;
using System.Linq;

namespace AsgSearch.web.Controllers
{
    public class HomeController : Controller
    {
      

        
        public ActionResult Index()
        {
            ViewBag.Title = "Home";

            return View();
        }
        public ActionResult Step1()
        {
            ViewBag.Title = "Step 1";

            return View();
        }
        public ActionResult Step2()
        {
            ViewBag.Title = "Step 2";

            return View();
        }
        public ActionResult Step3()
        {
            ViewBag.Title = "Step 3";

            return View();
        }

    }
}
