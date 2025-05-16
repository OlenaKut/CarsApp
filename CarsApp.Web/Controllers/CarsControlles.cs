using CarsApp.Web.Models;
using CarsApp.Web.Services;
using Microsoft.AspNetCore.Mvc;

namespace CarsApp.Web.Controllers
{
    public class CarsController : Controller
    {
        static CarService carService = new CarService();

        [HttpGet("")]
        public IActionResult Index()
        {
            var cars = carService.GetAllCars();
            return View(cars);
        }

        [HttpGet("create")]
        public IActionResult Create()
        {
            return View();
        }


        [HttpPost("create")]
        public IActionResult Create(Car car)
        {

            if (!ModelState.IsValid)
                return View();

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

        [HttpPost("delete/{id}")]
        public IActionResult Delete(int id)
        {
           carService.DeleteCar(id);
            return RedirectToAction(nameof(Index));
        }

    }
}
