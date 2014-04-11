using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OdeoFoodMVC4.Models;

namespace OdeoFoodMVC4.Controllers
{
    public class CustomerController : Controller
    {
        //
        // GET: /Customer/

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult AllCustomer()
        {
            return View();
        }
        public ActionResult Sales()
        {
            return View();
        }

        public ActionResult CreateOrder()
        {
            return View();
        }
      
    }
}
