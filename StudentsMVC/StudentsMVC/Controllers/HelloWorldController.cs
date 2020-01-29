using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentsMVC.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: HelloWorld
        public ActionResult Index(String name)
        {
            ViewBag.Message = "HelloWorld Controller. Name is: " + name;
            return View();
        }

        public ActionResult Welcome(String name, int numTimes = 1)
        {
            ViewBag.Message = $"Hello from {name}";
            ViewBag.numTimes = numTimes;
            return View();
        }
    }
}