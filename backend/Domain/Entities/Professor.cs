namespace Domain.Entities
{
    public class Professor
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
         public string PhoneNumber { get; set; }
        public virtual ICollection<Assignment> Assignments { get; set; } = new List<Assignment>();
        public virtual ICollection<Course> Courses { get; set; } = new List<Course>();
        public virtual ICollection<Exam> Exams { get; set; } = new List<Exam>();
    }
}