using IncidentManagement.Application.Dtos.Responses;
using IncidentManagement.WebClient.Interfaces;
using System.Net.Http.Json;

namespace IncidentManagement.WebClient.Services
{
    public class IncidentPriorityService : IIncidentPriorityService
    {
        private readonly HttpClient _httpClient;

        public IncidentPriorityService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        async Task<List<IncidentPriorityResponse>> IIncidentPriorityService.GetPrioritiesAsync()
        {
            return await _httpClient.GetFromJsonAsync<List<IncidentPriorityResponse>>("api/IncidentPriority/all") ?? new();
        }
    }
}

