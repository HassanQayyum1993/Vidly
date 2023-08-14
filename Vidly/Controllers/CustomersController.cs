using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ViewResult Index()
        {
            var customers = GetCustomers();
            return View(customers);
        }

        // GET: Customer Details
        [Route("Customers/Details/{id}")]
        public ActionResult Details(int id)
        {
            var customers = GetCustomers();
            var customer = customers.SingleOrDefault(c => c.Id == id);

            if (customer == null)
            {
                return HttpNotFound();

            }
            return View(customer);
        }

        private IEnumerable<Customer> GetCustomers()
        {
            return new List<Customer>()
            {
                new Customer() { Id = 1, Name = "Hassan" },
                new Customer() { Id = 2, Name = "Amina" },
                new Customer() { Id = 3, Name = "Abdul Qayyum" },
            };
        }
    }
}