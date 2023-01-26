namespace Domain.Entities
{
    public class Request
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public Administration Administration { get; set; }
        public User User { get; set; }
    }
}