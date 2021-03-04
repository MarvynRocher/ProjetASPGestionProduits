using Carshop.Core;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Carshop.Core.ViewModel;
using System;


namespace Carshop.Controllers
{
    [Route("/voitures")]
    public class CarController : Controller
    {
        
        private readonly ICarRepository _carRepository;

        public CarController(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        public async Task<IActionResult> List()
        {

            var carsListViewModel = new CarsListViewModel
            {
                Voitures = await _carRepository.GetCars()
 
            };
            return View(carsListViewModel);
        }

        [HttpGet("details/{id}")]
        public async Task<IActionResult> Details(int id)
        {

            var car = await _carRepository.GetCarById(id);

            return View(car);
        }
    }
}
