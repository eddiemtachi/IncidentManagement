using IncidentManagement.Application.Dtos.Responses;

namespace IncidentManagement.WebClient.Interfaces
{
    public interface IIncidentPropertyService
    {
        Task<List<IncidentPropertyResponse>> GetProperitesAsync();
    }
}
