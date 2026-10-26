using IncidentManagement.Application.Dtos.Responses;

namespace IncidentManagement.WebClient.Interfaces
{
    public interface IIncidentStatusService
    {
        Task<List<IncidentStatusResponse>> GetStatusesAsync();
    }
}
