﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ZenithDataLib.Models;
using ZenithWebSite.Models;
using System.Data.Entity;

namespace ZenithWebSite.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext(); //db access

        public ActionResult Index()
        {
            //using System.Data.Entity; must be including for (a=>a) to work 
            //var today = new DateTime(today.Year, today.Month, today.Day);
           // var today = new DateTime(2017, 02, 13);

            DateTime today = DateTime.Today;
            DateTime startOfWeek = today.AddDays(-(int)today.DayOfWeek);
            DateTime endOfWeek = startOfWeek.AddDays(8);

            var activities = db.Activities.Include(a => a.Events)
                                .Where(a => a.Events.Any(b => b.EventFrom >= startOfWeek && b.EventTo <= endOfWeek && b.IsActive == true))
                                .Select(a => a);

            ViewBag.DateFormat = "{0:dddd MMMM dd, yyyy}";
            ViewBag.TimeFormat = "{0:h:mm tt}";

            return View(activities.ToList());

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
    }
}