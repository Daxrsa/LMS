namespace Domain.Entities
{
    public class Assignment
    {
        public Guid Id { get; set; }
        public DateTime DateCreated { get; set; }
        public Professor Professor { get; set; }
        public virtual ICollection<File> Files { get; set; } = new List<File>();
    }
}