﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SessionStateAsyncExample.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            Session["User"] = "Ted";
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult StartSession()
        {
            Session["User"] = "Session started for John Doe!";

            return View("Index");
        }

        public ActionResult ClearSession()
        {
            Session.Clear();

            return View("Index");
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page for " + Session["User"];

            return View();
        }
    }
}