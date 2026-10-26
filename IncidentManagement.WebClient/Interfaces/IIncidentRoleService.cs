using IncidentManagement.Application.Dtos.Responses;

namespace IncidentManagement.WebClient.Interfaces
{
    public interface IIncidentRoleService
    {
        Task<List<IncidentRoleResponse>> GetRolesAsync();
    }
}
