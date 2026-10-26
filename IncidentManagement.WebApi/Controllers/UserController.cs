using IncidentManagement.Application.Dtos.Requests;
using IncidentManagement.Application.Service_Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace IncidentManagement.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("create")]
        public async Task<IActionResult> CreateIncident([FromBody] CreateUserRequest request)
        {
            var response = await _userService.CreateUserAsync(request);
            return Ok(response);
        }
    }
}
