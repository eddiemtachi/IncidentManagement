using IncidentManagement.Application.Dtos.Responses;
using IncidentManagement.Application.Interfaces;
using IncidentManagement.Application.Service_Interfaces;
using IncidentManagement.Application.UnitOfWork;
using System.Linq.Expressions;

namespace IncidentManagement.Application.Services
{
    public class IncidentStatusService : IIncidentStatusService
    {
        private readonly IUnitOfWork _unitOfWork;
        public IncidentStatusService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }


        public async Task<IEnumerable<IncidentStatusResponse>> GetAllIncidentStatusesAsync()
        {
            var incidentStatuses = await _unitOfWork.IncidentStatuses.GetAllAsync();

            return incidentStatuses.Select(status => new IncidentStatusResponse(status.StatusId, status?.StatusName!));
        }
        
    }
}
