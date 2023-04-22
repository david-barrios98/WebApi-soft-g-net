﻿namespace WebApi.Models
{
    public class Vehicles
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int? Year { get; set; }
        public int? Make { get; set; }
        public int? Capacity { get; set; }
        public bool? Active { get; set; }
    }
}
