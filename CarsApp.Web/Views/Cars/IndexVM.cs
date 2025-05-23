namespace CarsApp.Web.Views.Cars
{
    public class IndexVM
    {

        public required CarItemVM[] CarItems { get; set; }
        public class CarItemVM
        {

            public required int Id { get; set; }
            public required string Make { get; set; }
            public required string Model { get; set; }
            public required int Year { get; set; }
            public required string Color { get; set; }

        }
    }
}
