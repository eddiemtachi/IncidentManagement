using IncidentManagement.Application.Service_Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IncidentManagement.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IncidentStatusController : ControllerBase
    {
        private readonly IIncidentStatusService _incidentStatusService;

        public IncidentStatusController(IIncidentStatusService incidentStatusService)
        {
            _incidentStatusService = incidentStatusService;
        }

        [HttpGet("all")]
        public async Task<IActionResult> GetAllIncidentStatuses()
        {
            var responses = await _incidentStatusService.GetAllIncidentStatusesAsync();

            return Ok(responses);
        }
     
    }
}
