using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using WebApi.Data;
using WebApi.Data.Interfaces;
using WebApi.Models;

namespace WebApi.Controllers
{
    
    [ApiController]
    [Route("api/[controller]")]
    public class DriversControllers : ControllerBase
    {
        private readonly IApiRepository _repo;

        public DriversControllers(IApiRepository repo) {
            _repo = repo;
        }

        [EnableCors("MyPolicy")]
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var drivers = await _repo.GetDriversAsync();

            return Ok(drivers);
        }
        [EnableCors("MyPolicy")]
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var drivers = await _repo.GetDriversByIdAsync(id);

            if (drivers == null)
            {
                return NotFound("Drivers no encontrado");

            }

            

            return Ok(drivers);
        }
        [EnableCors("MyPolicy")]
        [HttpPost]
        public async Task<ActionResult> Post(Drivers drivers)
        {
            _repo.Add(drivers);
            if(await _repo.SaveAll())
            {
                return Ok(drivers);
            }
            return BadRequest();
        }
        [EnableCors("MyPolicy")]
        [HttpPut]
        public async Task<ActionResult> Put(Drivers drivers)
        {
            var Drivers_data = await _repo.GetDriversByIdAsync(drivers.Id);

            if (Drivers_data == null) { return BadRequest(); }

            Drivers_data.FirstName= drivers.FirstName;
            Drivers_data.LastName= drivers.LastName;
            Drivers_data.Zip = drivers.Zip;
            Drivers_data.Address = drivers.Address;
            Drivers_data.City = drivers.City;
            Drivers_data.Dob = drivers.Dob;
            Drivers_data.Active = drivers.Active;

            if (!await _repo.SaveAll()) 
            { 
                return NoContent(); 
            }

            return Ok(Drivers_data);
        }
        [EnableCors("MyPolicy")]
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var Drivers_data = await _repo.GetDriversByIdAsync(id);

            if (Drivers_data == null) { return NotFound("Drivers no encontrado"); }

            _repo.Delete(Drivers_data);

            if (!await _repo.SaveAll())
            {
                return NoContent();
            }

            return Ok(Drivers_data);
        }
    }
}
