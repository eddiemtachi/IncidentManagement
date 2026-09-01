using IncidentManagement.Application.Dtos.Requests;
using IncidentManagement.Application.Dtos.Responses;

namespace IncidentManagement.WebClient.Services
{
    public class IncidentApiClientRepository
    {
        private readonly ApiClient _client;

        public IncidentApiClientRepository(ApiClient client)
        {
            _client = client;
        }

        public Task<IEnumerable<IncidentResponse>> GetAllIncidentsAsync()
        {
            return _client.GetAsync<IEnumerable<IncidentResponse>>("incident/all");
        }

        public Task<IEnumerable<IncidentResponse>> GetByPropertyAsync(int propertyId) =>
            _client.GetAsync<IEnumerable<IncidentResponse>>($"incident/property/{propertyId}");

        public Task<IncidentResponse> CreateIncidentAsync(CreateIncidentRequest request)
        {
            return _client.PostAsync<IncidentResponse>("incident/create", request);
        }

        public Task<IncidentResponse> UpdateIncidentStatusAsync(UpdateIncidentStatusRequest request) =>
            _client.PutAsync<IncidentResponse>("incident/status", request);
    }
}
