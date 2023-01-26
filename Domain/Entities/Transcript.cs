namespace Domain.Entities
{
    public class Transcript
    {
        public Guid Id { get; set; }
        public string Degree { get; set; } //bachelor, masters etj
        public string Status { get; set; }
        public int AvgGrade { get; set; }
        public Student Student { get; set; }
    }
}