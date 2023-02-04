using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Application.Services.CourseService;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CourseController : ControllerBase
    {
        private readonly ICourseService _courseService;
        public CourseController(ICourseService courseService)
        {
            _courseService = courseService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Course>>> GetAllCourses()
        {
            return await _courseService.GetCourses();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Course>> GetCourseById(Guid id)
        {
            var result = await _courseService.GetCourseById(id);
            if (result is null)
            {
                return NotFound("Course not found");
            }
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<List<Course>>> AddCourse(Course course)
        {
            var result = await _courseService.AddCourse(course);
            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<List<Course>>> UpdateCourse(Guid id, Course request)
        {
            var result = await _courseService.UpdateCourse(id, request);
            if (result is null)
            {
                return NotFound("Course not found");
            }
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Course>>> DeleteCourse(Guid id)
        {
            var result = await _courseService.DeleteCourse(id);
            if (result is null)
            {
                return NotFound("Course not found");
            }
            return Ok(result);
        }

    }
}
