using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AssignmentController : ControllerBase
    {
        private readonly IAssignmentService _assignmentService;
        public AssignmentController(IAssignmentService assignmentService)
        {
            _assignmentService = assignmentService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Assignment>>> GetAssignments()
        {
            return await _assignmentService.GetAssignments();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Assignment>> GetAssignmentById(Guid id)
        {
            var result = await _assignmentService.GetAssignmentById(id);
            if(result is null)
            {
                return NotFound("Object not found");
            }
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<List<Assignment>>> AddAssignment(Assignment assignment)
        {
            var result = await _assignmentService.AddAssignment(assignment);
            return Ok(result); 
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<List<Assignment>>> UpdateAssignment(Guid id, Assignment request)
        {
            var result = await _assignmentService.UpdateAssignment(id, request);
            if(result is null)
            {
                return NotFound("Object not found");
            }
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Assignment>>> DeleteAssignment(Guid id)
        {
            var result = await _assignmentService.DeleteAssignment(id);
            if(result is null)
            {
                return NotFound("Object not found");
            }
            return Ok(result);
        }
    }
}