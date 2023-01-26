namespace Domain.Entities
{
    public class Administration
    {
        public Guid Id { get; set; }
        public string Leader { get; set; }
        public virtual ICollection<Request> Requests { get; set; } = new List<Request>();
    }
}