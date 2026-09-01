using IncidentManagement.Application.Dtos.Requests;
using IncidentManagement.Application.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IncidentManagement.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IncidentController : ControllerBase
    {
        private readonly IncidentService _incidentService;

        public IncidentController(IncidentService incidentService)
        {
            _incidentService = incidentService;
        }

        [HttpPost("create")]
        public async Task<IActionResult> CreateIncident([FromBody] CreateIncidentRequest request)
        {
            var response = await _incidentService.CreateIncidentAsync(request);
            return Ok(response);
        }

        [HttpPut("status")]
        public async Task<IActionResult> UpdateStatus(UpdateIncidentStatusRequest request)
        {
            var response = await _incidentService.UpdateIncidentStatusAsync(request);
            return Ok(response);
        }

        //[HttpGet("property/{propertyId}")]
        //public async Task<IActionResult> GetByProperty(int propertyId)
        //{
        //    var responses = await _incidentService.GetIncidentsByPropertyAsync(propertyId);
        //    return Ok(responses);
        //}

        [HttpGet("all")]
        public async Task<IActionResult> GetAllIncidents()
        {
            var responses = await _incidentService.GetAllIncidentsAsync();
            return Ok(responses);
        }
    }
}
