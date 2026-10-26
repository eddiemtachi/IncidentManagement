using IncidentManagement.Application.Dtos.Responses;

namespace IncidentManagement.Application.Services
{
    public interface IIncidentPriorityService
    {
        Task<IEnumerable<IncidentPriorityResponse>> GetAllIncidentPriorityAsync();
    }
}
