﻿using Microsoft.AspNetCore.Mvc;
using WebApi.Data.Interfaces;
using WebApi.Models;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VehiclesControllers : ControllerBase
    {
        private readonly IApiRepository _repo;

        public VehiclesControllers(IApiRepository repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var vehicles = await _repo.GetVehiclesAsync();

            return Ok(vehicles);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var vehicles = await _repo.GetDriversByIdAsync(id);

            if (vehicles == null)
            {
                return NotFound("Vehicles no encontrado");
            }

            return Ok(vehicles);
        }

        [HttpPost]
        public async Task<ActionResult> Post(Vehicles vehicles)
        {
            _repo.Add(vehicles);
            if (await _repo.SaveAll())
            {
                return Ok(vehicles);
            }
            return BadRequest();
        }

        [HttpPut]
        public async Task<ActionResult> Put(Vehicles vehicles)
        {
            var vehicles_data = await _repo.GetVehiclesByIdAsync(vehicles.Id);

            if (vehicles_data == null) { return BadRequest(); }

            vehicles_data.Description = vehicles.Description;
            vehicles_data.Active = vehicles.Active;
            vehicles_data.Capacity= vehicles.Capacity;
            vehicles_data.Year = vehicles.Year;

            if (!await _repo.SaveAll())
            {
                return NoContent();
            }

            return Ok(vehicles_data);
        }
    }

}
