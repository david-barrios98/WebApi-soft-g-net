using Microsoft.EntityFrameworkCore;
using WebApi.Models;
using System;
using System.Collections.Generic;

namespace WebApi.Data
{
    public partial class DataContext : DbContext
    {
        public DataContext() {
        }
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Drivers> Drivers { get; set; }

        public DbSet<Vehicles> Vehicles { get; set; }

        public DbSet<Models.Route> Route { get; set; }

        public DbSet<Schedule> Schedules { get; set; }

        

    }
}
