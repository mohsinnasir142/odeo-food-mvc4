using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OdeoFoodMVC4.Models;

namespace OdeoFoodMVC4.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
           
            var ModelHome = new homeModel();

            ModelHome.getAddress = "Township";
            ModelHome.getLocation = "Pakistan   "+DateTime.UtcNow;
            return View( ModelHome);
        }

        public ActionResult About()
        {   
           // AboutModel models=new AboutModel();
            var models = new AboutModel();
            //both lines will work
            models.Name = "Mohsin";
            models.Location = "Lahore";
            return View(models);
        }

        public ActionResult Contact()
        {
            var controller = RouteData.Values["controller"].ToString()+" / " + RouteData.Values["action"].ToString()+" / " + RouteData.Values["id"];
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";
            ViewBag.Message = " this is router "+controller;

            return View();
        }
        public string ActionOnClick(string input) {
            if(input=="")
                return "Enter The value first";
            else
            return "your name is "+input;
        }


        public string LogIn(LoginModelNew obj)
        {

            return obj.username +"   "+ obj.password ;
        }
    }
}
