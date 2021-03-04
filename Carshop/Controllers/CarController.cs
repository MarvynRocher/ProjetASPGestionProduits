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
    //    private readonly ICategoryRepository _categoryRepository;


        public CarController(ICarRepository carRepository)
        {
          
            _carRepository = carRepository;
           // _categoryRepository = categoryRepository;
        }

      //  [HttpGet("{category?}")]
      [HttpGet("/test")]
        public async Task<IActionResult> List()
        {
           // var selectedCategory = !string.IsNullOrWhiteSpace(category) ? category : null;
            var carsListViewModel = new CarsListViewModel
            {
                Voitures = await _carRepository.GetCars()
                //(selectedCategory),
                //CurrentCategory = selectedCategory ?? "All Cars"
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
