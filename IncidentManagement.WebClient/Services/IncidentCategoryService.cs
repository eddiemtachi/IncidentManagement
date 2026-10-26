using IncidentManagement.Application.Dtos.Responses;
using IncidentManagement.WebClient.Interfaces;
using System.Net.Http.Json;

namespace IncidentManagement.WebClient.Services
{
    public class IncidentCategoryService : IIncidentCategoryService
    {
        private readonly HttpClient _httpClient;

        public IncidentCategoryService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<IncidentCategoryResponse>> GetCategoriesAsync()
        {
            return await _httpClient.GetFromJsonAsync<List<IncidentCategoryResponse>>("api/IncidentCatergory/all") ?? new();
        }
    }
}
