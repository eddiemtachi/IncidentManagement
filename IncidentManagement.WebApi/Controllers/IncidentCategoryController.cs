using IncidentManagement.Application.Service_Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace IncidentManagement.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IncidentCategoryController : ControllerBase
    {
        private readonly IIncidentCategoryService _incidentCategoryService;
        public IncidentCategoryController(IIncidentCategoryService incidentCategoryService)
        {
            _incidentCategoryService = incidentCategoryService;
        }

        [HttpGet("all")]
        public async Task<IActionResult> GetAllIncidentCategories()
        {
            var responses = await _incidentCategoryService.GetAllIncidentCategoryAsync();

            return Ok(responses);
        }
    }
}
