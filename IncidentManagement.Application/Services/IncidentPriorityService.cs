using IncidentManagement.Application.Dtos.Responses;
using IncidentManagement.Application.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace IncidentManagement.Application.Services
{
    public class IncidentPriorityService : IIncidentPriorityService
    {
        private readonly IUnitOfWork _unitOfWork;
        public IncidentPriorityService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<IncidentPriorityResponse>> GetAllIncidentPriorityAsync()
        {
            var incidentPriority = await _unitOfWork.Priority.GetAllAsync();

            return incidentPriority.Select(Priority => new IncidentPriorityResponse(Priority.PriorityId, Priority?.PriorityName!));
        }
    }
}
