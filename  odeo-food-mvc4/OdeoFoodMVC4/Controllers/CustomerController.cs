using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using OdeoFoodMVC4.Models;

namespace OdeoFoodMVC4.Controllers
{
    public class CustomerController : Controller
    {
        //
        // GET: /Customer/
        DishModel dishModelObj = new DishModel();

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
        [HttpPost]
        public JsonResult ReciveJSON(dataArray data)
        {
           return Json(new { Message = "Survey saved sucessfully.", ID = 1234, error = 0 });
        }
        [HttpGet]
        public string  SendJSON()
        {
          return  this.ConvertDataTabletoString();
        }
       public string ConvertDataTabletoString()
         {
            DataTable dt = dishModelObj.getAllDishes();
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row;
            foreach (DataRow dr in dt.Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in dt.Columns)
                {
                    row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }
            return serializer.Serialize(rows);
        }
    
}

       
    
   
    public class Binding
    {
        public string ircEvent { get; set; }
        public string method { get; set; }
        public string regex { get; set; }
    }
    public class dataArray
    {
        public List<Binding> bindings { get; set; }
    }


}
