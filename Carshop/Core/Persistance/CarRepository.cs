using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Carshop.Shared;
using Carshop.Core;

namespace Carshop.Core.Persistance
{
    public class CarRepository : ICarRepository
    {
        private readonly CarshopDb _context;

        public CarRepository(CarshopDb context)
        {
            _context = context;
        }


        public async Task<Voiture> GetCarById(int carId)
        {
            return await _context.Voitures.FirstAsync(e => e.VoitureID == carId);
        }


        public async Task<IEnumerable<Voiture>> GetCars()
        {

            var query = _context.Voitures
                .AsQueryable();

            return await query.ToListAsync();
        }

   
        /**
        public async Task<IEnumerable<CakeNameIdDto>> GetAllCakesNameId()
        {
            return await _context.Cakes
                 .Select(e => new CakeNameIdDto
                 {
                     Id = e.Id,
                     Name = e.Name
                 })
                 .ToListAsync();
        }


        public void UpdateCake(Cake cake)
        {
            _context.Cakes.Update(cake);
        }

        public async Task AddCakeAsync(Cake cake)
        {
            await _context.Cakes.AddAsync(cake);
        }

        public void Delete(int id)
        {
            var cake = new Cake { Id = id };
            _context.Entry(cake).State = EntityState.Deleted;
        }
        **/
    }
}
