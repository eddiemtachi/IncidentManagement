using IncidentManagement.Application.Dtos.Responses;
using IncidentManagement.WebClient.Interfaces;
using System.Net.Http.Json;

namespace IncidentManagement.WebClient.Services
{
    public class IncidentStatusService : IIncidentStatusService
    {
        private readonly HttpClient _httpClient;

        public IncidentStatusService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        
        async Task<List<IncidentStatusResponse>> IIncidentStatusService.GetStatusesAsync()
        {
            return await _httpClient.GetFromJsonAsync<List<IncidentStatusResponse>>("api/IncidentStatus/all") ?? new();
        }
    }
}
