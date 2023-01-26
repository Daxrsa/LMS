using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Administration> Administration { get; set; }
        public DbSet<Assignment> Assignments { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Exam> Exams { get; set; }
        public DbSet<Media> Medias { get; set; }
        public DbSet<Professor> Professor { get; set; }
        public DbSet<Request> Request { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Transcript> Transcripts { get; set; }
        public DbSet<User> Users { get; set; }
    }
}