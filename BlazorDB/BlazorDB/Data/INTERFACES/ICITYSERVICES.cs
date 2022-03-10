using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorDB.Data.INTERFACES
{
   public interface ICITYSERVICES
    {
        Task<IEnumerable<City>> GetCities();
        Task<bool> CreateCity(City city);
        Task<bool> EditCity(int id, City city);
        Task<City> SingleCity(int id);
        Task<bool> DeleteCity(int id);
    }
}
