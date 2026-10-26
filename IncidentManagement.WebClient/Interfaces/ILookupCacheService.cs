using IncidentManagement.Application.Dtos.Responses;

namespace IncidentManagement.WebClient.Interfaces
{
    public interface ILookupCacheService
    {
        Task<List<IncidentStatusResponse>> GetIncidentStatusesAsync();
        Task<List<IncidentPriorityResponse>> GetIncidentPrioritiesAsync();
        Task<List<IncidentRoleResponse>> GetIncidentRolesAsync();
        Task<List<IncidentCategoryResponse>> GetIncidentCategoriesAsync();
        Task<List<IncidentPropertyResponse>> GetIncidentPropertiesAsync();
    }
}
