﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OdeoFoodMVC4.Controllers
{
    public class DishController : Controller
    {
        //
        // GET: /Dish/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Dish()
        {
            return View();
        }
        public ActionResult AllDishes()
        {
            return View();
        }
        public ActionResult CreateDishType()
        {
            return View();
        }
        public ActionResult AllDishType()
        {
            return View();
        }
    }
}
