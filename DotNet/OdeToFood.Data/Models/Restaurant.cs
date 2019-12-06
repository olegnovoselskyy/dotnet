using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdeToFood.Data.Models
{
    public class Restaurant
    {
        public int RestaurantID { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [Display(Name = "Restaurant Name")]
        public string RestaurantName { get; set; }

        [Display(Name = "Cuisine")]
        public CuisineType CuisineType { get; set; }
    }
}
