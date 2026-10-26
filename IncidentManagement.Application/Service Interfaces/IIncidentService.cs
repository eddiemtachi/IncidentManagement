using IncidentManagement.Application.Dtos.Requests;
using IncidentManagement.Application.Dtos.Responses;

namespace IncidentManagement.Application.Service_Interfaces
{
    public interface IIncidentService
    {
        Task<IncidentResponse> CreateIncidentAsync(CreateIncidentRequest request);
        Task<IEnumerable<IncidentResponse>> GetAllIncidentsAsync();
        Task<IncidentResponse> UpdateIncidentStatusAsync(UpdateIncidentStatusRequest request);
    }
}
