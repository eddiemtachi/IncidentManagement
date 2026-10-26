
using IncidentManagement.Application.Dtos.Responses;
using IncidentManagement.WebClient.Interfaces;
using System.Net.Http.Json;

namespace IncidentManagement.WebClient.Services
{
    public class IncidentRoleService : IIncidentRoleService
    {
        private readonly HttpClient _httpClient;

        public IncidentRoleService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        async Task<List<IncidentRoleResponse>> IIncidentRoleService.GetRolesAsync()
        {
            return await _httpClient.GetFromJsonAsync<List<IncidentRoleResponse>>("api/IncidentRole/all") ?? new();
        }
    }
}
