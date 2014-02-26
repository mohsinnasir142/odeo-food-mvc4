using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OdeoFoodMVC4.Controllers
{
    public class CusineController : Controller
    {
        //
        // GET: /Cusine/

        public ActionResult Search(string name)
        {
            var message = Server.HtmlEncode(name);
            return Content("Hello ! your selected cusine is  "+message + " and Orignal name is "+name);
        }

    }
}
