using IncidentManagement.Application.Dtos.Requests;
using IncidentManagement.Application.Dtos.Responses;
using IncidentManagement.Application.Helpers;
using IncidentManagement.Application.UnitOfWork;

namespace IncidentManagement.Application.Services
{
    public class IncidentService
    {
        private readonly IUnitOfWork _unitOfWork;

        public IncidentService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IncidentResponse> CreateIncidentAsync(CreateIncidentRequest request)
        {
            var incident = DtoMapper.MapToEntity(request);
            await _unitOfWork.Incidents.AddAsync(incident);
            await _unitOfWork.CompleteAsync();
            return DtoMapper.MapToResponse(incident);
        }

        public async Task<IEnumerable<IncidentResponse>> GetAllIncidentsAsync()
        {
            var incidents = await _unitOfWork.Incidents.GetAllIncidentsAsync();
            return DtoMapper.MapToResponse(incidents);
        }

        public async Task<IncidentResponse> UpdateIncidentStatusAsync(UpdateIncidentStatusRequest request)
        {
            var incident = await _unitOfWork.Incidents.GetByIdAsync(request.IncidentId);
            if (incident == null) throw new Exception("Incident not found");

            incident.UpdateStatus(request.StatusId);            
            await _unitOfWork.CompleteAsync();

            return DtoMapper.MapToResponse(incident);
        }
    }
}
