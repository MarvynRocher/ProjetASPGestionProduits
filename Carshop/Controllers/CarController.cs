using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System;
using Carshop.Shared;
using Carshop.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Carshop.Controllers
{
    [Route("/voitures")]
    public class CarController : Controller
    {

        private CarshopDb db;

        public CarController(CarshopDb injectedContext)
        {
            db = injectedContext;
        }

        public IActionResult List()
        {

            var carsListViewModel = new CarViewModel
            {
                Voitures = db.Voitures.ToList()
 
            };
            return View(carsListViewModel);
        }

        [HttpGet("details/{id}")]
        public IActionResult Details(int id)
        {

            var car = db.Voitures.Where(e => e.VoitureID == id).SingleOrDefault();

            return View(car);
        }
    }
}
