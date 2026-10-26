using IncidentManagement.Application.Dtos.Responses;

namespace IncidentManagement.WebClient.Interfaces
{
    public interface IIncidentCategoryService
    {
        Task<List<IncidentCategoryResponse>> GetCategoriesAsync();
    }
}
