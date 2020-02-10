using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CM = Activity3V2.Models.CustomerModel;

namespace Activity3V2.Controllers
{
    public class CustomerController : Controller
    {
        private List<CM> Customers { get; set; } = new List<CM>();

        public CustomerController()
        {
            CM customer1 = new CM(1, "Harry Potter", 30);
            CM customer2 = new CM(2, "Severus Snape", 60);
            CM customer3 = new CM(3, "Albus Dumbledore", 255);

            this.Customers.Add(customer1);
            this.Customers.Add(customer2);
            this.Customers.Add(customer3);
        }

        // GET: Customer
        public ActionResult Index()
        {
            Tuple<List<CM>, CM> tuple = 
                new Tuple<List<CM>, CM>(this.Customers, this.Customers[0]);


            return View(tuple);
        }

        [HttpPost]
        public ActionResult OnSelectCustomer(string Customer)
        {
            int id = int.Parse(Customer);

            CM customer = this.Customers.Where(i => i.ID == id).First();

            return PartialView("_CustomerDetails", customer);
        }


        [HttpPost]
        public String GetMoreInfo(String CustomerID)
        {
            return "You Did it!!";
        }
    }
}