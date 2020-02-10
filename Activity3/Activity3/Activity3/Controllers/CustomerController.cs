using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using CM = Activity3.Models.CustomerModel;

using static System.Tuple;



namespace Activity3.Controllers
{
    public class CustomerController : Controller
    {
        private List<CM> customers { get; set; }
        
        public CustomerController()
        {
            CM cust1 = new CM(1, "Julius Cesar", 33);
            CM cust2 = new CM(2, "Edgar Allen Poe", 499);
            CM cust3 = new CM(3, "Woodroe Wilson", 56);

            customers = new List<CM>();

            customers.Add(cust1);
            customers.Add(cust2);
            customers.Add(cust3);
        }

        // GET: Customer
        public ActionResult Index()
        {

            Tuple<List<CM>, CM> tuple = new Tuple<List<CM>, CM>(customers, customers[0]);

            return View(tuple);
        }

        [HttpPost]
        public ActionResult OnSelectCustomer(string Customer)
        {
            int id = int.Parse(Customer);
            CM cust = customers.Where(i => i.ID == id).First();

            //Tuple<List<CM>, CM> tuple = new Tuple<List<CM>, CM>(this.customers, cust);

            return PartialView("_CustomerDetails", cust);
        }
    }
}