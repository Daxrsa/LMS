using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class RequestController : ControllerBase
    {
        private readonly IRequestService _requestService;
        public RequestController(IRequestService requestService)
        {
            _requestService = requestService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Request>>> GetRequests()
        {
            return await _requestService.GetAllRequests();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Request>> GetRequestById(Guid id)
        {
            var result = await _requestService.GetRequestById(id);
            if(result is null)
            {
                return NotFound("Object not found");
            }
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<List<Request>>> AddRequest(Request request)
        {
            var result = await _requestService.AddRequest(request);
            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<List<Request>>> UpdateRequest(Guid id, Request request)
        {
            var result = await _requestService.UpdateRequest(id, request);
            if(result is null)
            {
                return NotFound("Object not found");
            }
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Request>>> DeleteRequest(Guid id)
        {
            var result = await _requestService.DeleteRequest(id);
            if(result is null)
            {
                return NotFound("Object not found");
            }
            return Ok(result);
        }
    }
}