using IncidentManagement.Application.Dtos.Responses;

namespace IncidentManagement.Application.Service_Interfaces
{
    public interface IIncidentCategoryService
    {
        Task<IEnumerable<IncidentCategoryResponse>> GetAllIncidentCategoryAsync();
    }
}
