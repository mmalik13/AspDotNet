using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentsMVC.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult TestAction(string name)
        {
            ViewBag.Message = "Test Action. Hello from ";
            ViewBag.Name = name;
            return View();
        }
    }
}