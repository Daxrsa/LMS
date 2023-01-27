namespace Domain.Entities
{
    public class Student
    {
        public Guid Id { get; set; }
        public Guid TranscriptId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public Department Department { get; set; }
        public Transcript Transcript { get; set; }
        public virtual ICollection<Course> Courses { get; set; } = new List<Course>();
        public virtual ICollection<Exam> Exams { get; set; } = new List<Exam>();
    }
}