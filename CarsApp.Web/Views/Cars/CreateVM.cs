using CarsApp.Web.Models;
using System.ComponentModel.DataAnnotations;

namespace CarsApp.Web.Views.Cars
{
    public class CreateVM
    {

        [Required(ErrorMessage = "Make is required")]
        [StringLength(30, MinimumLength = 2, ErrorMessage = "Make must be 2-30 characters")]
        [Display(Name = "Car Make")]
        [BadCar("Tesla", ErrorMessage = "This is not the best option")]
        public required string Make { get; set; }

        [Required(ErrorMessage = "Model is required")]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "Make must be 2-20 characters")]
        [Display(Name = "Car Model")]
        public required string Model { get; set; }

        [Required(ErrorMessage = "Year is required")]
        [Range(1886, 2025, ErrorMessage = "Year must be between 1886 and 2025")]
        [Display(Name = "Car Year")]
        public required string Year { get; set; }

        [Required(ErrorMessage = "Color is required")]
        [StringLength(20, ErrorMessage = "Make must be 2-20 characters")]
        [Display(Name = "Car Color")]
        public required string Color { get; set; }

    }
}
