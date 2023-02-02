namespace Domain.Entities
{
    public class Assignment
    {
        public Guid Id { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateDeleted { get; set; }
        public DateTime Deadline { get; set; }
        public Professor Professor { get; set; }
        public virtual ICollection<Media> Medias { get; set; } = new List<Media>();
    }
}