using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VidlyWebsite.Models;

namespace VidlyWebsite.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            var customers = GetCustomers();
            return View(customers);
        }

        public IActionResult GetCustomer(int id)
        {
            var customer = GetCustomers().SingleOrDefault(c => c.Id == id);
            if (customer == null)
            {
                return NotFound();
            }
            else
            {
                return View(customer);
            }
        }

        private IEnumerable<Customers> GetCustomers()
        {
            return new List<Customers>
            {
                new Customers { Id =1 , Name = "BAC"},
                new Customers { Id =2 , Name = "XYZ"}
            };
        }
    }
}
