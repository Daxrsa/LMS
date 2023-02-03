using Domain.Entities;

namespace Application.Services.CourseService
{
    public interface ICourseService
    {
         Task<List<Course>> GetCourses();
        Task<Course> GetCourseById(Guid id);
        Task<List<Course>> AddCourse(Course course);
        Task<List<Course>> UpdateCourse(Guid id, Course request);
        Task<List<Course>> DeleteCourse(Guid id);
        //Task handleRequestPresentExam();
    }
}