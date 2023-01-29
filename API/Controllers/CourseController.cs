using Application.Courses;
using Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Persistence;
using System.Collections.Generic;
using System.Diagnostics;

namespace API.Controllers
{
    /*[Route("[controller]")]
    [ApiController]*/
    public class CourseController : BaseApiController
    {
        private readonly IMediator _mediator;

        public CourseController(IMediator mediator)
        {
            _mediator = mediator;

        }
        [HttpGet]
        public async Task<ActionResult<List<Course>>> Courses()
        {
            return await Mediator.Send(new List.Query());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Course>> GetCourse(Guid id)
        {
            return await Mediator.Send(new Details.Query { Id = id });
        }

        [HttpPost]
        public async Task<IActionResult> CreateCourse(Course course)
        {

            return Ok(await Mediator.Send(new Create.Command { Course = course }));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> EditCourse(Guid id, Course course)
        {
            course.Id = id;

            return Ok(await Mediator.Send(new Edit.Command { Course = course }));
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCourse(Guid id)
        {
            return Ok(await Mediator.Send(new Delete.Command { Id = id }));
        }

        /*
        private DataContext _context;

         public CourseController(DataContext context)
         {
             this._context = context;
         }

         [HttpGet]
         public async Task<ActionResult<List<Course>>> GetCourses()
         {
             return await _context.Courses.ToListAsync();

         }

         [HttpGet("{id}")]
         public async Task<ActionResult<Course>> GetCourse(Guid id)
         {
             return await _context.Courses.FindAsync(id);
         }*/

    }
}