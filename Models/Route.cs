namespace WebApi.Models
{
    public class Route
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int DriverId { get; set; }
        public int VehicleId { get; set; }
        public bool Active { get; set; }

        public Route()
        {
        }

        public Route(int id, string description, int driverId, int vehicleId, bool active)
        {
            Id = id;
            Description = description;
            DriverId = driverId;
            VehicleId = vehicleId;
            Active = active;
        }
    }
}
