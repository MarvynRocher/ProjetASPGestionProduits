using Carshop.Core;
using System.Collections.Generic;
using Carshop.Shared;

namespace Carshop.Core.ViewModel
{
    public class CarsListViewModel
    {
        public IEnumerable<Voiture> Voitures { get; set; }
      //  public string CurrentCategory { get; set; }
    }
}
