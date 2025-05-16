using System.ComponentModel.DataAnnotations;

namespace CarsApp.Web.Models
{
    public class BadCarAttribute(string make) : ValidationAttribute
    {
        public override bool IsValid(object? value) =>
            value?.ToString()?.ToUpper() != make.ToUpper();
    }
    
}
