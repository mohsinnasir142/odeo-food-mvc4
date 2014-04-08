using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OdeoFoodMVC4.Models;

namespace OdeoFoodMVC4.Controllers
{
    
    public class DishController : Controller
    {
        //
        // GET: /Dish/
        DishModel model = new DishModel();
        public ActionResult Index()
        {
            return View();
        }
        [Authorize(Roles = "administrator, manager")]
        public ActionResult Dish()
        {
            ViewBag.ItemTypes = model.getItemTypeNames();
            return View();
        }
        [Authorize(Roles = "administrator, manager,customer")]
        public ActionResult AllDishes()
        {
           
             return View(model.getAllDishes());
        }
        public ActionResult CreateDishType()
        {
            return View();
        }
        
        public ActionResult AllDishType()
        {
            return View(model.getAllDishTypes());
        }

        [HttpPost]
        public ActionResult InsertDishType(DishModelClasses obj)
        {
            if(ModelState.IsValid){
                model.InsertDishType(obj);
                return RedirectToAction("CreateDishType", "Dish", null);
            }
            return RedirectToAction("CreateDishType", "Dish", null);
        }
        
        [HttpPost]
        public ActionResult InsertDish(CreateDishModel createDishObj, HttpPostedFileBase file,FormCollection frmCollection)
        {
            if (ModelState.IsValid)
            {
                if (file != null)
                {
                    var filename = Path.GetFileName(file.FileName);
                    var path = Path.Combine(Server.MapPath("~/Images/DBImages/"), filename);
                    file.SaveAs(path);
                    createDishObj.ItemImageUrl = "../../Images/DBImages/" + filename;
                }
                else 
                {

                    createDishObj.ItemImageUrl = "../../Images/DBImages/notfound.jpg";
                }
                createDishObj.ItemServing = "Order for "+ createDishObj.ItemServing+" Person";
                createDishObj.ItemTypeFK = Convert.ToInt32(frmCollection.GetValue("itemTypes").AttemptedValue.ToString());
                model.InsertDish(createDishObj);
                return RedirectToAction("Dish", "Dish", null);
            }
            return RedirectToAction("Dish", "Dish", null);
        }

        [HttpPost]
        public void deleteDishType(int id) {
        
        
        }
    }
}
