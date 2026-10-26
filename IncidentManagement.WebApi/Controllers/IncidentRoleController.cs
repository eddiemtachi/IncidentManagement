using IncidentManagement.Application.Service_Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IncidentManagement.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IncidentRoleController : ControllerBase
    {
        private readonly IIncidentRoleService _incidentRoleService;

        public IncidentRoleController(IIncidentRoleService incidentRoleService)
        {
            _incidentRoleService = incidentRoleService;
        }

        [HttpGet("all")]
        public async Task<IActionResult> GetAllIncidentRoles()
        {
            var responses = await _incidentRoleService.GetAllIncidentRoleAsync();

            return Ok(responses);
        }
    }
}
