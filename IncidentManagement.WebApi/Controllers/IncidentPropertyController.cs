using IncidentManagement.Application.Service_Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IncidentManagement.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IncidentPropertyController : ControllerBase
    {
        private readonly IIncidentPropertyService _incidentPropertyService;
        public IncidentPropertyController(IIncidentPropertyService incidentPropertyService)
        {
            _incidentPropertyService = incidentPropertyService;
        }

        [HttpGet("all")]
        public async Task<IActionResult> GetAllIncidentProperties()
        {
            var responses = await _incidentPropertyService.GetAllIncidentPropertyAsync();

            return Ok(responses);
        }
    }
}
