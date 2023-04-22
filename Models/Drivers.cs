namespace WebApi.Models
{
    public class Drivers
    {
        public int Id { get; set; }
        public string? LastName { get; set; }
        public string? FirstName { get; set; }
        public string? Ssn { get; set; }
        public string? Dob { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }
        public string? Zip { get; set; }
        public int? Phone { get; set; }
        public bool Active { get; set; }
    }
}
