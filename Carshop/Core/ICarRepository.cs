
using System.Collections.Generic;
using System.Threading.Tasks;
using Carshop.Shared;

namespace Carshop.Core
{
    public interface ICarRepository
    {
        Task<IEnumerable<Voiture>> GetCars();
        

        Task<Voiture> GetCarById(int carId);

       // Task<IEnumerable<CarNameIdDto>> GetAllCarsNameId();

    //    void UpdateCake(Cake cake);
      //  Task AddCakeAsync(Cake cake);
        //void Delete(int id);
    }
}
