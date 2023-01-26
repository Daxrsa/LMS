namespace Domain.Entities
{
    public class Exam
    {
        public Guid Id { get; set; }
        public Course Course { get; set; }
        public Professor Professor { get; set; }
        public DateTime ExamDate { get; set; }
        public string Afati { get; set; }
        public virtual ICollection<Student> Students { get; set; } = new List<Student>();
    }
}