using Application.Core;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BaseApiController : ControllerBase
    {
        private IMediator _mediator;

        protected IMediator Mediator => _mediator ??=
            HttpContext.RequestServices.GetService<IMediator>();

        protected ActionResult HandleResult<T>(ServiceResponse<T> result)
        {
            if (result == null) return NotFound();

            if (result.Success && result.Data != null)
                return Ok(result.Data);

            if (result.Success && result.Data == null)
                return NotFound();

            return BadRequest(result.Message);
        }
    }
}