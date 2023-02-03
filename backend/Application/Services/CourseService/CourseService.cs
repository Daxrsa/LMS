using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Services.CourseService
{
    public class CourseService : ICourseService
    {
        private readonly DataContext _context;
        public CourseService(DataContext context)
        {
            _context = context;
        }

        public async Task<List<Course>> AddCourse(Course course)
        {
            _context.Courses.Add(course);
            await _context.SaveChangesAsync();
            return await _context.Courses.ToListAsync();
        }
        public async Task<List<Course>> DeleteCourse(Guid id)
        {
            var course = await _context.Courses.FindAsync(id);
            if (course is null)
            {
                return null; //make a custom API response class for this
            }
            _context.Courses.Remove(course);
            await _context.SaveChangesAsync();
            return await _context.Courses.ToListAsync();
        }

        public async Task<Course> GetCourseById(Guid id)
        {
            var course = await _context.Courses.FindAsync(id);
            if (course is null)
            {
                return null;
            }
            return course;
        }

        public async Task<List<Course>> GetCourses()
        {
            var courses = await _context.Courses.ToListAsync();
            return courses;
        }

        public async Task<List<Course>> UpdateCourse(Guid id, Course request)
        {
            var course = await _context.Courses.FindAsync(id);
            if (course is null)
            {
                return null;
            }

            await _context.SaveChangesAsync();
            return await _context.Courses.ToListAsync();
        }

        

        /* public Task handleRequestGradeCourse()
         {
             throw new NotImplementedException();
         }*/
    }
}