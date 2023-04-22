using Microsoft.AspNetCore.Components.Web;
using Microsoft.EntityFrameworkCore;
using WebApi.Data.Interfaces;
using WebApi.Models;

namespace WebApi.Data
{
    public class AuthRepository : IAuthRepository
    {

        private readonly DataContext _context;

        public AuthRepository(DataContext context) { this._context = context; }

        public async Task<bool> ExisteDrivers(String lastname)
        {
            if (await _context.Drivers.AnyAsync(x=> x.LastName == lastname)) 
                return true;

            return false;
        }
        public Task<Drivers> ConsultarDriversById(string lastname, string psd)
        {
            throw new NotImplementedException();
        }

        public Task<Drivers> RegistrarDrivers(Drivers drivers, string psd)
        {
            throw new NotImplementedException();
        }
    }
}
