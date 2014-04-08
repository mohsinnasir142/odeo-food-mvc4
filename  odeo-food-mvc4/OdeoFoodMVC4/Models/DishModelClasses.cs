using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace OdeoFoodMVC4.Models
{
    public class DishModelClasses
    {
        [Required(ErrorMessage = "Category is required")]
        [StringLength(20, MinimumLength = 5, ErrorMessage = "Minimum 5 Chracters & Maximum 20 Chracters is Allowed")]
        public string DishCategoryTB { get; set; }

        [Required(ErrorMessage = "Description is required")]
        [StringLength(100, MinimumLength = 10, ErrorMessage = "Minimum 10 Chracters & Maximum 100 Chracters is Allowed")]
        public string DishDescriptionTB { get; set; }
        
    }
    public class CreateDishModel {

        [Required(ErrorMessage = "Item Name is required")]
        [StringLength(20, MinimumLength = 5, ErrorMessage = "Minimum 5 Chracters & Maximum 20 Chracters is Allowed")]
        public string ItemName { get; set; }

        [Required(ErrorMessage = "Item Price is required")]
        public int ItemPrice { get; set; }

        [Required(ErrorMessage = "Item Description is required")]
        [StringLength(100, MinimumLength = 10, ErrorMessage = "Minimum 10 Chracters & Maximum 100 Chracters is Allowed")]
        public string ItemDescription { get; set; }

       
        public int ItemTypeFK { get; set; }

        public string ItemImageUrl { get; set; }
        [Required(ErrorMessage = "Item Serving is required")]
        [RegularExpression(@"[0-9]*\.?[0-9]+", ErrorMessage = "Serving number  must be a Numbers only.")]
        public string ItemServing { get; set; }
    
    }
   
}