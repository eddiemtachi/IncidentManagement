using IncidentManagement.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace IncidentManagement.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IncidentPriorityController : ControllerBase
    {
        private readonly IIncidentPriorityService _incidentPriorityService;

        public IncidentPriorityController(IIncidentPriorityService incidentPriorityService)
        {
            _incidentPriorityService = incidentPriorityService;
        }

        [HttpGet("all")]
        public async Task<IActionResult> GetAllIncidentPriorities()
        {
            var responses = await _incidentPriorityService.GetAllIncidentPriorityAsync();

            return Ok(responses);
        }
    }
}
