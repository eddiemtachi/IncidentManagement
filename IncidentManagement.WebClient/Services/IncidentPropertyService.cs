using IncidentManagement.Application.Dtos.Responses;
using IncidentManagement.WebClient.Interfaces;
using System.Net.Http.Json;

namespace IncidentManagement.WebClient.Services
{
    public class IncidentPropertyService : IIncidentPropertyService
    {
        private readonly HttpClient _httpClient;

        public IncidentPropertyService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<IncidentPropertyResponse>> GetProperitesAsync()
        {
            return await _httpClient.GetFromJsonAsync<List<IncidentPropertyResponse>>("api/IncidentProperty/all") ?? new();
        }
    }
}
