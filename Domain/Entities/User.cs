namespace Domain.Entities
{
    public class User
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int PhoneNumber { get; set; }
        public DateTime BirthDate { get; set; }
        public virtual ICollection<Request> Requests { get; set; } = new List<Request>();
    }
}