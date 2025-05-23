namespace CarsApp.Web.Views.Cars
{
    public class EditVM
    {

        public string Make { get; set; } = string.Empty;
        public required string Model { get; set; } = string.Empty;
        public required int Year { get; set; }
        public required string Color { get; set; } = string.Empty;

    }
}
