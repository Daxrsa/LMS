namespace Domain.Entities
{
    public class Course
    {
        public Guid Id { get; set; }
        public Guid ExamId { get; set; }
        public string Title { get; set; }
        public int NrOfStudents { get; set; }
        public Department Department { get; set; }
        public Exam Exam { get; set; }
        public virtual ICollection<Professor> Professors { get; set; } = new List<Professor>();
        public virtual ICollection<Student> Students { get; set; } = new List<Student>();
    }
}