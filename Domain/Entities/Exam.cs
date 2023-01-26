namespace Domain.Entities
{
    public class Exam
    {
        public Guid Id { get; set; }
        public Course Course { get; set; }
        public virtual ICollection<Student> Students { get; set; } = new List<Student>();
        public virtual ICollection<Professor> Professors { get; set; } = new List<Professor>();
    }
}