using CarsApp.Web.Models;
using CarsApp.Web.Services;
using Microsoft.AspNetCore.Mvc;
using CarsApp.Web.Views.Cars;

namespace CarsApp.Web.Controllers
{
    public class CarsController(CarService carService, ILogger<CarsController> logger) : Controller
    {

        [HttpGet("")]
        public IActionResult Index()
        {
            var cars = carService.GetAllCars();

            logger.LogInformation("Cars count: {count}", cars.Length);

            var viewModel = new IndexVM
            {
                CarItems = cars
                .Select(c => new IndexVM.CarItemVM
                {
                    Id = c.Id,
                    Make = c.Make,
                    Model = c.Model,
                    Year = c.Year,
                    Color = c.Color
                })
                .ToArray()
            };
            return View(viewModel);
        }

        [HttpGet("create")]
        public IActionResult Create()
        {
            return View();
        }


        [HttpPost("create")]
        public IActionResult Create(CreateVM viewModel)
        {

            if (!ModelState.IsValid)
                return View();

            var car = new Car
            {
                Make = viewModel.Make,
                Model = viewModel.Model,
                Year = int.Parse(viewModel.Year),
                Color = viewModel.Color
            };

            carService.AddCar(car);

            return RedirectToAction(nameof(Index));
        }

        [HttpGet("details/{id:int}")]
        public IActionResult Details(int id)
        {
            var car = carService.GetCarById(id);
            if (car == null)
                return NotFound();
            return View(car);
        }

        [HttpGet("edit/{id}")]
        public IActionResult Edit(int id)
        {
            var model = carService.GetCarById(id);

            var viewModel = new EditVM
            {
                Make = model.Make,
                Model = model.Model,
                Year = model.Year,
                Color = model.Color
            };
            return View(viewModel);

        }

        [HttpPost("edit/{id}")]
        public IActionResult Edit(Car car)
        {
            carService.UpdateCar(car);
            return RedirectToAction(nameof(Index));
        }


        [HttpPost("delete/{id}")]
        public IActionResult Delete(int id)
        {
           carService.DeleteCar(id);
            return RedirectToAction(nameof(Index));
        }

    }
}
