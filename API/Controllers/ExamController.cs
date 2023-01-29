using Microsoft.AspNetCore.Mvc;
using Application.Services.ExamService;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ExamController : ControllerBase
    {
        private readonly IExamService _examService;
        public ExamController(IExamService examService)
        {
            examService = _examService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Exam>>> GetExams()
        {
            return await _examService.GetExams();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Exam>> GetExamById(Guid id)
        {
            var result = await _examService.GetExamById(id);
            if(result is null)
            {
                return NotFound("Exam not found");
            }
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<List<Exam>>> AddExam(Exam exam)
        {
            var result = await _examService.AddExam(exam);
            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<List<Exam>>> UpdateExam(Guid id, Exam request)
        {
            var result = await _examService.UpdateExam(id, request);
            if(result is null)
            {
                return NotFound("Exam not found");
            }
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Exam>>> DeleteExam(Guid id)
        {
            var result = await _examService.DeleteExam(id);
            if(result is null)
            {
                return NotFound("Exam not found");
            }
            return Ok(result);
        }
    }
}
    