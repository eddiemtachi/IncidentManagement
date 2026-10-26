using IncidentManagement.Application.Dtos.Responses;

namespace IncidentManagement.Application.Service_Interfaces
{
    public interface IIncidentStatusService
    {
        Task<IEnumerable<IncidentStatusResponse>> GetAllIncidentStatusesAsync();
    }
}
