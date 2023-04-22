using Microsoft.EntityFrameworkCore;
using WebApi.Data.Interfaces;
using WebApi.Models;

namespace WebApi.Data
{
    public class ApiRespository : IApiRepository
    {

        private readonly DataContext _context;

        public ApiRespository(DataContext context) 
        {
            _context= context;
        }

        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }

        public async Task<IEnumerable<Drivers>> GetDriversAsync()
        {
            var drivers = await _context.Drivers.ToListAsync();
            return drivers;
        }

        public async Task<Drivers> GetDriversByIdAsync(int id)
        {
            var driver = await _context.Drivers.FirstOrDefaultAsync(u => u.Id == id);
            return driver;
        }

        public async Task<Vehicles> GetUVehiclesByIdAsync(int id)
        {
            var vehicle = await _context.Vehicles.FirstOrDefaultAsync(u => u.Id == id);
            return vehicle;
        }

        public async Task<IEnumerable<Vehicles>> GetVehiclesAsync()
        {
            var vehicles = await _context.Vehicles.ToListAsync();
            return vehicles;
        }

        public async Task<bool> SaveAll()
        {
            return await _context.SaveChangesAsync() > 0;
        }

    }
}
