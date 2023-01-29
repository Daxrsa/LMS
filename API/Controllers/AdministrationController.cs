using Microsoft.AspNetCore.Mvc;
using Persistence.Repositories.AdministrationRepository;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AdministrationController : ControllerBase
    {
        private readonly IAdministrationRepository _administrationRepository;
        public AdministrationController(IAdministrationRepository administrationRepository)
        {
            administrationRepository = _administrationRepository;
        }

        [HttpGet]
        public async Task<ActionResult<List<Administration>>> GetAdministrations()
        {
            return await _administrationRepository.GetAdministrations();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Administration>> GetAdministrationById(Guid id)
        {
            var result = await _administrationRepository.GetAdministrationById(id);
            if(result is null)
            {
                return NotFound("Administration not found");
            }
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<List<Administration>>> AddAdministration(Administration administration)
        {
            var result = await _administrationRepository.AddAdministration(administration);
            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<List<Administration>>> UpdateAdministration(Guid id, Administration request)
        {
            var result = await _administrationRepository.UpdateAdministration(id, request);
            if(result is null)
            {
                return NotFound("Administration not found");
            }
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Administration>>> DeleteAdministration(Guid id)
        {
            var result = await _administrationRepository.DeleteAdministration(id);
            if(result is null)
            {
                return NotFound("Administration not found");
            }
            return Ok(result);
        }
    }
}