using WebApi.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebApi.Data.Interfaces
{
    public interface IApiRepository
    {
        void Add<T>(T entity) where T : class;

        void Delete<T>(T entity) where T : class;

        Task <bool> SaveAll();

        Task<IEnumerable<Drivers>> GetDriversAsync();

        Task<Drivers> GetDriversByIdAsync(int id);

        Task<IEnumerable<Vehicles>> GetVehiclesAsync();

        Task<Vehicles> GetUVehiclesByIdAsync(int id);
    }
}
