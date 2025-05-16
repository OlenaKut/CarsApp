using System.ComponentModel.DataAnnotations;

namespace CarsApp.Web.Models
{
    public class Car
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Make is required")]
        [StringLength(50, ErrorMessage = "Make cannot be longer than 25 characters")]
        [Display(Name = "Car Make")]
        public string Make { get; set; } = string.Empty;

        [Required(ErrorMessage = "Model is required")]
        [StringLength(50, ErrorMessage = "Model cannot be longer than 20 characters")]
        [Display(Name = "Car Model")]
        public string Model { get; set; } = string.Empty;

        [Required(ErrorMessage = "Year is required")]
        [Range(1886, 2025, ErrorMessage = "Year must be between 1886 and 2025")]
        [Display(Name = "Car Year")]
        public int Year { get; set; }

        [Required(ErrorMessage = "Color is required")]
        [StringLength(20, ErrorMessage = "Color cannot be longer than 30 characters")]
        [Display(Name = "Car Color")]
        public string Color { get; set; } = string.Empty;
    }
}