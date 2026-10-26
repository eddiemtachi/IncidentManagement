using IncidentManagement.Application.Dtos.Responses;

namespace IncidentManagement.WebClient.Interfaces
{
    public interface IIncidentPriorityService
    {
        Task<List<IncidentPriorityResponse>> GetPrioritiesAsync();
        
    }
}
