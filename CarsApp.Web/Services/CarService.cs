using CarsApp.Web.Models;

namespace CarsApp.Web.Services
{
    public class CarService
    {
        List<Car> cars =
            [
            new Car { Id = 11, Make = "Toyota", Model = "Camry", Year = 2020, Color = "Blue" },
            new Car { Id = 32, Make = "Honda", Model = "Civic", Year = 2019, Color = "Red" },
            new Car { Id = 3, Make = "Ford", Model = "Mustang", Year = 2021, Color = "Black" },
            new Car { Id = 423, Make = "Chevrolet", Model = "Malibu", Year = 2018, Color = "White" },
            ];

        public Car[] GetAllCars() => cars.OrderBy(c => c.Make).ToArray();

        public Car GetCarById(int id) => cars.Single(c => c.Id == id);

        public void AddCar(Car car)
        {
            car.Id = cars.Count < 0 ? 1 : cars.Max(e => e.Id) + 1;
            cars.Add(car);
        }

        internal void DeleteCar(int id) => cars.Remove(GetCarById(id));
    }
}

