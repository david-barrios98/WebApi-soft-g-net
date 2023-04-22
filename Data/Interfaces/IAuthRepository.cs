using WebApi.Models;

namespace WebApi.Data.Interfaces
{
    public interface IAuthRepository
    {
        Task<Drivers> RegistrarDrivers(Drivers drivers, string psd);

        Task<Drivers> ConsultarDriversById(String lastname, string psd);


    }
}
