using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Activity1Part2.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public string Index()
        {
            return "<b>Hello World as a string from Index</b>";
        }

        //GET: Play
        [HttpGet]
        public string Play()
        {
            return "<b>Hello Worl as a string from Play</b>";
        }

        //GET: TestView
        [HttpGet]
        public ActionResult TestView()
        {
            return View();
        }
    }
}