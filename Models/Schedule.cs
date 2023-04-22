namespace WebApi.Models
{
    public class Schedule
    {
        public int Id { get; set; }
        public int? RouteId { get; set; }
        public int? WeekNum { get; set; }
        public DateTime? From { get; set; }
        public DateTime? To { get; set; }
        public bool? Active { get; set; }
    }
}
