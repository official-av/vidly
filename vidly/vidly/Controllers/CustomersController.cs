using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using vidly.Models;

namespace vidly.Controllers
{
    public class CustomersController : Controller
    {
        static List<Customer> csList = new List<Customer>
        {
            new Customer {Id=1,Name="Anmol vashistha"},
            new Customer {Id = 2,Name = "Post Malone"}
        };

        // GET: Customers
        public ActionResult Index()
        {
            return View(csList);
        }
        public ActionResult Details(int Id)
        {
            return View(csList[Id-1]);
        }

        
        
    }
}