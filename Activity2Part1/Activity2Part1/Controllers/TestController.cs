using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Activity2Part1.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {

            List<Activity2Part1.Models.UserModel> users = new List<Activity2Part1.Models.UserModel>();

            //Activity2Part1.Models.UserModel user = new Models.UserModel("Frank Brock", "HelloKitty453@Motel5.com", "(509) 555-5555");
            //Activity2Part1.Models.UserModel user2 = new Models.UserModel("Mary Poppins", "tester@yahoo.com", "(509) 555-5555");
            //Activity2Part1.Models.UserModel user3 = new Models.UserModel("Luke Sywalker", "tester@yahoo.com", "(509) 555-5555");
            //Activity2Part1.Models.UserModel user4 = new Models.UserModel("Ben Kenobi", "tester@yahoo.com", "(509) 555-5555");
            //
            //users.Add(user);
            //users.Add(user2);
            //users.Add(user3);
            //users.Add(user4);

            
            return View("Test" /*, users*/);

        }
    }
}